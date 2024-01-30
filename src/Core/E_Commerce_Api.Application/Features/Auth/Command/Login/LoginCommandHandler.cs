using AutoMapper;
using E_Commerce_Api.Application.Bases;
using E_Commerce_Api.Application.Features.Auth.Rules;
using E_Commerce_Api.Application.Interfaces.Tokens;
using E_Commerce_Api.Application.Interfaces.UnitOfWorks;
using E_Commerce_Api.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using System.IdentityModel.Tokens.Jwt;

namespace E_Commerce_Api.Application.Features.Auth.Command.Login
{
    public class LoginCommandHandler : BaseHandler, IRequestHandler<LoginCommandRequest, LoginCommandResponse>
    {
        UserManager<AppUser> _userManager;
        RoleManager<AppRole> _roleManager;
        ITokenService _tokenService;
        AuthRules _authRules;
        IConfiguration _configuration;
        public LoginCommandHandler(IMapper mapper, IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor, UserManager<AppUser> userManager, RoleManager<AppRole> roleManager, ITokenService tokenService, AuthRules authRules, IConfiguration configuration) : base(mapper, unitOfWork, httpContextAccessor)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _tokenService = tokenService;
            _authRules = authRules;
            _configuration = configuration;
        }

        public async Task<LoginCommandResponse> Handle(LoginCommandRequest request, CancellationToken cancellationToken)
        {
            var user = await _userManager.FindByEmailAsync(request.Email);
            bool checkPassword = await _userManager.CheckPasswordAsync(user, request.Password);
            await _authRules.EmailOrPasswordShouldNotBeInvalid(user, checkPassword);
            IList<string> roles = await _userManager.GetRolesAsync(user);
            JwtSecurityToken jwtSecurityToken = await _tokenService.CareateToken(user, roles);
            string refreshToken = _tokenService.GenerateRefreshToken();
            _ = int.TryParse(_configuration["JWT:TokenValidityInDays"], out var refreshTokenValidityInDays);
            user.RefreshToken = refreshToken;
            user.RefreshTokenExpiryTime = DateTime.Now.AddDays(refreshTokenValidityInDays);
            await _userManager.UpdateAsync(user);
            await _userManager.UpdateSecurityStampAsync(user);
            string token = new JwtSecurityTokenHandler().WriteToken(jwtSecurityToken);
            await _userManager.SetAuthenticationTokenAsync(user, "Default", "AccessToken", token);
            return new LoginCommandResponse
            {
                Token = token,
                RefreshToken = refreshToken,
                Expiration = jwtSecurityToken.ValidTo
            };
        }
    }
}
