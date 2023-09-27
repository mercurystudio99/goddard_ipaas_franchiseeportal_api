# FranchiseePortal.ToursWebApiClient.Api.GuidesApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiV1SchoolsSchoolCrmIdGuidesGet**](GuidesApi.md#apiv1schoolsschoolcrmidguidesget) | **GET** /api/v1/schools/{schoolCrmId}/guides | Gets school tour guides


<a name="apiv1schoolsschoolcrmidguidesget"></a>
# **ApiV1SchoolsSchoolCrmIdGuidesGet**
> List&lt;TourGuideDto&gt; ApiV1SchoolsSchoolCrmIdGuidesGet (string schoolCrmId)

Gets school tour guides

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FranchiseePortal.ToursWebApiClient.Api;
using FranchiseePortal.ToursWebApiClient.Client;
using FranchiseePortal.ToursWebApiClient.Model;

namespace Example
{
    public class ApiV1SchoolsSchoolCrmIdGuidesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new GuidesApi(config);
            var schoolCrmId = F0EDC50F-ED22-DE11-B821-0014221C4264;  // string | ID (CRM) of school

            try
            {
                // Gets school tour guides
                List<TourGuideDto> result = apiInstance.ApiV1SchoolsSchoolCrmIdGuidesGet(schoolCrmId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GuidesApi.ApiV1SchoolsSchoolCrmIdGuidesGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **schoolCrmId** | **string**| ID (CRM) of school | 

### Return type

[**List&lt;TourGuideDto&gt;**](TourGuideDto.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns school tour guides |  -  |
| **400** | schoolCrmId is invalid |  -  |
| **404** | School not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

