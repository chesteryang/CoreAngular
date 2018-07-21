using System.ComponentModel.DataAnnotations;
#pragma warning disable 1591

namespace CoreAngular.Model
{
    public class User
    {
        [Required]
        public string LoginId { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
