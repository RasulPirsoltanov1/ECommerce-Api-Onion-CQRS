using Microsoft.AspNetCore.Builder;

namespace E_Commerce_Api.Application.Exceptions
{
    public static class ConfigureExceptionMiddleware
    {
        public static void ConfigureExceptionMiddlewareHandling(this IApplicationBuilder builder)
        {
            builder.UseMiddleware<ExceptionMiddleware>();
        }
    }
}
