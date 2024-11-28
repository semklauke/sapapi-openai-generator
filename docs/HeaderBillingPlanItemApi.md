# Org.OpenAPITools.Api.HeaderBillingPlanItemApi

All URIs are relative to *https://:/sap/opu/odata/sap/API_SALES_ORDER_SRV*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ASalesOrderBillingPlanItemGet**](HeaderBillingPlanItemApi.md#asalesorderbillingplanitemget) | **GET** /A_SalesOrderBillingPlanItem | Reads the billing plan items of all sales orders. |
| [**ASalesOrderBillingPlanItemPost**](HeaderBillingPlanItemApi.md#asalesorderbillingplanitempost) | **POST** /A_SalesOrderBillingPlanItem | Creates a billing plan item of a sales order. |
| [**ASalesOrderBillingPlanItemSalesOrderSalesOrderBillingPlanBillingPlanBillingPlanItemBillingPlanItemDelete**](HeaderBillingPlanItemApi.md#asalesorderbillingplanitemsalesordersalesorderbillingplanbillingplanbillingplanitembillingplanitemdelete) | **DELETE** /A_SalesOrderBillingPlanItem(SalesOrder&#x3D;&#39;{SalesOrder}&#39;,BillingPlan&#x3D;&#39;{BillingPlan}&#39;,BillingPlanItem&#x3D;&#39;{BillingPlanItem}&#39;) | Deletes a billing plan item of a sales order. |
| [**ASalesOrderBillingPlanItemSalesOrderSalesOrderBillingPlanBillingPlanBillingPlanItemBillingPlanItemGet**](HeaderBillingPlanItemApi.md#asalesorderbillingplanitemsalesordersalesorderbillingplanbillingplanbillingplanitembillingplanitemget) | **GET** /A_SalesOrderBillingPlanItem(SalesOrder&#x3D;&#39;{SalesOrder}&#39;,BillingPlan&#x3D;&#39;{BillingPlan}&#39;,BillingPlanItem&#x3D;&#39;{BillingPlanItem}&#39;) | Reads a billing plan item of a sales order. |
| [**ASalesOrderBillingPlanItemSalesOrderSalesOrderBillingPlanBillingPlanBillingPlanItemBillingPlanItemPatch**](HeaderBillingPlanItemApi.md#asalesorderbillingplanitemsalesordersalesorderbillingplanbillingplanbillingplanitembillingplanitempatch) | **PATCH** /A_SalesOrderBillingPlanItem(SalesOrder&#x3D;&#39;{SalesOrder}&#39;,BillingPlan&#x3D;&#39;{BillingPlan}&#39;,BillingPlanItem&#x3D;&#39;{BillingPlanItem}&#39;) | Updates a billing plan item of a sales order. |
| [**ASalesOrderBillingPlanItemSalesOrderSalesOrderBillingPlanBillingPlanBillingPlanItemBillingPlanItemToBillingPlanGet**](HeaderBillingPlanItemApi.md#asalesorderbillingplanitemsalesordersalesorderbillingplanbillingplanbillingplanitembillingplanitemtobillingplanget) | **GET** /A_SalesOrderBillingPlanItem(SalesOrder&#x3D;&#39;{SalesOrder}&#39;,BillingPlan&#x3D;&#39;{BillingPlan}&#39;,BillingPlanItem&#x3D;&#39;{BillingPlanItem}&#39;)/to_BillingPlan | Reads the billing plan of a billing plan item of a sales order header. |
| [**ASalesOrderBillingPlanItemSalesOrderSalesOrderBillingPlanBillingPlanBillingPlanItemBillingPlanItemToSalesOrderGet**](HeaderBillingPlanItemApi.md#asalesorderbillingplanitemsalesordersalesorderbillingplanbillingplanbillingplanitembillingplanitemtosalesorderget) | **GET** /A_SalesOrderBillingPlanItem(SalesOrder&#x3D;&#39;{SalesOrder}&#39;,BillingPlan&#x3D;&#39;{BillingPlan}&#39;,BillingPlanItem&#x3D;&#39;{BillingPlanItem}&#39;)/to_SalesOrder | Reads the sales order header for a billing plan item of a sales order. |
| [**ASalesOrderBillingPlanSalesOrderSalesOrderBillingPlanBillingPlanToBillingPlanItemGet**](HeaderBillingPlanItemApi.md#asalesorderbillingplansalesordersalesorderbillingplanbillingplantobillingplanitemget) | **GET** /A_SalesOrderBillingPlan(SalesOrder&#x3D;&#39;{SalesOrder}&#39;,BillingPlan&#x3D;&#39;{BillingPlan}&#39;)/to_BillingPlanItem | Reads the billing plan items of a sales order billing plan. |
| [**ASalesOrderBillingPlanSalesOrderSalesOrderBillingPlanBillingPlanToBillingPlanItemPost**](HeaderBillingPlanItemApi.md#asalesorderbillingplansalesordersalesorderbillingplanbillingplantobillingplanitempost) | **POST** /A_SalesOrderBillingPlan(SalesOrder&#x3D;&#39;{SalesOrder}&#39;,BillingPlan&#x3D;&#39;{BillingPlan}&#39;)/to_BillingPlanItem | Creates a billing plan item for a sales order billing plan. |

<a id="asalesorderbillingplanitemget"></a>
# **ASalesOrderBillingPlanItemGet**
> Wrapper10 ASalesOrderBillingPlanItemGet (int? top = null, int? skip = null, string? filter = null, string? inlinecount = null, List<string>? orderby = null, List<string>? select = null, List<string>? expand = null)

Reads the billing plan items of all sales orders.

Reads the billing plan item data from the headers of all sales orders in the system.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ASalesOrderBillingPlanItemGetExample
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

            var apiInstance = new HeaderBillingPlanItemApi(config);
            var top = 50;  // int? | Show only the first n items, see [Paging - Top](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=66) (optional) 
            var skip = 56;  // int? | Skip the first n items, see [Paging - Skip](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=65) (optional) 
            var filter = "filter_example";  // string? | Filter items by property values, see [Filtering](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=64) (optional) 
            var inlinecount = "allpages";  // string? | Include count of items, see [Inlinecount](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=67) (optional) 
            var orderby = new List<string>?(); // List<string>? | Order items by property values, see [Sorting](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=65) (optional) 
            var select = new List<string>?(); // List<string>? | Select properties to be returned, see [Select](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=68) (optional) 
            var expand = new List<string>?(); // List<string>? | Expand related entities, see [Expand](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=63) (optional) 

            try
            {
                // Reads the billing plan items of all sales orders.
                Wrapper10 result = apiInstance.ASalesOrderBillingPlanItemGet(top, skip, filter, inlinecount, orderby, select, expand);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HeaderBillingPlanItemApi.ASalesOrderBillingPlanItemGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ASalesOrderBillingPlanItemGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Reads the billing plan items of all sales orders.
    ApiResponse<Wrapper10> response = apiInstance.ASalesOrderBillingPlanItemGetWithHttpInfo(top, skip, filter, inlinecount, orderby, select, expand);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling HeaderBillingPlanItemApi.ASalesOrderBillingPlanItemGetWithHttpInfo: " + e.Message);
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

[**Wrapper10**](Wrapper10.md)

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

<a id="asalesorderbillingplanitempost"></a>
# **ASalesOrderBillingPlanItemPost**
> ASalesOrderBillingPlanItemType ASalesOrderBillingPlanItemPost (APISALESORDERSRVASalesOrderBillingPlanItemTypeCreate aPISALESORDERSRVASalesOrderBillingPlanItemTypeCreate)

Creates a billing plan item of a sales order.

Creates a specific billing plan item for a specific sales order. Consumers must pass the following key fields: sales order ID, number of the header billing plan, and item number of the header billing plan.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ASalesOrderBillingPlanItemPostExample
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

            var apiInstance = new HeaderBillingPlanItemApi(config);
            var aPISALESORDERSRVASalesOrderBillingPlanItemTypeCreate = new APISALESORDERSRVASalesOrderBillingPlanItemTypeCreate(); // APISALESORDERSRVASalesOrderBillingPlanItemTypeCreate | New entity

            try
            {
                // Creates a billing plan item of a sales order.
                ASalesOrderBillingPlanItemType result = apiInstance.ASalesOrderBillingPlanItemPost(aPISALESORDERSRVASalesOrderBillingPlanItemTypeCreate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HeaderBillingPlanItemApi.ASalesOrderBillingPlanItemPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ASalesOrderBillingPlanItemPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a billing plan item of a sales order.
    ApiResponse<ASalesOrderBillingPlanItemType> response = apiInstance.ASalesOrderBillingPlanItemPostWithHttpInfo(aPISALESORDERSRVASalesOrderBillingPlanItemTypeCreate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling HeaderBillingPlanItemApi.ASalesOrderBillingPlanItemPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **aPISALESORDERSRVASalesOrderBillingPlanItemTypeCreate** | [**APISALESORDERSRVASalesOrderBillingPlanItemTypeCreate**](APISALESORDERSRVASalesOrderBillingPlanItemTypeCreate.md) | New entity |  |

### Return type

[**ASalesOrderBillingPlanItemType**](ASalesOrderBillingPlanItemType.md)

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

<a id="asalesorderbillingplanitemsalesordersalesorderbillingplanbillingplanbillingplanitembillingplanitemdelete"></a>
# **ASalesOrderBillingPlanItemSalesOrderSalesOrderBillingPlanBillingPlanBillingPlanItemBillingPlanItemDelete**
> void ASalesOrderBillingPlanItemSalesOrderSalesOrderBillingPlanBillingPlanBillingPlanItemBillingPlanItemDelete (string salesOrder, string billingPlan, string billingPlanItem)

Deletes a billing plan item of a sales order.

Deletes a specific billing plan item for a specific sales order. Consumers must pass the following key fields: sales order ID, number of the header billing plan, and item number of the header billing plan.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ASalesOrderBillingPlanItemSalesOrderSalesOrderBillingPlanBillingPlanBillingPlanItemBillingPlanItemDeleteExample
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

            var apiInstance = new HeaderBillingPlanItemApi(config);
            var salesOrder = "salesOrder_example";  // string | Sales Order
            var billingPlan = "billingPlan_example";  // string | Billing/Invoicing Plan Number
            var billingPlanItem = "billingPlanItem_example";  // string | Item for billing plan/invoice plan/payment cards

            try
            {
                // Deletes a billing plan item of a sales order.
                apiInstance.ASalesOrderBillingPlanItemSalesOrderSalesOrderBillingPlanBillingPlanBillingPlanItemBillingPlanItemDelete(salesOrder, billingPlan, billingPlanItem);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HeaderBillingPlanItemApi.ASalesOrderBillingPlanItemSalesOrderSalesOrderBillingPlanBillingPlanBillingPlanItemBillingPlanItemDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ASalesOrderBillingPlanItemSalesOrderSalesOrderBillingPlanBillingPlanBillingPlanItemBillingPlanItemDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deletes a billing plan item of a sales order.
    apiInstance.ASalesOrderBillingPlanItemSalesOrderSalesOrderBillingPlanBillingPlanBillingPlanItemBillingPlanItemDeleteWithHttpInfo(salesOrder, billingPlan, billingPlanItem);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling HeaderBillingPlanItemApi.ASalesOrderBillingPlanItemSalesOrderSalesOrderBillingPlanBillingPlanBillingPlanItemBillingPlanItemDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **salesOrder** | **string** | Sales Order |  |
| **billingPlan** | **string** | Billing/Invoicing Plan Number |  |
| **billingPlanItem** | **string** | Item for billing plan/invoice plan/payment cards |  |

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

<a id="asalesorderbillingplanitemsalesordersalesorderbillingplanbillingplanbillingplanitembillingplanitemget"></a>
# **ASalesOrderBillingPlanItemSalesOrderSalesOrderBillingPlanBillingPlanBillingPlanItemBillingPlanItemGet**
> ASalesOrderBillingPlanItemType ASalesOrderBillingPlanItemSalesOrderSalesOrderBillingPlanBillingPlanBillingPlanItemBillingPlanItemGet (string salesOrder, string billingPlan, string billingPlanItem, List<string>? select = null, List<string>? expand = null)

Reads a billing plan item of a sales order.

Reads a specific billing plan item for a specific sales order. Consumers must pass the following key fields: sales order ID, number of the header billing plan, and item number of the header billing plan.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ASalesOrderBillingPlanItemSalesOrderSalesOrderBillingPlanBillingPlanBillingPlanItemBillingPlanItemGetExample
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

            var apiInstance = new HeaderBillingPlanItemApi(config);
            var salesOrder = "salesOrder_example";  // string | Sales Order
            var billingPlan = "billingPlan_example";  // string | Billing/Invoicing Plan Number
            var billingPlanItem = "billingPlanItem_example";  // string | Item for billing plan/invoice plan/payment cards
            var select = new List<string>?(); // List<string>? | Select properties to be returned, see [Select](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=68) (optional) 
            var expand = new List<string>?(); // List<string>? | Expand related entities, see [Expand](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=63) (optional) 

            try
            {
                // Reads a billing plan item of a sales order.
                ASalesOrderBillingPlanItemType result = apiInstance.ASalesOrderBillingPlanItemSalesOrderSalesOrderBillingPlanBillingPlanBillingPlanItemBillingPlanItemGet(salesOrder, billingPlan, billingPlanItem, select, expand);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HeaderBillingPlanItemApi.ASalesOrderBillingPlanItemSalesOrderSalesOrderBillingPlanBillingPlanBillingPlanItemBillingPlanItemGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ASalesOrderBillingPlanItemSalesOrderSalesOrderBillingPlanBillingPlanBillingPlanItemBillingPlanItemGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Reads a billing plan item of a sales order.
    ApiResponse<ASalesOrderBillingPlanItemType> response = apiInstance.ASalesOrderBillingPlanItemSalesOrderSalesOrderBillingPlanBillingPlanBillingPlanItemBillingPlanItemGetWithHttpInfo(salesOrder, billingPlan, billingPlanItem, select, expand);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling HeaderBillingPlanItemApi.ASalesOrderBillingPlanItemSalesOrderSalesOrderBillingPlanBillingPlanBillingPlanItemBillingPlanItemGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **salesOrder** | **string** | Sales Order |  |
| **billingPlan** | **string** | Billing/Invoicing Plan Number |  |
| **billingPlanItem** | **string** | Item for billing plan/invoice plan/payment cards |  |
| **select** | [**List&lt;string&gt;?**](string.md) | Select properties to be returned, see [Select](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page&#x3D;68) | [optional]  |
| **expand** | [**List&lt;string&gt;?**](string.md) | Expand related entities, see [Expand](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page&#x3D;63) | [optional]  |

### Return type

[**ASalesOrderBillingPlanItemType**](ASalesOrderBillingPlanItemType.md)

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

<a id="asalesorderbillingplanitemsalesordersalesorderbillingplanbillingplanbillingplanitembillingplanitempatch"></a>
# **ASalesOrderBillingPlanItemSalesOrderSalesOrderBillingPlanBillingPlanBillingPlanItemBillingPlanItemPatch**
> void ASalesOrderBillingPlanItemSalesOrderSalesOrderBillingPlanBillingPlanBillingPlanItemBillingPlanItemPatch (string salesOrder, string billingPlan, string billingPlanItem, ModifiedASalesOrderBillingPlanItemType modifiedASalesOrderBillingPlanItemType)

Updates a billing plan item of a sales order.

Updates a specific billing plan item for a specific sales order. Consumers must pass the following key fields: sales order ID, number of the header billing plan, and item number of the header billing plan.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ASalesOrderBillingPlanItemSalesOrderSalesOrderBillingPlanBillingPlanBillingPlanItemBillingPlanItemPatchExample
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

            var apiInstance = new HeaderBillingPlanItemApi(config);
            var salesOrder = "salesOrder_example";  // string | Sales Order
            var billingPlan = "billingPlan_example";  // string | Billing/Invoicing Plan Number
            var billingPlanItem = "billingPlanItem_example";  // string | Item for billing plan/invoice plan/payment cards
            var modifiedASalesOrderBillingPlanItemType = new ModifiedASalesOrderBillingPlanItemType(); // ModifiedASalesOrderBillingPlanItemType | New property values

            try
            {
                // Updates a billing plan item of a sales order.
                apiInstance.ASalesOrderBillingPlanItemSalesOrderSalesOrderBillingPlanBillingPlanBillingPlanItemBillingPlanItemPatch(salesOrder, billingPlan, billingPlanItem, modifiedASalesOrderBillingPlanItemType);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HeaderBillingPlanItemApi.ASalesOrderBillingPlanItemSalesOrderSalesOrderBillingPlanBillingPlanBillingPlanItemBillingPlanItemPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ASalesOrderBillingPlanItemSalesOrderSalesOrderBillingPlanBillingPlanBillingPlanItemBillingPlanItemPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates a billing plan item of a sales order.
    apiInstance.ASalesOrderBillingPlanItemSalesOrderSalesOrderBillingPlanBillingPlanBillingPlanItemBillingPlanItemPatchWithHttpInfo(salesOrder, billingPlan, billingPlanItem, modifiedASalesOrderBillingPlanItemType);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling HeaderBillingPlanItemApi.ASalesOrderBillingPlanItemSalesOrderSalesOrderBillingPlanBillingPlanBillingPlanItemBillingPlanItemPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **salesOrder** | **string** | Sales Order |  |
| **billingPlan** | **string** | Billing/Invoicing Plan Number |  |
| **billingPlanItem** | **string** | Item for billing plan/invoice plan/payment cards |  |
| **modifiedASalesOrderBillingPlanItemType** | [**ModifiedASalesOrderBillingPlanItemType**](ModifiedASalesOrderBillingPlanItemType.md) | New property values |  |

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

<a id="asalesorderbillingplanitemsalesordersalesorderbillingplanbillingplanbillingplanitembillingplanitemtobillingplanget"></a>
# **ASalesOrderBillingPlanItemSalesOrderSalesOrderBillingPlanBillingPlanBillingPlanItemBillingPlanItemToBillingPlanGet**
> ASalesOrderBillingPlanType ASalesOrderBillingPlanItemSalesOrderSalesOrderBillingPlanBillingPlanBillingPlanItemBillingPlanItemToBillingPlanGet (string salesOrder, string billingPlan, string billingPlanItem, List<string>? select = null, List<string>? expand = null)

Reads the billing plan of a billing plan item of a sales order header.

Reads the billing plan data for a specific billing plan item of a specific sales order header. Consumers must pass the following key fields: sales order ID, number of the header billing plan, and item number of the header billing plan.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ASalesOrderBillingPlanItemSalesOrderSalesOrderBillingPlanBillingPlanBillingPlanItemBillingPlanItemToBillingPlanGetExample
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

            var apiInstance = new HeaderBillingPlanItemApi(config);
            var salesOrder = "salesOrder_example";  // string | Sales Order
            var billingPlan = "billingPlan_example";  // string | Billing/Invoicing Plan Number
            var billingPlanItem = "billingPlanItem_example";  // string | Item for billing plan/invoice plan/payment cards
            var select = new List<string>?(); // List<string>? | Select properties to be returned, see [Select](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=68) (optional) 
            var expand = new List<string>?(); // List<string>? | Expand related entities, see [Expand](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=63) (optional) 

            try
            {
                // Reads the billing plan of a billing plan item of a sales order header.
                ASalesOrderBillingPlanType result = apiInstance.ASalesOrderBillingPlanItemSalesOrderSalesOrderBillingPlanBillingPlanBillingPlanItemBillingPlanItemToBillingPlanGet(salesOrder, billingPlan, billingPlanItem, select, expand);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HeaderBillingPlanItemApi.ASalesOrderBillingPlanItemSalesOrderSalesOrderBillingPlanBillingPlanBillingPlanItemBillingPlanItemToBillingPlanGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ASalesOrderBillingPlanItemSalesOrderSalesOrderBillingPlanBillingPlanBillingPlanItemBillingPlanItemToBillingPlanGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Reads the billing plan of a billing plan item of a sales order header.
    ApiResponse<ASalesOrderBillingPlanType> response = apiInstance.ASalesOrderBillingPlanItemSalesOrderSalesOrderBillingPlanBillingPlanBillingPlanItemBillingPlanItemToBillingPlanGetWithHttpInfo(salesOrder, billingPlan, billingPlanItem, select, expand);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling HeaderBillingPlanItemApi.ASalesOrderBillingPlanItemSalesOrderSalesOrderBillingPlanBillingPlanBillingPlanItemBillingPlanItemToBillingPlanGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **salesOrder** | **string** | Sales Order |  |
| **billingPlan** | **string** | Billing/Invoicing Plan Number |  |
| **billingPlanItem** | **string** | Item for billing plan/invoice plan/payment cards |  |
| **select** | [**List&lt;string&gt;?**](string.md) | Select properties to be returned, see [Select](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page&#x3D;68) | [optional]  |
| **expand** | [**List&lt;string&gt;?**](string.md) | Expand related entities, see [Expand](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page&#x3D;63) | [optional]  |

### Return type

[**ASalesOrderBillingPlanType**](ASalesOrderBillingPlanType.md)

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

<a id="asalesorderbillingplanitemsalesordersalesorderbillingplanbillingplanbillingplanitembillingplanitemtosalesorderget"></a>
# **ASalesOrderBillingPlanItemSalesOrderSalesOrderBillingPlanBillingPlanBillingPlanItemBillingPlanItemToSalesOrderGet**
> ASalesOrderType ASalesOrderBillingPlanItemSalesOrderSalesOrderBillingPlanBillingPlanBillingPlanItemBillingPlanItemToSalesOrderGet (string salesOrder, string billingPlan, string billingPlanItem, List<string>? select = null, List<string>? expand = null)

Reads the sales order header for a billing plan item of a sales order.

Reads the sales order header data for a specific billing plan item of a specific sales order. Consumers must pass the following key fields: sales order ID, number of the header billing plan, and item number of the header billing plan.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ASalesOrderBillingPlanItemSalesOrderSalesOrderBillingPlanBillingPlanBillingPlanItemBillingPlanItemToSalesOrderGetExample
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

            var apiInstance = new HeaderBillingPlanItemApi(config);
            var salesOrder = "salesOrder_example";  // string | Sales Order
            var billingPlan = "billingPlan_example";  // string | Billing/Invoicing Plan Number
            var billingPlanItem = "billingPlanItem_example";  // string | Item for billing plan/invoice plan/payment cards
            var select = new List<string>?(); // List<string>? | Select properties to be returned, see [Select](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=68) (optional) 
            var expand = new List<string>?(); // List<string>? | Expand related entities, see [Expand](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=63) (optional) 

            try
            {
                // Reads the sales order header for a billing plan item of a sales order.
                ASalesOrderType result = apiInstance.ASalesOrderBillingPlanItemSalesOrderSalesOrderBillingPlanBillingPlanBillingPlanItemBillingPlanItemToSalesOrderGet(salesOrder, billingPlan, billingPlanItem, select, expand);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HeaderBillingPlanItemApi.ASalesOrderBillingPlanItemSalesOrderSalesOrderBillingPlanBillingPlanBillingPlanItemBillingPlanItemToSalesOrderGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ASalesOrderBillingPlanItemSalesOrderSalesOrderBillingPlanBillingPlanBillingPlanItemBillingPlanItemToSalesOrderGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Reads the sales order header for a billing plan item of a sales order.
    ApiResponse<ASalesOrderType> response = apiInstance.ASalesOrderBillingPlanItemSalesOrderSalesOrderBillingPlanBillingPlanBillingPlanItemBillingPlanItemToSalesOrderGetWithHttpInfo(salesOrder, billingPlan, billingPlanItem, select, expand);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling HeaderBillingPlanItemApi.ASalesOrderBillingPlanItemSalesOrderSalesOrderBillingPlanBillingPlanBillingPlanItemBillingPlanItemToSalesOrderGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **salesOrder** | **string** | Sales Order |  |
| **billingPlan** | **string** | Billing/Invoicing Plan Number |  |
| **billingPlanItem** | **string** | Item for billing plan/invoice plan/payment cards |  |
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

<a id="asalesorderbillingplansalesordersalesorderbillingplanbillingplantobillingplanitemget"></a>
# **ASalesOrderBillingPlanSalesOrderSalesOrderBillingPlanBillingPlanToBillingPlanItemGet**
> Wrapper10 ASalesOrderBillingPlanSalesOrderSalesOrderBillingPlanBillingPlanToBillingPlanItemGet (string salesOrder, string billingPlan, int? top = null, int? skip = null, string? filter = null, string? inlinecount = null, List<string>? orderby = null, List<string>? select = null, List<string>? expand = null)

Reads the billing plan items of a sales order billing plan.

Reads the billing plan item data for a specific sales order billing plan. Consumers must pass the following key fields: sales order ID and number of the header billing plan.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ASalesOrderBillingPlanSalesOrderSalesOrderBillingPlanBillingPlanToBillingPlanItemGetExample
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

            var apiInstance = new HeaderBillingPlanItemApi(config);
            var salesOrder = "salesOrder_example";  // string | Sales Order
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
                // Reads the billing plan items of a sales order billing plan.
                Wrapper10 result = apiInstance.ASalesOrderBillingPlanSalesOrderSalesOrderBillingPlanBillingPlanToBillingPlanItemGet(salesOrder, billingPlan, top, skip, filter, inlinecount, orderby, select, expand);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HeaderBillingPlanItemApi.ASalesOrderBillingPlanSalesOrderSalesOrderBillingPlanBillingPlanToBillingPlanItemGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ASalesOrderBillingPlanSalesOrderSalesOrderBillingPlanBillingPlanToBillingPlanItemGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Reads the billing plan items of a sales order billing plan.
    ApiResponse<Wrapper10> response = apiInstance.ASalesOrderBillingPlanSalesOrderSalesOrderBillingPlanBillingPlanToBillingPlanItemGetWithHttpInfo(salesOrder, billingPlan, top, skip, filter, inlinecount, orderby, select, expand);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling HeaderBillingPlanItemApi.ASalesOrderBillingPlanSalesOrderSalesOrderBillingPlanBillingPlanToBillingPlanItemGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **salesOrder** | **string** | Sales Order |  |
| **billingPlan** | **string** | Billing/Invoicing Plan Number |  |
| **top** | **int?** | Show only the first n items, see [Paging - Top](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page&#x3D;66) | [optional]  |
| **skip** | **int?** | Skip the first n items, see [Paging - Skip](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page&#x3D;65) | [optional]  |
| **filter** | **string?** | Filter items by property values, see [Filtering](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page&#x3D;64) | [optional]  |
| **inlinecount** | **string?** | Include count of items, see [Inlinecount](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page&#x3D;67) | [optional]  |
| **orderby** | [**List&lt;string&gt;?**](string.md) | Order items by property values, see [Sorting](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page&#x3D;65) | [optional]  |
| **select** | [**List&lt;string&gt;?**](string.md) | Select properties to be returned, see [Select](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page&#x3D;68) | [optional]  |
| **expand** | [**List&lt;string&gt;?**](string.md) | Expand related entities, see [Expand](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page&#x3D;63) | [optional]  |

### Return type

[**Wrapper10**](Wrapper10.md)

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

<a id="asalesorderbillingplansalesordersalesorderbillingplanbillingplantobillingplanitempost"></a>
# **ASalesOrderBillingPlanSalesOrderSalesOrderBillingPlanBillingPlanToBillingPlanItemPost**
> ASalesOrderBillingPlanItemType ASalesOrderBillingPlanSalesOrderSalesOrderBillingPlanBillingPlanToBillingPlanItemPost (string salesOrder, string billingPlan, APISALESORDERSRVASalesOrderBillingPlanItemTypeCreate aPISALESORDERSRVASalesOrderBillingPlanItemTypeCreate)

Creates a billing plan item for a sales order billing plan.

Creates a billing plan item for a specific sales order billing plan. Consumers must pass the following key fields: sales order ID and number of the header billing plan.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ASalesOrderBillingPlanSalesOrderSalesOrderBillingPlanBillingPlanToBillingPlanItemPostExample
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

            var apiInstance = new HeaderBillingPlanItemApi(config);
            var salesOrder = "salesOrder_example";  // string | Sales Order
            var billingPlan = "billingPlan_example";  // string | Billing/Invoicing Plan Number
            var aPISALESORDERSRVASalesOrderBillingPlanItemTypeCreate = new APISALESORDERSRVASalesOrderBillingPlanItemTypeCreate(); // APISALESORDERSRVASalesOrderBillingPlanItemTypeCreate | New entity

            try
            {
                // Creates a billing plan item for a sales order billing plan.
                ASalesOrderBillingPlanItemType result = apiInstance.ASalesOrderBillingPlanSalesOrderSalesOrderBillingPlanBillingPlanToBillingPlanItemPost(salesOrder, billingPlan, aPISALESORDERSRVASalesOrderBillingPlanItemTypeCreate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HeaderBillingPlanItemApi.ASalesOrderBillingPlanSalesOrderSalesOrderBillingPlanBillingPlanToBillingPlanItemPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ASalesOrderBillingPlanSalesOrderSalesOrderBillingPlanBillingPlanToBillingPlanItemPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a billing plan item for a sales order billing plan.
    ApiResponse<ASalesOrderBillingPlanItemType> response = apiInstance.ASalesOrderBillingPlanSalesOrderSalesOrderBillingPlanBillingPlanToBillingPlanItemPostWithHttpInfo(salesOrder, billingPlan, aPISALESORDERSRVASalesOrderBillingPlanItemTypeCreate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling HeaderBillingPlanItemApi.ASalesOrderBillingPlanSalesOrderSalesOrderBillingPlanBillingPlanToBillingPlanItemPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **salesOrder** | **string** | Sales Order |  |
| **billingPlan** | **string** | Billing/Invoicing Plan Number |  |
| **aPISALESORDERSRVASalesOrderBillingPlanItemTypeCreate** | [**APISALESORDERSRVASalesOrderBillingPlanItemTypeCreate**](APISALESORDERSRVASalesOrderBillingPlanItemTypeCreate.md) | New entity |  |

### Return type

[**ASalesOrderBillingPlanItemType**](ASalesOrderBillingPlanItemType.md)

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

