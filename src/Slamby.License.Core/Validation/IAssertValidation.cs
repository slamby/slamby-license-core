﻿using System.Collections.Generic;

﻿namespace Slamby.License.Core.Validation
{
    /// <summary>
    /// Interface for the fluent validation syntax.
    /// </summary>
    public interface IAssertValidation : IFluentInterface
    {
        /// <summary>
        /// Invokes the license assertion.
        /// </summary>
        /// <returns>An array is <see cref="IValidationFailure"/> when the validation fails.</returns>
        IEnumerable<IValidationFailure> AssertValidLicense();
    }
}