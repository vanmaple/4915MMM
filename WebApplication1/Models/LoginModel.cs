using System.ComponentModel.DataAnnotations;

namespace Project.Models
{
    public class LoginModel
    {
        [Required]
        public string? Username { get; set; }
        [Required]
        public string? Password { get; set; }
        public bool IsUser { get; set; }
    }
}