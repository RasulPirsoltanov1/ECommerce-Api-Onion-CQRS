using E_Commerce_Api.Application.Tokens;
using E_Commerce_Api.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce_Api.Infrastructure.Tokens
{
    public class TokenService : ITokenService

    {
        TokenSettings _options;
        UserManager<AppUser> _userManager;

        public TokenService(IOptions<TokenSettings> options, UserManager<AppUser> userManager)
        {
            _options = options.Value;
            _userManager = userManager;
        }

        public string GenerateRefreshToken()
        {

            throw new NotImplementedException();
        }

        public async Task<System.IdentityModel.Tokens.Jwt.JwtSecurityToken> JwtSecurityToken(E_Commerce_Api.Domain.Entities.AppUser user, IList<string> roles)
        {
            var claims = new List<Claim>()
            {
                new Claim(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString()),
                new Claim(ClaimTypes.NameIdentifier,user.Id.ToString()),
                new Claim(JwtRegisteredClaimNames.Email,user?.Email),
            };
            foreach (var role in roles)
            {
                claims.Add(new Claim(ClaimTypes.Role, role));
            }
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_options.Secret));
            var token = new JwtSecurityToken(issuer:_options.Issuer,audience:_options.Audience,expires:DateTime.UtcNow.AddMinutes(_options.TokenValidityInMinutes),claims:claims,signingCredentials:new SigningCredentials(key,SecurityAlgorithms.HmacSha256));
            return token;
        }
    }
}
