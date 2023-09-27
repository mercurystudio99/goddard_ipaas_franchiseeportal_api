# FranchiseePortal.ToursWebApiClient.Api.AvailabilityApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiV1SchoolsSchoolCrmIdAvailabilityDelete**](AvailabilityApi.md#apiv1schoolsschoolcrmidavailabilitydelete) | **DELETE** /api/v1/schools/{schoolCrmId}/availability | Deletes school customized regular (day of week) availability
[**ApiV1SchoolsSchoolCrmIdAvailabilityGet**](AvailabilityApi.md#apiv1schoolsschoolcrmidavailabilityget) | **GET** /api/v1/schools/{schoolCrmId}/availability | Gets school regular (day of week) availability
[**ApiV1SchoolsSchoolCrmIdAvailabilityPut**](AvailabilityApi.md#apiv1schoolsschoolcrmidavailabilityput) | **PUT** /api/v1/schools/{schoolCrmId}/availability | Saves school regular (day of week) availability


<a name="apiv1schoolsschoolcrmidavailabilitydelete"></a>
# **ApiV1SchoolsSchoolCrmIdAvailabilityDelete**
> void ApiV1SchoolsSchoolCrmIdAvailabilityDelete (string schoolCrmId)

Deletes school customized regular (day of week) availability

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FranchiseePortal.ToursWebApiClient.Api;
using FranchiseePortal.ToursWebApiClient.Client;
using FranchiseePortal.ToursWebApiClient.Model;

namespace Example
{
    public class ApiV1SchoolsSchoolCrmIdAvailabilityDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new AvailabilityApi(config);
            var schoolCrmId = F0EDC50F-ED22-DE11-B821-0014221C4264;  // string | ID (CRM) of school

            try
            {
                // Deletes school customized regular (day of week) availability
                apiInstance.ApiV1SchoolsSchoolCrmIdAvailabilityDelete(schoolCrmId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AvailabilityApi.ApiV1SchoolsSchoolCrmIdAvailabilityDelete: " + e.Message );
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

void (empty response body)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns school tour settings |  -  |
| **404** | School not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv1schoolsschoolcrmidavailabilityget"></a>
# **ApiV1SchoolsSchoolCrmIdAvailabilityGet**
> AvailabilityDto ApiV1SchoolsSchoolCrmIdAvailabilityGet (string schoolCrmId)

Gets school regular (day of week) availability

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FranchiseePortal.ToursWebApiClient.Api;
using FranchiseePortal.ToursWebApiClient.Client;
using FranchiseePortal.ToursWebApiClient.Model;

namespace Example
{
    public class ApiV1SchoolsSchoolCrmIdAvailabilityGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new AvailabilityApi(config);
            var schoolCrmId = F0EDC50F-ED22-DE11-B821-0014221C4264;  // string | ID (CRM) of school

            try
            {
                // Gets school regular (day of week) availability
                AvailabilityDto result = apiInstance.ApiV1SchoolsSchoolCrmIdAvailabilityGet(schoolCrmId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AvailabilityApi.ApiV1SchoolsSchoolCrmIdAvailabilityGet: " + e.Message );
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

[**AvailabilityDto**](AvailabilityDto.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns school regular availability |  -  |
| **404** | School not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv1schoolsschoolcrmidavailabilityput"></a>
# **ApiV1SchoolsSchoolCrmIdAvailabilityPut**
> AvailabilityDto ApiV1SchoolsSchoolCrmIdAvailabilityPut (string schoolCrmId, AvailabilityInputDto availabilityInputDto = null)

Saves school regular (day of week) availability

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FranchiseePortal.ToursWebApiClient.Api;
using FranchiseePortal.ToursWebApiClient.Client;
using FranchiseePortal.ToursWebApiClient.Model;

namespace Example
{
    public class ApiV1SchoolsSchoolCrmIdAvailabilityPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new AvailabilityApi(config);
            var schoolCrmId = F0EDC50F-ED22-DE11-B821-0014221C4264;  // string | ID (CRM) of school
            var availabilityInputDto = new AvailabilityInputDto(); // AvailabilityInputDto | input (optional) 

            try
            {
                // Saves school regular (day of week) availability
                AvailabilityDto result = apiInstance.ApiV1SchoolsSchoolCrmIdAvailabilityPut(schoolCrmId, availabilityInputDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AvailabilityApi.ApiV1SchoolsSchoolCrmIdAvailabilityPut: " + e.Message );
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
 **availabilityInputDto** | [**AvailabilityInputDto**](AvailabilityInputDto.md)| input | [optional] 

### Return type

[**AvailabilityDto**](AvailabilityDto.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns saved school regular availability |  -  |
| **400** | Request is invalid |  -  |
| **404** | School not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

