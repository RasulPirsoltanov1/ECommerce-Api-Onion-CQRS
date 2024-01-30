using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce_Api.Application.Features.Auth.Command.Revoke
{
    public class RevokeCommandRequest:IRequest<RevokeCommandResponse>
    {
        public string Email { get; set; }
    }
}
