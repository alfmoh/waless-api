using System.ComponentModel.DataAnnotations;

namespace Waless.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Email { get; set; }

        [Required]
        [StringLength(12, MinimumLength = 8, ErrorMessage = "You must specify a password between 8 and 12 characters")]
        public string Password { get; set; }
        public string Username { get; set; }
    }
}