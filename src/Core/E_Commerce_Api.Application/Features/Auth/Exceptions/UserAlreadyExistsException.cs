using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce_Api.Application.Features.Auth.Exceptions
{
    public class UserAlreadyExistsException:Exception
    {
        public UserAlreadyExistsException() : base("User already exists") { }
        public UserAlreadyExistsException(string message):base(message) { }
    }
}
