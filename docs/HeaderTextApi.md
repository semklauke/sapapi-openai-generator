# Org.OpenAPITools.Api.HeaderTextApi

All URIs are relative to *https://:/sap/opu/odata/sap/API_SALES_ORDER_SRV*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ASalesOrderSalesOrderToTextGet**](HeaderTextApi.md#asalesordersalesordertotextget) | **GET** /A_SalesOrder(&#39;{SalesOrder}&#39;)/to_Text | Reads the header texts of a sales order. |
| [**ASalesOrderSalesOrderToTextPost**](HeaderTextApi.md#asalesordersalesordertotextpost) | **POST** /A_SalesOrder(&#39;{SalesOrder}&#39;)/to_Text | Creates a header text for a sales order. |
| [**ASalesOrderTextGet**](HeaderTextApi.md#asalesordertextget) | **GET** /A_SalesOrderText | Reads the header texts of all sales orders. |
| [**ASalesOrderTextPost**](HeaderTextApi.md#asalesordertextpost) | **POST** /A_SalesOrderText | Creates a header text for a sales order. |
| [**ASalesOrderTextSalesOrderSalesOrderLanguageLanguageLongTextIDLongTextIDDelete**](HeaderTextApi.md#asalesordertextsalesordersalesorderlanguagelanguagelongtextidlongtextiddelete) | **DELETE** /A_SalesOrderText(SalesOrder&#x3D;&#39;{SalesOrder}&#39;,Language&#x3D;&#39;{Language}&#39;,LongTextID&#x3D;&#39;{LongTextID}&#39;) | Deletes a header text from a sales order. |
| [**ASalesOrderTextSalesOrderSalesOrderLanguageLanguageLongTextIDLongTextIDGet**](HeaderTextApi.md#asalesordertextsalesordersalesorderlanguagelanguagelongtextidlongtextidget) | **GET** /A_SalesOrderText(SalesOrder&#x3D;&#39;{SalesOrder}&#39;,Language&#x3D;&#39;{Language}&#39;,LongTextID&#x3D;&#39;{LongTextID}&#39;) | Reads a header text from a sales order. |
| [**ASalesOrderTextSalesOrderSalesOrderLanguageLanguageLongTextIDLongTextIDPatch**](HeaderTextApi.md#asalesordertextsalesordersalesorderlanguagelanguagelongtextidlongtextidpatch) | **PATCH** /A_SalesOrderText(SalesOrder&#x3D;&#39;{SalesOrder}&#39;,Language&#x3D;&#39;{Language}&#39;,LongTextID&#x3D;&#39;{LongTextID}&#39;) | Updates a header text for a sales order. |
| [**ASalesOrderTextSalesOrderSalesOrderLanguageLanguageLongTextIDLongTextIDToSalesOrderGet**](HeaderTextApi.md#asalesordertextsalesordersalesorderlanguagelanguagelongtextidlongtextidtosalesorderget) | **GET** /A_SalesOrderText(SalesOrder&#x3D;&#39;{SalesOrder}&#39;,Language&#x3D;&#39;{Language}&#39;,LongTextID&#x3D;&#39;{LongTextID}&#39;)/to_SalesOrder | Reads the sales order header for a header text. |

<a id="asalesordersalesordertotextget"></a>
# **ASalesOrderSalesOrderToTextGet**
> Wrapper8 ASalesOrderSalesOrderToTextGet (string salesOrder, int? top = null, int? skip = null, string? filter = null, string? inlinecount = null, List<string>? orderby = null, List<string>? select = null, List<string>? expand = null)

Reads the header texts of a sales order.

Reads the text data from the header of a specific sales order. Consumers must pass the sales order ID (key field).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ASalesOrderSalesOrderToTextGetExample
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

            var apiInstance = new HeaderTextApi(config);
            var salesOrder = "salesOrder_example";  // string | Sales Order
            var top = 50;  // int? | Show only the first n items, see [Paging - Top](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=66) (optional) 
            var skip = 56;  // int? | Skip the first n items, see [Paging - Skip](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=65) (optional) 
            var filter = "filter_example";  // string? | Filter items by property values, see [Filtering](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=64) (optional) 
            var inlinecount = "allpages";  // string? | Include count of items, see [Inlinecount](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=67) (optional) 
            var orderby = new List<string>?(); // List<string>? | Order items by property values, see [Sorting](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=65) (optional) 
            var select = new List<string>?(); // List<string>? | Select properties to be returned, see [Select](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=68) (optional) 
            var expand = new List<string>?(); // List<string>? | Expand related entities, see [Expand](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=63) (optional) 

            try
            {
                // Reads the header texts of a sales order.
                Wrapper8 result = apiInstance.ASalesOrderSalesOrderToTextGet(salesOrder, top, skip, filter, inlinecount, orderby, select, expand);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HeaderTextApi.ASalesOrderSalesOrderToTextGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ASalesOrderSalesOrderToTextGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Reads the header texts of a sales order.
    ApiResponse<Wrapper8> response = apiInstance.ASalesOrderSalesOrderToTextGetWithHttpInfo(salesOrder, top, skip, filter, inlinecount, orderby, select, expand);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling HeaderTextApi.ASalesOrderSalesOrderToTextGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **salesOrder** | **string** | Sales Order |  |
| **top** | **int?** | Show only the first n items, see [Paging - Top](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page&#x3D;66) | [optional]  |
| **skip** | **int?** | Skip the first n items, see [Paging - Skip](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page&#x3D;65) | [optional]  |
| **filter** | **string?** | Filter items by property values, see [Filtering](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page&#x3D;64) | [optional]  |
| **inlinecount** | **string?** | Include count of items, see [Inlinecount](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page&#x3D;67) | [optional]  |
| **orderby** | [**List&lt;string&gt;?**](string.md) | Order items by property values, see [Sorting](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page&#x3D;65) | [optional]  |
| **select** | [**List&lt;string&gt;?**](string.md) | Select properties to be returned, see [Select](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page&#x3D;68) | [optional]  |
| **expand** | [**List&lt;string&gt;?**](string.md) | Expand related entities, see [Expand](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page&#x3D;63) | [optional]  |

### Return type

[**Wrapper8**](Wrapper8.md)

### Authorization

[BasicAuth](../README.md#BasicAuth), [OAuth2Auth](../README.md#OAuth2Auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Retrieved entities |  -  |
| **4XX** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="asalesordersalesordertotextpost"></a>
# **ASalesOrderSalesOrderToTextPost**
> ASalesOrderTextType ASalesOrderSalesOrderToTextPost (string salesOrder, APISALESORDERSRVASalesOrderTextTypeCreate aPISALESORDERSRVASalesOrderTextTypeCreate)

Creates a header text for a sales order.

Creates the text data for a specific sales order header. Consumers must pass the sales order ID (key field).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ASalesOrderSalesOrderToTextPostExample
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

            var apiInstance = new HeaderTextApi(config);
            var salesOrder = "salesOrder_example";  // string | Sales Order
            var aPISALESORDERSRVASalesOrderTextTypeCreate = new APISALESORDERSRVASalesOrderTextTypeCreate(); // APISALESORDERSRVASalesOrderTextTypeCreate | New entity

            try
            {
                // Creates a header text for a sales order.
                ASalesOrderTextType result = apiInstance.ASalesOrderSalesOrderToTextPost(salesOrder, aPISALESORDERSRVASalesOrderTextTypeCreate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HeaderTextApi.ASalesOrderSalesOrderToTextPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ASalesOrderSalesOrderToTextPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a header text for a sales order.
    ApiResponse<ASalesOrderTextType> response = apiInstance.ASalesOrderSalesOrderToTextPostWithHttpInfo(salesOrder, aPISALESORDERSRVASalesOrderTextTypeCreate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling HeaderTextApi.ASalesOrderSalesOrderToTextPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **salesOrder** | **string** | Sales Order |  |
| **aPISALESORDERSRVASalesOrderTextTypeCreate** | [**APISALESORDERSRVASalesOrderTextTypeCreate**](APISALESORDERSRVASalesOrderTextTypeCreate.md) | New entity |  |

### Return type

[**ASalesOrderTextType**](ASalesOrderTextType.md)

### Authorization

[BasicAuth](../README.md#BasicAuth), [OAuth2Auth](../README.md#OAuth2Auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created entity |  -  |
| **4XX** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="asalesordertextget"></a>
# **ASalesOrderTextGet**
> Wrapper8 ASalesOrderTextGet (int? top = null, int? skip = null, string? filter = null, string? inlinecount = null, List<string>? orderby = null, List<string>? select = null, List<string>? expand = null)

Reads the header texts of all sales orders.

Reads the text data from the headers of all sales orders in the system.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ASalesOrderTextGetExample
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

            var apiInstance = new HeaderTextApi(config);
            var top = 50;  // int? | Show only the first n items, see [Paging - Top](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=66) (optional) 
            var skip = 56;  // int? | Skip the first n items, see [Paging - Skip](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=65) (optional) 
            var filter = "filter_example";  // string? | Filter items by property values, see [Filtering](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=64) (optional) 
            var inlinecount = "allpages";  // string? | Include count of items, see [Inlinecount](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=67) (optional) 
            var orderby = new List<string>?(); // List<string>? | Order items by property values, see [Sorting](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=65) (optional) 
            var select = new List<string>?(); // List<string>? | Select properties to be returned, see [Select](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=68) (optional) 
            var expand = new List<string>?(); // List<string>? | Expand related entities, see [Expand](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=63) (optional) 

            try
            {
                // Reads the header texts of all sales orders.
                Wrapper8 result = apiInstance.ASalesOrderTextGet(top, skip, filter, inlinecount, orderby, select, expand);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HeaderTextApi.ASalesOrderTextGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ASalesOrderTextGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Reads the header texts of all sales orders.
    ApiResponse<Wrapper8> response = apiInstance.ASalesOrderTextGetWithHttpInfo(top, skip, filter, inlinecount, orderby, select, expand);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling HeaderTextApi.ASalesOrderTextGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **top** | **int?** | Show only the first n items, see [Paging - Top](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page&#x3D;66) | [optional]  |
| **skip** | **int?** | Skip the first n items, see [Paging - Skip](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page&#x3D;65) | [optional]  |
| **filter** | **string?** | Filter items by property values, see [Filtering](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page&#x3D;64) | [optional]  |
| **inlinecount** | **string?** | Include count of items, see [Inlinecount](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page&#x3D;67) | [optional]  |
| **orderby** | [**List&lt;string&gt;?**](string.md) | Order items by property values, see [Sorting](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page&#x3D;65) | [optional]  |
| **select** | [**List&lt;string&gt;?**](string.md) | Select properties to be returned, see [Select](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page&#x3D;68) | [optional]  |
| **expand** | [**List&lt;string&gt;?**](string.md) | Expand related entities, see [Expand](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page&#x3D;63) | [optional]  |

### Return type

[**Wrapper8**](Wrapper8.md)

### Authorization

[BasicAuth](../README.md#BasicAuth), [OAuth2Auth](../README.md#OAuth2Auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Retrieved entities |  -  |
| **4XX** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="asalesordertextpost"></a>
# **ASalesOrderTextPost**
> ASalesOrderTextType ASalesOrderTextPost (APISALESORDERSRVASalesOrderTextTypeCreate aPISALESORDERSRVASalesOrderTextTypeCreate)

Creates a header text for a sales order.

Creates specific text data for the header of a specific sales order. Consumers must pass the following key fields: sales order ID, language, and text ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ASalesOrderTextPostExample
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

            var apiInstance = new HeaderTextApi(config);
            var aPISALESORDERSRVASalesOrderTextTypeCreate = new APISALESORDERSRVASalesOrderTextTypeCreate(); // APISALESORDERSRVASalesOrderTextTypeCreate | New entity

            try
            {
                // Creates a header text for a sales order.
                ASalesOrderTextType result = apiInstance.ASalesOrderTextPost(aPISALESORDERSRVASalesOrderTextTypeCreate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HeaderTextApi.ASalesOrderTextPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ASalesOrderTextPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a header text for a sales order.
    ApiResponse<ASalesOrderTextType> response = apiInstance.ASalesOrderTextPostWithHttpInfo(aPISALESORDERSRVASalesOrderTextTypeCreate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling HeaderTextApi.ASalesOrderTextPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **aPISALESORDERSRVASalesOrderTextTypeCreate** | [**APISALESORDERSRVASalesOrderTextTypeCreate**](APISALESORDERSRVASalesOrderTextTypeCreate.md) | New entity |  |

### Return type

[**ASalesOrderTextType**](ASalesOrderTextType.md)

### Authorization

[BasicAuth](../README.md#BasicAuth), [OAuth2Auth](../README.md#OAuth2Auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created entity |  -  |
| **4XX** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="asalesordertextsalesordersalesorderlanguagelanguagelongtextidlongtextiddelete"></a>
# **ASalesOrderTextSalesOrderSalesOrderLanguageLanguageLongTextIDLongTextIDDelete**
> void ASalesOrderTextSalesOrderSalesOrderLanguageLanguageLongTextIDLongTextIDDelete (string salesOrder, string language, string longTextID)

Deletes a header text from a sales order.

Deletes specific text data from the header of a specific sales order. Consumers must pass the following key fields: sales order ID, language, and text ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ASalesOrderTextSalesOrderSalesOrderLanguageLanguageLongTextIDLongTextIDDeleteExample
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

            var apiInstance = new HeaderTextApi(config);
            var salesOrder = "salesOrder_example";  // string | Sales Order
            var language = "language_example";  // string | Language Key
            var longTextID = "longTextID_example";  // string | Text ID

            try
            {
                // Deletes a header text from a sales order.
                apiInstance.ASalesOrderTextSalesOrderSalesOrderLanguageLanguageLongTextIDLongTextIDDelete(salesOrder, language, longTextID);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HeaderTextApi.ASalesOrderTextSalesOrderSalesOrderLanguageLanguageLongTextIDLongTextIDDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ASalesOrderTextSalesOrderSalesOrderLanguageLanguageLongTextIDLongTextIDDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deletes a header text from a sales order.
    apiInstance.ASalesOrderTextSalesOrderSalesOrderLanguageLanguageLongTextIDLongTextIDDeleteWithHttpInfo(salesOrder, language, longTextID);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling HeaderTextApi.ASalesOrderTextSalesOrderSalesOrderLanguageLanguageLongTextIDLongTextIDDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **salesOrder** | **string** | Sales Order |  |
| **language** | **string** | Language Key |  |
| **longTextID** | **string** | Text ID |  |

### Return type

void (empty response body)

### Authorization

[BasicAuth](../README.md#BasicAuth), [OAuth2Auth](../README.md#OAuth2Auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Success |  -  |
| **4XX** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="asalesordertextsalesordersalesorderlanguagelanguagelongtextidlongtextidget"></a>
# **ASalesOrderTextSalesOrderSalesOrderLanguageLanguageLongTextIDLongTextIDGet**
> ASalesOrderTextType ASalesOrderTextSalesOrderSalesOrderLanguageLanguageLongTextIDLongTextIDGet (string salesOrder, string language, string longTextID, List<string>? select = null, List<string>? expand = null)

Reads a header text from a sales order.

Reads the text data from the header of a specific sales order. Consumers must pass the following key fields: sales order ID, language, and text ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ASalesOrderTextSalesOrderSalesOrderLanguageLanguageLongTextIDLongTextIDGetExample
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

            var apiInstance = new HeaderTextApi(config);
            var salesOrder = "salesOrder_example";  // string | Sales Order
            var language = "language_example";  // string | Language Key
            var longTextID = "longTextID_example";  // string | Text ID
            var select = new List<string>?(); // List<string>? | Select properties to be returned, see [Select](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=68) (optional) 
            var expand = new List<string>?(); // List<string>? | Expand related entities, see [Expand](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=63) (optional) 

            try
            {
                // Reads a header text from a sales order.
                ASalesOrderTextType result = apiInstance.ASalesOrderTextSalesOrderSalesOrderLanguageLanguageLongTextIDLongTextIDGet(salesOrder, language, longTextID, select, expand);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HeaderTextApi.ASalesOrderTextSalesOrderSalesOrderLanguageLanguageLongTextIDLongTextIDGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ASalesOrderTextSalesOrderSalesOrderLanguageLanguageLongTextIDLongTextIDGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Reads a header text from a sales order.
    ApiResponse<ASalesOrderTextType> response = apiInstance.ASalesOrderTextSalesOrderSalesOrderLanguageLanguageLongTextIDLongTextIDGetWithHttpInfo(salesOrder, language, longTextID, select, expand);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling HeaderTextApi.ASalesOrderTextSalesOrderSalesOrderLanguageLanguageLongTextIDLongTextIDGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **salesOrder** | **string** | Sales Order |  |
| **language** | **string** | Language Key |  |
| **longTextID** | **string** | Text ID |  |
| **select** | [**List&lt;string&gt;?**](string.md) | Select properties to be returned, see [Select](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page&#x3D;68) | [optional]  |
| **expand** | [**List&lt;string&gt;?**](string.md) | Expand related entities, see [Expand](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page&#x3D;63) | [optional]  |

### Return type

[**ASalesOrderTextType**](ASalesOrderTextType.md)

### Authorization

[BasicAuth](../README.md#BasicAuth), [OAuth2Auth](../README.md#OAuth2Auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Retrieved entity |  -  |
| **4XX** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="asalesordertextsalesordersalesorderlanguagelanguagelongtextidlongtextidpatch"></a>
# **ASalesOrderTextSalesOrderSalesOrderLanguageLanguageLongTextIDLongTextIDPatch**
> void ASalesOrderTextSalesOrderSalesOrderLanguageLanguageLongTextIDLongTextIDPatch (string salesOrder, string language, string longTextID, ModifiedASalesOrderTextType modifiedASalesOrderTextType)

Updates a header text for a sales order.

Updates specific text data from the header of a specific sales order. Consumers must pass the following key fields: sales order ID, language, and text ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ASalesOrderTextSalesOrderSalesOrderLanguageLanguageLongTextIDLongTextIDPatchExample
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

            var apiInstance = new HeaderTextApi(config);
            var salesOrder = "salesOrder_example";  // string | Sales Order
            var language = "language_example";  // string | Language Key
            var longTextID = "longTextID_example";  // string | Text ID
            var modifiedASalesOrderTextType = new ModifiedASalesOrderTextType(); // ModifiedASalesOrderTextType | New property values

            try
            {
                // Updates a header text for a sales order.
                apiInstance.ASalesOrderTextSalesOrderSalesOrderLanguageLanguageLongTextIDLongTextIDPatch(salesOrder, language, longTextID, modifiedASalesOrderTextType);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HeaderTextApi.ASalesOrderTextSalesOrderSalesOrderLanguageLanguageLongTextIDLongTextIDPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ASalesOrderTextSalesOrderSalesOrderLanguageLanguageLongTextIDLongTextIDPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates a header text for a sales order.
    apiInstance.ASalesOrderTextSalesOrderSalesOrderLanguageLanguageLongTextIDLongTextIDPatchWithHttpInfo(salesOrder, language, longTextID, modifiedASalesOrderTextType);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling HeaderTextApi.ASalesOrderTextSalesOrderSalesOrderLanguageLanguageLongTextIDLongTextIDPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **salesOrder** | **string** | Sales Order |  |
| **language** | **string** | Language Key |  |
| **longTextID** | **string** | Text ID |  |
| **modifiedASalesOrderTextType** | [**ModifiedASalesOrderTextType**](ModifiedASalesOrderTextType.md) | New property values |  |

### Return type

void (empty response body)

### Authorization

[BasicAuth](../README.md#BasicAuth), [OAuth2Auth](../README.md#OAuth2Auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Success |  -  |
| **4XX** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="asalesordertextsalesordersalesorderlanguagelanguagelongtextidlongtextidtosalesorderget"></a>
# **ASalesOrderTextSalesOrderSalesOrderLanguageLanguageLongTextIDLongTextIDToSalesOrderGet**
> ASalesOrderType ASalesOrderTextSalesOrderSalesOrderLanguageLanguageLongTextIDLongTextIDToSalesOrderGet (string salesOrder, string language, string longTextID, List<string>? select = null, List<string>? expand = null)

Reads the sales order header for a header text.

Reads the sales order header data for a specific header text. Consumers must pass the following key fields: sales order ID, language, and text ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ASalesOrderTextSalesOrderSalesOrderLanguageLanguageLongTextIDLongTextIDToSalesOrderGetExample
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

            var apiInstance = new HeaderTextApi(config);
            var salesOrder = "salesOrder_example";  // string | Sales Order
            var language = "language_example";  // string | Language Key
            var longTextID = "longTextID_example";  // string | Text ID
            var select = new List<string>?(); // List<string>? | Select properties to be returned, see [Select](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=68) (optional) 
            var expand = new List<string>?(); // List<string>? | Expand related entities, see [Expand](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=63) (optional) 

            try
            {
                // Reads the sales order header for a header text.
                ASalesOrderType result = apiInstance.ASalesOrderTextSalesOrderSalesOrderLanguageLanguageLongTextIDLongTextIDToSalesOrderGet(salesOrder, language, longTextID, select, expand);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HeaderTextApi.ASalesOrderTextSalesOrderSalesOrderLanguageLanguageLongTextIDLongTextIDToSalesOrderGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ASalesOrderTextSalesOrderSalesOrderLanguageLanguageLongTextIDLongTextIDToSalesOrderGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Reads the sales order header for a header text.
    ApiResponse<ASalesOrderType> response = apiInstance.ASalesOrderTextSalesOrderSalesOrderLanguageLanguageLongTextIDLongTextIDToSalesOrderGetWithHttpInfo(salesOrder, language, longTextID, select, expand);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling HeaderTextApi.ASalesOrderTextSalesOrderSalesOrderLanguageLanguageLongTextIDLongTextIDToSalesOrderGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **salesOrder** | **string** | Sales Order |  |
| **language** | **string** | Language Key |  |
| **longTextID** | **string** | Text ID |  |
| **select** | [**List&lt;string&gt;?**](string.md) | Select properties to be returned, see [Select](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page&#x3D;68) | [optional]  |
| **expand** | [**List&lt;string&gt;?**](string.md) | Expand related entities, see [Expand](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page&#x3D;63) | [optional]  |

### Return type

[**ASalesOrderType**](ASalesOrderType.md)

### Authorization

[BasicAuth](../README.md#BasicAuth), [OAuth2Auth](../README.md#OAuth2Auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Retrieved entity |  -  |
| **4XX** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

