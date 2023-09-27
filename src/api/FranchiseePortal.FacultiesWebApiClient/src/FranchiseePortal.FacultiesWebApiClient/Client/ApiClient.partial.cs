using RestSharp;
using FranchiseePortal.WebApiClient.Extensions;

namespace FranchiseePortal.FacultiesWebApiClient.Client
{
    public partial class ApiClient
    {
        partial void InterceptRequest(IRestRequest request)
        {
            request.AddCorrelation();
        }
    }
}
