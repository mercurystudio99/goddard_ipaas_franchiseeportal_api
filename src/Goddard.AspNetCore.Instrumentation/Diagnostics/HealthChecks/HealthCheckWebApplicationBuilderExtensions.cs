using Goddard.AspNetCore.Diagnostics.HealthChecks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Serilog;
using Serilog.Extensions.Hosting;

namespace Goddard.AspNetCore.Builder
{
    public static class HealthCheckWebApplicationBuilderExtensions
    {
        public static IWebHostBuilder AddGoddardHealthChecks(this IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) =>
            {                
                services.Configure<GoddardHealthCheckOptions>(context.Configuration.GetSection(GoddardHealthCheckOptions.DEFAULT_CONFIGURATION_SECTION));
                services.AddHealthChecks();
            });

            return builder;
        }
    }
}
