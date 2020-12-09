using CategoryService.Exceptions;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace CategoryService.Middleware
{
    public class CustomExceptionsMiddleware
    {
        private readonly RequestDelegate _next;
        public CustomExceptionsMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next.Invoke(context);
            }
            catch(Exception ex)
            {
                await HandleExceptionAsync(context, ex);
            }
        }
        private async Task HandleExceptionAsync(HttpContext context,Exception exception)
        {
            var response = context.Response;
            var exceptionType = exception.GetType();
            var message = exception.Message;
            if (exceptionType == typeof(CategoryNotFoundException))
            {
                response.StatusCode = (int)HttpStatusCode.NotFound;
            }
            else if (exceptionType == typeof(CategoryNotCreatedException))
            {
                response.StatusCode = (int)HttpStatusCode.Conflict;
            }
            else
            {
                response.StatusCode = (int)HttpStatusCode.InternalServerError;
            }
            //response.ContentType = "application/json";
            await response.WriteAsync(message);
        }
    }
}
