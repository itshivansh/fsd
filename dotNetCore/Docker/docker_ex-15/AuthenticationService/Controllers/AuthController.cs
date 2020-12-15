using System;
using System.IdentityModel.Tokens.Jwt;
using System.Net;
using System.Security.Claims;
using System.Text;
using AuthenticationService.Exceptions;
using AuthenticationService.Models;
using AuthenticationService.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;

namespace AuthenticationService.Controllers
{
    [Route("api/[controller]")]
    public class AuthController : Controller
    {
        private readonly IAuthService authService;
        public AuthController(IAuthService auth)
        {
            authService = auth;
        }
        [HttpPost]
        [Route("register")]
        public IActionResult Register([FromBody] User user)
        {
            try
            {
                return Created("", authService.RegisterUser(user));
            }
            catch (UserAlreadyExistsException ex)
            {
                return Conflict(ex.Message);
            }
            catch (Exception)
            {
                return StatusCode(500, "Something went wrong");
            }
        }
        [HttpPost]
        [Route("login")]
        public IActionResult Login([FromBody] User user)
        {

            try
            {
                bool _user = authService.LoginUser(user);
                if (_user == true)
                    return Ok(GetToken(user.UserId));

                return Unauthorized("Invalid user id or password");
            }

            catch (Exception)
            {
                return StatusCode(500, "SOmething wrong");
            }
        }


        private string GetToken(string userId)
        {
            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.UniqueName,userId),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("secret_auth_jwt_to_secure_microservice"));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var token = new JwtSecurityToken(
                issuer: "AuthenticationServer",
                audience: "AuthClient",
                claims: claims,
                expires: DateTime.UtcNow.AddMinutes(30),
                signingCredentials: creds
            );
            var response = new
            {
                token = new JwtSecurityTokenHandler().WriteToken(token)
            };
            return JsonConvert.SerializeObject(response);
        }
    }
}