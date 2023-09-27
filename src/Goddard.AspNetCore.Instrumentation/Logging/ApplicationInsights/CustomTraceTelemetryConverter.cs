using Microsoft.ApplicationInsights.Channel;
using Serilog.Events;
using Serilog.Sinks.ApplicationInsights.TelemetryConverters;
using System;
using System.Collections.Generic;

namespace Goddard.AspNetCore.Logging.ApplicationInsights
{
    /// <summary>
    /// Enhances OOTB <see cref="TraceTelemetryConverter"/> to also include parent ID
    /// </summary>
    /// <remarks>
    /// credit: https://stackoverflow.com/a/57348252/541456
    /// credit: https://gist.github.com/oleh-zheleznyak/5f5eb59c7ccf9501119df67767f15708
    /// </remarks>
    public class CustomTraceTelemetryConverter : TraceTelemetryConverter
    {
        /// <summary>
        ///     Property that is included when in log context, will be pushed out as AI parent ID.
        /// </summary>
        public const string ParentIdProperty = "parentId";

        public override IEnumerable<ITelemetry> Convert(LogEvent logEvent, IFormatProvider formatProvider)
        {
            foreach (var telemetry in base.Convert(logEvent, formatProvider))
            {
                if (TryGetScalarProperty(logEvent, ParentIdProperty, out var parentId))
                {
                    telemetry.Context.Operation.ParentId = parentId.ToString();
                }
                    
                yield return telemetry;
            }
        }

        private bool TryGetScalarProperty(LogEvent logEvent, string propertyName, out object value)
        {
            var hasScalarValue =
                logEvent.Properties.TryGetValue(propertyName, out var someValue) &&
                (someValue is ScalarValue);

            value = hasScalarValue ? ((ScalarValue)someValue).Value : default;

            return hasScalarValue;
        }
    }
}
