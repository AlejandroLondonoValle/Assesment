using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Assesment.DTOs.Auth;
using Assesment.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace Assesment.Controllers.Auth
{
    [ApiController]
    [Route("api/auth")]
    public class AuthController : ControllerBase
    {
        private readonly UserServices _userService;

        public AuthController(UserServices userService)
        {
            _userService = userService;
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginDTO login)
        {
            if (login == null)
            {
                return BadRequest("Invalid login request");
            }

            var user = _userService.GetUserByEmail(login.Email!);
            if (user == null)
            {
                return Unauthorized("User not found");
            }

            if (!BCrypt.Net.BCrypt.Verify(login.Password, user.Password))
            {
                return Unauthorized("Invalid password");
            }

            if (string.IsNullOrEmpty(user.Name) || string.IsNullOrEmpty(user.Role))
            {
                return Unauthorized("User name or role is missing");
            }

            // Add the user role
            var claims = new[]
            {
                new Claim(ClaimTypes.Name, user.Name),
                new Claim(ClaimTypes.Role, user.Role.ToLower()) // Keep role in lowercase
            };

            // We retrieve the environment variables for JWT
            var jwtSecretKey = Environment.GetEnvironmentVariable("JWT_SECRET_KEY");
            var jwtIssuer = Environment.GetEnvironmentVariable("JWT_ISSUER");
            var jwtAudience = Environment.GetEnvironmentVariable("JWT_AUDIENCE");

            // We check if any of the environment variables are empty or null
            if (string.IsNullOrEmpty(jwtSecretKey))
            {
                return Unauthorized("JWT_SECRET_KEY is not set.");
            }

            if (string.IsNullOrEmpty(jwtIssuer))
            {
                return Unauthorized("JWT_ISSUER is not set.");
            }

            if (string.IsNullOrEmpty(jwtAudience))
            {
                return Unauthorized("JWT_AUDIENCE is not set.");
            }

            // Crear el token JWT
            var token = new JwtSecurityToken(
                issuer: Environment.GetEnvironmentVariable("JWT_ISSUER"),
                audience: Environment.GetEnvironmentVariable("JWT_AUDIENCE"),
                claims: claims,
                expires: DateTime.UtcNow.AddMinutes(30), 
                signingCredentials: new SigningCredentials(
                    new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Environment.GetEnvironmentVariable("JWT_SECRET_KEY"))),
                    SecurityAlgorithms.HmacSha256
                )
            );

            return Ok(new
            {
                Token = new JwtSecurityTokenHandler().WriteToken(token),
                user.Email,
                user.Name,
                user.LastName,
                user.Role
            });
        }
    }
}
