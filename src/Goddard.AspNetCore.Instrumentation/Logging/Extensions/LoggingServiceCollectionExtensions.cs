using Goddard.AspNetCore.Logging.HttpLogging;
using Hellang.Middleware.ProblemDetails;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Goddard.AspNetCore.Logging.Extensions
{
    /// <summary>
    /// <see cref="IServiceCollection"/> extension methods for logging
    /// </summary>
    public static class LoggingServiceCollectionExtensions
    {
        /// <summary>
        /// Adds services for logging
        /// </summary>
        /// <param name="services"></param>
        /// <param name="configuration"></param>
        /// <returns></returns>
        public static IServiceCollection AddGoddardLogging(this IServiceCollection services, IConfiguration configuration)
        {            
            // Bind to configuration
            // https://learn.microsoft.com/en-us/aspnet/core/fundamentals/configuration/options?view=aspnetcore-7.0#bind-hierarchical-configuration
            services.Configure<GoddardHttpLoggingOptions>(
                configuration.GetSection(GoddardHttpLoggingOptions.DEFAULT_CONFIGURATION_SECTION));

            if(!string.IsNullOrEmpty(configuration["ApplicationInsights:ConnectionString"]))
            {
                services.AddApplicationInsightsTelemetry();
            }
            
            // User Story 16452: Add centralized logging to Application Insights to Tours API
            // Each API should standardize their error response contract - Should follow the  RFC 7807 specification
            // Add services for ProblemDetailsMiddleware
            // credit: https://andrewlock.net/handling-web-api-exceptions-with-problemdetails-middleware/
            services.AddProblemDetails(); // Add the required services

            return services;
        } 
    }
}
