# Org.OpenAPITools.Api.ItemPricingElementApi

All URIs are relative to *https://:/sap/opu/odata/sap/API_SALES_ORDER_SRV*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ASalesOrderItemPrElementGet**](ItemPricingElementApi.md#asalesorderitemprelementget) | **GET** /A_SalesOrderItemPrElement | Reads the item pricing elements of all sales orders. |
| [**ASalesOrderItemPrElementPost**](ItemPricingElementApi.md#asalesorderitemprelementpost) | **POST** /A_SalesOrderItemPrElement | Creates an item pricing element. |
| [**ASalesOrderItemPrElementSalesOrderSalesOrderSalesOrderItemSalesOrderItemPricingProcedureStepPricingProcedureStepPricingProcedureCounterPricingProcedureCounterDelete**](ItemPricingElementApi.md#asalesorderitemprelementsalesordersalesordersalesorderitemsalesorderitempricingproceduresteppricingproceduresteppricingprocedurecounterpricingprocedurecounterdelete) | **DELETE** /A_SalesOrderItemPrElement(SalesOrder&#x3D;&#39;{SalesOrder}&#39;,SalesOrderItem&#x3D;&#39;{SalesOrderItem}&#39;,PricingProcedureStep&#x3D;&#39;{PricingProcedureStep}&#39;,PricingProcedureCounter&#x3D;&#39;{PricingProcedureCounter}&#39;) | Deletes an item pricing element. |
| [**ASalesOrderItemPrElementSalesOrderSalesOrderSalesOrderItemSalesOrderItemPricingProcedureStepPricingProcedureStepPricingProcedureCounterPricingProcedureCounterGet**](ItemPricingElementApi.md#asalesorderitemprelementsalesordersalesordersalesorderitemsalesorderitempricingproceduresteppricingproceduresteppricingprocedurecounterpricingprocedurecounterget) | **GET** /A_SalesOrderItemPrElement(SalesOrder&#x3D;&#39;{SalesOrder}&#39;,SalesOrderItem&#x3D;&#39;{SalesOrderItem}&#39;,PricingProcedureStep&#x3D;&#39;{PricingProcedureStep}&#39;,PricingProcedureCounter&#x3D;&#39;{PricingProcedureCounter}&#39;) | Reads the pricing element of a item with specific pricing details. |
| [**ASalesOrderItemPrElementSalesOrderSalesOrderSalesOrderItemSalesOrderItemPricingProcedureStepPricingProcedureStepPricingProcedureCounterPricingProcedureCounterPatch**](ItemPricingElementApi.md#asalesorderitemprelementsalesordersalesordersalesorderitemsalesorderitempricingproceduresteppricingproceduresteppricingprocedurecounterpricingprocedurecounterpatch) | **PATCH** /A_SalesOrderItemPrElement(SalesOrder&#x3D;&#39;{SalesOrder}&#39;,SalesOrderItem&#x3D;&#39;{SalesOrderItem}&#39;,PricingProcedureStep&#x3D;&#39;{PricingProcedureStep}&#39;,PricingProcedureCounter&#x3D;&#39;{PricingProcedureCounter}&#39;) | Updates an item pricing element. |
| [**ASalesOrderItemPrElementSalesOrderSalesOrderSalesOrderItemSalesOrderItemPricingProcedureStepPricingProcedureStepPricingProcedureCounterPricingProcedureCounterToSalesOrderGet**](ItemPricingElementApi.md#asalesorderitemprelementsalesordersalesordersalesorderitemsalesorderitempricingproceduresteppricingproceduresteppricingprocedurecounterpricingprocedurecountertosalesorderget) | **GET** /A_SalesOrderItemPrElement(SalesOrder&#x3D;&#39;{SalesOrder}&#39;,SalesOrderItem&#x3D;&#39;{SalesOrderItem}&#39;,PricingProcedureStep&#x3D;&#39;{PricingProcedureStep}&#39;,PricingProcedureCounter&#x3D;&#39;{PricingProcedureCounter}&#39;)/to_SalesOrder | Reads the sales order header for a pricing element. |
| [**ASalesOrderItemPrElementSalesOrderSalesOrderSalesOrderItemSalesOrderItemPricingProcedureStepPricingProcedureStepPricingProcedureCounterPricingProcedureCounterToSalesOrderItemGet**](ItemPricingElementApi.md#asalesorderitemprelementsalesordersalesordersalesorderitemsalesorderitempricingproceduresteppricingproceduresteppricingprocedurecounterpricingprocedurecountertosalesorderitemget) | **GET** /A_SalesOrderItemPrElement(SalesOrder&#x3D;&#39;{SalesOrder}&#39;,SalesOrderItem&#x3D;&#39;{SalesOrderItem}&#39;,PricingProcedureStep&#x3D;&#39;{PricingProcedureStep}&#39;,PricingProcedureCounter&#x3D;&#39;{PricingProcedureCounter}&#39;)/to_SalesOrderItem | Reads the sales order item for a pricing element. |
| [**ASalesOrderItemSalesOrderSalesOrderSalesOrderItemSalesOrderItemToPricingElementGet**](ItemPricingElementApi.md#asalesorderitemsalesordersalesordersalesorderitemsalesorderitemtopricingelementget) | **GET** /A_SalesOrderItem(SalesOrder&#x3D;&#39;{SalesOrder}&#39;,SalesOrderItem&#x3D;&#39;{SalesOrderItem}&#39;)/to_PricingElement | Reads the pricing element of a sales order item. |
| [**ASalesOrderItemSalesOrderSalesOrderSalesOrderItemSalesOrderItemToPricingElementPost**](ItemPricingElementApi.md#asalesorderitemsalesordersalesordersalesorderitemsalesorderitemtopricingelementpost) | **POST** /A_SalesOrderItem(SalesOrder&#x3D;&#39;{SalesOrder}&#39;,SalesOrderItem&#x3D;&#39;{SalesOrderItem}&#39;)/to_PricingElement | Creates a pricing element for a specific sales order item. |

<a id="asalesorderitemprelementget"></a>
# **ASalesOrderItemPrElementGet**
> Wrapper14 ASalesOrderItemPrElementGet (int? top = null, int? skip = null, string? filter = null, string? inlinecount = null, List<string>? orderby = null, List<string>? select = null, List<string>? expand = null)

Reads the item pricing elements of all sales orders.

Reads the pricing element data from the items of all sales orders in the system.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ASalesOrderItemPrElementGetExample
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

            var apiInstance = new ItemPricingElementApi(config);
            var top = 50;  // int? | Show only the first n items, see [Paging - Top](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=66) (optional) 
            var skip = 56;  // int? | Skip the first n items, see [Paging - Skip](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=65) (optional) 
            var filter = "filter_example";  // string? | Filter items by property values, see [Filtering](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=64) (optional) 
            var inlinecount = "allpages";  // string? | Include count of items, see [Inlinecount](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=67) (optional) 
            var orderby = new List<string>?(); // List<string>? | Order items by property values, see [Sorting](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=65) (optional) 
            var select = new List<string>?(); // List<string>? | Select properties to be returned, see [Select](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=68) (optional) 
            var expand = new List<string>?(); // List<string>? | Expand related entities, see [Expand](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=63) (optional) 

            try
            {
                // Reads the item pricing elements of all sales orders.
                Wrapper14 result = apiInstance.ASalesOrderItemPrElementGet(top, skip, filter, inlinecount, orderby, select, expand);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ItemPricingElementApi.ASalesOrderItemPrElementGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ASalesOrderItemPrElementGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Reads the item pricing elements of all sales orders.
    ApiResponse<Wrapper14> response = apiInstance.ASalesOrderItemPrElementGetWithHttpInfo(top, skip, filter, inlinecount, orderby, select, expand);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ItemPricingElementApi.ASalesOrderItemPrElementGetWithHttpInfo: " + e.Message);
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

[**Wrapper14**](Wrapper14.md)

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

<a id="asalesorderitemprelementpost"></a>
# **ASalesOrderItemPrElementPost**
> ASalesOrderItemPrElementType ASalesOrderItemPrElementPost (APISALESORDERSRVASalesOrderItemPrElementTypeCreate aPISALESORDERSRVASalesOrderItemPrElementTypeCreate)

Creates an item pricing element.

Creates a pricing element for a specific sales order item. Consumers must pass the following key fields: sales order ID, item number, pricing procedure step, and pricing procedure counter.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ASalesOrderItemPrElementPostExample
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

            var apiInstance = new ItemPricingElementApi(config);
            var aPISALESORDERSRVASalesOrderItemPrElementTypeCreate = new APISALESORDERSRVASalesOrderItemPrElementTypeCreate(); // APISALESORDERSRVASalesOrderItemPrElementTypeCreate | New entity

            try
            {
                // Creates an item pricing element.
                ASalesOrderItemPrElementType result = apiInstance.ASalesOrderItemPrElementPost(aPISALESORDERSRVASalesOrderItemPrElementTypeCreate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ItemPricingElementApi.ASalesOrderItemPrElementPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ASalesOrderItemPrElementPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates an item pricing element.
    ApiResponse<ASalesOrderItemPrElementType> response = apiInstance.ASalesOrderItemPrElementPostWithHttpInfo(aPISALESORDERSRVASalesOrderItemPrElementTypeCreate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ItemPricingElementApi.ASalesOrderItemPrElementPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **aPISALESORDERSRVASalesOrderItemPrElementTypeCreate** | [**APISALESORDERSRVASalesOrderItemPrElementTypeCreate**](APISALESORDERSRVASalesOrderItemPrElementTypeCreate.md) | New entity |  |

### Return type

[**ASalesOrderItemPrElementType**](ASalesOrderItemPrElementType.md)

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

<a id="asalesorderitemprelementsalesordersalesordersalesorderitemsalesorderitempricingproceduresteppricingproceduresteppricingprocedurecounterpricingprocedurecounterdelete"></a>
# **ASalesOrderItemPrElementSalesOrderSalesOrderSalesOrderItemSalesOrderItemPricingProcedureStepPricingProcedureStepPricingProcedureCounterPricingProcedureCounterDelete**
> void ASalesOrderItemPrElementSalesOrderSalesOrderSalesOrderItemSalesOrderItemPricingProcedureStepPricingProcedureStepPricingProcedureCounterPricingProcedureCounterDelete (string salesOrder, string salesOrderItem, string pricingProcedureStep, string pricingProcedureCounter)

Deletes an item pricing element.

Deletes a pricing element of a specific sales order item. Consumers must pass the following key fields: sales order ID, item number, pricing procedure step, and pricing procedure counter.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ASalesOrderItemPrElementSalesOrderSalesOrderSalesOrderItemSalesOrderItemPricingProcedureStepPricingProcedureStepPricingProcedureCounterPricingProcedureCounterDeleteExample
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

            var apiInstance = new ItemPricingElementApi(config);
            var salesOrder = "salesOrder_example";  // string | Sales Order
            var salesOrderItem = "salesOrderItem_example";  // string | Sales Order Item
            var pricingProcedureStep = "pricingProcedureStep_example";  // string | Step Number
            var pricingProcedureCounter = "pricingProcedureCounter_example";  // string | Condition Counter

            try
            {
                // Deletes an item pricing element.
                apiInstance.ASalesOrderItemPrElementSalesOrderSalesOrderSalesOrderItemSalesOrderItemPricingProcedureStepPricingProcedureStepPricingProcedureCounterPricingProcedureCounterDelete(salesOrder, salesOrderItem, pricingProcedureStep, pricingProcedureCounter);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ItemPricingElementApi.ASalesOrderItemPrElementSalesOrderSalesOrderSalesOrderItemSalesOrderItemPricingProcedureStepPricingProcedureStepPricingProcedureCounterPricingProcedureCounterDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ASalesOrderItemPrElementSalesOrderSalesOrderSalesOrderItemSalesOrderItemPricingProcedureStepPricingProcedureStepPricingProcedureCounterPricingProcedureCounterDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deletes an item pricing element.
    apiInstance.ASalesOrderItemPrElementSalesOrderSalesOrderSalesOrderItemSalesOrderItemPricingProcedureStepPricingProcedureStepPricingProcedureCounterPricingProcedureCounterDeleteWithHttpInfo(salesOrder, salesOrderItem, pricingProcedureStep, pricingProcedureCounter);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ItemPricingElementApi.ASalesOrderItemPrElementSalesOrderSalesOrderSalesOrderItemSalesOrderItemPricingProcedureStepPricingProcedureStepPricingProcedureCounterPricingProcedureCounterDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **salesOrder** | **string** | Sales Order |  |
| **salesOrderItem** | **string** | Sales Order Item |  |
| **pricingProcedureStep** | **string** | Step Number |  |
| **pricingProcedureCounter** | **string** | Condition Counter |  |

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

<a id="asalesorderitemprelementsalesordersalesordersalesorderitemsalesorderitempricingproceduresteppricingproceduresteppricingprocedurecounterpricingprocedurecounterget"></a>
# **ASalesOrderItemPrElementSalesOrderSalesOrderSalesOrderItemSalesOrderItemPricingProcedureStepPricingProcedureStepPricingProcedureCounterPricingProcedureCounterGet**
> ASalesOrderItemPrElementType ASalesOrderItemPrElementSalesOrderSalesOrderSalesOrderItemSalesOrderItemPricingProcedureStepPricingProcedureStepPricingProcedureCounterPricingProcedureCounterGet (string salesOrder, string salesOrderItem, string pricingProcedureStep, string pricingProcedureCounter, List<string>? select = null, List<string>? expand = null)

Reads the pricing element of a item with specific pricing details.

Reads a specific item pricing element of a specific sales order. Consumers must pass the following key fields: sales order ID, item number, pricing procedure step, and pricing procedure counter.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ASalesOrderItemPrElementSalesOrderSalesOrderSalesOrderItemSalesOrderItemPricingProcedureStepPricingProcedureStepPricingProcedureCounterPricingProcedureCounterGetExample
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

            var apiInstance = new ItemPricingElementApi(config);
            var salesOrder = "salesOrder_example";  // string | Sales Order
            var salesOrderItem = "salesOrderItem_example";  // string | Sales Order Item
            var pricingProcedureStep = "pricingProcedureStep_example";  // string | Step Number
            var pricingProcedureCounter = "pricingProcedureCounter_example";  // string | Condition Counter
            var select = new List<string>?(); // List<string>? | Select properties to be returned, see [Select](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=68) (optional) 
            var expand = new List<string>?(); // List<string>? | Expand related entities, see [Expand](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=63) (optional) 

            try
            {
                // Reads the pricing element of a item with specific pricing details.
                ASalesOrderItemPrElementType result = apiInstance.ASalesOrderItemPrElementSalesOrderSalesOrderSalesOrderItemSalesOrderItemPricingProcedureStepPricingProcedureStepPricingProcedureCounterPricingProcedureCounterGet(salesOrder, salesOrderItem, pricingProcedureStep, pricingProcedureCounter, select, expand);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ItemPricingElementApi.ASalesOrderItemPrElementSalesOrderSalesOrderSalesOrderItemSalesOrderItemPricingProcedureStepPricingProcedureStepPricingProcedureCounterPricingProcedureCounterGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ASalesOrderItemPrElementSalesOrderSalesOrderSalesOrderItemSalesOrderItemPricingProcedureStepPricingProcedureStepPricingProcedureCounterPricingProcedureCounterGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Reads the pricing element of a item with specific pricing details.
    ApiResponse<ASalesOrderItemPrElementType> response = apiInstance.ASalesOrderItemPrElementSalesOrderSalesOrderSalesOrderItemSalesOrderItemPricingProcedureStepPricingProcedureStepPricingProcedureCounterPricingProcedureCounterGetWithHttpInfo(salesOrder, salesOrderItem, pricingProcedureStep, pricingProcedureCounter, select, expand);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ItemPricingElementApi.ASalesOrderItemPrElementSalesOrderSalesOrderSalesOrderItemSalesOrderItemPricingProcedureStepPricingProcedureStepPricingProcedureCounterPricingProcedureCounterGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **salesOrder** | **string** | Sales Order |  |
| **salesOrderItem** | **string** | Sales Order Item |  |
| **pricingProcedureStep** | **string** | Step Number |  |
| **pricingProcedureCounter** | **string** | Condition Counter |  |
| **select** | [**List&lt;string&gt;?**](string.md) | Select properties to be returned, see [Select](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page&#x3D;68) | [optional]  |
| **expand** | [**List&lt;string&gt;?**](string.md) | Expand related entities, see [Expand](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page&#x3D;63) | [optional]  |

### Return type

[**ASalesOrderItemPrElementType**](ASalesOrderItemPrElementType.md)

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

<a id="asalesorderitemprelementsalesordersalesordersalesorderitemsalesorderitempricingproceduresteppricingproceduresteppricingprocedurecounterpricingprocedurecounterpatch"></a>
# **ASalesOrderItemPrElementSalesOrderSalesOrderSalesOrderItemSalesOrderItemPricingProcedureStepPricingProcedureStepPricingProcedureCounterPricingProcedureCounterPatch**
> void ASalesOrderItemPrElementSalesOrderSalesOrderSalesOrderItemSalesOrderItemPricingProcedureStepPricingProcedureStepPricingProcedureCounterPricingProcedureCounterPatch (string salesOrder, string salesOrderItem, string pricingProcedureStep, string pricingProcedureCounter, ModifiedASalesOrderItemPrElementType modifiedASalesOrderItemPrElementType)

Updates an item pricing element.

Updates a pricing element of a specific sales order item. Consumers must pass the following key fields: sales order ID, item number, pricing procedure step, and pricing procedure counter.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ASalesOrderItemPrElementSalesOrderSalesOrderSalesOrderItemSalesOrderItemPricingProcedureStepPricingProcedureStepPricingProcedureCounterPricingProcedureCounterPatchExample
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

            var apiInstance = new ItemPricingElementApi(config);
            var salesOrder = "salesOrder_example";  // string | Sales Order
            var salesOrderItem = "salesOrderItem_example";  // string | Sales Order Item
            var pricingProcedureStep = "pricingProcedureStep_example";  // string | Step Number
            var pricingProcedureCounter = "pricingProcedureCounter_example";  // string | Condition Counter
            var modifiedASalesOrderItemPrElementType = new ModifiedASalesOrderItemPrElementType(); // ModifiedASalesOrderItemPrElementType | New property values

            try
            {
                // Updates an item pricing element.
                apiInstance.ASalesOrderItemPrElementSalesOrderSalesOrderSalesOrderItemSalesOrderItemPricingProcedureStepPricingProcedureStepPricingProcedureCounterPricingProcedureCounterPatch(salesOrder, salesOrderItem, pricingProcedureStep, pricingProcedureCounter, modifiedASalesOrderItemPrElementType);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ItemPricingElementApi.ASalesOrderItemPrElementSalesOrderSalesOrderSalesOrderItemSalesOrderItemPricingProcedureStepPricingProcedureStepPricingProcedureCounterPricingProcedureCounterPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ASalesOrderItemPrElementSalesOrderSalesOrderSalesOrderItemSalesOrderItemPricingProcedureStepPricingProcedureStepPricingProcedureCounterPricingProcedureCounterPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates an item pricing element.
    apiInstance.ASalesOrderItemPrElementSalesOrderSalesOrderSalesOrderItemSalesOrderItemPricingProcedureStepPricingProcedureStepPricingProcedureCounterPricingProcedureCounterPatchWithHttpInfo(salesOrder, salesOrderItem, pricingProcedureStep, pricingProcedureCounter, modifiedASalesOrderItemPrElementType);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ItemPricingElementApi.ASalesOrderItemPrElementSalesOrderSalesOrderSalesOrderItemSalesOrderItemPricingProcedureStepPricingProcedureStepPricingProcedureCounterPricingProcedureCounterPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **salesOrder** | **string** | Sales Order |  |
| **salesOrderItem** | **string** | Sales Order Item |  |
| **pricingProcedureStep** | **string** | Step Number |  |
| **pricingProcedureCounter** | **string** | Condition Counter |  |
| **modifiedASalesOrderItemPrElementType** | [**ModifiedASalesOrderItemPrElementType**](ModifiedASalesOrderItemPrElementType.md) | New property values |  |

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

<a id="asalesorderitemprelementsalesordersalesordersalesorderitemsalesorderitempricingproceduresteppricingproceduresteppricingprocedurecounterpricingprocedurecountertosalesorderget"></a>
# **ASalesOrderItemPrElementSalesOrderSalesOrderSalesOrderItemSalesOrderItemPricingProcedureStepPricingProcedureStepPricingProcedureCounterPricingProcedureCounterToSalesOrderGet**
> ASalesOrderType ASalesOrderItemPrElementSalesOrderSalesOrderSalesOrderItemSalesOrderItemPricingProcedureStepPricingProcedureStepPricingProcedureCounterPricingProcedureCounterToSalesOrderGet (string salesOrder, string salesOrderItem, string pricingProcedureStep, string pricingProcedureCounter, List<string>? select = null, List<string>? expand = null)

Reads the sales order header for a pricing element.

Reads the sales order header data for a specific pricing element of a specific sales order item. Consumers must pass the following key fields: sales order ID, item number, pricing procedure step, and pricing procedure counter.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ASalesOrderItemPrElementSalesOrderSalesOrderSalesOrderItemSalesOrderItemPricingProcedureStepPricingProcedureStepPricingProcedureCounterPricingProcedureCounterToSalesOrderGetExample
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

            var apiInstance = new ItemPricingElementApi(config);
            var salesOrder = "salesOrder_example";  // string | Sales Order
            var salesOrderItem = "salesOrderItem_example";  // string | Sales Order Item
            var pricingProcedureStep = "pricingProcedureStep_example";  // string | Step Number
            var pricingProcedureCounter = "pricingProcedureCounter_example";  // string | Condition Counter
            var select = new List<string>?(); // List<string>? | Select properties to be returned, see [Select](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=68) (optional) 
            var expand = new List<string>?(); // List<string>? | Expand related entities, see [Expand](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=63) (optional) 

            try
            {
                // Reads the sales order header for a pricing element.
                ASalesOrderType result = apiInstance.ASalesOrderItemPrElementSalesOrderSalesOrderSalesOrderItemSalesOrderItemPricingProcedureStepPricingProcedureStepPricingProcedureCounterPricingProcedureCounterToSalesOrderGet(salesOrder, salesOrderItem, pricingProcedureStep, pricingProcedureCounter, select, expand);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ItemPricingElementApi.ASalesOrderItemPrElementSalesOrderSalesOrderSalesOrderItemSalesOrderItemPricingProcedureStepPricingProcedureStepPricingProcedureCounterPricingProcedureCounterToSalesOrderGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ASalesOrderItemPrElementSalesOrderSalesOrderSalesOrderItemSalesOrderItemPricingProcedureStepPricingProcedureStepPricingProcedureCounterPricingProcedureCounterToSalesOrderGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Reads the sales order header for a pricing element.
    ApiResponse<ASalesOrderType> response = apiInstance.ASalesOrderItemPrElementSalesOrderSalesOrderSalesOrderItemSalesOrderItemPricingProcedureStepPricingProcedureStepPricingProcedureCounterPricingProcedureCounterToSalesOrderGetWithHttpInfo(salesOrder, salesOrderItem, pricingProcedureStep, pricingProcedureCounter, select, expand);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ItemPricingElementApi.ASalesOrderItemPrElementSalesOrderSalesOrderSalesOrderItemSalesOrderItemPricingProcedureStepPricingProcedureStepPricingProcedureCounterPricingProcedureCounterToSalesOrderGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **salesOrder** | **string** | Sales Order |  |
| **salesOrderItem** | **string** | Sales Order Item |  |
| **pricingProcedureStep** | **string** | Step Number |  |
| **pricingProcedureCounter** | **string** | Condition Counter |  |
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

<a id="asalesorderitemprelementsalesordersalesordersalesorderitemsalesorderitempricingproceduresteppricingproceduresteppricingprocedurecounterpricingprocedurecountertosalesorderitemget"></a>
# **ASalesOrderItemPrElementSalesOrderSalesOrderSalesOrderItemSalesOrderItemPricingProcedureStepPricingProcedureStepPricingProcedureCounterPricingProcedureCounterToSalesOrderItemGet**
> ASalesOrderItemType ASalesOrderItemPrElementSalesOrderSalesOrderSalesOrderItemSalesOrderItemPricingProcedureStepPricingProcedureStepPricingProcedureCounterPricingProcedureCounterToSalesOrderItemGet (string salesOrder, string salesOrderItem, string pricingProcedureStep, string pricingProcedureCounter, List<string>? select = null, List<string>? expand = null)

Reads the sales order item for a pricing element.

Reads the sales order item data for a specific pricing element of a specific sales order item. Consumers must pass the following key fields: sales order ID, item number, pricing procedure step, and pricing procedure counter.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ASalesOrderItemPrElementSalesOrderSalesOrderSalesOrderItemSalesOrderItemPricingProcedureStepPricingProcedureStepPricingProcedureCounterPricingProcedureCounterToSalesOrderItemGetExample
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

            var apiInstance = new ItemPricingElementApi(config);
            var salesOrder = "salesOrder_example";  // string | Sales Order
            var salesOrderItem = "salesOrderItem_example";  // string | Sales Order Item
            var pricingProcedureStep = "pricingProcedureStep_example";  // string | Step Number
            var pricingProcedureCounter = "pricingProcedureCounter_example";  // string | Condition Counter
            var select = new List<string>?(); // List<string>? | Select properties to be returned, see [Select](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=68) (optional) 
            var expand = new List<string>?(); // List<string>? | Expand related entities, see [Expand](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=63) (optional) 

            try
            {
                // Reads the sales order item for a pricing element.
                ASalesOrderItemType result = apiInstance.ASalesOrderItemPrElementSalesOrderSalesOrderSalesOrderItemSalesOrderItemPricingProcedureStepPricingProcedureStepPricingProcedureCounterPricingProcedureCounterToSalesOrderItemGet(salesOrder, salesOrderItem, pricingProcedureStep, pricingProcedureCounter, select, expand);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ItemPricingElementApi.ASalesOrderItemPrElementSalesOrderSalesOrderSalesOrderItemSalesOrderItemPricingProcedureStepPricingProcedureStepPricingProcedureCounterPricingProcedureCounterToSalesOrderItemGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ASalesOrderItemPrElementSalesOrderSalesOrderSalesOrderItemSalesOrderItemPricingProcedureStepPricingProcedureStepPricingProcedureCounterPricingProcedureCounterToSalesOrderItemGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Reads the sales order item for a pricing element.
    ApiResponse<ASalesOrderItemType> response = apiInstance.ASalesOrderItemPrElementSalesOrderSalesOrderSalesOrderItemSalesOrderItemPricingProcedureStepPricingProcedureStepPricingProcedureCounterPricingProcedureCounterToSalesOrderItemGetWithHttpInfo(salesOrder, salesOrderItem, pricingProcedureStep, pricingProcedureCounter, select, expand);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ItemPricingElementApi.ASalesOrderItemPrElementSalesOrderSalesOrderSalesOrderItemSalesOrderItemPricingProcedureStepPricingProcedureStepPricingProcedureCounterPricingProcedureCounterToSalesOrderItemGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **salesOrder** | **string** | Sales Order |  |
| **salesOrderItem** | **string** | Sales Order Item |  |
| **pricingProcedureStep** | **string** | Step Number |  |
| **pricingProcedureCounter** | **string** | Condition Counter |  |
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

<a id="asalesorderitemsalesordersalesordersalesorderitemsalesorderitemtopricingelementget"></a>
# **ASalesOrderItemSalesOrderSalesOrderSalesOrderItemSalesOrderItemToPricingElementGet**
> Wrapper14 ASalesOrderItemSalesOrderSalesOrderSalesOrderItemSalesOrderItemToPricingElementGet (string salesOrder, string salesOrderItem, int? top = null, int? skip = null, string? filter = null, string? inlinecount = null, List<string>? orderby = null, List<string>? select = null, List<string>? expand = null)

Reads the pricing element of a sales order item.

Reads the pricing element data for a specific item of a specific sales order. Consumers must pass the following key fields: sales order ID and item number.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ASalesOrderItemSalesOrderSalesOrderSalesOrderItemSalesOrderItemToPricingElementGetExample
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

            var apiInstance = new ItemPricingElementApi(config);
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
                // Reads the pricing element of a sales order item.
                Wrapper14 result = apiInstance.ASalesOrderItemSalesOrderSalesOrderSalesOrderItemSalesOrderItemToPricingElementGet(salesOrder, salesOrderItem, top, skip, filter, inlinecount, orderby, select, expand);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ItemPricingElementApi.ASalesOrderItemSalesOrderSalesOrderSalesOrderItemSalesOrderItemToPricingElementGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ASalesOrderItemSalesOrderSalesOrderSalesOrderItemSalesOrderItemToPricingElementGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Reads the pricing element of a sales order item.
    ApiResponse<Wrapper14> response = apiInstance.ASalesOrderItemSalesOrderSalesOrderSalesOrderItemSalesOrderItemToPricingElementGetWithHttpInfo(salesOrder, salesOrderItem, top, skip, filter, inlinecount, orderby, select, expand);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ItemPricingElementApi.ASalesOrderItemSalesOrderSalesOrderSalesOrderItemSalesOrderItemToPricingElementGetWithHttpInfo: " + e.Message);
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

[**Wrapper14**](Wrapper14.md)

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

<a id="asalesorderitemsalesordersalesordersalesorderitemsalesorderitemtopricingelementpost"></a>
# **ASalesOrderItemSalesOrderSalesOrderSalesOrderItemSalesOrderItemToPricingElementPost**
> ASalesOrderItemPrElementType ASalesOrderItemSalesOrderSalesOrderSalesOrderItemSalesOrderItemToPricingElementPost (string salesOrder, string salesOrderItem, APISALESORDERSRVASalesOrderItemPrElementTypeCreate aPISALESORDERSRVASalesOrderItemPrElementTypeCreate)

Creates a pricing element for a specific sales order item.

Creates the pricing element data for a specific item of a specific sales order. Consumers must pass the following key fields: sales order ID and item number.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ASalesOrderItemSalesOrderSalesOrderSalesOrderItemSalesOrderItemToPricingElementPostExample
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

            var apiInstance = new ItemPricingElementApi(config);
            var salesOrder = "salesOrder_example";  // string | Sales Order
            var salesOrderItem = "salesOrderItem_example";  // string | Sales Order Item
            var aPISALESORDERSRVASalesOrderItemPrElementTypeCreate = new APISALESORDERSRVASalesOrderItemPrElementTypeCreate(); // APISALESORDERSRVASalesOrderItemPrElementTypeCreate | New entity

            try
            {
                // Creates a pricing element for a specific sales order item.
                ASalesOrderItemPrElementType result = apiInstance.ASalesOrderItemSalesOrderSalesOrderSalesOrderItemSalesOrderItemToPricingElementPost(salesOrder, salesOrderItem, aPISALESORDERSRVASalesOrderItemPrElementTypeCreate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ItemPricingElementApi.ASalesOrderItemSalesOrderSalesOrderSalesOrderItemSalesOrderItemToPricingElementPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ASalesOrderItemSalesOrderSalesOrderSalesOrderItemSalesOrderItemToPricingElementPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a pricing element for a specific sales order item.
    ApiResponse<ASalesOrderItemPrElementType> response = apiInstance.ASalesOrderItemSalesOrderSalesOrderSalesOrderItemSalesOrderItemToPricingElementPostWithHttpInfo(salesOrder, salesOrderItem, aPISALESORDERSRVASalesOrderItemPrElementTypeCreate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ItemPricingElementApi.ASalesOrderItemSalesOrderSalesOrderSalesOrderItemSalesOrderItemToPricingElementPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **salesOrder** | **string** | Sales Order |  |
| **salesOrderItem** | **string** | Sales Order Item |  |
| **aPISALESORDERSRVASalesOrderItemPrElementTypeCreate** | [**APISALESORDERSRVASalesOrderItemPrElementTypeCreate**](APISALESORDERSRVASalesOrderItemPrElementTypeCreate.md) | New entity |  |

### Return type

[**ASalesOrderItemPrElementType**](ASalesOrderItemPrElementType.md)

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

