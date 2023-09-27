using Goddard.AspNetCore.Logging;
using Goddard.AspNetCore.Logging.Enrichers;
using Goddard.AspNetCore.Logging.HttpLogging;
using Hellang.Middleware.ProblemDetails;
using Microsoft.AspNetCore.Builder;
using Serilog;
using System;

namespace Goddard.AspNetCore.Builder
{
    public static class LoggingIApplicationBuilderExtensions
    {
        /// <summary>
        /// Adds HTTP logging middleware
        /// </summary>
        /// <param name="app"></param>
        public static void UseGoddardHttpLogging(
            this IApplicationBuilder app)
        {
            if (app == null) throw new ArgumentNullException(nameof(app));                        

            app.UseSerilogRequestLogging(opts =>
            {
                opts.EnrichDiagnosticContext = SerilogLogHelper.EnrichFromRequest;
                opts.GetLevel = SerilogLogHelper.GetLevel;
            });

            // Additional middleware that will add request/response details (headers, body) to DiagnosticContext
            // that can't be captured by EnrichDiagnosticContext due to async code
            app.UseMiddleware<HttpLoggingDetailsMiddleware>();

            // User Story 16452: Add centralized logging to Application Insights to Tours API
            // Each API should standardize their error response contract - Should follow the  RFC 7807 specification
            // Add ProblemDetailsMiddleware
            // credit: https://andrewlock.net/handling-web-api-exceptions-with-problemdetails-middleware/
            app.UseProblemDetails(); 
        }
    }
}