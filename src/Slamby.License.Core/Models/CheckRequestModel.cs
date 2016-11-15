using System;
using System.ComponentModel.DataAnnotations;

namespace Slamby.License.Models
{
    public class CheckRequestModel
    {
        [Required]
        public Guid Id { get; set; }

        [Required]
        [RegularExpression("^[A-Za-z0-9+/]+[=]{0,2}$")]
        public string License { get; set; }

        [Required]
        public CheckDetailsModel Details { get; set; }
    }

    public class CheckDetailsModel
    {
        [Required]
        public DateTime LaunchTime { get; set; }
        [Required]
        [Range(0,1000)]
        public int Cores { get; set; }
        [Required]
        public string ElasticName { get; set; }
    }
}
