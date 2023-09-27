using Microsoft.ApplicationInsights.W3C;
using RestSharp;

namespace FranchiseePortal.WebApiClient.Extensions
{
    public static class IRestRequestExtensions
    {
        /// <summary>
        /// Adds correlation to request
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        /// <remarks>
        /// credit: https://github.com/microsoft/ApplicationInsights-dotnet/issues/1662#issuecomment-581857871
        /// </remarks>
        public static IRestRequest AddCorrelation(this IRestRequest request)
        {
            var activity = System.Diagnostics.Activity.Current;
            if(activity == null) {
                return request;
            }
            request.AddHeader(W3CConstants.TraceParentHeader, activity.Id);
            var traceState = activity.TraceStateString;
            if (traceState != null)
            {
                request.AddHeader(W3CConstants.TraceStateHeader, traceState);
            }

            return request;
        }
    }
}
