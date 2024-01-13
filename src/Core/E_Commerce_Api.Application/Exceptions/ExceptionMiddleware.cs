using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Http;
using SendGrid;
using SendGrid.Helpers.Errors.Model;

namespace E_Commerce_Api.Application.Exceptions
{
    public class ExceptionMiddleware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            try
            {
                await next(context);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(context, ex);
            }
        }

        private static async Task HandleExceptionAsync(HttpContext context, Exception ex)
        {
            int statusCode = GetStatusCode(ex);
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = statusCode;
            List<string> errors = new List<string>()
            {
                ex.Message,
            };
            if(ex.InnerException != null)
            {
                errors.Add(ex.InnerException.Message);
            }
            await context.Response.WriteAsync(new ExceptionModel
            {
                Errors = errors,
                StatusCode = statusCode
            }.ToString());
        }
        private static int GetStatusCode(Exception exception)
        {
            if (exception is BadRequestException)
            {
                return StatusCodes.Status400BadRequest;
            }
            else if (exception is NotFoundException)
            {
                return StatusCodes.Status404NotFound;
            }
            else if (exception is ValidationException)
            {
                return StatusCodes.Status422UnprocessableEntity;
            }
            else
            {
                return StatusCodes.Status500InternalServerError;
            }
        }


    }
}
