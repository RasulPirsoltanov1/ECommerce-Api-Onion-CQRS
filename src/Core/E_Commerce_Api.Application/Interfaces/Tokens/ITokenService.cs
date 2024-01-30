using E_Commerce_Api.Domain.Entities;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace E_Commerce_Api.Application.Interfaces.Tokens
{
    public interface ITokenService
    {
        Task<JwtSecurityToken> CareateToken(AppUser user, IList<string> roles);
        string GenerateRefreshToken();
        ClaimsPrincipal GetPrincipalFromExpiredToken(string? token);
    }
}
