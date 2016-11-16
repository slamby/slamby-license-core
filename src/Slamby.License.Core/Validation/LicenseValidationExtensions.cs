using Slamby.License.Core.Resources;
using System;
using System.Linq;
using System.Reflection;

namespace Slamby.License.Core.Validation
{
    /// <summary>
    /// Extension methods for <see cref="License"/> validation.
    /// </summary>
    public static class LicenseValidationExtensions
    {
        /// <summary>
        /// Starts the validation chain of the <see cref="License"/>.
        /// </summary>
        /// <param name="license">The <see cref="License"/> to validate.</param>
        /// <returns>An instance of <see cref="IStartValidationChain"/>.</returns>
        public static IStartValidationChain Validate(this License license)
        {
            return new ValidationChainBuilder(license);
        }

        /// <summary>
        /// Validates if the license has been expired.
        /// </summary>
        /// <param name="validationChain">The current <see cref="IStartValidationChain"/>.</param>
        /// <returns>An instance of <see cref="IStartValidationChain"/>.</returns>
        public static IValidationChain ExpirationDate(this IStartValidationChain validationChain)
        {
            var validationChainBuilder = (validationChain as ValidationChainBuilder);
            var validator = validationChainBuilder.StartValidatorChain();
            validator.Validate = license => license.Expiration > DateTime.Now;

            validator.FailureResult = new ValidationFailure()
                                          {
                                              Message = GlobalResources.LicenseExpiredMessage,
                                              HowToResolve = GlobalResources.LicenseExpiredResolve
            };

            return validationChainBuilder;
        }

        /// <summary>
        /// Allows you to specify a custom assertion that validates the <see cref="License"/>.
        /// </summary>
        /// <param name="validationChain">The current <see cref="IStartValidationChain"/>.</param>
        /// <param name="predicate">The predicate to determine of the <see cref="License"/> is valid.</param>
        /// <param name="failure">The <see cref="IValidationFailure"/> will be returned to the application when the <see cref="ILicenseValidator"/> fails.</param>
        /// <returns>An instance of <see cref="IStartValidationChain"/>.</returns>
        public static IValidationChain AssertThat(this IStartValidationChain validationChain, Predicate<License> predicate, ValidationFailure failure)
        {
            var validationChainBuilder = (validationChain as ValidationChainBuilder);
            var validator = validationChainBuilder.StartValidatorChain();

            validator.Validate = predicate;
            validator.FailureResult = failure;

            return validationChainBuilder;
        }

        /// <summary>
        /// Validates the <see cref="License.Signature"/>.
        /// </summary>
        /// <param name="validationChain">The current <see cref="IStartValidationChain"/>.</param>
        /// <param name="publicKey">The public product key to validate the signature..</param>
        /// <returns>An instance of <see cref="IStartValidationChain"/>.</returns>
        public static IValidationChain Signature(this IStartValidationChain validationChain, string publicKey)
        {
            var validationChainBuilder = (validationChain as ValidationChainBuilder);
            var validator = validationChainBuilder.StartValidatorChain();
            validator.Validate = license => license.VerifySignature(publicKey);

            validator.FailureResult = new ValidationFailure()
                                          {
                                              Message = GlobalResources.LicenseSignatureMessage,
                                              HowToResolve = GlobalResources.LicenseSignatureResolve
            };

            return validationChainBuilder;
        }

        /// <summary>
        /// Validates if the license id is the same.
        /// </summary>
        /// <param name="validationChain">The current <see cref="IStartValidationChain"/>.</param>
        /// <returns>An instance of <see cref="IStartValidationChain"/>.</returns>
        public static IValidationChain Id(this IStartValidationChain validationChain, string id)
        {
            var validationChainBuilder = (validationChain as ValidationChainBuilder);
            var validator = validationChainBuilder.StartValidatorChain();
            validator.Validate = license => license.Id == id;

            validator.FailureResult = new ValidationFailure()
            {
                Message = GlobalResources.LicenseIdMessage,
                HowToResolve = GlobalResources.LicenseIdResolve
            };

            return validationChainBuilder;
        }

        /// <summary>
        /// Validates the cores number.
        /// </summary>
        /// <param name="validationChain">The current <see cref="IStartValidationChain"/>.</param>
        /// <returns>An instance of <see cref="IStartValidationChain"/>.</returns>
        public static IValidationChain Cores(this IStartValidationChain validationChain, int cores)
        {
            var validationChainBuilder = (validationChain as ValidationChainBuilder);
            var validator = validationChainBuilder.StartValidatorChain();
            validator.Validate = license => license.Cores >= cores;

            validator.FailureResult = new ValidationFailure()
            {
                Message = GlobalResources.LicenseCoresMessage,
                HowToResolve = GlobalResources.LicenseCoresResolve
            };

            return validationChainBuilder;
        }
    }
}
