using AutoMapper;
using E_Commerce_Api.Application.Bases;
using E_Commerce_Api.Application.Interfaces.UnitOfWorks;
using E_Commerce_Api.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce_Api.Application.Features.Auth.Command.RevokeAll
{
    public class RevokeAllCommandHandler : BaseHandler, IRequestHandler<RevokeAllCommandRequest, RevokeAllCommandResponse>
    {

        UserManager<AppUser> _userManager;
        RoleManager<AppRole> _roleManager;
        public RevokeAllCommandHandler(IMapper mapper, IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor, UserManager<AppUser> userManager, RoleManager<AppRole> roleManager) : base(mapper, unitOfWork, httpContextAccessor)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public async Task<RevokeAllCommandResponse> Handle(RevokeAllCommandRequest request, CancellationToken cancellationToken)
        {
            List<AppUser> users = await _userManager.Users.ToListAsync();
            foreach (AppUser user in users)
            {
                user.RefreshToken = null;
                await _userManager.UpdateAsync(user);
            }
            return new RevokeAllCommandResponse();
        }
    }

}
