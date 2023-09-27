# FranchiseePortal.ToursWebApiClient.Api.DefaultAvailabilityApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiV1DefaultAvailabilityTourDurationGet**](DefaultAvailabilityApi.md#apiv1defaultavailabilitytourdurationget) | **GET** /api/v1/default-availability/{tourDuration} | Gets default availability for specified tourDuration


<a name="apiv1defaultavailabilitytourdurationget"></a>
# **ApiV1DefaultAvailabilityTourDurationGet**
> AvailabilityDto ApiV1DefaultAvailabilityTourDurationGet (int tourDuration)

Gets default availability for specified tourDuration

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FranchiseePortal.ToursWebApiClient.Api;
using FranchiseePortal.ToursWebApiClient.Client;
using FranchiseePortal.ToursWebApiClient.Model;

namespace Example
{
    public class ApiV1DefaultAvailabilityTourDurationGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new DefaultAvailabilityApi(config);
            var tourDuration = 30;  // int | Default tour duration (30 or 60)

            try
            {
                // Gets default availability for specified tourDuration
                AvailabilityDto result = apiInstance.ApiV1DefaultAvailabilityTourDurationGet(tourDuration);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultAvailabilityApi.ApiV1DefaultAvailabilityTourDurationGet: " + e.Message );
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
 **tourDuration** | **int**| Default tour duration (30 or 60) | 

### Return type

[**AvailabilityDto**](AvailabilityDto.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

