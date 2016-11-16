using Slamby.License.Core.Validation;
using System.Collections.Generic;

namespace Slamby.License.Core.Models
{
    public class CreateResponseModel
    {
        public string License { get; set; }

        public List<ValidationFailure> Failures { get; set; }
    }
}
