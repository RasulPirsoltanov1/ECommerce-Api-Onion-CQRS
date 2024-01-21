using AutoMapper;
using E_Commerce_Api.Application.Bases;
using E_Commerce_Api.Application.Features.Auth.Rules;
using E_Commerce_Api.Application.Interfaces.UnitOfWorks;
using E_Commerce_Api.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce_Api.Application.Features.Auth.Command.Register
{
    public class RegisterCommandHandler : BaseHandler, IRequestHandler<RegisterCommandRequest, Unit>
    {
        AuthRules _authRules;
        UserManager<AppUser> _userManager;
        RoleManager<AppRole> _roleManager;
        public RegisterCommandHandler(IMapper mapper, IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor, AuthRules authRules, UserManager<AppUser> userManager, RoleManager<AppRole> roleManager) : base(mapper, unitOfWork, httpContextAccessor)
        {
            _authRules = authRules;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public async Task<Unit> Handle(RegisterCommandRequest request, CancellationToken cancellationToken)
        {
            await _authRules.UserShoulNotBeExists(await _userManager.FindByEmailAsync(request.Email));
            AppUser user = _mapper.Map<RegisterCommandRequest, AppUser>(request);
            user.UserName = request.Email;
            user.SecurityStamp = Guid.NewGuid().ToString();
            IdentityResult identityResult = await _userManager.CreateAsync(user, request.Password);
            if (identityResult.Succeeded)
            {
                var resultRoleExists = await _roleManager.RoleExistsAsync("user");
                if (!resultRoleExists)
                {
                  var resultRole= await _roleManager.CreateAsync(new AppRole
                    {
                        Name = "user",
                    });
                }
                await _userManager.AddToRoleAsync(user, "user");
            }
            return Unit.Value;
        }


    }
}
