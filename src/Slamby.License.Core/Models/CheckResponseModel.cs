using Slamby.License.Core.Validation;
using System.Collections.Generic;

namespace Slamby.License.Models
{
    public class CheckResponseModel
    {
        public bool IsValid { get; set; }
        public List<IValidationFailure> Failures { get; set; }
        public string License { get; set; }
    }
}
