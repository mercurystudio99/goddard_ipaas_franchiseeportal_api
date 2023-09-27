using Goddard.AspNetCore.Logging.Enrichers;
using Goddard.AspNetCore.Logging.Extensions;
using Goddard.AspNetCore.Logging.HttpLogging;
using Hellang.Middleware.ProblemDetails;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Serilog;

namespace Goddard.AspNetCore.Builder
{
    public static class LoggingWebApplicationBuilderExtensions
    {
        /// <summary>
        /// Adds services for web application logging
        /// </summary>
        /// <param name="builder"></param>
        /// <remarks>
        /// Wires up
        ///   * Services for <see cref="ProblemDetailsMiddleware"/>
        ///   * Serilog
        /// </remarks>        
        public static IWebHostBuilder AddGoddardLogging(this IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) =>
            {
                services.AddGoddardLogging(context.Configuration);
            });

            // 20230317RBP - Continuing to use IWebHostBuilder because that's what the FBP API is using
            builder.UseSerilog((context, configuration) =>
            {
                configuration
                    .ReadFrom.Configuration(context.Configuration)
                    // 20230317RBP - services is not available in .NET 2.0
                    // so this is commented out
                    //.ReadFrom.Services(services)
                    ;
            });

            return builder;
        }
    }
}
