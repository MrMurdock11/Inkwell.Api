using Microsoft.AspNetCore.Mvc;

namespace Inkwell.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthenticationController : ControllerBase
    {

        private readonly ILogger<AuthenticationController> _logger;

        public AuthenticationController(ILogger<AuthenticationController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("sign-up")]
        public string SignUp()
        {
            return "You sign up in the system.";
        }
    }
}