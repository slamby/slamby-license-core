﻿using Slamby.License.Core.Resources;
using System;
using System.Collections.Generic;

namespace Slamby.License.Core.Validation
{
    internal class ValidationChainBuilder : IStartValidationChain, IValidationChain
    {
        private readonly Queue<ILicenseValidator> validators;
        private ILicenseValidator currentValidatorChain;
        private readonly License license;

        public ValidationChainBuilder(License license)
        {
            this.license = license;
            validators = new Queue<ILicenseValidator>();
        }

        public ILicenseValidator StartValidatorChain()
        {
            return currentValidatorChain = new LicenseValidator();
        }

        public void CompleteValidatorChain()
        {
            if (currentValidatorChain == null)
                return;

            validators.Enqueue(currentValidatorChain);
            currentValidatorChain = null;
        }

        public ICompleteValidationChain When(Predicate<License> predicate)
        {
            currentValidatorChain.ValidateWhen = predicate;
            return this;
        }

        public IStartValidationChain And()
        {
            CompleteValidatorChain();
            return this;
        }

        public IEnumerable<ValidationFailure> AssertValidLicense()
        {
            CompleteValidatorChain();

            while (validators.Count > 0)
            {
                var validator = validators.Dequeue();
                if (validator.ValidateWhen != null && !validator.ValidateWhen(license))
                    continue;

                if (!validator.Validate(license))
                    yield return validator.FailureResult
                                 ?? new ValidationFailure
                                        {
                                            Message = GlobalResources.LicenseValidationFailedMessage
                                 };
            }
        }
    }
}