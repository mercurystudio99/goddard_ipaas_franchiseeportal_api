# FranchiseePortal.ToursWebApiClient.Api.ToursApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiV1SchoolsSchoolCrmIdToursGet**](ToursApi.md#apiv1schoolsschoolcrmidtoursget) | **GET** /api/v1/schools/{schoolCrmId}/tours | Gets school tours
[**ApiV1SchoolsSchoolCrmIdToursIdGet**](ToursApi.md#apiv1schoolsschoolcrmidtoursidget) | **GET** /api/v1/schools/{schoolCrmId}/tours/{id} | Gets school tour
[**ApiV1SchoolsSchoolCrmIdToursIdPut**](ToursApi.md#apiv1schoolsschoolcrmidtoursidput) | **PUT** /api/v1/schools/{schoolCrmId}/tours/{id} | Saves school tour
[**ApiV1SchoolsSchoolCrmIdToursPost**](ToursApi.md#apiv1schoolsschoolcrmidtourspost) | **POST** /api/v1/schools/{schoolCrmId}/tours | Creates school tour


<a name="apiv1schoolsschoolcrmidtoursget"></a>
# **ApiV1SchoolsSchoolCrmIdToursGet**
> TourDtoPaginationDto ApiV1SchoolsSchoolCrmIdToursGet (string schoolCrmId, List<TourStatus> statuses = null, DateTime? startDateTime = null, DateTime? endDateTime = null, List<TourType> types = null, List<string> guideIds = null, List<string> leadIds = null, string leadName = null, DateTime? leadMaximumPreferredStartDate = null, DateTime? leadMinimumPreferredStartDate = null, List<string> leadProgramsOfInterest = null, TourSort? sort = null, ListSortDirection? sortDirection = null, int? page = null, int? pageSize = null)

Gets school tours

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FranchiseePortal.ToursWebApiClient.Api;
using FranchiseePortal.ToursWebApiClient.Client;
using FranchiseePortal.ToursWebApiClient.Model;

namespace Example
{
    public class ApiV1SchoolsSchoolCrmIdToursGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new ToursApi(config);
            var schoolCrmId = F0EDC50F-ED22-DE11-B821-0014221C4264;  // string | ID (CRM) of school
            var statuses = new List<TourStatus>(); // List<TourStatus> |  (optional) 
            var startDateTime = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Gets or sets optional start UTC date and time query filter (optional) 
            var endDateTime = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Gets or sets optional end UTC date and time query filter (optional) 
            var types = new List<TourType>(); // List<TourType> |  (optional) 
            var guideIds = new List<string>(); // List<string> |  (optional) 
            var leadIds = new List<string>(); // List<string> |  (optional) 
            var leadName = "leadName_example";  // string | Name to filter by (optional) 
            var leadMaximumPreferredStartDate = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Maximum preferred start date (optional) 
            var leadMinimumPreferredStartDate = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Minimum preferred start date (optional) 
            var leadProgramsOfInterest = new List<string>(); // List<string> | Programs of interest (optional) 
            var sort = (TourSort) "Default";  // TourSort? |  (optional) 
            var sortDirection = (ListSortDirection) "Ascending";  // ListSortDirection? |  (optional) 
            var page = 56;  // int? |  (optional) 
            var pageSize = 56;  // int? |  (optional) 

            try
            {
                // Gets school tours
                TourDtoPaginationDto result = apiInstance.ApiV1SchoolsSchoolCrmIdToursGet(schoolCrmId, statuses, startDateTime, endDateTime, types, guideIds, leadIds, leadName, leadMaximumPreferredStartDate, leadMinimumPreferredStartDate, leadProgramsOfInterest, sort, sortDirection, page, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ToursApi.ApiV1SchoolsSchoolCrmIdToursGet: " + e.Message );
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
 **statuses** | [**List&lt;TourStatus&gt;**](TourStatus.md)|  | [optional] 
 **startDateTime** | **DateTime?**| Gets or sets optional start UTC date and time query filter | [optional] 
 **endDateTime** | **DateTime?**| Gets or sets optional end UTC date and time query filter | [optional] 
 **types** | [**List&lt;TourType&gt;**](TourType.md)|  | [optional] 
 **guideIds** | [**List&lt;string&gt;**](string.md)|  | [optional] 
 **leadIds** | [**List&lt;string&gt;**](string.md)|  | [optional] 
 **leadName** | **string**| Name to filter by | [optional] 
 **leadMaximumPreferredStartDate** | **DateTime?**| Maximum preferred start date | [optional] 
 **leadMinimumPreferredStartDate** | **DateTime?**| Minimum preferred start date | [optional] 
 **leadProgramsOfInterest** | [**List&lt;string&gt;**](string.md)| Programs of interest | [optional] 
 **sort** | **TourSort?**|  | [optional] 
 **sortDirection** | **ListSortDirection?**|  | [optional] 
 **page** | **int?**|  | [optional] 
 **pageSize** | **int?**|  | [optional] 

### Return type

[**TourDtoPaginationDto**](TourDtoPaginationDto.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns school tours |  -  |
| **404** | School not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv1schoolsschoolcrmidtoursidget"></a>
# **ApiV1SchoolsSchoolCrmIdToursIdGet**
> TourDto ApiV1SchoolsSchoolCrmIdToursIdGet (string schoolCrmId, string id)

Gets school tour

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FranchiseePortal.ToursWebApiClient.Api;
using FranchiseePortal.ToursWebApiClient.Client;
using FranchiseePortal.ToursWebApiClient.Model;

namespace Example
{
    public class ApiV1SchoolsSchoolCrmIdToursIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new ToursApi(config);
            var schoolCrmId = F0EDC50F-ED22-DE11-B821-0014221C4264;  // string | ID (CRM) of school
            var id = 45A6F328-55E4-409C-BB89-2E5B0B29632D;  // string | ID of tour

            try
            {
                // Gets school tour
                TourDto result = apiInstance.ApiV1SchoolsSchoolCrmIdToursIdGet(schoolCrmId, id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ToursApi.ApiV1SchoolsSchoolCrmIdToursIdGet: " + e.Message );
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
 **id** | **string**| ID of tour | 

### Return type

[**TourDto**](TourDto.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns school tours |  -  |
| **404** | Tour not found |  -  |
| **400** | schoolId is invalid |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv1schoolsschoolcrmidtoursidput"></a>
# **ApiV1SchoolsSchoolCrmIdToursIdPut**
> void ApiV1SchoolsSchoolCrmIdToursIdPut (string schoolCrmId, string id, TourInputDto tourInputDto = null)

Saves school tour

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FranchiseePortal.ToursWebApiClient.Api;
using FranchiseePortal.ToursWebApiClient.Client;
using FranchiseePortal.ToursWebApiClient.Model;

namespace Example
{
    public class ApiV1SchoolsSchoolCrmIdToursIdPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new ToursApi(config);
            var schoolCrmId = F0EDC50F-ED22-DE11-B821-0014221C4264;  // string | ID (CRM) of school
            var id = 45A6F328-55E4-409C-BB89-2E5B0B29632D;  // string | ID of tour
            var tourInputDto = new TourInputDto(); // TourInputDto |  (optional) 

            try
            {
                // Saves school tour
                apiInstance.ApiV1SchoolsSchoolCrmIdToursIdPut(schoolCrmId, id, tourInputDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ToursApi.ApiV1SchoolsSchoolCrmIdToursIdPut: " + e.Message );
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
 **id** | **string**| ID of tour | 
 **tourInputDto** | [**TourInputDto**](TourInputDto.md)|  | [optional] 

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
| **200** | Returns school tours |  -  |
| **404** | School or tour not found |  -  |
| **400** | Request is invalid |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv1schoolsschoolcrmidtourspost"></a>
# **ApiV1SchoolsSchoolCrmIdToursPost**
> TourDto ApiV1SchoolsSchoolCrmIdToursPost (string schoolCrmId, TourInputDto tourInputDto = null)

Creates school tour

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FranchiseePortal.ToursWebApiClient.Api;
using FranchiseePortal.ToursWebApiClient.Client;
using FranchiseePortal.ToursWebApiClient.Model;

namespace Example
{
    public class ApiV1SchoolsSchoolCrmIdToursPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new ToursApi(config);
            var schoolCrmId = F0EDC50F-ED22-DE11-B821-0014221C4264;  // string | ID (CRM) of school
            var tourInputDto = new TourInputDto(); // TourInputDto |  (optional) 

            try
            {
                // Creates school tour
                TourDto result = apiInstance.ApiV1SchoolsSchoolCrmIdToursPost(schoolCrmId, tourInputDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ToursApi.ApiV1SchoolsSchoolCrmIdToursPost: " + e.Message );
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
 **tourInputDto** | [**TourInputDto**](TourInputDto.md)|  | [optional] 

### Return type

[**TourDto**](TourDto.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns school tours |  -  |
| **400** | Request is invalid |  -  |
| **404** | School not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

