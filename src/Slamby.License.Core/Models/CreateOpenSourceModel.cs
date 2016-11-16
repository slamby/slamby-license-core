using System;
using System.ComponentModel.DataAnnotations;

namespace Slamby.License.Core.Models
{
    public class CreateOpenSourceModel
    {
        [Required]
        [RegularExpression(@"^[^@]+@[^@]+\.[^@]+$")]
        public string Email { get; set; }

        [Required]
        public Guid Id { get; set; }
    }
}
