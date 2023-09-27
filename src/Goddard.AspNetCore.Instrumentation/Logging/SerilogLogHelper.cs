using Microsoft.AspNetCore.Http;
using Microsoft.IO;
using Serilog;
using Serilog.Events;
using System;

namespace Goddard.AspNetCore.Logging
{
    /// <summary>
    /// Serilog log helper
    /// credit: https://andrewlock.net/using-serilog-aspnetcore-in-asp-net-core-3-logging-the-selected-endpoint-name-with-serilog/
    /// </summary>
    public static class SerilogLogHelper
    {
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// The instance should live as long as the process is alive, i.e., for the lifetime of the process.
        /// </remarks>
        private static readonly Lazy<RecyclableMemoryStreamManager>
            _recyclableMemoryStreamManager = new Lazy<RecyclableMemoryStreamManager>(() => new RecyclableMemoryStreamManager());
                
        /// <summary>
        /// Adds additional request/response metadata to <paramref name="diagnosticContext"/> from <paramref name="httpContext"/>
        /// </summary>
        /// <param name="diagnosticContext"></param>
        /// <param name="httpContext"></param>
        /// <remarks>
        /// credit: https://andrewlock.net/using-serilog-aspnetcore-in-asp-net-core-3-logging-the-selected-endpoint-name-with-serilog/
        /// </remarks>
        public static void EnrichFromRequest(
            IDiagnosticContext diagnosticContext, 
            HttpContext httpContext)
        {
            var request = httpContext.Request;

            // Set all the common properties available for every request
            diagnosticContext.Set("Host", request.Host);
            diagnosticContext.Set("Protocol", request.Protocol);
            diagnosticContext.Set("Scheme", request.Scheme);

            // Only set it if available. You're not sending sensitive data in a querystring right?!
            if (request.QueryString.HasValue)
            {
                diagnosticContext.Set("QueryString", request.QueryString.Value);
            }

            // Set the content-type of the Response at this point
            diagnosticContext.Set("ContentType", httpContext.Response.ContentType);

            // Retrieve the IEndpointFeature selected for the request
            var endpoint = httpContext.GetEndpoint();
            if (endpoint is object) // endpoint != null
            {
                diagnosticContext.Set("EndpointName", endpoint.DisplayName);
            }

        }

        /// <summary>
        /// Gets <see cref="LogEventLevel"/> for request
        /// </summary>
        /// <param name="ctx"></param>
        /// <param name="_"></param>
        /// <param name="ex"></param>
        /// <returns></returns>
        /// <remarks>
        /// credit: https://andrewlock.net/using-serilog-aspnetcore-in-asp-net-core-3-excluding-health-check-endpoints-from-serilog-request-logging/
        /// </remarks>
        public static LogEventLevel GetLevel(HttpContext ctx, double _, Exception? ex = null)
        {
            if(ex != null)
            {
                return LogEventLevel.Error;
            }
           
            var statusCode = ctx.Response.StatusCode;

            var result = statusCode switch
            {
                < StatusCodes.Status400BadRequest => LogEventLevel.Information,
                >= StatusCodes.Status400BadRequest and < StatusCodes.Status500InternalServerError => LogEventLevel.Warning,
                >= StatusCodes.Status500InternalServerError => LogEventLevel.Error
            };

            if(result == LogEventLevel.Information)
            {
                // Do further filtering for Healthchecks
                // to return as Verbose to avoid filling up logs
                result = IsHealthCheckEndpoint(ctx) ? LogEventLevel.Verbose : LogEventLevel.Information;
            }

            return result;
        }

        /// <summary>
        /// Returns true if is health check point assuming default name
        /// credit: https://andrewlock.net/using-serilog-aspnetcore-in-asp-net-core-3-excluding-health-check-endpoints-from-serilog-request-logging/
        /// </summary>
        /// <param name="ctx"></param>
        /// <returns></returns>
        private static bool IsHealthCheckEndpoint(HttpContext ctx)
        {
            var endpoint = ctx.GetEndpoint();
            if (endpoint is object) // same as !(endpoint is null)
            {
                return string.Equals(
                    endpoint.DisplayName,
                    "Health checks",
                    StringComparison.Ordinal);
            }
            // No endpoint, so not a health check endpoint
            return false;
        }
    }
}
