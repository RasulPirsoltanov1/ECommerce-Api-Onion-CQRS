using E_Commerce_Api.Application.AutoMapperConfigs;
using E_Commerce_Api.Application.Exceptions;
using E_Commerce_Api.Application.Features.Products.Command.CreateProduct;
using E_Commerce_Api.Application.Features.Products.Queries.GetAllProducts;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce_Api.Application
{
    public static class Registration
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(GetAllProductsQueryHandler).Assembly));
            services.AddAutoMapper(typeof(AutoMapperConfig));
            services.AddFluentValidationAutoValidation();
            services.AddFluentValidationClientsideAdapters();
            services.AddValidatorsFromAssembly(typeof(CreateProductCommandValidator).Assembly);
            ValidatorOptions.Global.LanguageManager.Culture = new System.Globalization.CultureInfo("az");
            services.AddTransient<ExceptionMiddleware>();
            return services;
        }
    }
}
