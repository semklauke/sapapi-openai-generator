# Org.OpenAPITools.Api.ServiceOperationsApi

All URIs are relative to *https://:/sap/opu/odata/sap/API_SALES_ORDER_SRV*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**RejectApprovalRequestPost**](ServiceOperationsApi.md#rejectapprovalrequestpost) | **POST** /rejectApprovalRequest | Invoke action rejectApprovalRequest |
| [**ReleaseApprovalRequestPost**](ServiceOperationsApi.md#releaseapprovalrequestpost) | **POST** /releaseApprovalRequest | Invoke action releaseApprovalRequest |

<a id="rejectapprovalrequestpost"></a>
# **RejectApprovalRequestPost**
> FunctionResult RejectApprovalRequestPost (string salesOrder)

Invoke action rejectApprovalRequest

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class RejectApprovalRequestPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://:/sap/opu/odata/sap/API_SALES_ORDER_SRV";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";
            // Configure OAuth2 access token for authorization: OAuth2Auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ServiceOperationsApi(config);
            var salesOrder = "salesOrder_example";  // string | Value needs to be enclosed in single quotes

            try
            {
                // Invoke action rejectApprovalRequest
                FunctionResult result = apiInstance.RejectApprovalRequestPost(salesOrder);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ServiceOperationsApi.RejectApprovalRequestPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RejectApprovalRequestPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Invoke action rejectApprovalRequest
    ApiResponse<FunctionResult> response = apiInstance.RejectApprovalRequestPostWithHttpInfo(salesOrder);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ServiceOperationsApi.RejectApprovalRequestPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **salesOrder** | **string** | Value needs to be enclosed in single quotes |  |

### Return type

[**FunctionResult**](FunctionResult.md)

### Authorization

[BasicAuth](../README.md#BasicAuth), [OAuth2Auth](../README.md#OAuth2Auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **4XX** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="releaseapprovalrequestpost"></a>
# **ReleaseApprovalRequestPost**
> FunctionResult1 ReleaseApprovalRequestPost (string salesOrder)

Invoke action releaseApprovalRequest

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReleaseApprovalRequestPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://:/sap/opu/odata/sap/API_SALES_ORDER_SRV";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";
            // Configure OAuth2 access token for authorization: OAuth2Auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ServiceOperationsApi(config);
            var salesOrder = "salesOrder_example";  // string | Value needs to be enclosed in single quotes

            try
            {
                // Invoke action releaseApprovalRequest
                FunctionResult1 result = apiInstance.ReleaseApprovalRequestPost(salesOrder);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ServiceOperationsApi.ReleaseApprovalRequestPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReleaseApprovalRequestPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Invoke action releaseApprovalRequest
    ApiResponse<FunctionResult1> response = apiInstance.ReleaseApprovalRequestPostWithHttpInfo(salesOrder);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ServiceOperationsApi.ReleaseApprovalRequestPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **salesOrder** | **string** | Value needs to be enclosed in single quotes |  |

### Return type

[**FunctionResult1**](FunctionResult1.md)

### Authorization

[BasicAuth](../README.md#BasicAuth), [OAuth2Auth](../README.md#OAuth2Auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **4XX** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

