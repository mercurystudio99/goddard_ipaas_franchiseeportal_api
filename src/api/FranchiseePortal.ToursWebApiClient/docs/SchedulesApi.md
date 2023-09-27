# FranchiseePortal.ToursWebApiClient.Api.SchedulesApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiV1SchoolsSchoolCrmIdSchedulesGet**](SchedulesApi.md#apiv1schoolsschoolcrmidschedulesget) | **GET** /api/v1/schools/{schoolCrmId}/schedules | Gets school day schedules


<a name="apiv1schoolsschoolcrmidschedulesget"></a>
# **ApiV1SchoolsSchoolCrmIdSchedulesGet**
> List&lt;ScheduleDto&gt; ApiV1SchoolsSchoolCrmIdSchedulesGet (string schoolCrmId, DateTime startDate, DateTime endDate)

Gets school day schedules

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FranchiseePortal.ToursWebApiClient.Api;
using FranchiseePortal.ToursWebApiClient.Client;
using FranchiseePortal.ToursWebApiClient.Model;

namespace Example
{
    public class ApiV1SchoolsSchoolCrmIdSchedulesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new SchedulesApi(config);
            var schoolCrmId = F0EDC50F-ED22-DE11-B821-0014221C4264;  // string | ID (CRM) of school
            var startDate = DateTime.Parse("2013-10-20");  // DateTime | Start date
            var endDate = DateTime.Parse("2013-10-20");  // DateTime | End date

            try
            {
                // Gets school day schedules
                List<ScheduleDto> result = apiInstance.ApiV1SchoolsSchoolCrmIdSchedulesGet(schoolCrmId, startDate, endDate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SchedulesApi.ApiV1SchoolsSchoolCrmIdSchedulesGet: " + e.Message );
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
 **startDate** | **DateTime**| Start date | 
 **endDate** | **DateTime**| End date | 

### Return type

[**List&lt;ScheduleDto&gt;**](ScheduleDto.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns day schedules |  -  |
| **404** | School ID not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

