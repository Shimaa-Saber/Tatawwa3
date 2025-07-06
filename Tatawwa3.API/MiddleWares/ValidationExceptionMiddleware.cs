using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Text.Json;

namespace Tatawwa3.API.MiddleWares
{
    public class ValidationExceptionMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly IHostEnvironment _env;

        public ValidationExceptionMiddleware(RequestDelegate next, IHostEnvironment env)
        {
            _next = next;
            _env = env;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (ValidationException ex)
            {
                context.Response.StatusCode = (int)HttpStatusCode.BadRequest;
                context.Response.ContentType = "application/json";

              
                var errors = new Dictionary<string, string[]>
                    {
                        { "ValidationError", new[] { ex.Message } }
                    };

                var response = new
                {
                    status = 400,
                    errors
                };

                var options = new JsonSerializerOptions
                {
                    PropertyNamingPolicy = JsonNamingPolicy.CamelCase
                };

                var json = JsonSerializer.Serialize(response, options);
                await context.Response.WriteAsync(json);
            }
        }
    }
}
