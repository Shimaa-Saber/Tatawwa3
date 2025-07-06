using System.Net;
using System.Text.Json;

namespace Tatawwa3.API.MiddleWares
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<ExceptionMiddleware> _logger;
        private readonly IHostEnvironment _env;

        public ExceptionMiddleware(RequestDelegate next, ILogger<ExceptionMiddleware> logger, IHostEnvironment env)
        {
            _next = next;
            _logger = logger;
            _env = env;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
              
                Console.WriteLine("🔥 EXCEPTION CAUGHT IN MIDDLEWARE 🔥");
                Console.WriteLine(ex.ToString());

          
                _logger.LogError(ex, ex.Message);

                context.Response.ContentType = "application/json";

                var statusCode = context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

                object response;

           
                if (_env.IsDevelopment())
                {
                    response = new
                    {
                        status = statusCode,
                        error = ex.Message,
                        stackTrace = ex.StackTrace
                    };
                }
                else
                {
                  
                    response = new
                    {
                        status = statusCode,
                        error = ex.Message,
                    };
                }

                var options = new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase };
                var json = JsonSerializer.Serialize(response, options);

                await context.Response.WriteAsync(json);
            }
        }
    }
}
