using E_Commerce_Api.Application.Bases;
using E_Commerce_Api.Application.Features.Auth.Exceptions;
using E_Commerce_Api.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce_Api.Application.Features.Auth.Rules
{
    public class AuthRules:BaseRules
    {
        public Task UserShoulNotBeExists(AppUser? appUser)
        {
            if (appUser != null)
                throw new UserAlreadyExistsException();
            return Task.CompletedTask;
        }
    }
}
