using System.ComponentModel.DataAnnotations;

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
