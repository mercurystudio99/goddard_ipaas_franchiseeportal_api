using Goddard.AspNetCore.Diagnostics.HealthChecks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace Goddard.AspNetCore.Builder
{
    public static class WebApplicationExtensions
    {
        /// <summary>
        /// Adds health check endpoint
        /// </summary>
        /// <param name="app"></param>
        public static IApplicationBuilder MapGoddardHealthChecks(this IApplicationBuilder app)
        {
            var optionsAccessor = app.ApplicationServices.GetService<IOptions<GoddardHealthCheckOptions>>()
                ?? Options.Create(new GoddardHealthCheckOptions());
            
            var options = optionsAccessor.Value;

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapHealthChecks(options.Path, options);
            });

            return app;
        }
    }
}
