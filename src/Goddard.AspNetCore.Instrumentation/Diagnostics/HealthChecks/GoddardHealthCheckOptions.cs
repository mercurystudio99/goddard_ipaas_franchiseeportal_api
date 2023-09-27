using Microsoft.AspNetCore.Diagnostics.HealthChecks;

namespace Goddard.AspNetCore.Diagnostics.HealthChecks
{
    /// <inheritdoc cref="HealthCheckOptions"/>
    public class GoddardHealthCheckOptions : HealthCheckOptions
    {
        public const string DEFAULT_CONFIGURATION_SECTION = "Goddard:Diagnostics:HealthCheck";

        public const string DEFAULT_PATH = "/health";

        /// <summary>
        /// Path to health check endpoint
        /// </summary>
        public string Path
        {
            get;
            set;
        } = DEFAULT_PATH;
    }
}