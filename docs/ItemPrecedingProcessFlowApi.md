# Org.OpenAPITools.Api.ItemPrecedingProcessFlowApi

All URIs are relative to *https://:/sap/opu/odata/sap/API_SALES_ORDER_SRV*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ASalesOrderItemSalesOrderSalesOrderSalesOrderItemSalesOrderItemToPrecedingProcFlowDocItemGet**](ItemPrecedingProcessFlowApi.md#asalesorderitemsalesordersalesordersalesorderitemsalesorderitemtoprecedingprocflowdocitemget) | **GET** /A_SalesOrderItem(SalesOrder&#x3D;&#39;{SalesOrder}&#39;,SalesOrderItem&#x3D;&#39;{SalesOrderItem}&#39;)/to_PrecedingProcFlowDocItem | Get entities from related to_PrecedingProcFlowDocItem |
| [**ASalesOrderItmPrecdgProcFlowGet**](ItemPrecedingProcessFlowApi.md#asalesorderitmprecdgprocflowget) | **GET** /A_SalesOrderItmPrecdgProcFlow | Reads the preceding items of all sales orders items. |
| [**ASalesOrderItmPrecdgProcFlowSalesOrderSalesOrderSalesOrderItemSalesOrderItemDocRelationshipUUIDguidDocRelationshipUUIDGet**](ItemPrecedingProcessFlowApi.md#asalesorderitmprecdgprocflowsalesordersalesordersalesorderitemsalesorderitemdocrelationshipuuidguiddocrelationshipuuidget) | **GET** /A_SalesOrderItmPrecdgProcFlow(SalesOrder&#x3D;&#39;{SalesOrder}&#39;,SalesOrderItem&#x3D;&#39;{SalesOrderItem}&#39;,DocRelationshipUUID&#x3D;guid&#39;{DocRelationshipUUID}&#39;) | Reads a preceding item for a sales order item. |
| [**ASalesOrderItmPrecdgProcFlowSalesOrderSalesOrderSalesOrderItemSalesOrderItemDocRelationshipUUIDguidDocRelationshipUUIDToSalesOrderGet**](ItemPrecedingProcessFlowApi.md#asalesorderitmprecdgprocflowsalesordersalesordersalesorderitemsalesorderitemdocrelationshipuuidguiddocrelationshipuuidtosalesorderget) | **GET** /A_SalesOrderItmPrecdgProcFlow(SalesOrder&#x3D;&#39;{SalesOrder}&#39;,SalesOrderItem&#x3D;&#39;{SalesOrderItem}&#39;,DocRelationshipUUID&#x3D;guid&#39;{DocRelationshipUUID}&#39;)/to_SalesOrder | Reads the sales order header data of a preceding item of a sales order. |
| [**ASalesOrderItmPrecdgProcFlowSalesOrderSalesOrderSalesOrderItemSalesOrderItemDocRelationshipUUIDguidDocRelationshipUUIDToSalesOrderItemGet**](ItemPrecedingProcessFlowApi.md#asalesorderitmprecdgprocflowsalesordersalesordersalesorderitemsalesorderitemdocrelationshipuuidguiddocrelationshipuuidtosalesorderitemget) | **GET** /A_SalesOrderItmPrecdgProcFlow(SalesOrder&#x3D;&#39;{SalesOrder}&#39;,SalesOrderItem&#x3D;&#39;{SalesOrderItem}&#39;,DocRelationshipUUID&#x3D;guid&#39;{DocRelationshipUUID}&#39;)/to_SalesOrderItem | Reads the sales order item data for a preceding item of a sales order. |

<a id="asalesorderitemsalesordersalesordersalesorderitemsalesorderitemtoprecedingprocflowdocitemget"></a>
# **ASalesOrderItemSalesOrderSalesOrderSalesOrderItemSalesOrderItemToPrecedingProcFlowDocItemGet**
> Wrapper13 ASalesOrderItemSalesOrderSalesOrderSalesOrderItemSalesOrderItemToPrecedingProcFlowDocItemGet (string salesOrder, string salesOrderItem, int? top = null, int? skip = null, string? filter = null, string? inlinecount = null, List<string>? orderby = null, List<string>? select = null, List<string>? expand = null)

Get entities from related to_PrecedingProcFlowDocItem

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ASalesOrderItemSalesOrderSalesOrderSalesOrderItemSalesOrderItemToPrecedingProcFlowDocItemGetExample
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

            var apiInstance = new ItemPrecedingProcessFlowApi(config);
            var salesOrder = "salesOrder_example";  // string | Sales Order
            var salesOrderItem = "salesOrderItem_example";  // string | Sales Order Item
            var top = 50;  // int? | Show only the first n items, see [Paging - Top](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=66) (optional) 
            var skip = 56;  // int? | Skip the first n items, see [Paging - Skip](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=65) (optional) 
            var filter = "filter_example";  // string? | Filter items by property values, see [Filtering](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=64) (optional) 
            var inlinecount = "allpages";  // string? | Include count of items, see [Inlinecount](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=67) (optional) 
            var orderby = new List<string>?(); // List<string>? | Order items by property values, see [Sorting](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=65) (optional) 
            var select = new List<string>?(); // List<string>? | Select properties to be returned, see [Select](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=68) (optional) 
            var expand = new List<string>?(); // List<string>? | Expand related entities, see [Expand](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=63) (optional) 

            try
            {
                // Get entities from related to_PrecedingProcFlowDocItem
                Wrapper13 result = apiInstance.ASalesOrderItemSalesOrderSalesOrderSalesOrderItemSalesOrderItemToPrecedingProcFlowDocItemGet(salesOrder, salesOrderItem, top, skip, filter, inlinecount, orderby, select, expand);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ItemPrecedingProcessFlowApi.ASalesOrderItemSalesOrderSalesOrderSalesOrderItemSalesOrderItemToPrecedingProcFlowDocItemGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ASalesOrderItemSalesOrderSalesOrderSalesOrderItemSalesOrderItemToPrecedingProcFlowDocItemGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get entities from related to_PrecedingProcFlowDocItem
    ApiResponse<Wrapper13> response = apiInstance.ASalesOrderItemSalesOrderSalesOrderSalesOrderItemSalesOrderItemToPrecedingProcFlowDocItemGetWithHttpInfo(salesOrder, salesOrderItem, top, skip, filter, inlinecount, orderby, select, expand);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ItemPrecedingProcessFlowApi.ASalesOrderItemSalesOrderSalesOrderSalesOrderItemSalesOrderItemToPrecedingProcFlowDocItemGetWithHttpInfo: " + e.Message);
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
| **expand** | [**List&lt;string&gt;?**](string.md) | Expand related entities, see [Expand](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page&#x3D;63) | [optional]  |

### Return type

[**Wrapper13**](Wrapper13.md)

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

<a id="asalesorderitmprecdgprocflowget"></a>
# **ASalesOrderItmPrecdgProcFlowGet**
> Wrapper13 ASalesOrderItmPrecdgProcFlowGet (int? top = null, int? skip = null, string? filter = null, string? inlinecount = null, List<string>? orderby = null, List<string>? select = null, List<string>? expand = null)

Reads the preceding items of all sales orders items.

Reads the process flow data for all sales order items and their preceding items in the system.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ASalesOrderItmPrecdgProcFlowGetExample
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

            var apiInstance = new ItemPrecedingProcessFlowApi(config);
            var top = 50;  // int? | Show only the first n items, see [Paging - Top](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=66) (optional) 
            var skip = 56;  // int? | Skip the first n items, see [Paging - Skip](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=65) (optional) 
            var filter = "filter_example";  // string? | Filter items by property values, see [Filtering](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=64) (optional) 
            var inlinecount = "allpages";  // string? | Include count of items, see [Inlinecount](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=67) (optional) 
            var orderby = new List<string>?(); // List<string>? | Order items by property values, see [Sorting](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=65) (optional) 
            var select = new List<string>?(); // List<string>? | Select properties to be returned, see [Select](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=68) (optional) 
            var expand = new List<string>?(); // List<string>? | Expand related entities, see [Expand](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=63) (optional) 

            try
            {
                // Reads the preceding items of all sales orders items.
                Wrapper13 result = apiInstance.ASalesOrderItmPrecdgProcFlowGet(top, skip, filter, inlinecount, orderby, select, expand);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ItemPrecedingProcessFlowApi.ASalesOrderItmPrecdgProcFlowGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ASalesOrderItmPrecdgProcFlowGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Reads the preceding items of all sales orders items.
    ApiResponse<Wrapper13> response = apiInstance.ASalesOrderItmPrecdgProcFlowGetWithHttpInfo(top, skip, filter, inlinecount, orderby, select, expand);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ItemPrecedingProcessFlowApi.ASalesOrderItmPrecdgProcFlowGetWithHttpInfo: " + e.Message);
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

[**Wrapper13**](Wrapper13.md)

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

<a id="asalesorderitmprecdgprocflowsalesordersalesordersalesorderitemsalesorderitemdocrelationshipuuidguiddocrelationshipuuidget"></a>
# **ASalesOrderItmPrecdgProcFlowSalesOrderSalesOrderSalesOrderItemSalesOrderItemDocRelationshipUUIDguidDocRelationshipUUIDGet**
> ASalesOrderItmPrecdgProcFlowType ASalesOrderItmPrecdgProcFlowSalesOrderSalesOrderSalesOrderItemSalesOrderItemDocRelationshipUUIDguidDocRelationshipUUIDGet (string salesOrder, string salesOrderItem, Guid docRelationshipUUID, List<string>? select = null, List<string>? expand = null)

Reads a preceding item for a sales order item.

Reads the process flow data of a specific preceding item of a specific sales order item. Consumers must pass the following key fields: sales order ID, sales order item ID, and document relationship UUID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ASalesOrderItmPrecdgProcFlowSalesOrderSalesOrderSalesOrderItemSalesOrderItemDocRelationshipUUIDguidDocRelationshipUUIDGetExample
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

            var apiInstance = new ItemPrecedingProcessFlowApi(config);
            var salesOrder = "salesOrder_example";  // string | Subsequent Sales and Distribution Document
            var salesOrderItem = "salesOrderItem_example";  // string | Subsequent Item of an SD Document
            var docRelationshipUUID = 01234567-89ab-cdef-0123-456789abcdef;  // Guid | SD Unique Document Relationship Identification
            var select = new List<string>?(); // List<string>? | Select properties to be returned, see [Select](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=68) (optional) 
            var expand = new List<string>?(); // List<string>? | Expand related entities, see [Expand](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=63) (optional) 

            try
            {
                // Reads a preceding item for a sales order item.
                ASalesOrderItmPrecdgProcFlowType result = apiInstance.ASalesOrderItmPrecdgProcFlowSalesOrderSalesOrderSalesOrderItemSalesOrderItemDocRelationshipUUIDguidDocRelationshipUUIDGet(salesOrder, salesOrderItem, docRelationshipUUID, select, expand);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ItemPrecedingProcessFlowApi.ASalesOrderItmPrecdgProcFlowSalesOrderSalesOrderSalesOrderItemSalesOrderItemDocRelationshipUUIDguidDocRelationshipUUIDGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ASalesOrderItmPrecdgProcFlowSalesOrderSalesOrderSalesOrderItemSalesOrderItemDocRelationshipUUIDguidDocRelationshipUUIDGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Reads a preceding item for a sales order item.
    ApiResponse<ASalesOrderItmPrecdgProcFlowType> response = apiInstance.ASalesOrderItmPrecdgProcFlowSalesOrderSalesOrderSalesOrderItemSalesOrderItemDocRelationshipUUIDguidDocRelationshipUUIDGetWithHttpInfo(salesOrder, salesOrderItem, docRelationshipUUID, select, expand);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ItemPrecedingProcessFlowApi.ASalesOrderItmPrecdgProcFlowSalesOrderSalesOrderSalesOrderItemSalesOrderItemDocRelationshipUUIDguidDocRelationshipUUIDGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **salesOrder** | **string** | Subsequent Sales and Distribution Document |  |
| **salesOrderItem** | **string** | Subsequent Item of an SD Document |  |
| **docRelationshipUUID** | **Guid** | SD Unique Document Relationship Identification |  |
| **select** | [**List&lt;string&gt;?**](string.md) | Select properties to be returned, see [Select](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page&#x3D;68) | [optional]  |
| **expand** | [**List&lt;string&gt;?**](string.md) | Expand related entities, see [Expand](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page&#x3D;63) | [optional]  |

### Return type

[**ASalesOrderItmPrecdgProcFlowType**](ASalesOrderItmPrecdgProcFlowType.md)

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

<a id="asalesorderitmprecdgprocflowsalesordersalesordersalesorderitemsalesorderitemdocrelationshipuuidguiddocrelationshipuuidtosalesorderget"></a>
# **ASalesOrderItmPrecdgProcFlowSalesOrderSalesOrderSalesOrderItemSalesOrderItemDocRelationshipUUIDguidDocRelationshipUUIDToSalesOrderGet**
> ASalesOrderType ASalesOrderItmPrecdgProcFlowSalesOrderSalesOrderSalesOrderItemSalesOrderItemDocRelationshipUUIDguidDocRelationshipUUIDToSalesOrderGet (string salesOrder, string salesOrderItem, Guid docRelationshipUUID, List<string>? select = null, List<string>? expand = null)

Reads the sales order header data of a preceding item of a sales order.

Reads the sales order header data for specific preceding item of a sales order item. Consumers must pass the following key fields: sales order ID, sales order item number, and document relationship UUID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ASalesOrderItmPrecdgProcFlowSalesOrderSalesOrderSalesOrderItemSalesOrderItemDocRelationshipUUIDguidDocRelationshipUUIDToSalesOrderGetExample
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

            var apiInstance = new ItemPrecedingProcessFlowApi(config);
            var salesOrder = "salesOrder_example";  // string | Subsequent Sales and Distribution Document
            var salesOrderItem = "salesOrderItem_example";  // string | Subsequent Item of an SD Document
            var docRelationshipUUID = 01234567-89ab-cdef-0123-456789abcdef;  // Guid | SD Unique Document Relationship Identification
            var select = new List<string>?(); // List<string>? | Select properties to be returned, see [Select](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=68) (optional) 
            var expand = new List<string>?(); // List<string>? | Expand related entities, see [Expand](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=63) (optional) 

            try
            {
                // Reads the sales order header data of a preceding item of a sales order.
                ASalesOrderType result = apiInstance.ASalesOrderItmPrecdgProcFlowSalesOrderSalesOrderSalesOrderItemSalesOrderItemDocRelationshipUUIDguidDocRelationshipUUIDToSalesOrderGet(salesOrder, salesOrderItem, docRelationshipUUID, select, expand);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ItemPrecedingProcessFlowApi.ASalesOrderItmPrecdgProcFlowSalesOrderSalesOrderSalesOrderItemSalesOrderItemDocRelationshipUUIDguidDocRelationshipUUIDToSalesOrderGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ASalesOrderItmPrecdgProcFlowSalesOrderSalesOrderSalesOrderItemSalesOrderItemDocRelationshipUUIDguidDocRelationshipUUIDToSalesOrderGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Reads the sales order header data of a preceding item of a sales order.
    ApiResponse<ASalesOrderType> response = apiInstance.ASalesOrderItmPrecdgProcFlowSalesOrderSalesOrderSalesOrderItemSalesOrderItemDocRelationshipUUIDguidDocRelationshipUUIDToSalesOrderGetWithHttpInfo(salesOrder, salesOrderItem, docRelationshipUUID, select, expand);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ItemPrecedingProcessFlowApi.ASalesOrderItmPrecdgProcFlowSalesOrderSalesOrderSalesOrderItemSalesOrderItemDocRelationshipUUIDguidDocRelationshipUUIDToSalesOrderGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **salesOrder** | **string** | Subsequent Sales and Distribution Document |  |
| **salesOrderItem** | **string** | Subsequent Item of an SD Document |  |
| **docRelationshipUUID** | **Guid** | SD Unique Document Relationship Identification |  |
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

<a id="asalesorderitmprecdgprocflowsalesordersalesordersalesorderitemsalesorderitemdocrelationshipuuidguiddocrelationshipuuidtosalesorderitemget"></a>
# **ASalesOrderItmPrecdgProcFlowSalesOrderSalesOrderSalesOrderItemSalesOrderItemDocRelationshipUUIDguidDocRelationshipUUIDToSalesOrderItemGet**
> ASalesOrderItemType ASalesOrderItmPrecdgProcFlowSalesOrderSalesOrderSalesOrderItemSalesOrderItemDocRelationshipUUIDguidDocRelationshipUUIDToSalesOrderItemGet (string salesOrder, string salesOrderItem, Guid docRelationshipUUID, List<string>? select = null, List<string>? expand = null)

Reads the sales order item data for a preceding item of a sales order.

Reads the sales order item data for a specific preceding item of a sales order item. Consumers must pass the following key fields: sales order ID, sales order item number, and document relationship UUID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ASalesOrderItmPrecdgProcFlowSalesOrderSalesOrderSalesOrderItemSalesOrderItemDocRelationshipUUIDguidDocRelationshipUUIDToSalesOrderItemGetExample
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

            var apiInstance = new ItemPrecedingProcessFlowApi(config);
            var salesOrder = "salesOrder_example";  // string | Subsequent Sales and Distribution Document
            var salesOrderItem = "salesOrderItem_example";  // string | Subsequent Item of an SD Document
            var docRelationshipUUID = 01234567-89ab-cdef-0123-456789abcdef;  // Guid | SD Unique Document Relationship Identification
            var select = new List<string>?(); // List<string>? | Select properties to be returned, see [Select](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=68) (optional) 
            var expand = new List<string>?(); // List<string>? | Expand related entities, see [Expand](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=63) (optional) 

            try
            {
                // Reads the sales order item data for a preceding item of a sales order.
                ASalesOrderItemType result = apiInstance.ASalesOrderItmPrecdgProcFlowSalesOrderSalesOrderSalesOrderItemSalesOrderItemDocRelationshipUUIDguidDocRelationshipUUIDToSalesOrderItemGet(salesOrder, salesOrderItem, docRelationshipUUID, select, expand);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ItemPrecedingProcessFlowApi.ASalesOrderItmPrecdgProcFlowSalesOrderSalesOrderSalesOrderItemSalesOrderItemDocRelationshipUUIDguidDocRelationshipUUIDToSalesOrderItemGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ASalesOrderItmPrecdgProcFlowSalesOrderSalesOrderSalesOrderItemSalesOrderItemDocRelationshipUUIDguidDocRelationshipUUIDToSalesOrderItemGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Reads the sales order item data for a preceding item of a sales order.
    ApiResponse<ASalesOrderItemType> response = apiInstance.ASalesOrderItmPrecdgProcFlowSalesOrderSalesOrderSalesOrderItemSalesOrderItemDocRelationshipUUIDguidDocRelationshipUUIDToSalesOrderItemGetWithHttpInfo(salesOrder, salesOrderItem, docRelationshipUUID, select, expand);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ItemPrecedingProcessFlowApi.ASalesOrderItmPrecdgProcFlowSalesOrderSalesOrderSalesOrderItemSalesOrderItemDocRelationshipUUIDguidDocRelationshipUUIDToSalesOrderItemGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **salesOrder** | **string** | Subsequent Sales and Distribution Document |  |
| **salesOrderItem** | **string** | Subsequent Item of an SD Document |  |
| **docRelationshipUUID** | **Guid** | SD Unique Document Relationship Identification |  |
| **select** | [**List&lt;string&gt;?**](string.md) | Select properties to be returned, see [Select](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page&#x3D;68) | [optional]  |
| **expand** | [**List&lt;string&gt;?**](string.md) | Expand related entities, see [Expand](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page&#x3D;63) | [optional]  |

### Return type

[**ASalesOrderItemType**](ASalesOrderItemType.md)

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

