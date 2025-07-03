namespace Tatawwa3.API.MiddleWares
{
    public class RequestResponseLoggingMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<RequestResponseLoggingMiddleware> _logger;

        public RequestResponseLoggingMiddleware(RequestDelegate next, ILogger<RequestResponseLoggingMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            // 1. Log Request
            context.Request.EnableBuffering();

            var requestBody = await new StreamReader(context.Request.Body).ReadToEndAsync();
            context.Request.Body.Position = 0;

            _logger.LogInformation($"\n🚀 Request:\n" +
                                   $"Method: {context.Request.Method}\n" +
                                   $"Path: {context.Request.Path}\n" +
                                   $"Headers: {string.Join(", ", context.Request.Headers.Select(h => $"{h.Key}:{h.Value}"))}\n" +
                                   $"Body: {requestBody}");

            // 2. Capture Response
            var originalBodyStream = context.Response.Body;
            using var responseBody = new MemoryStream();
            context.Response.Body = responseBody;

            await _next(context);

            context.Response.Body.Seek(0, SeekOrigin.Begin);
            var responseText = await new StreamReader(context.Response.Body).ReadToEndAsync();
            context.Response.Body.Seek(0, SeekOrigin.Begin);

            _logger.LogInformation($"\n✅ Response:\n" +
                                   $"Status Code: {context.Response.StatusCode}\n" +
                                   $"Body: {responseText}");

            await responseBody.CopyToAsync(originalBodyStream);
        }
    }
}
