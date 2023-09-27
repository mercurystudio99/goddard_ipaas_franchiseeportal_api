using Goddard.AspNetCore.Logging.ApplicationInsights;
using Serilog.Core;
using Serilog.Events;
using Serilog.Sinks.ApplicationInsights.TelemetryConverters;
using System.Diagnostics;

namespace Goddard.AspNetCore.Logging.Enrichers
{
    /// <summary>
    /// Adds operation and parent ID for AI sink
    /// </summary>
    /// <remarks>
    /// Logic is a combination of various sources
    /// see: https://github.com/serilog-contrib/serilog-sinks-applicationinsights#including-operation-id
    /// see also: https://stackoverflow.com/a/57348252/541456
    /// see also: https://oleh-zheleznyak.blogspot.com/2019/08/serilog-with-application-insights.html
    /// see also: https://gist.github.com/oleh-zheleznyak/9fea0c10cddd79eb89c8a75830597de5
    /// </remarks>
    public class OperationIdEnricher : ILogEventEnricher
    {
        public void Enrich(LogEvent logEvent, ILogEventPropertyFactory propertyFactory)
        {
            var currentActivity = Activity.Current;

            if (currentActivity != null)
            {
                // Get operation and parent IDs from current activity
                // credit: https://github.com/microsoft/ApplicationInsights-dotnet/blob/405fd6a9916956f2233520c8ab66110a1f9dcfbc/BASE/src/Microsoft.ApplicationInsights/Extensibility/OperationCorrelationTelemetryInitializer.cs#L60

                string operationId;
                string parentId;
                if (currentActivity.IdFormat == ActivityIdFormat.W3C)
                {
                    // Set OperationID to Activity.TraceId
                    operationId = currentActivity.TraceId.ToHexString();
                    parentId = currentActivity.SpanId.ToHexString();
                }
                else
                {
                    operationId = currentActivity.RootId;
                    parentId = currentActivity.Id;                    
                }

                // Add to log even if not already populated
                logEvent.AddPropertyIfAbsent(propertyFactory.CreateProperty(TelemetryConverterBase.OperationIdProperty, operationId));
                logEvent.AddPropertyIfAbsent(propertyFactory.CreateProperty(CustomTraceTelemetryConverter.ParentIdProperty, parentId));               
            }
            else
            {
                // Current activity was null, fallback to what's documented in the AI sink docs
                // https://github.com/serilog-contrib/serilog-sinks-applicationinsights#including-operation-id

                if (logEvent.Properties.TryGetValue("RequestId", out var requestId))
                {
                    // Otherwise fall back to RequestId as document in sink docs
                    logEvent.AddPropertyIfAbsent(new LogEventProperty(TelemetryConverterBase.OperationIdProperty, requestId));
                }
            }
        }
    }
}
