using AutoMapper;
using E_Commerce_Api.Application.Bases;
using E_Commerce_Api.Application.Features.Auth.Rules;
using E_Commerce_Api.Application.Interfaces.Tokens;
using E_Commerce_Api.Application.Interfaces.UnitOfWorks;
using E_Commerce_Api.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace E_Commerce_Api.Application.Features.Auth.Command.RefreshToken
{
    public class RefreshTokenCommandHandler : BaseHandler, IRequestHandler<RefreshTokenCommandRequest, RefreshTokenCommandResponse>
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly ITokenService _tokenService;
        AuthRules _authRules;
        public RefreshTokenCommandHandler(IMapper mapper, IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor, UserManager<AppUser> userManager, ITokenService tokenService, AuthRules authRules) : base(mapper, unitOfWork, httpContextAccessor)
        {
            _userManager = userManager;
            _tokenService = tokenService;
            _authRules = authRules;
        }

        public async Task<RefreshTokenCommandResponse> Handle(RefreshTokenCommandRequest request, CancellationToken cancellationToken)
        {
            ClaimsPrincipal? principal = _tokenService.GetPrincipalFromExpiredToken(request.AccessToken);
            string? email = principal.FindFirstValue(ClaimTypes.Email);
            var user = await _userManager.FindByEmailAsync(email);
            if (user == null)
                throw new Exception("user can not find in current context.");
            var roles = await _userManager.GetRolesAsync(user);
            await _authRules.RefreshTokenShouldNotBeExpired(user.RefreshTokenExpiryTime);
            JwtSecurityToken? newAccessToken = await _tokenService.CareateToken(user, roles);
            string accessToken = new JwtSecurityTokenHandler().WriteToken(newAccessToken);
            var refreshToken = _tokenService.GenerateRefreshToken();
            user.RefreshToken = refreshToken;
            await _userManager.UpdateAsync(user);
            return new RefreshTokenCommandResponse
            {
                AccessToken = accessToken,
                RefreshToken = refreshToken,
            };
        }
    }
}
