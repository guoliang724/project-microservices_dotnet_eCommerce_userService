using eCommerce.Core.DTO;
using eCommerce.Core.ServiceContracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eCommerce.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IUserService _userService;

        public AuthController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(RegisterRequest registerRequest)
        {
            if (registerRequest == null) return BadRequest("Invalid Registration data");

            var authResponse = await _userService.Register(registerRequest);

            if (authResponse == null || !authResponse.Sucess)
            {
                return BadRequest("Registration failed");
            }

            return Ok(authResponse);
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginRequest loginRequest)
        {
            if (loginRequest == null) return BadRequest("Invalid Login data");

            AuthenticationResponse? authentication = await _userService.Login(loginRequest);

            if (authentication == null || !authentication.Sucess)
            {
                return Unauthorized(authentication);
            }

            return Ok(authentication);
        }
    }
}
