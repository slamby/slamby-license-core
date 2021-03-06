﻿using Slamby.License.Core.Validation;
using System.Collections.Generic;

namespace Slamby.License.Core.Models
{
    public class CheckResponseModel
    {
        public bool IsValid { get; set; }
        public List<ValidationFailure> Failures { get; set; }
        public string License { get; set; }
    }
}
