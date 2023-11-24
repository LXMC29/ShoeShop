using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShoeShop.Application.Models.Identity;
using ShoeShop.Application.Repositories.Identity;

namespace ShoeShop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login(LoginRequest loginRequest)
        {
            var token = await _authService.Login(loginRequest);
            return Ok(new { JetToken = token });
        }
    }
}
