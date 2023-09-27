# FranchiseePortal.ToursWebApiClient.Api.SettingsApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiV1SchoolsSchoolCrmIdSettingsDelete**](SettingsApi.md#apiv1schoolsschoolcrmidsettingsdelete) | **DELETE** /api/v1/schools/{schoolCrmId}/settings | Deletes school customized tour settings
[**ApiV1SchoolsSchoolCrmIdSettingsGet**](SettingsApi.md#apiv1schoolsschoolcrmidsettingsget) | **GET** /api/v1/schools/{schoolCrmId}/settings | Gets school tour settings
[**ApiV1SchoolsSchoolCrmIdSettingsPut**](SettingsApi.md#apiv1schoolsschoolcrmidsettingsput) | **PUT** /api/v1/schools/{schoolCrmId}/settings | Saves school tour settings


<a name="apiv1schoolsschoolcrmidsettingsdelete"></a>
# **ApiV1SchoolsSchoolCrmIdSettingsDelete**
> void ApiV1SchoolsSchoolCrmIdSettingsDelete (string schoolCrmId)

Deletes school customized tour settings

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FranchiseePortal.ToursWebApiClient.Api;
using FranchiseePortal.ToursWebApiClient.Client;
using FranchiseePortal.ToursWebApiClient.Model;

namespace Example
{
    public class ApiV1SchoolsSchoolCrmIdSettingsDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new SettingsApi(config);
            var schoolCrmId = F0EDC50F-ED22-DE11-B821-0014221C4264;  // string | ID (CRM) of school

            try
            {
                // Deletes school customized tour settings
                apiInstance.ApiV1SchoolsSchoolCrmIdSettingsDelete(schoolCrmId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsApi.ApiV1SchoolsSchoolCrmIdSettingsDelete: " + e.Message );
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
| **200** | OK |  -  |
| **404** | School not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv1schoolsschoolcrmidsettingsget"></a>
# **ApiV1SchoolsSchoolCrmIdSettingsGet**
> TourSettingsDto ApiV1SchoolsSchoolCrmIdSettingsGet (string schoolCrmId)

Gets school tour settings

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FranchiseePortal.ToursWebApiClient.Api;
using FranchiseePortal.ToursWebApiClient.Client;
using FranchiseePortal.ToursWebApiClient.Model;

namespace Example
{
    public class ApiV1SchoolsSchoolCrmIdSettingsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new SettingsApi(config);
            var schoolCrmId = F0EDC50F-ED22-DE11-B821-0014221C4264;  // string | ID (CRM) of school

            try
            {
                // Gets school tour settings
                TourSettingsDto result = apiInstance.ApiV1SchoolsSchoolCrmIdSettingsGet(schoolCrmId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsApi.ApiV1SchoolsSchoolCrmIdSettingsGet: " + e.Message );
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

[**TourSettingsDto**](TourSettingsDto.md)

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

<a name="apiv1schoolsschoolcrmidsettingsput"></a>
# **ApiV1SchoolsSchoolCrmIdSettingsPut**
> void ApiV1SchoolsSchoolCrmIdSettingsPut (string schoolCrmId, TourSettingsInputDto tourSettingsInputDto = null)

Saves school tour settings

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FranchiseePortal.ToursWebApiClient.Api;
using FranchiseePortal.ToursWebApiClient.Client;
using FranchiseePortal.ToursWebApiClient.Model;

namespace Example
{
    public class ApiV1SchoolsSchoolCrmIdSettingsPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new SettingsApi(config);
            var schoolCrmId = F0EDC50F-ED22-DE11-B821-0014221C4264;  // string | ID (CRM) of school
            var tourSettingsInputDto = new TourSettingsInputDto(); // TourSettingsInputDto |  (optional) 

            try
            {
                // Saves school tour settings
                apiInstance.ApiV1SchoolsSchoolCrmIdSettingsPut(schoolCrmId, tourSettingsInputDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsApi.ApiV1SchoolsSchoolCrmIdSettingsPut: " + e.Message );
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
 **tourSettingsInputDto** | [**TourSettingsInputDto**](TourSettingsInputDto.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns school tour settings |  -  |
| **400** | Request is invalid |  -  |
| **404** | School not found |  -  |
| **422** | Request conflicts with business requirements |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

