using System.ComponentModel.DataAnnotations;

namespace Waless.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}