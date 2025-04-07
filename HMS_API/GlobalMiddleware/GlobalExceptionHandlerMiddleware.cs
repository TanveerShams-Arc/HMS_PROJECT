using System.Net;

namespace HMS_API.GlobalMiddleware
{
    public class GlobalExceptionHandlerMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<GlobalExceptionHandlerMiddleware> _logger;
        private readonly IHostEnvironment _env;

        public GlobalExceptionHandlerMiddleware(RequestDelegate next, ILogger<GlobalExceptionHandlerMiddleware> logger, IHostEnvironment env)
        {
            _next = next;
            _logger = logger;
            _env = env;
        }

        public async Task InvokeAsync(HttpContext httpContext)
        {
            try
            {
                await _next(httpContext);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(httpContext, ex);
            }
        }

        private Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            context.Response.ContentType = "application/json";

            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

            if (_env.IsDevelopment())
            {
                _logger.LogError($"Hello from global middleware exceptions: {exception}", exception.Message);
            }
            else
            {
                _logger.LogError("An unexpected error occurred.");
            }

            var response = new
            {
                message = "An unexpected error occurred. Please try again later.",
                details = _env.IsDevelopment() ? exception.Message : null
            };
            return context.Response.WriteAsJsonAsync(response);
        }
    }
}
