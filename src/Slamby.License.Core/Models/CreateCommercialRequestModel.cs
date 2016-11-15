using System;
using System.ComponentModel.DataAnnotations;

namespace Slamby.License.Models
{
    public class CreateCommercialRequestModel
    {
        [Required]
        public Guid Id { get; set; }
        [Required]
        [Range(0, 1000)]
        public int Cores { get; set; }
        public DateTime? Expiration { get; set; }
        [Required]
        public CustomerModel Customer { get; set; }
    }

    public class CustomerModel
    {
        [Required]
        [RegularExpression(@"^[^@]+@[^@]+\.[^@]+$")]
        public string Email { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Company { get; set; }
    }
}
