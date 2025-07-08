namespace Usermanagement.Models
{
    public class AuthKeylayer
    {
            private readonly RequestDelegate _next;
            private readonly string _apiKey;

            private const string ApiKeyHeader = "X-API-KEY";

            public AuthKeylayer(RequestDelegate next, IConfiguration config)
            {
                _next = next;
                _apiKey = config["ApiKey"];
            }

            public async Task InvokeAsync(HttpContext context)
            {
            ////if (!context.Request.Headers.TryGetValue(ApiKeyHeader, out var providedKey) ||
            ////    string.IsNullOrWhiteSpace(_apiKey) ||
            ////    providedKey != _apiKey)
            ////{
            ////    context.Response.StatusCode = StatusCodes.Status401Unauthorized;
            ////    await context.Response.WriteAsync("Unauthorized - Invalid API Key provided");
            ////    return;
            ////}

            ////await _next(context);
           if (!context.Request.Headers.TryGetValue("X-API-KEY", out var extractedKey))
            {
                context.Response.StatusCode = 401;
                await context.Response.WriteAsync("API Key is missing.");
                return;
            }

            if (extractedKey != _apiKey)
            {
                context.Response.StatusCode = 401;
                await context.Response.WriteAsync("Invalid API Key.");
                return;
            }
            await _next(context);

        }  }










    
}
