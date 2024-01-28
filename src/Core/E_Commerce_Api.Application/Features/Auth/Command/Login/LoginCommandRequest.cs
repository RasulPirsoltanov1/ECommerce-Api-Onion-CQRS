using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce_Api.Application.Features.Auth.Command.Login
{
    public class LoginCommandRequest: IRequest<LoginCommandResponse>
    {
        [DefaultValue("resulresull510@gmail.com")]
        public string Email { get; set; }
        [DefaultValue("Rasul123.")]
        public string Password { get; set; }
    }
}
