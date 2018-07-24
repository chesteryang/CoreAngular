using System.ComponentModel.DataAnnotations;
#pragma warning disable 1591

namespace CoreAngular.Model
{
    public class User
    {
        [Required(ErrorMessage = "Login Id is required")]
        public string LoginId { get; set; }
        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }
    }
}
