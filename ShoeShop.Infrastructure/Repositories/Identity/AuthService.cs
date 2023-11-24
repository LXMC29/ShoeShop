using ShoeShop.Application.Repositories.Identity;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using ShoeShop.Application.Models.Identity;
using ShoeShop.Infrastructure.Identity.Model;

namespace ShoeShop.Infrastructure.Repositories.Identity
{
    public class AuthService : IAuthService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IConfiguration _configuration;

        public AuthService(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, IConfiguration configuration)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _configuration = configuration;
        }
        public async Task<string> Login(LoginRequest loginRequest)
        {
            var user = await _userManager.FindByNameAsync(loginRequest.UserName);
            if (user == null)
            {
                return "";
            }

            var result = await _signInManager.CheckPasswordSignInAsync(user, loginRequest.Password, false);

            // tra ve token kieu string

            var jwt = await GenerateToken(user);
            var token = new JwtSecurityTokenHandler().WriteToken(jwt);

            return token;

        }

        public Task<string> Register(RegisterRequest registerRequest)
        {
            throw new NotImplementedException();
        }

        public async Task<JwtSecurityToken> GenerateToken(ApplicationUser user)
        {
            //Lấy ra thông tin user
            var userClaims = await _userManager.GetClaimsAsync(user);
            var roles = await _userManager.GetRolesAsync(user);

            //Chuyển các thông tin user sang Claims
            var rolesClaim = roles.Select(c => new Claim(ClaimTypes.Role, c)).ToList();
            var claims = new[]
                {
                    new Claim(JwtRegisteredClaimNames.Sub, user.UserName),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                    new Claim(JwtRegisteredClaimNames.Email, user.Email),
                    new Claim("lol", user.Id)
                }
                .Union(userClaims)
                .Union(rolesClaim);

            //Tạo khóa bảo mật đối xứng
            var symetricSecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["SettingsJwt:SecretKey"]));

            //tạo khóa ký = cách chuyển chuỗi symetricSecurityKey băm  sang Sha256, Sha512,...
            var signingCredential = new SigningCredentials(symetricSecurityKey, SecurityAlgorithms.HmacSha256);

            //tạo JWT
            var jwtSecurityToken = new JwtSecurityToken(
                issuer: _configuration["SettingsJwt:ValidIssuer"],
                audience: _configuration["SettingsJwt:ValidAudience"],
                claims: claims,
                expires: DateTime.UtcNow.AddMinutes(5),
                signingCredentials: signingCredential);

            return jwtSecurityToken;
        }
    }
}
