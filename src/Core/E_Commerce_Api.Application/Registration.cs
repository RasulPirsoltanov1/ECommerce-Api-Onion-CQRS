using E_Commerce_Api.Application.AutoMapperConfigs;
using E_Commerce_Api.Application.Bases;
using E_Commerce_Api.Application.Exceptions;
using E_Commerce_Api.Application.Features.Products.Command.CreateProduct;
using E_Commerce_Api.Application.Features.Products.Queries.GetAllProducts;
using E_Commerce_Api.Application.Features.Products.Rules;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.Extensions.Configuration;
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
            services.AddRulesFromAssemblyContaining(Assembly.GetExecutingAssembly(), typeof(BaseRules));
            return services;
        }

        public static IServiceCollection AddRulesFromAssemblyContaining(this IServiceCollection services, Assembly assembly, Type type)
        {
            var types = assembly.GetTypes().Where(x => x.IsSubclassOf(type) && x != type).ToList();
            foreach (var typ in types)
            {
                services.AddTransient(typ);
            }
            return services;
        }
    }
}
