# Org.OpenAPITools.Api.ItemScheduleLineApi

All URIs are relative to *https://:/sap/opu/odata/sap/API_SALES_ORDER_SRV*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ASalesOrderItemSalesOrderSalesOrderSalesOrderItemSalesOrderItemToScheduleLineGet**](ItemScheduleLineApi.md#asalesorderitemsalesordersalesordersalesorderitemsalesorderitemtoschedulelineget) | **GET** /A_SalesOrderItem(SalesOrder&#x3D;&#39;{SalesOrder}&#39;,SalesOrderItem&#x3D;&#39;{SalesOrderItem}&#39;)/to_ScheduleLine | Reads the schedule lines of a sales order item. |
| [**ASalesOrderItemSalesOrderSalesOrderSalesOrderItemSalesOrderItemToScheduleLinePost**](ItemScheduleLineApi.md#asalesorderitemsalesordersalesordersalesorderitemsalesorderitemtoschedulelinepost) | **POST** /A_SalesOrderItem(SalesOrder&#x3D;&#39;{SalesOrder}&#39;,SalesOrderItem&#x3D;&#39;{SalesOrderItem}&#39;)/to_ScheduleLine | Creates schedule lines for a sales order item. |
| [**ASalesOrderScheduleLineGet**](ItemScheduleLineApi.md#asalesorderschedulelineget) | **GET** /A_SalesOrderScheduleLine | Reads the schedule lines of all sales orders. |
| [**ASalesOrderScheduleLinePost**](ItemScheduleLineApi.md#asalesorderschedulelinepost) | **POST** /A_SalesOrderScheduleLine | Creates a schedule line. |
| [**ASalesOrderScheduleLineSalesOrderSalesOrderSalesOrderItemSalesOrderItemScheduleLineScheduleLineDelete**](ItemScheduleLineApi.md#asalesorderschedulelinesalesordersalesordersalesorderitemsalesorderitemschedulelineschedulelinedelete) | **DELETE** /A_SalesOrderScheduleLine(SalesOrder&#x3D;&#39;{SalesOrder}&#39;,SalesOrderItem&#x3D;&#39;{SalesOrderItem}&#39;,ScheduleLine&#x3D;&#39;{ScheduleLine}&#39;) | Deletes a schedule line. |
| [**ASalesOrderScheduleLineSalesOrderSalesOrderSalesOrderItemSalesOrderItemScheduleLineScheduleLineGet**](ItemScheduleLineApi.md#asalesorderschedulelinesalesordersalesordersalesorderitemsalesorderitemschedulelineschedulelineget) | **GET** /A_SalesOrderScheduleLine(SalesOrder&#x3D;&#39;{SalesOrder}&#39;,SalesOrderItem&#x3D;&#39;{SalesOrderItem}&#39;,ScheduleLine&#x3D;&#39;{ScheduleLine}&#39;) | Reads a schedule line. |
| [**ASalesOrderScheduleLineSalesOrderSalesOrderSalesOrderItemSalesOrderItemScheduleLineScheduleLinePatch**](ItemScheduleLineApi.md#asalesorderschedulelinesalesordersalesordersalesorderitemsalesorderitemschedulelineschedulelinepatch) | **PATCH** /A_SalesOrderScheduleLine(SalesOrder&#x3D;&#39;{SalesOrder}&#39;,SalesOrderItem&#x3D;&#39;{SalesOrderItem}&#39;,ScheduleLine&#x3D;&#39;{ScheduleLine}&#39;) | Updates a schedule line. |

<a id="asalesorderitemsalesordersalesordersalesorderitemsalesorderitemtoschedulelineget"></a>
# **ASalesOrderItemSalesOrderSalesOrderSalesOrderItemSalesOrderItemToScheduleLineGet**
> Wrapper16 ASalesOrderItemSalesOrderSalesOrderSalesOrderItemSalesOrderItemToScheduleLineGet (string salesOrder, string salesOrderItem, int? top = null, int? skip = null, string? filter = null, string? inlinecount = null, List<string>? orderby = null, List<string>? select = null)

Reads the schedule lines of a sales order item.

Reads the schedule line data for a specific item. Consumers must pass the following key fields: sales order ID and item number.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ASalesOrderItemSalesOrderSalesOrderSalesOrderItemSalesOrderItemToScheduleLineGetExample
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

            var apiInstance = new ItemScheduleLineApi(config);
            var salesOrder = "salesOrder_example";  // string | Sales Order
            var salesOrderItem = "salesOrderItem_example";  // string | Sales Order Item
            var top = 50;  // int? | Show only the first n items, see [Paging - Top](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=66) (optional) 
            var skip = 56;  // int? | Skip the first n items, see [Paging - Skip](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=65) (optional) 
            var filter = "filter_example";  // string? | Filter items by property values, see [Filtering](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=64) (optional) 
            var inlinecount = "allpages";  // string? | Include count of items, see [Inlinecount](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=67) (optional) 
            var orderby = new List<string>?(); // List<string>? | Order items by property values, see [Sorting](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=65) (optional) 
            var select = new List<string>?(); // List<string>? | Select properties to be returned, see [Select](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=68) (optional) 

            try
            {
                // Reads the schedule lines of a sales order item.
                Wrapper16 result = apiInstance.ASalesOrderItemSalesOrderSalesOrderSalesOrderItemSalesOrderItemToScheduleLineGet(salesOrder, salesOrderItem, top, skip, filter, inlinecount, orderby, select);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ItemScheduleLineApi.ASalesOrderItemSalesOrderSalesOrderSalesOrderItemSalesOrderItemToScheduleLineGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ASalesOrderItemSalesOrderSalesOrderSalesOrderItemSalesOrderItemToScheduleLineGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Reads the schedule lines of a sales order item.
    ApiResponse<Wrapper16> response = apiInstance.ASalesOrderItemSalesOrderSalesOrderSalesOrderItemSalesOrderItemToScheduleLineGetWithHttpInfo(salesOrder, salesOrderItem, top, skip, filter, inlinecount, orderby, select);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ItemScheduleLineApi.ASalesOrderItemSalesOrderSalesOrderSalesOrderItemSalesOrderItemToScheduleLineGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **salesOrder** | **string** | Sales Order |  |
| **salesOrderItem** | **string** | Sales Order Item |  |
| **top** | **int?** | Show only the first n items, see [Paging - Top](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page&#x3D;66) | [optional]  |
| **skip** | **int?** | Skip the first n items, see [Paging - Skip](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page&#x3D;65) | [optional]  |
| **filter** | **string?** | Filter items by property values, see [Filtering](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page&#x3D;64) | [optional]  |
| **inlinecount** | **string?** | Include count of items, see [Inlinecount](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page&#x3D;67) | [optional]  |
| **orderby** | [**List&lt;string&gt;?**](string.md) | Order items by property values, see [Sorting](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page&#x3D;65) | [optional]  |
| **select** | [**List&lt;string&gt;?**](string.md) | Select properties to be returned, see [Select](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page&#x3D;68) | [optional]  |

### Return type

[**Wrapper16**](Wrapper16.md)

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

<a id="asalesorderitemsalesordersalesordersalesorderitemsalesorderitemtoschedulelinepost"></a>
# **ASalesOrderItemSalesOrderSalesOrderSalesOrderItemSalesOrderItemToScheduleLinePost**
> ASalesOrderScheduleLineType ASalesOrderItemSalesOrderSalesOrderSalesOrderItemSalesOrderItemToScheduleLinePost (string salesOrder, string salesOrderItem, APISALESORDERSRVASalesOrderScheduleLineTypeCreate aPISALESORDERSRVASalesOrderScheduleLineTypeCreate)

Creates schedule lines for a sales order item.

Creates the schedule line data for a specific item. Consumers must pass the following key fields: sales order ID and item number.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ASalesOrderItemSalesOrderSalesOrderSalesOrderItemSalesOrderItemToScheduleLinePostExample
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

            var apiInstance = new ItemScheduleLineApi(config);
            var salesOrder = "salesOrder_example";  // string | Sales Order
            var salesOrderItem = "salesOrderItem_example";  // string | Sales Order Item
            var aPISALESORDERSRVASalesOrderScheduleLineTypeCreate = new APISALESORDERSRVASalesOrderScheduleLineTypeCreate(); // APISALESORDERSRVASalesOrderScheduleLineTypeCreate | New entity

            try
            {
                // Creates schedule lines for a sales order item.
                ASalesOrderScheduleLineType result = apiInstance.ASalesOrderItemSalesOrderSalesOrderSalesOrderItemSalesOrderItemToScheduleLinePost(salesOrder, salesOrderItem, aPISALESORDERSRVASalesOrderScheduleLineTypeCreate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ItemScheduleLineApi.ASalesOrderItemSalesOrderSalesOrderSalesOrderItemSalesOrderItemToScheduleLinePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ASalesOrderItemSalesOrderSalesOrderSalesOrderItemSalesOrderItemToScheduleLinePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates schedule lines for a sales order item.
    ApiResponse<ASalesOrderScheduleLineType> response = apiInstance.ASalesOrderItemSalesOrderSalesOrderSalesOrderItemSalesOrderItemToScheduleLinePostWithHttpInfo(salesOrder, salesOrderItem, aPISALESORDERSRVASalesOrderScheduleLineTypeCreate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ItemScheduleLineApi.ASalesOrderItemSalesOrderSalesOrderSalesOrderItemSalesOrderItemToScheduleLinePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **salesOrder** | **string** | Sales Order |  |
| **salesOrderItem** | **string** | Sales Order Item |  |
| **aPISALESORDERSRVASalesOrderScheduleLineTypeCreate** | [**APISALESORDERSRVASalesOrderScheduleLineTypeCreate**](APISALESORDERSRVASalesOrderScheduleLineTypeCreate.md) | New entity |  |

### Return type

[**ASalesOrderScheduleLineType**](ASalesOrderScheduleLineType.md)

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

<a id="asalesorderschedulelineget"></a>
# **ASalesOrderScheduleLineGet**
> Wrapper16 ASalesOrderScheduleLineGet (int? top = null, int? skip = null, string? filter = null, string? inlinecount = null, List<string>? orderby = null, List<string>? select = null)

Reads the schedule lines of all sales orders.

Reads the schedule line data from the items of all sales orders in the system.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ASalesOrderScheduleLineGetExample
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

            var apiInstance = new ItemScheduleLineApi(config);
            var top = 50;  // int? | Show only the first n items, see [Paging - Top](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=66) (optional) 
            var skip = 56;  // int? | Skip the first n items, see [Paging - Skip](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=65) (optional) 
            var filter = "filter_example";  // string? | Filter items by property values, see [Filtering](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=64) (optional) 
            var inlinecount = "allpages";  // string? | Include count of items, see [Inlinecount](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=67) (optional) 
            var orderby = new List<string>?(); // List<string>? | Order items by property values, see [Sorting](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=65) (optional) 
            var select = new List<string>?(); // List<string>? | Select properties to be returned, see [Select](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=68) (optional) 

            try
            {
                // Reads the schedule lines of all sales orders.
                Wrapper16 result = apiInstance.ASalesOrderScheduleLineGet(top, skip, filter, inlinecount, orderby, select);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ItemScheduleLineApi.ASalesOrderScheduleLineGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ASalesOrderScheduleLineGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Reads the schedule lines of all sales orders.
    ApiResponse<Wrapper16> response = apiInstance.ASalesOrderScheduleLineGetWithHttpInfo(top, skip, filter, inlinecount, orderby, select);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ItemScheduleLineApi.ASalesOrderScheduleLineGetWithHttpInfo: " + e.Message);
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

### Return type

[**Wrapper16**](Wrapper16.md)

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

<a id="asalesorderschedulelinepost"></a>
# **ASalesOrderScheduleLinePost**
> ASalesOrderScheduleLineType ASalesOrderScheduleLinePost (APISALESORDERSRVASalesOrderScheduleLineTypeCreate aPISALESORDERSRVASalesOrderScheduleLineTypeCreate)

Creates a schedule line.

Creates the schedule line data for a specific item of a specific sales order. Consumers must pass the following key fields: sales order ID, sales order item.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ASalesOrderScheduleLinePostExample
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

            var apiInstance = new ItemScheduleLineApi(config);
            var aPISALESORDERSRVASalesOrderScheduleLineTypeCreate = new APISALESORDERSRVASalesOrderScheduleLineTypeCreate(); // APISALESORDERSRVASalesOrderScheduleLineTypeCreate | New entity

            try
            {
                // Creates a schedule line.
                ASalesOrderScheduleLineType result = apiInstance.ASalesOrderScheduleLinePost(aPISALESORDERSRVASalesOrderScheduleLineTypeCreate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ItemScheduleLineApi.ASalesOrderScheduleLinePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ASalesOrderScheduleLinePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a schedule line.
    ApiResponse<ASalesOrderScheduleLineType> response = apiInstance.ASalesOrderScheduleLinePostWithHttpInfo(aPISALESORDERSRVASalesOrderScheduleLineTypeCreate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ItemScheduleLineApi.ASalesOrderScheduleLinePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **aPISALESORDERSRVASalesOrderScheduleLineTypeCreate** | [**APISALESORDERSRVASalesOrderScheduleLineTypeCreate**](APISALESORDERSRVASalesOrderScheduleLineTypeCreate.md) | New entity |  |

### Return type

[**ASalesOrderScheduleLineType**](ASalesOrderScheduleLineType.md)

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

<a id="asalesorderschedulelinesalesordersalesordersalesorderitemsalesorderitemschedulelineschedulelinedelete"></a>
# **ASalesOrderScheduleLineSalesOrderSalesOrderSalesOrderItemSalesOrderItemScheduleLineScheduleLineDelete**
> void ASalesOrderScheduleLineSalesOrderSalesOrderSalesOrderItemSalesOrderItemScheduleLineScheduleLineDelete (string salesOrder, string salesOrderItem, string scheduleLine)

Deletes a schedule line.

Deletes the schedule line data from a specific item of a specific sales order. Consumers must pass the following key fields: sales order ID, sales order item, and schedule line number.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ASalesOrderScheduleLineSalesOrderSalesOrderSalesOrderItemSalesOrderItemScheduleLineScheduleLineDeleteExample
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

            var apiInstance = new ItemScheduleLineApi(config);
            var salesOrder = "salesOrder_example";  // string | Sales Document
            var salesOrderItem = "salesOrderItem_example";  // string | Sales Document Item
            var scheduleLine = "scheduleLine_example";  // string | Schedule Line Number

            try
            {
                // Deletes a schedule line.
                apiInstance.ASalesOrderScheduleLineSalesOrderSalesOrderSalesOrderItemSalesOrderItemScheduleLineScheduleLineDelete(salesOrder, salesOrderItem, scheduleLine);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ItemScheduleLineApi.ASalesOrderScheduleLineSalesOrderSalesOrderSalesOrderItemSalesOrderItemScheduleLineScheduleLineDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ASalesOrderScheduleLineSalesOrderSalesOrderSalesOrderItemSalesOrderItemScheduleLineScheduleLineDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deletes a schedule line.
    apiInstance.ASalesOrderScheduleLineSalesOrderSalesOrderSalesOrderItemSalesOrderItemScheduleLineScheduleLineDeleteWithHttpInfo(salesOrder, salesOrderItem, scheduleLine);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ItemScheduleLineApi.ASalesOrderScheduleLineSalesOrderSalesOrderSalesOrderItemSalesOrderItemScheduleLineScheduleLineDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **salesOrder** | **string** | Sales Document |  |
| **salesOrderItem** | **string** | Sales Document Item |  |
| **scheduleLine** | **string** | Schedule Line Number |  |

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

<a id="asalesorderschedulelinesalesordersalesordersalesorderitemsalesorderitemschedulelineschedulelineget"></a>
# **ASalesOrderScheduleLineSalesOrderSalesOrderSalesOrderItemSalesOrderItemScheduleLineScheduleLineGet**
> ASalesOrderScheduleLineType ASalesOrderScheduleLineSalesOrderSalesOrderSalesOrderItemSalesOrderItemScheduleLineScheduleLineGet (string salesOrder, string salesOrderItem, string scheduleLine, List<string>? select = null)

Reads a schedule line.

Reads the schedule line data from a specific item of a specific sales order. Consumers must pass the following key fields: sales order ID, sales order item, and schedule line number.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ASalesOrderScheduleLineSalesOrderSalesOrderSalesOrderItemSalesOrderItemScheduleLineScheduleLineGetExample
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

            var apiInstance = new ItemScheduleLineApi(config);
            var salesOrder = "salesOrder_example";  // string | Sales Document
            var salesOrderItem = "salesOrderItem_example";  // string | Sales Document Item
            var scheduleLine = "scheduleLine_example";  // string | Schedule Line Number
            var select = new List<string>?(); // List<string>? | Select properties to be returned, see [Select](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=68) (optional) 

            try
            {
                // Reads a schedule line.
                ASalesOrderScheduleLineType result = apiInstance.ASalesOrderScheduleLineSalesOrderSalesOrderSalesOrderItemSalesOrderItemScheduleLineScheduleLineGet(salesOrder, salesOrderItem, scheduleLine, select);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ItemScheduleLineApi.ASalesOrderScheduleLineSalesOrderSalesOrderSalesOrderItemSalesOrderItemScheduleLineScheduleLineGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ASalesOrderScheduleLineSalesOrderSalesOrderSalesOrderItemSalesOrderItemScheduleLineScheduleLineGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Reads a schedule line.
    ApiResponse<ASalesOrderScheduleLineType> response = apiInstance.ASalesOrderScheduleLineSalesOrderSalesOrderSalesOrderItemSalesOrderItemScheduleLineScheduleLineGetWithHttpInfo(salesOrder, salesOrderItem, scheduleLine, select);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ItemScheduleLineApi.ASalesOrderScheduleLineSalesOrderSalesOrderSalesOrderItemSalesOrderItemScheduleLineScheduleLineGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **salesOrder** | **string** | Sales Document |  |
| **salesOrderItem** | **string** | Sales Document Item |  |
| **scheduleLine** | **string** | Schedule Line Number |  |
| **select** | [**List&lt;string&gt;?**](string.md) | Select properties to be returned, see [Select](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page&#x3D;68) | [optional]  |

### Return type

[**ASalesOrderScheduleLineType**](ASalesOrderScheduleLineType.md)

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

<a id="asalesorderschedulelinesalesordersalesordersalesorderitemsalesorderitemschedulelineschedulelinepatch"></a>
# **ASalesOrderScheduleLineSalesOrderSalesOrderSalesOrderItemSalesOrderItemScheduleLineScheduleLinePatch**
> void ASalesOrderScheduleLineSalesOrderSalesOrderSalesOrderItemSalesOrderItemScheduleLineScheduleLinePatch (string salesOrder, string salesOrderItem, string scheduleLine, ModifiedASalesOrderScheduleLineType modifiedASalesOrderScheduleLineType)

Updates a schedule line.

Updates the schedule line data from a specific item of a specific sales order. Consumers must pass the following key fields: sales order ID, sales order item, and schedule line number.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ASalesOrderScheduleLineSalesOrderSalesOrderSalesOrderItemSalesOrderItemScheduleLineScheduleLinePatchExample
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

            var apiInstance = new ItemScheduleLineApi(config);
            var salesOrder = "salesOrder_example";  // string | Sales Document
            var salesOrderItem = "salesOrderItem_example";  // string | Sales Document Item
            var scheduleLine = "scheduleLine_example";  // string | Schedule Line Number
            var modifiedASalesOrderScheduleLineType = new ModifiedASalesOrderScheduleLineType(); // ModifiedASalesOrderScheduleLineType | New property values

            try
            {
                // Updates a schedule line.
                apiInstance.ASalesOrderScheduleLineSalesOrderSalesOrderSalesOrderItemSalesOrderItemScheduleLineScheduleLinePatch(salesOrder, salesOrderItem, scheduleLine, modifiedASalesOrderScheduleLineType);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ItemScheduleLineApi.ASalesOrderScheduleLineSalesOrderSalesOrderSalesOrderItemSalesOrderItemScheduleLineScheduleLinePatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ASalesOrderScheduleLineSalesOrderSalesOrderSalesOrderItemSalesOrderItemScheduleLineScheduleLinePatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates a schedule line.
    apiInstance.ASalesOrderScheduleLineSalesOrderSalesOrderSalesOrderItemSalesOrderItemScheduleLineScheduleLinePatchWithHttpInfo(salesOrder, salesOrderItem, scheduleLine, modifiedASalesOrderScheduleLineType);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ItemScheduleLineApi.ASalesOrderScheduleLineSalesOrderSalesOrderSalesOrderItemSalesOrderItemScheduleLineScheduleLinePatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **salesOrder** | **string** | Sales Document |  |
| **salesOrderItem** | **string** | Sales Document Item |  |
| **scheduleLine** | **string** | Schedule Line Number |  |
| **modifiedASalesOrderScheduleLineType** | [**ModifiedASalesOrderScheduleLineType**](ModifiedASalesOrderScheduleLineType.md) | New property values |  |

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

