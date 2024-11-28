# Org.OpenAPITools.Api.ItemBillingPlanApi

All URIs are relative to *https://:/sap/opu/odata/sap/API_SALES_ORDER_SRV*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ASalesOrderItemBillingPlanGet**](ItemBillingPlanApi.md#asalesorderitembillingplanget) | **GET** /A_SalesOrderItemBillingPlan | Reads the billing plans of all sales order items. |
| [**ASalesOrderItemBillingPlanSalesOrderSalesOrderSalesOrderItemSalesOrderItemBillingPlanBillingPlanGet**](ItemBillingPlanApi.md#asalesorderitembillingplansalesordersalesordersalesorderitemsalesorderitembillingplanbillingplanget) | **GET** /A_SalesOrderItemBillingPlan(SalesOrder&#x3D;&#39;{SalesOrder}&#39;,SalesOrderItem&#x3D;&#39;{SalesOrderItem}&#39;,BillingPlan&#x3D;&#39;{BillingPlan}&#39;) | Reads the billing plan of a sales order item. |
| [**ASalesOrderItemBillingPlanSalesOrderSalesOrderSalesOrderItemSalesOrderItemBillingPlanBillingPlanPatch**](ItemBillingPlanApi.md#asalesorderitembillingplansalesordersalesordersalesorderitemsalesorderitembillingplanbillingplanpatch) | **PATCH** /A_SalesOrderItemBillingPlan(SalesOrder&#x3D;&#39;{SalesOrder}&#39;,SalesOrderItem&#x3D;&#39;{SalesOrderItem}&#39;,BillingPlan&#x3D;&#39;{BillingPlan}&#39;) | Updates the billing plan of a sales order item. |
| [**ASalesOrderItemBillingPlanSalesOrderSalesOrderSalesOrderItemSalesOrderItemBillingPlanBillingPlanToBillingPlanItemGet**](ItemBillingPlanApi.md#asalesorderitembillingplansalesordersalesordersalesorderitemsalesorderitembillingplanbillingplantobillingplanitemget) | **GET** /A_SalesOrderItemBillingPlan(SalesOrder&#x3D;&#39;{SalesOrder}&#39;,SalesOrderItem&#x3D;&#39;{SalesOrderItem}&#39;,BillingPlan&#x3D;&#39;{BillingPlan}&#39;)/to_BillingPlanItem | Reads the billing plan items of a sales order item billing plan. |
| [**ASalesOrderItemBillingPlanSalesOrderSalesOrderSalesOrderItemSalesOrderItemBillingPlanBillingPlanToBillingPlanItemPost**](ItemBillingPlanApi.md#asalesorderitembillingplansalesordersalesordersalesorderitemsalesorderitembillingplanbillingplantobillingplanitempost) | **POST** /A_SalesOrderItemBillingPlan(SalesOrder&#x3D;&#39;{SalesOrder}&#39;,SalesOrderItem&#x3D;&#39;{SalesOrderItem}&#39;,BillingPlan&#x3D;&#39;{BillingPlan}&#39;)/to_BillingPlanItem | Creates a billing plan item for a sales order item billing plan. |
| [**ASalesOrderItemBillingPlanSalesOrderSalesOrderSalesOrderItemSalesOrderItemBillingPlanBillingPlanToSalesOrderGet**](ItemBillingPlanApi.md#asalesorderitembillingplansalesordersalesordersalesorderitemsalesorderitembillingplanbillingplantosalesorderget) | **GET** /A_SalesOrderItemBillingPlan(SalesOrder&#x3D;&#39;{SalesOrder}&#39;,SalesOrderItem&#x3D;&#39;{SalesOrderItem}&#39;,BillingPlan&#x3D;&#39;{BillingPlan}&#39;)/to_SalesOrder | Reads the sales order header for an item billing plan. |
| [**ASalesOrderItemBillingPlanSalesOrderSalesOrderSalesOrderItemSalesOrderItemBillingPlanBillingPlanToSalesOrderItemGet**](ItemBillingPlanApi.md#asalesorderitembillingplansalesordersalesordersalesorderitemsalesorderitembillingplanbillingplantosalesorderitemget) | **GET** /A_SalesOrderItemBillingPlan(SalesOrder&#x3D;&#39;{SalesOrder}&#39;,SalesOrderItem&#x3D;&#39;{SalesOrderItem}&#39;,BillingPlan&#x3D;&#39;{BillingPlan}&#39;)/to_SalesOrderItem | Reads the sales order item for an item billing plan. |
| [**ASalesOrderItemSalesOrderSalesOrderSalesOrderItemSalesOrderItemToBillingPlanGet**](ItemBillingPlanApi.md#asalesorderitemsalesordersalesordersalesorderitemsalesorderitemtobillingplanget) | **GET** /A_SalesOrderItem(SalesOrder&#x3D;&#39;{SalesOrder}&#39;,SalesOrderItem&#x3D;&#39;{SalesOrderItem}&#39;)/to_BillingPlan | Reads the billing plan of a sales order item. |
| [**ASlsOrderItemBillingPlanItemSalesOrderSalesOrderSalesOrderItemSalesOrderItemBillingPlanBillingPlanBillingPlanItemBillingPlanItemToBillingPlanGet**](ItemBillingPlanApi.md#aslsorderitembillingplanitemsalesordersalesordersalesorderitemsalesorderitembillingplanbillingplanbillingplanitembillingplanitemtobillingplanget) | **GET** /A_SlsOrderItemBillingPlanItem(SalesOrder&#x3D;&#39;{SalesOrder}&#39;,SalesOrderItem&#x3D;&#39;{SalesOrderItem}&#39;,BillingPlan&#x3D;&#39;{BillingPlan}&#39;,BillingPlanItem&#x3D;&#39;{BillingPlanItem}&#39;)/to_BillingPlan | Reads the item billing plan for an item billing plan item. |

<a id="asalesorderitembillingplanget"></a>
# **ASalesOrderItemBillingPlanGet**
> Wrapper19 ASalesOrderItemBillingPlanGet (int? top = null, int? skip = null, string? filter = null, string? inlinecount = null, List<string>? orderby = null, List<string>? select = null, List<string>? expand = null)

Reads the billing plans of all sales order items.

Reads the billing plan data from the items of all sales orders in the system.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ASalesOrderItemBillingPlanGetExample
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

            var apiInstance = new ItemBillingPlanApi(config);
            var top = 50;  // int? | Show only the first n items, see [Paging - Top](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=66) (optional) 
            var skip = 56;  // int? | Skip the first n items, see [Paging - Skip](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=65) (optional) 
            var filter = "filter_example";  // string? | Filter items by property values, see [Filtering](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=64) (optional) 
            var inlinecount = "allpages";  // string? | Include count of items, see [Inlinecount](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=67) (optional) 
            var orderby = new List<string>?(); // List<string>? | Order items by property values, see [Sorting](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=65) (optional) 
            var select = new List<string>?(); // List<string>? | Select properties to be returned, see [Select](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=68) (optional) 
            var expand = new List<string>?(); // List<string>? | Expand related entities, see [Expand](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=63) (optional) 

            try
            {
                // Reads the billing plans of all sales order items.
                Wrapper19 result = apiInstance.ASalesOrderItemBillingPlanGet(top, skip, filter, inlinecount, orderby, select, expand);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ItemBillingPlanApi.ASalesOrderItemBillingPlanGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ASalesOrderItemBillingPlanGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Reads the billing plans of all sales order items.
    ApiResponse<Wrapper19> response = apiInstance.ASalesOrderItemBillingPlanGetWithHttpInfo(top, skip, filter, inlinecount, orderby, select, expand);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ItemBillingPlanApi.ASalesOrderItemBillingPlanGetWithHttpInfo: " + e.Message);
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

[**Wrapper19**](Wrapper19.md)

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

<a id="asalesorderitembillingplansalesordersalesordersalesorderitemsalesorderitembillingplanbillingplanget"></a>
# **ASalesOrderItemBillingPlanSalesOrderSalesOrderSalesOrderItemSalesOrderItemBillingPlanBillingPlanGet**
> ASalesOrderItemBillingPlanType ASalesOrderItemBillingPlanSalesOrderSalesOrderSalesOrderItemSalesOrderItemBillingPlanBillingPlanGet (string salesOrder, string salesOrderItem, string billingPlan, List<string>? select = null, List<string>? expand = null)

Reads the billing plan of a sales order item.

Reads the billing plan of a specific sales order item. Consumers must pass the following key fields: sales order ID, item number, and number of the item billing plan.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ASalesOrderItemBillingPlanSalesOrderSalesOrderSalesOrderItemSalesOrderItemBillingPlanBillingPlanGetExample
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

            var apiInstance = new ItemBillingPlanApi(config);
            var salesOrder = "salesOrder_example";  // string | Sales Order
            var salesOrderItem = "salesOrderItem_example";  // string | Sales Order Item
            var billingPlan = "billingPlan_example";  // string | Billing/Invoicing Plan Number
            var select = new List<string>?(); // List<string>? | Select properties to be returned, see [Select](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=68) (optional) 
            var expand = new List<string>?(); // List<string>? | Expand related entities, see [Expand](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=63) (optional) 

            try
            {
                // Reads the billing plan of a sales order item.
                ASalesOrderItemBillingPlanType result = apiInstance.ASalesOrderItemBillingPlanSalesOrderSalesOrderSalesOrderItemSalesOrderItemBillingPlanBillingPlanGet(salesOrder, salesOrderItem, billingPlan, select, expand);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ItemBillingPlanApi.ASalesOrderItemBillingPlanSalesOrderSalesOrderSalesOrderItemSalesOrderItemBillingPlanBillingPlanGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ASalesOrderItemBillingPlanSalesOrderSalesOrderSalesOrderItemSalesOrderItemBillingPlanBillingPlanGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Reads the billing plan of a sales order item.
    ApiResponse<ASalesOrderItemBillingPlanType> response = apiInstance.ASalesOrderItemBillingPlanSalesOrderSalesOrderSalesOrderItemSalesOrderItemBillingPlanBillingPlanGetWithHttpInfo(salesOrder, salesOrderItem, billingPlan, select, expand);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ItemBillingPlanApi.ASalesOrderItemBillingPlanSalesOrderSalesOrderSalesOrderItemSalesOrderItemBillingPlanBillingPlanGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **salesOrder** | **string** | Sales Order |  |
| **salesOrderItem** | **string** | Sales Order Item |  |
| **billingPlan** | **string** | Billing/Invoicing Plan Number |  |
| **select** | [**List&lt;string&gt;?**](string.md) | Select properties to be returned, see [Select](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page&#x3D;68) | [optional]  |
| **expand** | [**List&lt;string&gt;?**](string.md) | Expand related entities, see [Expand](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page&#x3D;63) | [optional]  |

### Return type

[**ASalesOrderItemBillingPlanType**](ASalesOrderItemBillingPlanType.md)

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

<a id="asalesorderitembillingplansalesordersalesordersalesorderitemsalesorderitembillingplanbillingplanpatch"></a>
# **ASalesOrderItemBillingPlanSalesOrderSalesOrderSalesOrderItemSalesOrderItemBillingPlanBillingPlanPatch**
> void ASalesOrderItemBillingPlanSalesOrderSalesOrderSalesOrderItemSalesOrderItemBillingPlanBillingPlanPatch (string salesOrder, string salesOrderItem, string billingPlan, ModifiedASalesOrderItemBillingPlanType modifiedASalesOrderItemBillingPlanType)

Updates the billing plan of a sales order item.

Updates the billing plan of a specific sales order item. Consumers must pass the following key fields: sales order ID, item number, and number of the item billing plan.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ASalesOrderItemBillingPlanSalesOrderSalesOrderSalesOrderItemSalesOrderItemBillingPlanBillingPlanPatchExample
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

            var apiInstance = new ItemBillingPlanApi(config);
            var salesOrder = "salesOrder_example";  // string | Sales Order
            var salesOrderItem = "salesOrderItem_example";  // string | Sales Order Item
            var billingPlan = "billingPlan_example";  // string | Billing/Invoicing Plan Number
            var modifiedASalesOrderItemBillingPlanType = new ModifiedASalesOrderItemBillingPlanType(); // ModifiedASalesOrderItemBillingPlanType | New property values

            try
            {
                // Updates the billing plan of a sales order item.
                apiInstance.ASalesOrderItemBillingPlanSalesOrderSalesOrderSalesOrderItemSalesOrderItemBillingPlanBillingPlanPatch(salesOrder, salesOrderItem, billingPlan, modifiedASalesOrderItemBillingPlanType);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ItemBillingPlanApi.ASalesOrderItemBillingPlanSalesOrderSalesOrderSalesOrderItemSalesOrderItemBillingPlanBillingPlanPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ASalesOrderItemBillingPlanSalesOrderSalesOrderSalesOrderItemSalesOrderItemBillingPlanBillingPlanPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates the billing plan of a sales order item.
    apiInstance.ASalesOrderItemBillingPlanSalesOrderSalesOrderSalesOrderItemSalesOrderItemBillingPlanBillingPlanPatchWithHttpInfo(salesOrder, salesOrderItem, billingPlan, modifiedASalesOrderItemBillingPlanType);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ItemBillingPlanApi.ASalesOrderItemBillingPlanSalesOrderSalesOrderSalesOrderItemSalesOrderItemBillingPlanBillingPlanPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **salesOrder** | **string** | Sales Order |  |
| **salesOrderItem** | **string** | Sales Order Item |  |
| **billingPlan** | **string** | Billing/Invoicing Plan Number |  |
| **modifiedASalesOrderItemBillingPlanType** | [**ModifiedASalesOrderItemBillingPlanType**](ModifiedASalesOrderItemBillingPlanType.md) | New property values |  |

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

<a id="asalesorderitembillingplansalesordersalesordersalesorderitemsalesorderitembillingplanbillingplantobillingplanitemget"></a>
# **ASalesOrderItemBillingPlanSalesOrderSalesOrderSalesOrderItemSalesOrderItemBillingPlanBillingPlanToBillingPlanItemGet**
> Wrapper20 ASalesOrderItemBillingPlanSalesOrderSalesOrderSalesOrderItemSalesOrderItemBillingPlanBillingPlanToBillingPlanItemGet (string salesOrder, string salesOrderItem, string billingPlan, int? top = null, int? skip = null, string? filter = null, string? inlinecount = null, List<string>? orderby = null, List<string>? select = null, List<string>? expand = null)

Reads the billing plan items of a sales order item billing plan.

Reads the billing plan item data for a specific sales order item billing plan. Consumers must pass the following key fields: sales order ID, item number, and number of the item billing plan.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ASalesOrderItemBillingPlanSalesOrderSalesOrderSalesOrderItemSalesOrderItemBillingPlanBillingPlanToBillingPlanItemGetExample
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

            var apiInstance = new ItemBillingPlanApi(config);
            var salesOrder = "salesOrder_example";  // string | Sales Order
            var salesOrderItem = "salesOrderItem_example";  // string | Sales Order Item
            var billingPlan = "billingPlan_example";  // string | Billing/Invoicing Plan Number
            var top = 50;  // int? | Show only the first n items, see [Paging - Top](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=66) (optional) 
            var skip = 56;  // int? | Skip the first n items, see [Paging - Skip](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=65) (optional) 
            var filter = "filter_example";  // string? | Filter items by property values, see [Filtering](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=64) (optional) 
            var inlinecount = "allpages";  // string? | Include count of items, see [Inlinecount](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=67) (optional) 
            var orderby = new List<string>?(); // List<string>? | Order items by property values, see [Sorting](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=65) (optional) 
            var select = new List<string>?(); // List<string>? | Select properties to be returned, see [Select](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=68) (optional) 
            var expand = new List<string>?(); // List<string>? | Expand related entities, see [Expand](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=63) (optional) 

            try
            {
                // Reads the billing plan items of a sales order item billing plan.
                Wrapper20 result = apiInstance.ASalesOrderItemBillingPlanSalesOrderSalesOrderSalesOrderItemSalesOrderItemBillingPlanBillingPlanToBillingPlanItemGet(salesOrder, salesOrderItem, billingPlan, top, skip, filter, inlinecount, orderby, select, expand);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ItemBillingPlanApi.ASalesOrderItemBillingPlanSalesOrderSalesOrderSalesOrderItemSalesOrderItemBillingPlanBillingPlanToBillingPlanItemGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ASalesOrderItemBillingPlanSalesOrderSalesOrderSalesOrderItemSalesOrderItemBillingPlanBillingPlanToBillingPlanItemGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Reads the billing plan items of a sales order item billing plan.
    ApiResponse<Wrapper20> response = apiInstance.ASalesOrderItemBillingPlanSalesOrderSalesOrderSalesOrderItemSalesOrderItemBillingPlanBillingPlanToBillingPlanItemGetWithHttpInfo(salesOrder, salesOrderItem, billingPlan, top, skip, filter, inlinecount, orderby, select, expand);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ItemBillingPlanApi.ASalesOrderItemBillingPlanSalesOrderSalesOrderSalesOrderItemSalesOrderItemBillingPlanBillingPlanToBillingPlanItemGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **salesOrder** | **string** | Sales Order |  |
| **salesOrderItem** | **string** | Sales Order Item |  |
| **billingPlan** | **string** | Billing/Invoicing Plan Number |  |
| **top** | **int?** | Show only the first n items, see [Paging - Top](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page&#x3D;66) | [optional]  |
| **skip** | **int?** | Skip the first n items, see [Paging - Skip](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page&#x3D;65) | [optional]  |
| **filter** | **string?** | Filter items by property values, see [Filtering](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page&#x3D;64) | [optional]  |
| **inlinecount** | **string?** | Include count of items, see [Inlinecount](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page&#x3D;67) | [optional]  |
| **orderby** | [**List&lt;string&gt;?**](string.md) | Order items by property values, see [Sorting](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page&#x3D;65) | [optional]  |
| **select** | [**List&lt;string&gt;?**](string.md) | Select properties to be returned, see [Select](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page&#x3D;68) | [optional]  |
| **expand** | [**List&lt;string&gt;?**](string.md) | Expand related entities, see [Expand](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page&#x3D;63) | [optional]  |

### Return type

[**Wrapper20**](Wrapper20.md)

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

<a id="asalesorderitembillingplansalesordersalesordersalesorderitemsalesorderitembillingplanbillingplantobillingplanitempost"></a>
# **ASalesOrderItemBillingPlanSalesOrderSalesOrderSalesOrderItemSalesOrderItemBillingPlanBillingPlanToBillingPlanItemPost**
> ASlsOrderItemBillingPlanItemType ASalesOrderItemBillingPlanSalesOrderSalesOrderSalesOrderItemSalesOrderItemBillingPlanBillingPlanToBillingPlanItemPost (string salesOrder, string salesOrderItem, string billingPlan, APISALESORDERSRVASlsOrderItemBillingPlanItemTypeCreate aPISALESORDERSRVASlsOrderItemBillingPlanItemTypeCreate)

Creates a billing plan item for a sales order item billing plan.

Creates a billing plan item for a specific sales order item billing plan. Consumers must pass the following key fields: sales order ID, item number, and number of the item billing plan.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ASalesOrderItemBillingPlanSalesOrderSalesOrderSalesOrderItemSalesOrderItemBillingPlanBillingPlanToBillingPlanItemPostExample
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

            var apiInstance = new ItemBillingPlanApi(config);
            var salesOrder = "salesOrder_example";  // string | Sales Order
            var salesOrderItem = "salesOrderItem_example";  // string | Sales Order Item
            var billingPlan = "billingPlan_example";  // string | Billing/Invoicing Plan Number
            var aPISALESORDERSRVASlsOrderItemBillingPlanItemTypeCreate = new APISALESORDERSRVASlsOrderItemBillingPlanItemTypeCreate(); // APISALESORDERSRVASlsOrderItemBillingPlanItemTypeCreate | New entity

            try
            {
                // Creates a billing plan item for a sales order item billing plan.
                ASlsOrderItemBillingPlanItemType result = apiInstance.ASalesOrderItemBillingPlanSalesOrderSalesOrderSalesOrderItemSalesOrderItemBillingPlanBillingPlanToBillingPlanItemPost(salesOrder, salesOrderItem, billingPlan, aPISALESORDERSRVASlsOrderItemBillingPlanItemTypeCreate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ItemBillingPlanApi.ASalesOrderItemBillingPlanSalesOrderSalesOrderSalesOrderItemSalesOrderItemBillingPlanBillingPlanToBillingPlanItemPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ASalesOrderItemBillingPlanSalesOrderSalesOrderSalesOrderItemSalesOrderItemBillingPlanBillingPlanToBillingPlanItemPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a billing plan item for a sales order item billing plan.
    ApiResponse<ASlsOrderItemBillingPlanItemType> response = apiInstance.ASalesOrderItemBillingPlanSalesOrderSalesOrderSalesOrderItemSalesOrderItemBillingPlanBillingPlanToBillingPlanItemPostWithHttpInfo(salesOrder, salesOrderItem, billingPlan, aPISALESORDERSRVASlsOrderItemBillingPlanItemTypeCreate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ItemBillingPlanApi.ASalesOrderItemBillingPlanSalesOrderSalesOrderSalesOrderItemSalesOrderItemBillingPlanBillingPlanToBillingPlanItemPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **salesOrder** | **string** | Sales Order |  |
| **salesOrderItem** | **string** | Sales Order Item |  |
| **billingPlan** | **string** | Billing/Invoicing Plan Number |  |
| **aPISALESORDERSRVASlsOrderItemBillingPlanItemTypeCreate** | [**APISALESORDERSRVASlsOrderItemBillingPlanItemTypeCreate**](APISALESORDERSRVASlsOrderItemBillingPlanItemTypeCreate.md) | New entity |  |

### Return type

[**ASlsOrderItemBillingPlanItemType**](ASlsOrderItemBillingPlanItemType.md)

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

<a id="asalesorderitembillingplansalesordersalesordersalesorderitemsalesorderitembillingplanbillingplantosalesorderget"></a>
# **ASalesOrderItemBillingPlanSalesOrderSalesOrderSalesOrderItemSalesOrderItemBillingPlanBillingPlanToSalesOrderGet**
> ASalesOrderType ASalesOrderItemBillingPlanSalesOrderSalesOrderSalesOrderItemSalesOrderItemBillingPlanBillingPlanToSalesOrderGet (string salesOrder, string salesOrderItem, string billingPlan, List<string>? select = null, List<string>? expand = null)

Reads the sales order header for an item billing plan.

Reads the sales order header data for a specific item billing plan. Consumers must pass the following key fields: sales order ID, item number, and number of the item billing plan.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ASalesOrderItemBillingPlanSalesOrderSalesOrderSalesOrderItemSalesOrderItemBillingPlanBillingPlanToSalesOrderGetExample
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

            var apiInstance = new ItemBillingPlanApi(config);
            var salesOrder = "salesOrder_example";  // string | Sales Order
            var salesOrderItem = "salesOrderItem_example";  // string | Sales Order Item
            var billingPlan = "billingPlan_example";  // string | Billing/Invoicing Plan Number
            var select = new List<string>?(); // List<string>? | Select properties to be returned, see [Select](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=68) (optional) 
            var expand = new List<string>?(); // List<string>? | Expand related entities, see [Expand](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=63) (optional) 

            try
            {
                // Reads the sales order header for an item billing plan.
                ASalesOrderType result = apiInstance.ASalesOrderItemBillingPlanSalesOrderSalesOrderSalesOrderItemSalesOrderItemBillingPlanBillingPlanToSalesOrderGet(salesOrder, salesOrderItem, billingPlan, select, expand);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ItemBillingPlanApi.ASalesOrderItemBillingPlanSalesOrderSalesOrderSalesOrderItemSalesOrderItemBillingPlanBillingPlanToSalesOrderGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ASalesOrderItemBillingPlanSalesOrderSalesOrderSalesOrderItemSalesOrderItemBillingPlanBillingPlanToSalesOrderGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Reads the sales order header for an item billing plan.
    ApiResponse<ASalesOrderType> response = apiInstance.ASalesOrderItemBillingPlanSalesOrderSalesOrderSalesOrderItemSalesOrderItemBillingPlanBillingPlanToSalesOrderGetWithHttpInfo(salesOrder, salesOrderItem, billingPlan, select, expand);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ItemBillingPlanApi.ASalesOrderItemBillingPlanSalesOrderSalesOrderSalesOrderItemSalesOrderItemBillingPlanBillingPlanToSalesOrderGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **salesOrder** | **string** | Sales Order |  |
| **salesOrderItem** | **string** | Sales Order Item |  |
| **billingPlan** | **string** | Billing/Invoicing Plan Number |  |
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

<a id="asalesorderitembillingplansalesordersalesordersalesorderitemsalesorderitembillingplanbillingplantosalesorderitemget"></a>
# **ASalesOrderItemBillingPlanSalesOrderSalesOrderSalesOrderItemSalesOrderItemBillingPlanBillingPlanToSalesOrderItemGet**
> ASalesOrderItemType ASalesOrderItemBillingPlanSalesOrderSalesOrderSalesOrderItemSalesOrderItemBillingPlanBillingPlanToSalesOrderItemGet (string salesOrder, string salesOrderItem, string billingPlan, List<string>? select = null, List<string>? expand = null)

Reads the sales order item for an item billing plan.

Reads the sales order item data for a specific item billing plan. Consumers must pass the following key fields: sales order ID, item number, and number of the item billing plan.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ASalesOrderItemBillingPlanSalesOrderSalesOrderSalesOrderItemSalesOrderItemBillingPlanBillingPlanToSalesOrderItemGetExample
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

            var apiInstance = new ItemBillingPlanApi(config);
            var salesOrder = "salesOrder_example";  // string | Sales Order
            var salesOrderItem = "salesOrderItem_example";  // string | Sales Order Item
            var billingPlan = "billingPlan_example";  // string | Billing/Invoicing Plan Number
            var select = new List<string>?(); // List<string>? | Select properties to be returned, see [Select](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=68) (optional) 
            var expand = new List<string>?(); // List<string>? | Expand related entities, see [Expand](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=63) (optional) 

            try
            {
                // Reads the sales order item for an item billing plan.
                ASalesOrderItemType result = apiInstance.ASalesOrderItemBillingPlanSalesOrderSalesOrderSalesOrderItemSalesOrderItemBillingPlanBillingPlanToSalesOrderItemGet(salesOrder, salesOrderItem, billingPlan, select, expand);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ItemBillingPlanApi.ASalesOrderItemBillingPlanSalesOrderSalesOrderSalesOrderItemSalesOrderItemBillingPlanBillingPlanToSalesOrderItemGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ASalesOrderItemBillingPlanSalesOrderSalesOrderSalesOrderItemSalesOrderItemBillingPlanBillingPlanToSalesOrderItemGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Reads the sales order item for an item billing plan.
    ApiResponse<ASalesOrderItemType> response = apiInstance.ASalesOrderItemBillingPlanSalesOrderSalesOrderSalesOrderItemSalesOrderItemBillingPlanBillingPlanToSalesOrderItemGetWithHttpInfo(salesOrder, salesOrderItem, billingPlan, select, expand);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ItemBillingPlanApi.ASalesOrderItemBillingPlanSalesOrderSalesOrderSalesOrderItemSalesOrderItemBillingPlanBillingPlanToSalesOrderItemGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **salesOrder** | **string** | Sales Order |  |
| **salesOrderItem** | **string** | Sales Order Item |  |
| **billingPlan** | **string** | Billing/Invoicing Plan Number |  |
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

<a id="asalesorderitemsalesordersalesordersalesorderitemsalesorderitemtobillingplanget"></a>
# **ASalesOrderItemSalesOrderSalesOrderSalesOrderItemSalesOrderItemToBillingPlanGet**
> ASalesOrderItemBillingPlanType ASalesOrderItemSalesOrderSalesOrderSalesOrderItemSalesOrderItemToBillingPlanGet (string salesOrder, string salesOrderItem, List<string>? select = null, List<string>? expand = null)

Reads the billing plan of a sales order item.

Reads the billing plan data for a specific sales order item. Consumers must pass the following key fields: sales order ID and item number.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ASalesOrderItemSalesOrderSalesOrderSalesOrderItemSalesOrderItemToBillingPlanGetExample
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

            var apiInstance = new ItemBillingPlanApi(config);
            var salesOrder = "salesOrder_example";  // string | Sales Order
            var salesOrderItem = "salesOrderItem_example";  // string | Sales Order Item
            var select = new List<string>?(); // List<string>? | Select properties to be returned, see [Select](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=68) (optional) 
            var expand = new List<string>?(); // List<string>? | Expand related entities, see [Expand](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=63) (optional) 

            try
            {
                // Reads the billing plan of a sales order item.
                ASalesOrderItemBillingPlanType result = apiInstance.ASalesOrderItemSalesOrderSalesOrderSalesOrderItemSalesOrderItemToBillingPlanGet(salesOrder, salesOrderItem, select, expand);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ItemBillingPlanApi.ASalesOrderItemSalesOrderSalesOrderSalesOrderItemSalesOrderItemToBillingPlanGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ASalesOrderItemSalesOrderSalesOrderSalesOrderItemSalesOrderItemToBillingPlanGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Reads the billing plan of a sales order item.
    ApiResponse<ASalesOrderItemBillingPlanType> response = apiInstance.ASalesOrderItemSalesOrderSalesOrderSalesOrderItemSalesOrderItemToBillingPlanGetWithHttpInfo(salesOrder, salesOrderItem, select, expand);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ItemBillingPlanApi.ASalesOrderItemSalesOrderSalesOrderSalesOrderItemSalesOrderItemToBillingPlanGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **salesOrder** | **string** | Sales Order |  |
| **salesOrderItem** | **string** | Sales Order Item |  |
| **select** | [**List&lt;string&gt;?**](string.md) | Select properties to be returned, see [Select](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page&#x3D;68) | [optional]  |
| **expand** | [**List&lt;string&gt;?**](string.md) | Expand related entities, see [Expand](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page&#x3D;63) | [optional]  |

### Return type

[**ASalesOrderItemBillingPlanType**](ASalesOrderItemBillingPlanType.md)

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

<a id="aslsorderitembillingplanitemsalesordersalesordersalesorderitemsalesorderitembillingplanbillingplanbillingplanitembillingplanitemtobillingplanget"></a>
# **ASlsOrderItemBillingPlanItemSalesOrderSalesOrderSalesOrderItemSalesOrderItemBillingPlanBillingPlanBillingPlanItemBillingPlanItemToBillingPlanGet**
> ASalesOrderItemBillingPlanType ASlsOrderItemBillingPlanItemSalesOrderSalesOrderSalesOrderItemSalesOrderItemBillingPlanBillingPlanBillingPlanItemBillingPlanItemToBillingPlanGet (string salesOrder, string salesOrderItem, string billingPlan, string billingPlanItem, List<string>? select = null, List<string>? expand = null)

Reads the item billing plan for an item billing plan item.

Reads the item billing plan data for a specific billing plan item of a sales order item. Consumers must pass the following key fields: sales order ID, item number, number of the item billing plan, and item number of the item billing plan.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ASlsOrderItemBillingPlanItemSalesOrderSalesOrderSalesOrderItemSalesOrderItemBillingPlanBillingPlanBillingPlanItemBillingPlanItemToBillingPlanGetExample
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

            var apiInstance = new ItemBillingPlanApi(config);
            var salesOrder = "salesOrder_example";  // string | Sales Order
            var salesOrderItem = "salesOrderItem_example";  // string | Sales Order Item
            var billingPlan = "billingPlan_example";  // string | Billing/Invoicing Plan Number
            var billingPlanItem = "billingPlanItem_example";  // string | Item for billing plan/invoice plan/payment cards
            var select = new List<string>?(); // List<string>? | Select properties to be returned, see [Select](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=68) (optional) 
            var expand = new List<string>?(); // List<string>? | Expand related entities, see [Expand](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=63) (optional) 

            try
            {
                // Reads the item billing plan for an item billing plan item.
                ASalesOrderItemBillingPlanType result = apiInstance.ASlsOrderItemBillingPlanItemSalesOrderSalesOrderSalesOrderItemSalesOrderItemBillingPlanBillingPlanBillingPlanItemBillingPlanItemToBillingPlanGet(salesOrder, salesOrderItem, billingPlan, billingPlanItem, select, expand);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ItemBillingPlanApi.ASlsOrderItemBillingPlanItemSalesOrderSalesOrderSalesOrderItemSalesOrderItemBillingPlanBillingPlanBillingPlanItemBillingPlanItemToBillingPlanGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ASlsOrderItemBillingPlanItemSalesOrderSalesOrderSalesOrderItemSalesOrderItemBillingPlanBillingPlanBillingPlanItemBillingPlanItemToBillingPlanGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Reads the item billing plan for an item billing plan item.
    ApiResponse<ASalesOrderItemBillingPlanType> response = apiInstance.ASlsOrderItemBillingPlanItemSalesOrderSalesOrderSalesOrderItemSalesOrderItemBillingPlanBillingPlanBillingPlanItemBillingPlanItemToBillingPlanGetWithHttpInfo(salesOrder, salesOrderItem, billingPlan, billingPlanItem, select, expand);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ItemBillingPlanApi.ASlsOrderItemBillingPlanItemSalesOrderSalesOrderSalesOrderItemSalesOrderItemBillingPlanBillingPlanBillingPlanItemBillingPlanItemToBillingPlanGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **salesOrder** | **string** | Sales Order |  |
| **salesOrderItem** | **string** | Sales Order Item |  |
| **billingPlan** | **string** | Billing/Invoicing Plan Number |  |
| **billingPlanItem** | **string** | Item for billing plan/invoice plan/payment cards |  |
| **select** | [**List&lt;string&gt;?**](string.md) | Select properties to be returned, see [Select](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page&#x3D;68) | [optional]  |
| **expand** | [**List&lt;string&gt;?**](string.md) | Expand related entities, see [Expand](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page&#x3D;63) | [optional]  |

### Return type

[**ASalesOrderItemBillingPlanType**](ASalesOrderItemBillingPlanType.md)

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

