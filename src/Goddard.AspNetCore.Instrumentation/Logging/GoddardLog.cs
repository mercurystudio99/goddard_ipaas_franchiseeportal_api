using Serilog;
using Serilog.Events;

namespace Goddard.AspNetCore.Logging
{
    /// <inheritdoc cref="Log"/>
    public class GoddardLog
    {
        /// <inheritdoc cref="Log.CloseAndFlush"/>
        public static void CloseAndFlush()
        {
            Log.CloseAndFlush();
        }

        /// <summary>
        /// Creates initial bootstrap logger to be used before configuration and DI
        /// are available
        /// see: https://github.com/serilog/serilog-aspnetcore#two-stage-initialization
        /// </summary>
        /// <returns></returns>
        public static ILogger SetupBootstrapLogger()
        {
            var result = Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Override("Microsoft", LogEventLevel.Information)
                .Enrich.FromLogContext()
                .WriteTo.Console()
                .CreateBootstrapLogger();

            return result;
        }
    }
}