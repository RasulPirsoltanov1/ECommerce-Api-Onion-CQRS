using E_Commerce_Api.Application.Interfaces.AutoMapper;
using E_Commerce_Api.Mapper.AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce_Api.Mapper
{
    public static class Registration
    {
        public static IServiceCollection AddCustomAutoMapper(this IServiceCollection services)
        {
            services.AddSingleton<IMapper, E_Commerce_Api.Mapper.AutoMapper.Mapper>();
            return services;
        }
    }
}
