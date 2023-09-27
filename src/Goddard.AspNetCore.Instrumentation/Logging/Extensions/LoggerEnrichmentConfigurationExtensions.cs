using Goddard.AspNetCore.Logging.Enrichers;
using Serilog;
using Serilog.Configuration;
using System;

namespace Goddard.AspNetCore.Logging.Extensions
{
    /// <summary>
    /// Extension methods to <see cref="LoggerEnrichmentConfiguration"/>
    /// </summary>
    public static class LoggerEnrichmentConfigurationExtensions
    {
        /// <summary>
        /// Adds <see cref="OperationIdEnricher"/>
        /// </summary>
        /// <param name="enrichConfiguration"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static LoggerConfiguration WithOperationId(this LoggerEnrichmentConfiguration enrichConfiguration)
        {
            if (enrichConfiguration is null) throw new ArgumentNullException(nameof(enrichConfiguration));

            return enrichConfiguration.With<OperationIdEnricher>();
        }
    }
}
