# FranchiseePortal.ToursWebApiClient.Api.DateAvailabilitiesApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiV1SchoolsSchoolCrmIdDateAvailabilitiesDateDelete**](DateAvailabilitiesApi.md#apiv1schoolsschoolcrmiddateavailabilitiesdatedelete) | **DELETE** /api/v1/schools/{schoolCrmId}/date-availabilities/{date} | Deletes school customized date availability
[**ApiV1SchoolsSchoolCrmIdDateAvailabilitiesDateGet**](DateAvailabilitiesApi.md#apiv1schoolsschoolcrmiddateavailabilitiesdateget) | **GET** /api/v1/schools/{schoolCrmId}/date-availabilities/{date} | Gets school availability for a date
[**ApiV1SchoolsSchoolCrmIdDateAvailabilitiesDatePut**](DateAvailabilitiesApi.md#apiv1schoolsschoolcrmiddateavailabilitiesdateput) | **PUT** /api/v1/schools/{schoolCrmId}/date-availabilities/{date} | Saves school date custom availability


<a name="apiv1schoolsschoolcrmiddateavailabilitiesdatedelete"></a>
# **ApiV1SchoolsSchoolCrmIdDateAvailabilitiesDateDelete**
> void ApiV1SchoolsSchoolCrmIdDateAvailabilitiesDateDelete (string schoolCrmId, DateTime date)

Deletes school customized date availability

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FranchiseePortal.ToursWebApiClient.Api;
using FranchiseePortal.ToursWebApiClient.Client;
using FranchiseePortal.ToursWebApiClient.Model;

namespace Example
{
    public class ApiV1SchoolsSchoolCrmIdDateAvailabilitiesDateDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new DateAvailabilitiesApi(config);
            var schoolCrmId = F0EDC50F-ED22-DE11-B821-0014221C4264;  // string | ID (CRM) of school
            var date = DateTime.Parse("2013-10-20");  // DateTime | Date

            try
            {
                // Deletes school customized date availability
                apiInstance.ApiV1SchoolsSchoolCrmIdDateAvailabilitiesDateDelete(schoolCrmId, date);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DateAvailabilitiesApi.ApiV1SchoolsSchoolCrmIdDateAvailabilitiesDateDelete: " + e.Message );
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
 **date** | **DateTime**| Date | 

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

<a name="apiv1schoolsschoolcrmiddateavailabilitiesdateget"></a>
# **ApiV1SchoolsSchoolCrmIdDateAvailabilitiesDateGet**
> DateAvailabilityDto ApiV1SchoolsSchoolCrmIdDateAvailabilitiesDateGet (string schoolCrmId, DateTime date)

Gets school availability for a date

If DateAvailability record does not exist will return regular availability for day of week  of specified date

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FranchiseePortal.ToursWebApiClient.Api;
using FranchiseePortal.ToursWebApiClient.Client;
using FranchiseePortal.ToursWebApiClient.Model;

namespace Example
{
    public class ApiV1SchoolsSchoolCrmIdDateAvailabilitiesDateGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new DateAvailabilitiesApi(config);
            var schoolCrmId = F0EDC50F-ED22-DE11-B821-0014221C4264;  // string | ID (CRM) of school
            var date = DateTime.Parse("2013-10-20");  // DateTime | Date

            try
            {
                // Gets school availability for a date
                DateAvailabilityDto result = apiInstance.ApiV1SchoolsSchoolCrmIdDateAvailabilitiesDateGet(schoolCrmId, date);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DateAvailabilitiesApi.ApiV1SchoolsSchoolCrmIdDateAvailabilitiesDateGet: " + e.Message );
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
 **date** | **DateTime**| Date | 

### Return type

[**DateAvailabilityDto**](DateAvailabilityDto.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns date availability |  -  |
| **404** | School not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv1schoolsschoolcrmiddateavailabilitiesdateput"></a>
# **ApiV1SchoolsSchoolCrmIdDateAvailabilitiesDatePut**
> DateAvailabilityDto ApiV1SchoolsSchoolCrmIdDateAvailabilitiesDatePut (string schoolCrmId, DateTime date, DateAvailabilityInputDto dateAvailabilityInputDto = null)

Saves school date custom availability

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FranchiseePortal.ToursWebApiClient.Api;
using FranchiseePortal.ToursWebApiClient.Client;
using FranchiseePortal.ToursWebApiClient.Model;

namespace Example
{
    public class ApiV1SchoolsSchoolCrmIdDateAvailabilitiesDatePutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new DateAvailabilitiesApi(config);
            var schoolCrmId = F0EDC50F-ED22-DE11-B821-0014221C4264;  // string | ID (CRM) of school
            var date = DateTime.Parse("2013-10-20");  // DateTime | Date
            var dateAvailabilityInputDto = new DateAvailabilityInputDto(); // DateAvailabilityInputDto | input (optional) 

            try
            {
                // Saves school date custom availability
                DateAvailabilityDto result = apiInstance.ApiV1SchoolsSchoolCrmIdDateAvailabilitiesDatePut(schoolCrmId, date, dateAvailabilityInputDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DateAvailabilitiesApi.ApiV1SchoolsSchoolCrmIdDateAvailabilitiesDatePut: " + e.Message );
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
 **date** | **DateTime**| Date | 
 **dateAvailabilityInputDto** | [**DateAvailabilityInputDto**](DateAvailabilityInputDto.md)| input | [optional] 

### Return type

[**DateAvailabilityDto**](DateAvailabilityDto.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns date availability |  -  |
| **400** | Request is invalid |  -  |
| **404** | School not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

