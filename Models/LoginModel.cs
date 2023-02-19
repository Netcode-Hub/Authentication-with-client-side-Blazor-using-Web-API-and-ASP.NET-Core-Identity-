using System.ComponentModel.DataAnnotations;

namespace JwtLoginOnline.Server.Models
{
    public class LoginModel
    {
        [Required]
        public string? Email { get; set; }

        [Required]
        public string? Password { get; set; }

        public bool RememberMe { get; set; }
    }
}
