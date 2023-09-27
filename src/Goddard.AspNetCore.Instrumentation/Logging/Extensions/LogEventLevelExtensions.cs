using Microsoft.Extensions.Logging;
using Serilog.Events;
using System;

namespace Goddard.Logging
{
    /// <summary>
    /// Extensions to <see cref="LogEventLevel"/>
    /// </summary>
    public static class LogEventLevelExtensions
    {
        /// <summary>
        /// Returns <see cref="LogLevel"/> mapped from <see cref="LogEventLevel"/>
        /// </summary>
        /// <param name="level"></param>
        /// <returns></returns>
        public static LogLevel ToLogLevel(this LogEventLevel level)
        {
            if (level == LogEventLevel.Fatal)
            {
                return LogLevel.Critical;
            }
            else if (level == LogEventLevel.Verbose)
            {
                return LogLevel.Trace;
            }
            else
            {
                var name = Enum.GetName(typeof(LogEventLevel), level);
                var result = (LogLevel)Enum.Parse(typeof(LogLevel), name!);
                return result;
            }
        }
    }
}
