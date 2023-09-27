# FranchiseePortal.ToursWebApiClient.Api.SchoolTourAvailabilityApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiV1SchoolTourAvailabilityDefaultAvailabilitySchoolIdGet**](SchoolTourAvailabilityApi.md#apiv1schooltouravailabilitydefaultavailabilityschoolidget) | **GET** /api/v1/SchoolTourAvailability/default-availability/{schoolId} | 
[**ApiV1SchoolTourAvailabilityDeleteBatchDelete**](SchoolTourAvailabilityApi.md#apiv1schooltouravailabilitydeletebatchdelete) | **DELETE** /api/v1/SchoolTourAvailability/delete-batch | 
[**ApiV1SchoolTourAvailabilityIdDelete**](SchoolTourAvailabilityApi.md#apiv1schooltouravailabilityiddelete) | **DELETE** /api/v1/SchoolTourAvailability/{id} | 
[**ApiV1SchoolTourAvailabilityIdPut**](SchoolTourAvailabilityApi.md#apiv1schooltouravailabilityidput) | **PUT** /api/v1/SchoolTourAvailability/{id} | 
[**ApiV1SchoolTourAvailabilityIncludeBatchPost**](SchoolTourAvailabilityApi.md#apiv1schooltouravailabilityincludebatchpost) | **POST** /api/v1/SchoolTourAvailability/include-batch | 
[**ApiV1SchoolTourAvailabilityIncludeSinglePost**](SchoolTourAvailabilityApi.md#apiv1schooltouravailabilityincludesinglepost) | **POST** /api/v1/SchoolTourAvailability/include-single | 
[**ApiV1SchoolTourAvailabilitySchoolIdGet**](SchoolTourAvailabilityApi.md#apiv1schooltouravailabilityschoolidget) | **GET** /api/v1/SchoolTourAvailability/{schoolId} | 
[**ApiV1SchoolTourAvailabilityUpdateBatchPut**](SchoolTourAvailabilityApi.md#apiv1schooltouravailabilityupdatebatchput) | **PUT** /api/v1/SchoolTourAvailability/update-batch | 


<a name="apiv1schooltouravailabilitydefaultavailabilityschoolidget"></a>
# **ApiV1SchoolTourAvailabilityDefaultAvailabilitySchoolIdGet**
> List&lt;SchoolTourAvailabilityDto&gt; ApiV1SchoolTourAvailabilityDefaultAvailabilitySchoolIdGet (string schoolId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FranchiseePortal.ToursWebApiClient.Api;
using FranchiseePortal.ToursWebApiClient.Client;
using FranchiseePortal.ToursWebApiClient.Model;

namespace Example
{
    public class ApiV1SchoolTourAvailabilityDefaultAvailabilitySchoolIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new SchoolTourAvailabilityApi(config);
            var schoolId = "schoolId_example";  // string | 

            try
            {
                List<SchoolTourAvailabilityDto> result = apiInstance.ApiV1SchoolTourAvailabilityDefaultAvailabilitySchoolIdGet(schoolId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SchoolTourAvailabilityApi.ApiV1SchoolTourAvailabilityDefaultAvailabilitySchoolIdGet: " + e.Message );
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
 **schoolId** | **string**|  | 

### Return type

[**List&lt;SchoolTourAvailabilityDto&gt;**](SchoolTourAvailabilityDto.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **404** | Not Found |  -  |
| **400** | Bad Request |  -  |
| **500** | Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv1schooltouravailabilitydeletebatchdelete"></a>
# **ApiV1SchoolTourAvailabilityDeleteBatchDelete**
> void ApiV1SchoolTourAvailabilityDeleteBatchDelete (List<SchoolTourAvailabilityDto> schoolTourAvailabilityDto = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FranchiseePortal.ToursWebApiClient.Api;
using FranchiseePortal.ToursWebApiClient.Client;
using FranchiseePortal.ToursWebApiClient.Model;

namespace Example
{
    public class ApiV1SchoolTourAvailabilityDeleteBatchDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new SchoolTourAvailabilityApi(config);
            var schoolTourAvailabilityDto = new List<SchoolTourAvailabilityDto>(); // List<SchoolTourAvailabilityDto> |  (optional) 

            try
            {
                apiInstance.ApiV1SchoolTourAvailabilityDeleteBatchDelete(schoolTourAvailabilityDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SchoolTourAvailabilityApi.ApiV1SchoolTourAvailabilityDeleteBatchDelete: " + e.Message );
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
 **schoolTourAvailabilityDto** | [**List&lt;SchoolTourAvailabilityDto&gt;**](SchoolTourAvailabilityDto.md)|  | [optional] 

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
| **200** | Success |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv1schooltouravailabilityiddelete"></a>
# **ApiV1SchoolTourAvailabilityIdDelete**
> void ApiV1SchoolTourAvailabilityIdDelete (string id)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FranchiseePortal.ToursWebApiClient.Api;
using FranchiseePortal.ToursWebApiClient.Client;
using FranchiseePortal.ToursWebApiClient.Model;

namespace Example
{
    public class ApiV1SchoolTourAvailabilityIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new SchoolTourAvailabilityApi(config);
            var id = "id_example";  // string | 

            try
            {
                apiInstance.ApiV1SchoolTourAvailabilityIdDelete(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SchoolTourAvailabilityApi.ApiV1SchoolTourAvailabilityIdDelete: " + e.Message );
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
 **id** | **string**|  | 

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
| **200** | Success |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv1schooltouravailabilityidput"></a>
# **ApiV1SchoolTourAvailabilityIdPut**
> void ApiV1SchoolTourAvailabilityIdPut (string id, SchoolTourAvailabilityDto schoolTourAvailabilityDto = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FranchiseePortal.ToursWebApiClient.Api;
using FranchiseePortal.ToursWebApiClient.Client;
using FranchiseePortal.ToursWebApiClient.Model;

namespace Example
{
    public class ApiV1SchoolTourAvailabilityIdPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new SchoolTourAvailabilityApi(config);
            var id = "id_example";  // string | 
            var schoolTourAvailabilityDto = new SchoolTourAvailabilityDto(); // SchoolTourAvailabilityDto |  (optional) 

            try
            {
                apiInstance.ApiV1SchoolTourAvailabilityIdPut(id, schoolTourAvailabilityDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SchoolTourAvailabilityApi.ApiV1SchoolTourAvailabilityIdPut: " + e.Message );
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
 **id** | **string**|  | 
 **schoolTourAvailabilityDto** | [**SchoolTourAvailabilityDto**](SchoolTourAvailabilityDto.md)|  | [optional] 

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
| **200** | Success |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv1schooltouravailabilityincludebatchpost"></a>
# **ApiV1SchoolTourAvailabilityIncludeBatchPost**
> void ApiV1SchoolTourAvailabilityIncludeBatchPost (List<SchoolTourAvailabilityDto> schoolTourAvailabilityDto = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FranchiseePortal.ToursWebApiClient.Api;
using FranchiseePortal.ToursWebApiClient.Client;
using FranchiseePortal.ToursWebApiClient.Model;

namespace Example
{
    public class ApiV1SchoolTourAvailabilityIncludeBatchPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new SchoolTourAvailabilityApi(config);
            var schoolTourAvailabilityDto = new List<SchoolTourAvailabilityDto>(); // List<SchoolTourAvailabilityDto> |  (optional) 

            try
            {
                apiInstance.ApiV1SchoolTourAvailabilityIncludeBatchPost(schoolTourAvailabilityDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SchoolTourAvailabilityApi.ApiV1SchoolTourAvailabilityIncludeBatchPost: " + e.Message );
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
 **schoolTourAvailabilityDto** | [**List&lt;SchoolTourAvailabilityDto&gt;**](SchoolTourAvailabilityDto.md)|  | [optional] 

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
| **200** | Success |  -  |
| **400** | Bad Request |  -  |
| **500** | Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv1schooltouravailabilityincludesinglepost"></a>
# **ApiV1SchoolTourAvailabilityIncludeSinglePost**
> void ApiV1SchoolTourAvailabilityIncludeSinglePost (SchoolTourAvailabilityDto schoolTourAvailabilityDto = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FranchiseePortal.ToursWebApiClient.Api;
using FranchiseePortal.ToursWebApiClient.Client;
using FranchiseePortal.ToursWebApiClient.Model;

namespace Example
{
    public class ApiV1SchoolTourAvailabilityIncludeSinglePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new SchoolTourAvailabilityApi(config);
            var schoolTourAvailabilityDto = new SchoolTourAvailabilityDto(); // SchoolTourAvailabilityDto |  (optional) 

            try
            {
                apiInstance.ApiV1SchoolTourAvailabilityIncludeSinglePost(schoolTourAvailabilityDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SchoolTourAvailabilityApi.ApiV1SchoolTourAvailabilityIncludeSinglePost: " + e.Message );
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
 **schoolTourAvailabilityDto** | [**SchoolTourAvailabilityDto**](SchoolTourAvailabilityDto.md)|  | [optional] 

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
| **204** | No Content |  -  |
| **400** | Bad Request |  -  |
| **500** | Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv1schooltouravailabilityschoolidget"></a>
# **ApiV1SchoolTourAvailabilitySchoolIdGet**
> List&lt;SchoolTourAvailabilityDto&gt; ApiV1SchoolTourAvailabilitySchoolIdGet (string schoolId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FranchiseePortal.ToursWebApiClient.Api;
using FranchiseePortal.ToursWebApiClient.Client;
using FranchiseePortal.ToursWebApiClient.Model;

namespace Example
{
    public class ApiV1SchoolTourAvailabilitySchoolIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new SchoolTourAvailabilityApi(config);
            var schoolId = "schoolId_example";  // string | 

            try
            {
                List<SchoolTourAvailabilityDto> result = apiInstance.ApiV1SchoolTourAvailabilitySchoolIdGet(schoolId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SchoolTourAvailabilityApi.ApiV1SchoolTourAvailabilitySchoolIdGet: " + e.Message );
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
 **schoolId** | **string**|  | 

### Return type

[**List&lt;SchoolTourAvailabilityDto&gt;**](SchoolTourAvailabilityDto.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **404** | Not Found |  -  |
| **400** | Bad Request |  -  |
| **500** | Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv1schooltouravailabilityupdatebatchput"></a>
# **ApiV1SchoolTourAvailabilityUpdateBatchPut**
> void ApiV1SchoolTourAvailabilityUpdateBatchPut (List<SchoolTourAvailabilityDto> schoolTourAvailabilityDto = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FranchiseePortal.ToursWebApiClient.Api;
using FranchiseePortal.ToursWebApiClient.Client;
using FranchiseePortal.ToursWebApiClient.Model;

namespace Example
{
    public class ApiV1SchoolTourAvailabilityUpdateBatchPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new SchoolTourAvailabilityApi(config);
            var schoolTourAvailabilityDto = new List<SchoolTourAvailabilityDto>(); // List<SchoolTourAvailabilityDto> |  (optional) 

            try
            {
                apiInstance.ApiV1SchoolTourAvailabilityUpdateBatchPut(schoolTourAvailabilityDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SchoolTourAvailabilityApi.ApiV1SchoolTourAvailabilityUpdateBatchPut: " + e.Message );
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
 **schoolTourAvailabilityDto** | [**List&lt;SchoolTourAvailabilityDto&gt;**](SchoolTourAvailabilityDto.md)|  | [optional] 

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
| **200** | Success |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

