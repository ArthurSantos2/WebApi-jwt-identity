
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebApi.Auth;
using WebApi.Entities;
using WebApi.Models;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TokenController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;


        public TokenController(SignInManager<ApplicationUser> signInManager,
        UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [AllowAnonymous]
        [HttpPost("/api/CreateToken")]
        public async Task<IActionResult> CreateToken([FromBody] LoginRequest request, CancellationToken cancellationToken)
        {
            if (string.IsNullOrEmpty(request.Email) || string.IsNullOrEmpty(request.Password))
            {
                return Unauthorized();
            }

            var result = await _signInManager.PasswordSignInAsync(request.Email, request.Password
                , false, lockoutOnFailure: false);

            if (result.Succeeded)
            {
                var token = new TokenJwtBuilder()
                    .AddSecurityKey(JwtSecurityKey.Create("43443FDFDF34DF34343fdf344SDFSDFSDFSDFSDF4545354345SDFGDFGDFGDFGdffgfdGDFGDGR%"))
                .AddSubject("Canal Dev Net Core")
                .AddIssuer("Teste.Securiry.Bearer")
                .AddAudience("Teste.Securiry.Bearer")
                .AddExpiryInMinutes(5)
                .Builder();

                return Ok(token.value);
            }

            return Unauthorized();
        }
    }
}
