﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce_Api.Domain.Entities
{
    public class AppUser:IdentityUser<Guid>
    {
    }
}
