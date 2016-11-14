﻿﻿namespace Slamby.License.Core.Validation
{
    /// <summary>
    /// Interface for the fluent validation syntax.
    /// This interface is used to add a condition or to complete a validation chain.
    /// </summary>
    public interface IValidationChain : IValidationChainCondition, ICompleteValidationChain
    {
    }
}