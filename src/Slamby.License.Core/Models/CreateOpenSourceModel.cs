using System;
using System.ComponentModel.DataAnnotations;

namespace Slamby.License.Models
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
