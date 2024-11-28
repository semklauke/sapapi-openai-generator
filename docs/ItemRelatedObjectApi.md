# Org.OpenAPITools.Api.ItemRelatedObjectApi

All URIs are relative to *https://:/sap/opu/odata/sap/API_SALES_ORDER_SRV*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ASalesOrderItemRelatedObjectGet**](ItemRelatedObjectApi.md#asalesorderitemrelatedobjectget) | **GET** /A_SalesOrderItemRelatedObject | Reads related objects from the items of all sales orders. |
| [**ASalesOrderItemRelatedObjectPost**](ItemRelatedObjectApi.md#asalesorderitemrelatedobjectpost) | **POST** /A_SalesOrderItemRelatedObject | Creates a related object for a sales order item. |
| [**ASalesOrderItemRelatedObjectSalesOrderSalesOrderSalesOrderItemSalesOrderItemSDDocRelatedObjectSequenceNmbrSDDocRelatedObjectSequenceNmbrDelete**](ItemRelatedObjectApi.md#asalesorderitemrelatedobjectsalesordersalesordersalesorderitemsalesorderitemsddocrelatedobjectsequencenmbrsddocrelatedobjectsequencenmbrdelete) | **DELETE** /A_SalesOrderItemRelatedObject(SalesOrder&#x3D;&#39;{SalesOrder}&#39;,SalesOrderItem&#x3D;&#39;{SalesOrderItem}&#39;,SDDocRelatedObjectSequenceNmbr&#x3D;&#39;{SDDocRelatedObjectSequenceNmbr}&#39;) | Deletes a related object from a sales order item. |
| [**ASalesOrderItemRelatedObjectSalesOrderSalesOrderSalesOrderItemSalesOrderItemSDDocRelatedObjectSequenceNmbrSDDocRelatedObjectSequenceNmbrGet**](ItemRelatedObjectApi.md#asalesorderitemrelatedobjectsalesordersalesordersalesorderitemsalesorderitemsddocrelatedobjectsequencenmbrsddocrelatedobjectsequencenmbrget) | **GET** /A_SalesOrderItemRelatedObject(SalesOrder&#x3D;&#39;{SalesOrder}&#39;,SalesOrderItem&#x3D;&#39;{SalesOrderItem}&#39;,SDDocRelatedObjectSequenceNmbr&#x3D;&#39;{SDDocRelatedObjectSequenceNmbr}&#39;) | Reads a related object from a sales order item. |
| [**ASalesOrderItemRelatedObjectSalesOrderSalesOrderSalesOrderItemSalesOrderItemSDDocRelatedObjectSequenceNmbrSDDocRelatedObjectSequenceNmbrToSalesOrderGet**](ItemRelatedObjectApi.md#asalesorderitemrelatedobjectsalesordersalesordersalesorderitemsalesorderitemsddocrelatedobjectsequencenmbrsddocrelatedobjectsequencenmbrtosalesorderget) | **GET** /A_SalesOrderItemRelatedObject(SalesOrder&#x3D;&#39;{SalesOrder}&#39;,SalesOrderItem&#x3D;&#39;{SalesOrderItem}&#39;,SDDocRelatedObjectSequenceNmbr&#x3D;&#39;{SDDocRelatedObjectSequenceNmbr}&#39;)/to_SalesOrder | Reads the sales order header for a related object of a sales order item. |
| [**ASalesOrderItemRelatedObjectSalesOrderSalesOrderSalesOrderItemSalesOrderItemSDDocRelatedObjectSequenceNmbrSDDocRelatedObjectSequenceNmbrToSalesOrderItemGet**](ItemRelatedObjectApi.md#asalesorderitemrelatedobjectsalesordersalesordersalesorderitemsalesorderitemsddocrelatedobjectsequencenmbrsddocrelatedobjectsequencenmbrtosalesorderitemget) | **GET** /A_SalesOrderItemRelatedObject(SalesOrder&#x3D;&#39;{SalesOrder}&#39;,SalesOrderItem&#x3D;&#39;{SalesOrderItem}&#39;,SDDocRelatedObjectSequenceNmbr&#x3D;&#39;{SDDocRelatedObjectSequenceNmbr}&#39;)/to_SalesOrderItem | Reads the sales order item for a related object. |
| [**ASalesOrderItemSalesOrderSalesOrderSalesOrderItemSalesOrderItemToRelatedObjectGet**](ItemRelatedObjectApi.md#asalesorderitemsalesordersalesordersalesorderitemsalesorderitemtorelatedobjectget) | **GET** /A_SalesOrderItem(SalesOrder&#x3D;&#39;{SalesOrder}&#39;,SalesOrderItem&#x3D;&#39;{SalesOrderItem}&#39;)/to_RelatedObject | Reads the related object of a sales order item. |
| [**ASalesOrderItemSalesOrderSalesOrderSalesOrderItemSalesOrderItemToRelatedObjectPost**](ItemRelatedObjectApi.md#asalesorderitemsalesordersalesordersalesorderitemsalesorderitemtorelatedobjectpost) | **POST** /A_SalesOrderItem(SalesOrder&#x3D;&#39;{SalesOrder}&#39;,SalesOrderItem&#x3D;&#39;{SalesOrderItem}&#39;)/to_RelatedObject | Creates a related object for a specific sales order item. |

<a id="asalesorderitemrelatedobjectget"></a>
# **ASalesOrderItemRelatedObjectGet**
> Wrapper15 ASalesOrderItemRelatedObjectGet (int? top = null, int? skip = null, string? filter = null, string? inlinecount = null, List<string>? orderby = null, List<string>? select = null, List<string>? expand = null)

Reads related objects from the items of all sales orders.

Reads the data for related objects from the items of all sales orders in the system.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ASalesOrderItemRelatedObjectGetExample
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

            var apiInstance = new ItemRelatedObjectApi(config);
            var top = 50;  // int? | Show only the first n items, see [Paging - Top](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=66) (optional) 
            var skip = 56;  // int? | Skip the first n items, see [Paging - Skip](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=65) (optional) 
            var filter = "filter_example";  // string? | Filter items by property values, see [Filtering](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=64) (optional) 
            var inlinecount = "allpages";  // string? | Include count of items, see [Inlinecount](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=67) (optional) 
            var orderby = new List<string>?(); // List<string>? | Order items by property values, see [Sorting](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=65) (optional) 
            var select = new List<string>?(); // List<string>? | Select properties to be returned, see [Select](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=68) (optional) 
            var expand = new List<string>?(); // List<string>? | Expand related entities, see [Expand](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=63) (optional) 

            try
            {
                // Reads related objects from the items of all sales orders.
                Wrapper15 result = apiInstance.ASalesOrderItemRelatedObjectGet(top, skip, filter, inlinecount, orderby, select, expand);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ItemRelatedObjectApi.ASalesOrderItemRelatedObjectGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ASalesOrderItemRelatedObjectGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Reads related objects from the items of all sales orders.
    ApiResponse<Wrapper15> response = apiInstance.ASalesOrderItemRelatedObjectGetWithHttpInfo(top, skip, filter, inlinecount, orderby, select, expand);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ItemRelatedObjectApi.ASalesOrderItemRelatedObjectGetWithHttpInfo: " + e.Message);
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

[**Wrapper15**](Wrapper15.md)

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

<a id="asalesorderitemrelatedobjectpost"></a>
# **ASalesOrderItemRelatedObjectPost**
> ASalesOrderItemRelatedObjectType ASalesOrderItemRelatedObjectPost (APISALESORDERSRVASalesOrderItemRelatedObjectTypeCreate aPISALESORDERSRVASalesOrderItemRelatedObjectTypeCreate)

Creates a related object for a sales order item.

Creates the data for a related object for a specific item of a specific sales order. Consumers must pass the following key fields: sales order ID, sales order item number, related object type, and related object reference 1.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ASalesOrderItemRelatedObjectPostExample
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

            var apiInstance = new ItemRelatedObjectApi(config);
            var aPISALESORDERSRVASalesOrderItemRelatedObjectTypeCreate = new APISALESORDERSRVASalesOrderItemRelatedObjectTypeCreate(); // APISALESORDERSRVASalesOrderItemRelatedObjectTypeCreate | New entity

            try
            {
                // Creates a related object for a sales order item.
                ASalesOrderItemRelatedObjectType result = apiInstance.ASalesOrderItemRelatedObjectPost(aPISALESORDERSRVASalesOrderItemRelatedObjectTypeCreate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ItemRelatedObjectApi.ASalesOrderItemRelatedObjectPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ASalesOrderItemRelatedObjectPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a related object for a sales order item.
    ApiResponse<ASalesOrderItemRelatedObjectType> response = apiInstance.ASalesOrderItemRelatedObjectPostWithHttpInfo(aPISALESORDERSRVASalesOrderItemRelatedObjectTypeCreate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ItemRelatedObjectApi.ASalesOrderItemRelatedObjectPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **aPISALESORDERSRVASalesOrderItemRelatedObjectTypeCreate** | [**APISALESORDERSRVASalesOrderItemRelatedObjectTypeCreate**](APISALESORDERSRVASalesOrderItemRelatedObjectTypeCreate.md) | New entity |  |

### Return type

[**ASalesOrderItemRelatedObjectType**](ASalesOrderItemRelatedObjectType.md)

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

<a id="asalesorderitemrelatedobjectsalesordersalesordersalesorderitemsalesorderitemsddocrelatedobjectsequencenmbrsddocrelatedobjectsequencenmbrdelete"></a>
# **ASalesOrderItemRelatedObjectSalesOrderSalesOrderSalesOrderItemSalesOrderItemSDDocRelatedObjectSequenceNmbrSDDocRelatedObjectSequenceNmbrDelete**
> void ASalesOrderItemRelatedObjectSalesOrderSalesOrderSalesOrderItemSalesOrderItemSDDocRelatedObjectSequenceNmbrSDDocRelatedObjectSequenceNmbrDelete (string salesOrder, string salesOrderItem, string sDDocRelatedObjectSequenceNmbr)

Deletes a related object from a sales order item.

Deletes the data for a related object from a specific item of a specific sales order. Consumers must pass the following key fields: sales order ID, sales order item number, and sequence number of the related object.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ASalesOrderItemRelatedObjectSalesOrderSalesOrderSalesOrderItemSalesOrderItemSDDocRelatedObjectSequenceNmbrSDDocRelatedObjectSequenceNmbrDeleteExample
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

            var apiInstance = new ItemRelatedObjectApi(config);
            var salesOrder = "salesOrder_example";  // string | Sales Order
            var salesOrderItem = "salesOrderItem_example";  // string | Sales Order Item
            var sDDocRelatedObjectSequenceNmbr = "sDDocRelatedObjectSequenceNmbr_example";  // string | Sequence Number of the Related Object of an SD Document

            try
            {
                // Deletes a related object from a sales order item.
                apiInstance.ASalesOrderItemRelatedObjectSalesOrderSalesOrderSalesOrderItemSalesOrderItemSDDocRelatedObjectSequenceNmbrSDDocRelatedObjectSequenceNmbrDelete(salesOrder, salesOrderItem, sDDocRelatedObjectSequenceNmbr);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ItemRelatedObjectApi.ASalesOrderItemRelatedObjectSalesOrderSalesOrderSalesOrderItemSalesOrderItemSDDocRelatedObjectSequenceNmbrSDDocRelatedObjectSequenceNmbrDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ASalesOrderItemRelatedObjectSalesOrderSalesOrderSalesOrderItemSalesOrderItemSDDocRelatedObjectSequenceNmbrSDDocRelatedObjectSequenceNmbrDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deletes a related object from a sales order item.
    apiInstance.ASalesOrderItemRelatedObjectSalesOrderSalesOrderSalesOrderItemSalesOrderItemSDDocRelatedObjectSequenceNmbrSDDocRelatedObjectSequenceNmbrDeleteWithHttpInfo(salesOrder, salesOrderItem, sDDocRelatedObjectSequenceNmbr);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ItemRelatedObjectApi.ASalesOrderItemRelatedObjectSalesOrderSalesOrderSalesOrderItemSalesOrderItemSDDocRelatedObjectSequenceNmbrSDDocRelatedObjectSequenceNmbrDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **salesOrder** | **string** | Sales Order |  |
| **salesOrderItem** | **string** | Sales Order Item |  |
| **sDDocRelatedObjectSequenceNmbr** | **string** | Sequence Number of the Related Object of an SD Document |  |

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

<a id="asalesorderitemrelatedobjectsalesordersalesordersalesorderitemsalesorderitemsddocrelatedobjectsequencenmbrsddocrelatedobjectsequencenmbrget"></a>
# **ASalesOrderItemRelatedObjectSalesOrderSalesOrderSalesOrderItemSalesOrderItemSDDocRelatedObjectSequenceNmbrSDDocRelatedObjectSequenceNmbrGet**
> ASalesOrderItemRelatedObjectType ASalesOrderItemRelatedObjectSalesOrderSalesOrderSalesOrderItemSalesOrderItemSDDocRelatedObjectSequenceNmbrSDDocRelatedObjectSequenceNmbrGet (string salesOrder, string salesOrderItem, string sDDocRelatedObjectSequenceNmbr, List<string>? select = null, List<string>? expand = null)

Reads a related object from a sales order item.

Reads the data for a related object from a specific item of a specific sales order. Consumers must pass the following key fields: sales order ID, sales order item number, and sequence number of the related object.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ASalesOrderItemRelatedObjectSalesOrderSalesOrderSalesOrderItemSalesOrderItemSDDocRelatedObjectSequenceNmbrSDDocRelatedObjectSequenceNmbrGetExample
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

            var apiInstance = new ItemRelatedObjectApi(config);
            var salesOrder = "salesOrder_example";  // string | Sales Order
            var salesOrderItem = "salesOrderItem_example";  // string | Sales Order Item
            var sDDocRelatedObjectSequenceNmbr = "sDDocRelatedObjectSequenceNmbr_example";  // string | Sequence Number of the Related Object of an SD Document
            var select = new List<string>?(); // List<string>? | Select properties to be returned, see [Select](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=68) (optional) 
            var expand = new List<string>?(); // List<string>? | Expand related entities, see [Expand](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=63) (optional) 

            try
            {
                // Reads a related object from a sales order item.
                ASalesOrderItemRelatedObjectType result = apiInstance.ASalesOrderItemRelatedObjectSalesOrderSalesOrderSalesOrderItemSalesOrderItemSDDocRelatedObjectSequenceNmbrSDDocRelatedObjectSequenceNmbrGet(salesOrder, salesOrderItem, sDDocRelatedObjectSequenceNmbr, select, expand);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ItemRelatedObjectApi.ASalesOrderItemRelatedObjectSalesOrderSalesOrderSalesOrderItemSalesOrderItemSDDocRelatedObjectSequenceNmbrSDDocRelatedObjectSequenceNmbrGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ASalesOrderItemRelatedObjectSalesOrderSalesOrderSalesOrderItemSalesOrderItemSDDocRelatedObjectSequenceNmbrSDDocRelatedObjectSequenceNmbrGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Reads a related object from a sales order item.
    ApiResponse<ASalesOrderItemRelatedObjectType> response = apiInstance.ASalesOrderItemRelatedObjectSalesOrderSalesOrderSalesOrderItemSalesOrderItemSDDocRelatedObjectSequenceNmbrSDDocRelatedObjectSequenceNmbrGetWithHttpInfo(salesOrder, salesOrderItem, sDDocRelatedObjectSequenceNmbr, select, expand);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ItemRelatedObjectApi.ASalesOrderItemRelatedObjectSalesOrderSalesOrderSalesOrderItemSalesOrderItemSDDocRelatedObjectSequenceNmbrSDDocRelatedObjectSequenceNmbrGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **salesOrder** | **string** | Sales Order |  |
| **salesOrderItem** | **string** | Sales Order Item |  |
| **sDDocRelatedObjectSequenceNmbr** | **string** | Sequence Number of the Related Object of an SD Document |  |
| **select** | [**List&lt;string&gt;?**](string.md) | Select properties to be returned, see [Select](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page&#x3D;68) | [optional]  |
| **expand** | [**List&lt;string&gt;?**](string.md) | Expand related entities, see [Expand](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page&#x3D;63) | [optional]  |

### Return type

[**ASalesOrderItemRelatedObjectType**](ASalesOrderItemRelatedObjectType.md)

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

<a id="asalesorderitemrelatedobjectsalesordersalesordersalesorderitemsalesorderitemsddocrelatedobjectsequencenmbrsddocrelatedobjectsequencenmbrtosalesorderget"></a>
# **ASalesOrderItemRelatedObjectSalesOrderSalesOrderSalesOrderItemSalesOrderItemSDDocRelatedObjectSequenceNmbrSDDocRelatedObjectSequenceNmbrToSalesOrderGet**
> ASalesOrderType ASalesOrderItemRelatedObjectSalesOrderSalesOrderSalesOrderItemSalesOrderItemSDDocRelatedObjectSequenceNmbrSDDocRelatedObjectSequenceNmbrToSalesOrderGet (string salesOrder, string salesOrderItem, string sDDocRelatedObjectSequenceNmbr, List<string>? select = null, List<string>? expand = null)

Reads the sales order header for a related object of a sales order item.

Reads the sales order header data for a specific related object of a specific sales order item. Consumers must pass the following key fields: sales order ID, item number, and sequence number.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ASalesOrderItemRelatedObjectSalesOrderSalesOrderSalesOrderItemSalesOrderItemSDDocRelatedObjectSequenceNmbrSDDocRelatedObjectSequenceNmbrToSalesOrderGetExample
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

            var apiInstance = new ItemRelatedObjectApi(config);
            var salesOrder = "salesOrder_example";  // string | Sales Order
            var salesOrderItem = "salesOrderItem_example";  // string | Sales Order Item
            var sDDocRelatedObjectSequenceNmbr = "sDDocRelatedObjectSequenceNmbr_example";  // string | Sequence Number of the Related Object of an SD Document
            var select = new List<string>?(); // List<string>? | Select properties to be returned, see [Select](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=68) (optional) 
            var expand = new List<string>?(); // List<string>? | Expand related entities, see [Expand](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=63) (optional) 

            try
            {
                // Reads the sales order header for a related object of a sales order item.
                ASalesOrderType result = apiInstance.ASalesOrderItemRelatedObjectSalesOrderSalesOrderSalesOrderItemSalesOrderItemSDDocRelatedObjectSequenceNmbrSDDocRelatedObjectSequenceNmbrToSalesOrderGet(salesOrder, salesOrderItem, sDDocRelatedObjectSequenceNmbr, select, expand);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ItemRelatedObjectApi.ASalesOrderItemRelatedObjectSalesOrderSalesOrderSalesOrderItemSalesOrderItemSDDocRelatedObjectSequenceNmbrSDDocRelatedObjectSequenceNmbrToSalesOrderGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ASalesOrderItemRelatedObjectSalesOrderSalesOrderSalesOrderItemSalesOrderItemSDDocRelatedObjectSequenceNmbrSDDocRelatedObjectSequenceNmbrToSalesOrderGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Reads the sales order header for a related object of a sales order item.
    ApiResponse<ASalesOrderType> response = apiInstance.ASalesOrderItemRelatedObjectSalesOrderSalesOrderSalesOrderItemSalesOrderItemSDDocRelatedObjectSequenceNmbrSDDocRelatedObjectSequenceNmbrToSalesOrderGetWithHttpInfo(salesOrder, salesOrderItem, sDDocRelatedObjectSequenceNmbr, select, expand);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ItemRelatedObjectApi.ASalesOrderItemRelatedObjectSalesOrderSalesOrderSalesOrderItemSalesOrderItemSDDocRelatedObjectSequenceNmbrSDDocRelatedObjectSequenceNmbrToSalesOrderGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **salesOrder** | **string** | Sales Order |  |
| **salesOrderItem** | **string** | Sales Order Item |  |
| **sDDocRelatedObjectSequenceNmbr** | **string** | Sequence Number of the Related Object of an SD Document |  |
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

<a id="asalesorderitemrelatedobjectsalesordersalesordersalesorderitemsalesorderitemsddocrelatedobjectsequencenmbrsddocrelatedobjectsequencenmbrtosalesorderitemget"></a>
# **ASalesOrderItemRelatedObjectSalesOrderSalesOrderSalesOrderItemSalesOrderItemSDDocRelatedObjectSequenceNmbrSDDocRelatedObjectSequenceNmbrToSalesOrderItemGet**
> ASalesOrderItemType ASalesOrderItemRelatedObjectSalesOrderSalesOrderSalesOrderItemSalesOrderItemSDDocRelatedObjectSequenceNmbrSDDocRelatedObjectSequenceNmbrToSalesOrderItemGet (string salesOrder, string salesOrderItem, string sDDocRelatedObjectSequenceNmbr, List<string>? select = null, List<string>? expand = null)

Reads the sales order item for a related object.

Reads the sales order item data for a specific related object. Consumers must pass the following key fields: sales order ID, item number, and sequence number.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ASalesOrderItemRelatedObjectSalesOrderSalesOrderSalesOrderItemSalesOrderItemSDDocRelatedObjectSequenceNmbrSDDocRelatedObjectSequenceNmbrToSalesOrderItemGetExample
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

            var apiInstance = new ItemRelatedObjectApi(config);
            var salesOrder = "salesOrder_example";  // string | Sales Order
            var salesOrderItem = "salesOrderItem_example";  // string | Sales Order Item
            var sDDocRelatedObjectSequenceNmbr = "sDDocRelatedObjectSequenceNmbr_example";  // string | Sequence Number of the Related Object of an SD Document
            var select = new List<string>?(); // List<string>? | Select properties to be returned, see [Select](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=68) (optional) 
            var expand = new List<string>?(); // List<string>? | Expand related entities, see [Expand](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=63) (optional) 

            try
            {
                // Reads the sales order item for a related object.
                ASalesOrderItemType result = apiInstance.ASalesOrderItemRelatedObjectSalesOrderSalesOrderSalesOrderItemSalesOrderItemSDDocRelatedObjectSequenceNmbrSDDocRelatedObjectSequenceNmbrToSalesOrderItemGet(salesOrder, salesOrderItem, sDDocRelatedObjectSequenceNmbr, select, expand);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ItemRelatedObjectApi.ASalesOrderItemRelatedObjectSalesOrderSalesOrderSalesOrderItemSalesOrderItemSDDocRelatedObjectSequenceNmbrSDDocRelatedObjectSequenceNmbrToSalesOrderItemGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ASalesOrderItemRelatedObjectSalesOrderSalesOrderSalesOrderItemSalesOrderItemSDDocRelatedObjectSequenceNmbrSDDocRelatedObjectSequenceNmbrToSalesOrderItemGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Reads the sales order item for a related object.
    ApiResponse<ASalesOrderItemType> response = apiInstance.ASalesOrderItemRelatedObjectSalesOrderSalesOrderSalesOrderItemSalesOrderItemSDDocRelatedObjectSequenceNmbrSDDocRelatedObjectSequenceNmbrToSalesOrderItemGetWithHttpInfo(salesOrder, salesOrderItem, sDDocRelatedObjectSequenceNmbr, select, expand);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ItemRelatedObjectApi.ASalesOrderItemRelatedObjectSalesOrderSalesOrderSalesOrderItemSalesOrderItemSDDocRelatedObjectSequenceNmbrSDDocRelatedObjectSequenceNmbrToSalesOrderItemGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **salesOrder** | **string** | Sales Order |  |
| **salesOrderItem** | **string** | Sales Order Item |  |
| **sDDocRelatedObjectSequenceNmbr** | **string** | Sequence Number of the Related Object of an SD Document |  |
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

<a id="asalesorderitemsalesordersalesordersalesorderitemsalesorderitemtorelatedobjectget"></a>
# **ASalesOrderItemSalesOrderSalesOrderSalesOrderItemSalesOrderItemToRelatedObjectGet**
> Wrapper15 ASalesOrderItemSalesOrderSalesOrderSalesOrderItemSalesOrderItemToRelatedObjectGet (string salesOrder, string salesOrderItem, int? top = null, int? skip = null, string? filter = null, string? inlinecount = null, List<string>? orderby = null, List<string>? select = null, List<string>? expand = null)

Reads the related object of a sales order item.

Reads the data of a related object for a specific item. Consumers must pass the following key fields: sales order ID and item number.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ASalesOrderItemSalesOrderSalesOrderSalesOrderItemSalesOrderItemToRelatedObjectGetExample
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

            var apiInstance = new ItemRelatedObjectApi(config);
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
                // Reads the related object of a sales order item.
                Wrapper15 result = apiInstance.ASalesOrderItemSalesOrderSalesOrderSalesOrderItemSalesOrderItemToRelatedObjectGet(salesOrder, salesOrderItem, top, skip, filter, inlinecount, orderby, select, expand);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ItemRelatedObjectApi.ASalesOrderItemSalesOrderSalesOrderSalesOrderItemSalesOrderItemToRelatedObjectGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ASalesOrderItemSalesOrderSalesOrderSalesOrderItemSalesOrderItemToRelatedObjectGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Reads the related object of a sales order item.
    ApiResponse<Wrapper15> response = apiInstance.ASalesOrderItemSalesOrderSalesOrderSalesOrderItemSalesOrderItemToRelatedObjectGetWithHttpInfo(salesOrder, salesOrderItem, top, skip, filter, inlinecount, orderby, select, expand);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ItemRelatedObjectApi.ASalesOrderItemSalesOrderSalesOrderSalesOrderItemSalesOrderItemToRelatedObjectGetWithHttpInfo: " + e.Message);
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

[**Wrapper15**](Wrapper15.md)

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

<a id="asalesorderitemsalesordersalesordersalesorderitemsalesorderitemtorelatedobjectpost"></a>
# **ASalesOrderItemSalesOrderSalesOrderSalesOrderItemSalesOrderItemToRelatedObjectPost**
> ASalesOrderItemRelatedObjectType ASalesOrderItemSalesOrderSalesOrderSalesOrderItemSalesOrderItemToRelatedObjectPost (string salesOrder, string salesOrderItem, APISALESORDERSRVASalesOrderItemRelatedObjectTypeCreate aPISALESORDERSRVASalesOrderItemRelatedObjectTypeCreate)

Creates a related object for a specific sales order item.

Creates the data of a related object for a specific item. Consumers must pass the following key fields: sales order ID, item number, related object type, and related object reference 1.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ASalesOrderItemSalesOrderSalesOrderSalesOrderItemSalesOrderItemToRelatedObjectPostExample
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

            var apiInstance = new ItemRelatedObjectApi(config);
            var salesOrder = "salesOrder_example";  // string | Sales Order
            var salesOrderItem = "salesOrderItem_example";  // string | Sales Order Item
            var aPISALESORDERSRVASalesOrderItemRelatedObjectTypeCreate = new APISALESORDERSRVASalesOrderItemRelatedObjectTypeCreate(); // APISALESORDERSRVASalesOrderItemRelatedObjectTypeCreate | New entity

            try
            {
                // Creates a related object for a specific sales order item.
                ASalesOrderItemRelatedObjectType result = apiInstance.ASalesOrderItemSalesOrderSalesOrderSalesOrderItemSalesOrderItemToRelatedObjectPost(salesOrder, salesOrderItem, aPISALESORDERSRVASalesOrderItemRelatedObjectTypeCreate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ItemRelatedObjectApi.ASalesOrderItemSalesOrderSalesOrderSalesOrderItemSalesOrderItemToRelatedObjectPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ASalesOrderItemSalesOrderSalesOrderSalesOrderItemSalesOrderItemToRelatedObjectPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a related object for a specific sales order item.
    ApiResponse<ASalesOrderItemRelatedObjectType> response = apiInstance.ASalesOrderItemSalesOrderSalesOrderSalesOrderItemSalesOrderItemToRelatedObjectPostWithHttpInfo(salesOrder, salesOrderItem, aPISALESORDERSRVASalesOrderItemRelatedObjectTypeCreate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ItemRelatedObjectApi.ASalesOrderItemSalesOrderSalesOrderSalesOrderItemSalesOrderItemToRelatedObjectPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **salesOrder** | **string** | Sales Order |  |
| **salesOrderItem** | **string** | Sales Order Item |  |
| **aPISALESORDERSRVASalesOrderItemRelatedObjectTypeCreate** | [**APISALESORDERSRVASalesOrderItemRelatedObjectTypeCreate**](APISALESORDERSRVASalesOrderItemRelatedObjectTypeCreate.md) | New entity |  |

### Return type

[**ASalesOrderItemRelatedObjectType**](ASalesOrderItemRelatedObjectType.md)

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

