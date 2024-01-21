using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce_Api.Application.Features.Auth.Command.Register
{
    public class RegisterCommandValidator : AbstractValidator<RegisterCommandRequest>
    {
        public RegisterCommandValidator()
        {
            RuleFor(x=>x.FullName).NotNull().NotEmpty().MaximumLength(50).MinimumLength(2);
            RuleFor(x=>x.Email).NotNull().NotEmpty().MaximumLength(50).EmailAddress().MinimumLength(2);
            RuleFor(x=>x.Password).NotNull().NotEmpty().MaximumLength(50).MinimumLength(6);
            RuleFor(x=>x.ConfirmPassword).NotNull().NotEmpty().MaximumLength(50).MinimumLength(6).Equal(x=>x.Password);
        


        }
    }
}
