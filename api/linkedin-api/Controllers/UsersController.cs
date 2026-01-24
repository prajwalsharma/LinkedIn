using Microsoft.AspNetCore.Mvc;

namespace linkedin_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        [HttpPost("login")]
        public IActionResult Login(string username, string password)
        {
            return Ok("Login success!");
        }

        [HttpPost("register")]
        public IActionResult Register(string username, string password)
        {
            return Ok("Account Created!");
        }
    }
}
