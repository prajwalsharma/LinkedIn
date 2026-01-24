using System.ComponentModel.DataAnnotations;

namespace linkedin_api.Features.Users.LoginUser
{
    public class LoginUserCommand
    {
        [Required(ErrorMessage = "Username is required")]
        public required string Username { get; set; }
        [Required(ErrorMessage = "Password is required")]
        public required string Password { get; set; }
    }
}
