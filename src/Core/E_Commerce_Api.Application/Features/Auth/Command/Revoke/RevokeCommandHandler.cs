using AutoMapper;
using E_Commerce_Api.Application.Bases;
using E_Commerce_Api.Application.Features.Auth.Rules;
using E_Commerce_Api.Application.Interfaces.UnitOfWorks;
using E_Commerce_Api.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;

namespace E_Commerce_Api.Application.Features.Auth.Command.Revoke
{
    public class RevokeCommandHandler : BaseHandler, IRequestHandler<RevokeCommandRequest,RevokeCommandResponse>
    {
        UserManager<AppUser> _userManager;
        RoleManager<AppRole> _roleManager;
        AuthRules _authRules;
        public RevokeCommandHandler(IMapper mapper, IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor, UserManager<AppUser> userManager, RoleManager<AppRole> roleManager, AuthRules authRules) : base(mapper, unitOfWork, httpContextAccessor)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _authRules = authRules;
        }

        public async Task<RevokeCommandResponse> Handle(RevokeCommandRequest request, CancellationToken cancellationToken)
        {
            AppUser? appUser = await _userManager.FindByEmailAsync(request.Email);
            await _authRules.EmailAddressShouldBeValid(appUser);
            appUser.RefreshToken = null;
            await _userManager.UpdateAsync(appUser);
            return new();
        }
    }
}
