using linkedin_api.Features.Users.LoginUser;
using Microsoft.AspNetCore.Mvc;

namespace linkedin_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class UsersController : ControllerBase
    {
        private readonly ILogger<UsersController> _logger;

        public UsersController(ILogger<UsersController> logger)
        {
            _logger = logger;
        }

        [HttpPost("login")]
        public IActionResult Login(LoginUserCommand command)
        {
            _logger.LogInformation("Login is called - {@command}", command);
            return Ok("Login success!");
        }

        [HttpPost("register")]
        public IActionResult Register(string username, string password)
        {
            return Ok("Account Created!");
        }
    }
}
