using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace OzonEdu.MerchandiseService.Infrastructure.Middlewares
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
            await LogRequest(context);
            await _next(context);
            await LogResponse(context);
        }

        private async Task LogRequest(HttpContext context)
        {
            _logger.LogInformation("Request logged");
            _logger.LogInformation("Request Headers:");
            foreach (var item in context.Request.Headers)
            {
                _logger.LogInformation($"{item.Key} - {item.Value}");
            }

            _logger.LogInformation("Request RouteValues:");
            foreach (var item in context.Request.RouteValues)
            {
                _logger.LogInformation($"{item.Key} - {item.Value}");
            }

            try
            {
                if (context.Request.ContentLength > 0)
                {
                    context.Request.EnableBuffering();

                    var buffer = new byte[context.Request.ContentLength.Value];
                    await context.Request.Body.ReadAsync(buffer, 0, buffer.Length);
                    var bodyAsText = Encoding.UTF8.GetString(buffer);
                    _logger.LogInformation(bodyAsText);

                    context.Request.Body.Position = 0;
                }
            }
            catch (Exception e)
            {
                _logger.LogError(e, "Could not log request body");
            }
        }

        private async Task LogResponse(HttpContext context)
        {
            _logger.LogInformation("Response logged");
            _logger.LogInformation("Response Headers:");
            foreach (var item in context.Response.Headers)
            {
                _logger.LogInformation($"{item.Key} - {item.Value}");
            }

            try
            {
                if (context.Response.ContentLength > 0)
                {
                    var buffer = new byte[context.Response.ContentLength.Value];
                    await context.Response.Body.ReadAsync(buffer, 0, buffer.Length);
                    var bodyAsText = Encoding.UTF8.GetString(buffer);
                    _logger.LogInformation(bodyAsText);
                }
            }
            catch (Exception e)
            {
                _logger.LogError(e, "Could not log request body");
            }

            context.Response.Body = Stream.Null;
        }
    }
}