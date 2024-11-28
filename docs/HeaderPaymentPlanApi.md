# Org.OpenAPITools.Api.HeaderPaymentPlanApi

All URIs are relative to *https://:/sap/opu/odata/sap/API_SALES_ORDER_SRV*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ASalesOrderSalesOrderToPaymentPlanItemDetailsGet**](HeaderPaymentPlanApi.md#asalesordersalesordertopaymentplanitemdetailsget) | **GET** /A_SalesOrder(&#39;{SalesOrder}&#39;)/to_PaymentPlanItemDetails | Reads the header payment plan of a specific sales order. |
| [**ASalesOrderSalesOrderToPaymentPlanItemDetailsPost**](HeaderPaymentPlanApi.md#asalesordersalesordertopaymentplanitemdetailspost) | **POST** /A_SalesOrder(&#39;{SalesOrder}&#39;)/to_PaymentPlanItemDetails | Creates a header payment plan for a specific sales order. |
| [**ASlsOrdPaymentPlanItemDetailsGet**](HeaderPaymentPlanApi.md#aslsordpaymentplanitemdetailsget) | **GET** /A_SlsOrdPaymentPlanItemDetails | Reads the payment plans of all sales orders. |
| [**ASlsOrdPaymentPlanItemDetailsPost**](HeaderPaymentPlanApi.md#aslsordpaymentplanitemdetailspost) | **POST** /A_SlsOrdPaymentPlanItemDetails | Creates a payment plan for a sales order. |
| [**ASlsOrdPaymentPlanItemDetailsSalesOrderSalesOrderPaymentPlanItemPaymentPlanItemDelete**](HeaderPaymentPlanApi.md#aslsordpaymentplanitemdetailssalesordersalesorderpaymentplanitempaymentplanitemdelete) | **DELETE** /A_SlsOrdPaymentPlanItemDetails(SalesOrder&#x3D;&#39;{SalesOrder}&#39;,PaymentPlanItem&#x3D;&#39;{PaymentPlanItem}&#39;) | Deletes a payment plan item of a specific sales order. |
| [**ASlsOrdPaymentPlanItemDetailsSalesOrderSalesOrderPaymentPlanItemPaymentPlanItemGet**](HeaderPaymentPlanApi.md#aslsordpaymentplanitemdetailssalesordersalesorderpaymentplanitempaymentplanitemget) | **GET** /A_SlsOrdPaymentPlanItemDetails(SalesOrder&#x3D;&#39;{SalesOrder}&#39;,PaymentPlanItem&#x3D;&#39;{PaymentPlanItem}&#39;) | Reads a payment plan item of a sales order. |
| [**ASlsOrdPaymentPlanItemDetailsSalesOrderSalesOrderPaymentPlanItemPaymentPlanItemPatch**](HeaderPaymentPlanApi.md#aslsordpaymentplanitemdetailssalesordersalesorderpaymentplanitempaymentplanitempatch) | **PATCH** /A_SlsOrdPaymentPlanItemDetails(SalesOrder&#x3D;&#39;{SalesOrder}&#39;,PaymentPlanItem&#x3D;&#39;{PaymentPlanItem}&#39;) | Updates a payment plan item of a sales order. |
| [**ASlsOrdPaymentPlanItemDetailsSalesOrderSalesOrderPaymentPlanItemPaymentPlanItemToSalesOrderGet**](HeaderPaymentPlanApi.md#aslsordpaymentplanitemdetailssalesordersalesorderpaymentplanitempaymentplanitemtosalesorderget) | **GET** /A_SlsOrdPaymentPlanItemDetails(SalesOrder&#x3D;&#39;{SalesOrder}&#39;,PaymentPlanItem&#x3D;&#39;{PaymentPlanItem}&#39;)/to_SalesOrder | Reads the sales order header for a payment plan item. |

<a id="asalesordersalesordertopaymentplanitemdetailsget"></a>
# **ASalesOrderSalesOrderToPaymentPlanItemDetailsGet**
> Wrapper3 ASalesOrderSalesOrderToPaymentPlanItemDetailsGet (string salesOrder, int? top = null, int? skip = null, string? filter = null, string? inlinecount = null, List<string>? orderby = null, List<string>? select = null, List<string>? expand = null)

Reads the header payment plan of a specific sales order.

Reads the payment plan data from the header of a specific sales order. Consumers must pass the sales order ID (key field).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ASalesOrderSalesOrderToPaymentPlanItemDetailsGetExample
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

            var apiInstance = new HeaderPaymentPlanApi(config);
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
                // Reads the header payment plan of a specific sales order.
                Wrapper3 result = apiInstance.ASalesOrderSalesOrderToPaymentPlanItemDetailsGet(salesOrder, top, skip, filter, inlinecount, orderby, select, expand);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HeaderPaymentPlanApi.ASalesOrderSalesOrderToPaymentPlanItemDetailsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ASalesOrderSalesOrderToPaymentPlanItemDetailsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Reads the header payment plan of a specific sales order.
    ApiResponse<Wrapper3> response = apiInstance.ASalesOrderSalesOrderToPaymentPlanItemDetailsGetWithHttpInfo(salesOrder, top, skip, filter, inlinecount, orderby, select, expand);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling HeaderPaymentPlanApi.ASalesOrderSalesOrderToPaymentPlanItemDetailsGetWithHttpInfo: " + e.Message);
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

[**Wrapper3**](Wrapper3.md)

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

<a id="asalesordersalesordertopaymentplanitemdetailspost"></a>
# **ASalesOrderSalesOrderToPaymentPlanItemDetailsPost**
> ASlsOrdPaymentPlanItemDetailsType ASalesOrderSalesOrderToPaymentPlanItemDetailsPost (string salesOrder, APISALESORDERSRVASlsOrdPaymentPlanItemDetailsTypeCreate aPISALESORDERSRVASlsOrdPaymentPlanItemDetailsTypeCreate)

Creates a header payment plan for a specific sales order.

Creates the payment plan data for a specific sales order header. Consumers must pass the sales order ID (key field).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ASalesOrderSalesOrderToPaymentPlanItemDetailsPostExample
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

            var apiInstance = new HeaderPaymentPlanApi(config);
            var salesOrder = "salesOrder_example";  // string | Sales Order
            var aPISALESORDERSRVASlsOrdPaymentPlanItemDetailsTypeCreate = new APISALESORDERSRVASlsOrdPaymentPlanItemDetailsTypeCreate(); // APISALESORDERSRVASlsOrdPaymentPlanItemDetailsTypeCreate | New entity

            try
            {
                // Creates a header payment plan for a specific sales order.
                ASlsOrdPaymentPlanItemDetailsType result = apiInstance.ASalesOrderSalesOrderToPaymentPlanItemDetailsPost(salesOrder, aPISALESORDERSRVASlsOrdPaymentPlanItemDetailsTypeCreate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HeaderPaymentPlanApi.ASalesOrderSalesOrderToPaymentPlanItemDetailsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ASalesOrderSalesOrderToPaymentPlanItemDetailsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a header payment plan for a specific sales order.
    ApiResponse<ASlsOrdPaymentPlanItemDetailsType> response = apiInstance.ASalesOrderSalesOrderToPaymentPlanItemDetailsPostWithHttpInfo(salesOrder, aPISALESORDERSRVASlsOrdPaymentPlanItemDetailsTypeCreate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling HeaderPaymentPlanApi.ASalesOrderSalesOrderToPaymentPlanItemDetailsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **salesOrder** | **string** | Sales Order |  |
| **aPISALESORDERSRVASlsOrdPaymentPlanItemDetailsTypeCreate** | [**APISALESORDERSRVASlsOrdPaymentPlanItemDetailsTypeCreate**](APISALESORDERSRVASlsOrdPaymentPlanItemDetailsTypeCreate.md) | New entity |  |

### Return type

[**ASlsOrdPaymentPlanItemDetailsType**](ASlsOrdPaymentPlanItemDetailsType.md)

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

<a id="aslsordpaymentplanitemdetailsget"></a>
# **ASlsOrdPaymentPlanItemDetailsGet**
> Wrapper3 ASlsOrdPaymentPlanItemDetailsGet (int? top = null, int? skip = null, string? filter = null, string? inlinecount = null, List<string>? orderby = null, List<string>? select = null, List<string>? expand = null)

Reads the payment plans of all sales orders.

Reads the payment plan data from the header of all sales orders in the system.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ASlsOrdPaymentPlanItemDetailsGetExample
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

            var apiInstance = new HeaderPaymentPlanApi(config);
            var top = 50;  // int? | Show only the first n items, see [Paging - Top](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=66) (optional) 
            var skip = 56;  // int? | Skip the first n items, see [Paging - Skip](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=65) (optional) 
            var filter = "filter_example";  // string? | Filter items by property values, see [Filtering](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=64) (optional) 
            var inlinecount = "allpages";  // string? | Include count of items, see [Inlinecount](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=67) (optional) 
            var orderby = new List<string>?(); // List<string>? | Order items by property values, see [Sorting](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=65) (optional) 
            var select = new List<string>?(); // List<string>? | Select properties to be returned, see [Select](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=68) (optional) 
            var expand = new List<string>?(); // List<string>? | Expand related entities, see [Expand](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=63) (optional) 

            try
            {
                // Reads the payment plans of all sales orders.
                Wrapper3 result = apiInstance.ASlsOrdPaymentPlanItemDetailsGet(top, skip, filter, inlinecount, orderby, select, expand);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HeaderPaymentPlanApi.ASlsOrdPaymentPlanItemDetailsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ASlsOrdPaymentPlanItemDetailsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Reads the payment plans of all sales orders.
    ApiResponse<Wrapper3> response = apiInstance.ASlsOrdPaymentPlanItemDetailsGetWithHttpInfo(top, skip, filter, inlinecount, orderby, select, expand);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling HeaderPaymentPlanApi.ASlsOrdPaymentPlanItemDetailsGetWithHttpInfo: " + e.Message);
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

[**Wrapper3**](Wrapper3.md)

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

<a id="aslsordpaymentplanitemdetailspost"></a>
# **ASlsOrdPaymentPlanItemDetailsPost**
> ASlsOrdPaymentPlanItemDetailsType ASlsOrdPaymentPlanItemDetailsPost (APISALESORDERSRVASlsOrdPaymentPlanItemDetailsTypeCreate aPISALESORDERSRVASlsOrdPaymentPlanItemDetailsTypeCreate)

Creates a payment plan for a sales order.

Creates the payment plan data for the header of a specific sales order.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ASlsOrdPaymentPlanItemDetailsPostExample
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

            var apiInstance = new HeaderPaymentPlanApi(config);
            var aPISALESORDERSRVASlsOrdPaymentPlanItemDetailsTypeCreate = new APISALESORDERSRVASlsOrdPaymentPlanItemDetailsTypeCreate(); // APISALESORDERSRVASlsOrdPaymentPlanItemDetailsTypeCreate | New entity

            try
            {
                // Creates a payment plan for a sales order.
                ASlsOrdPaymentPlanItemDetailsType result = apiInstance.ASlsOrdPaymentPlanItemDetailsPost(aPISALESORDERSRVASlsOrdPaymentPlanItemDetailsTypeCreate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HeaderPaymentPlanApi.ASlsOrdPaymentPlanItemDetailsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ASlsOrdPaymentPlanItemDetailsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a payment plan for a sales order.
    ApiResponse<ASlsOrdPaymentPlanItemDetailsType> response = apiInstance.ASlsOrdPaymentPlanItemDetailsPostWithHttpInfo(aPISALESORDERSRVASlsOrdPaymentPlanItemDetailsTypeCreate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling HeaderPaymentPlanApi.ASlsOrdPaymentPlanItemDetailsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **aPISALESORDERSRVASlsOrdPaymentPlanItemDetailsTypeCreate** | [**APISALESORDERSRVASlsOrdPaymentPlanItemDetailsTypeCreate**](APISALESORDERSRVASlsOrdPaymentPlanItemDetailsTypeCreate.md) | New entity |  |

### Return type

[**ASlsOrdPaymentPlanItemDetailsType**](ASlsOrdPaymentPlanItemDetailsType.md)

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

<a id="aslsordpaymentplanitemdetailssalesordersalesorderpaymentplanitempaymentplanitemdelete"></a>
# **ASlsOrdPaymentPlanItemDetailsSalesOrderSalesOrderPaymentPlanItemPaymentPlanItemDelete**
> void ASlsOrdPaymentPlanItemDetailsSalesOrderSalesOrderPaymentPlanItemPaymentPlanItemDelete (string salesOrder, string paymentPlanItem)

Deletes a payment plan item of a specific sales order.

Deletes the payment plan data from the header of a specific sales order.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ASlsOrdPaymentPlanItemDetailsSalesOrderSalesOrderPaymentPlanItemPaymentPlanItemDeleteExample
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

            var apiInstance = new HeaderPaymentPlanApi(config);
            var salesOrder = "salesOrder_example";  // string | Sales Order
            var paymentPlanItem = "paymentPlanItem_example";  // string | Item for billing plan/invoice plan/payment cards

            try
            {
                // Deletes a payment plan item of a specific sales order.
                apiInstance.ASlsOrdPaymentPlanItemDetailsSalesOrderSalesOrderPaymentPlanItemPaymentPlanItemDelete(salesOrder, paymentPlanItem);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HeaderPaymentPlanApi.ASlsOrdPaymentPlanItemDetailsSalesOrderSalesOrderPaymentPlanItemPaymentPlanItemDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ASlsOrdPaymentPlanItemDetailsSalesOrderSalesOrderPaymentPlanItemPaymentPlanItemDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deletes a payment plan item of a specific sales order.
    apiInstance.ASlsOrdPaymentPlanItemDetailsSalesOrderSalesOrderPaymentPlanItemPaymentPlanItemDeleteWithHttpInfo(salesOrder, paymentPlanItem);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling HeaderPaymentPlanApi.ASlsOrdPaymentPlanItemDetailsSalesOrderSalesOrderPaymentPlanItemPaymentPlanItemDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **salesOrder** | **string** | Sales Order |  |
| **paymentPlanItem** | **string** | Item for billing plan/invoice plan/payment cards |  |

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

<a id="aslsordpaymentplanitemdetailssalesordersalesorderpaymentplanitempaymentplanitemget"></a>
# **ASlsOrdPaymentPlanItemDetailsSalesOrderSalesOrderPaymentPlanItemPaymentPlanItemGet**
> ASlsOrdPaymentPlanItemDetailsType ASlsOrdPaymentPlanItemDetailsSalesOrderSalesOrderPaymentPlanItemPaymentPlanItemGet (string salesOrder, string paymentPlanItem, List<string>? select = null, List<string>? expand = null)

Reads a payment plan item of a sales order.

Reads the payment plan data from the header of a specific sales order.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ASlsOrdPaymentPlanItemDetailsSalesOrderSalesOrderPaymentPlanItemPaymentPlanItemGetExample
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

            var apiInstance = new HeaderPaymentPlanApi(config);
            var salesOrder = "salesOrder_example";  // string | Sales Order
            var paymentPlanItem = "paymentPlanItem_example";  // string | Item for billing plan/invoice plan/payment cards
            var select = new List<string>?(); // List<string>? | Select properties to be returned, see [Select](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=68) (optional) 
            var expand = new List<string>?(); // List<string>? | Expand related entities, see [Expand](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=63) (optional) 

            try
            {
                // Reads a payment plan item of a sales order.
                ASlsOrdPaymentPlanItemDetailsType result = apiInstance.ASlsOrdPaymentPlanItemDetailsSalesOrderSalesOrderPaymentPlanItemPaymentPlanItemGet(salesOrder, paymentPlanItem, select, expand);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HeaderPaymentPlanApi.ASlsOrdPaymentPlanItemDetailsSalesOrderSalesOrderPaymentPlanItemPaymentPlanItemGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ASlsOrdPaymentPlanItemDetailsSalesOrderSalesOrderPaymentPlanItemPaymentPlanItemGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Reads a payment plan item of a sales order.
    ApiResponse<ASlsOrdPaymentPlanItemDetailsType> response = apiInstance.ASlsOrdPaymentPlanItemDetailsSalesOrderSalesOrderPaymentPlanItemPaymentPlanItemGetWithHttpInfo(salesOrder, paymentPlanItem, select, expand);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling HeaderPaymentPlanApi.ASlsOrdPaymentPlanItemDetailsSalesOrderSalesOrderPaymentPlanItemPaymentPlanItemGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **salesOrder** | **string** | Sales Order |  |
| **paymentPlanItem** | **string** | Item for billing plan/invoice plan/payment cards |  |
| **select** | [**List&lt;string&gt;?**](string.md) | Select properties to be returned, see [Select](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page&#x3D;68) | [optional]  |
| **expand** | [**List&lt;string&gt;?**](string.md) | Expand related entities, see [Expand](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page&#x3D;63) | [optional]  |

### Return type

[**ASlsOrdPaymentPlanItemDetailsType**](ASlsOrdPaymentPlanItemDetailsType.md)

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

<a id="aslsordpaymentplanitemdetailssalesordersalesorderpaymentplanitempaymentplanitempatch"></a>
# **ASlsOrdPaymentPlanItemDetailsSalesOrderSalesOrderPaymentPlanItemPaymentPlanItemPatch**
> void ASlsOrdPaymentPlanItemDetailsSalesOrderSalesOrderPaymentPlanItemPaymentPlanItemPatch (string salesOrder, string paymentPlanItem, ModifiedASlsOrdPaymentPlanItemDetailsType modifiedASlsOrdPaymentPlanItemDetailsType)

Updates a payment plan item of a sales order.

Updates the payment plan data of the header of a specific sales order.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ASlsOrdPaymentPlanItemDetailsSalesOrderSalesOrderPaymentPlanItemPaymentPlanItemPatchExample
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

            var apiInstance = new HeaderPaymentPlanApi(config);
            var salesOrder = "salesOrder_example";  // string | Sales Order
            var paymentPlanItem = "paymentPlanItem_example";  // string | Item for billing plan/invoice plan/payment cards
            var modifiedASlsOrdPaymentPlanItemDetailsType = new ModifiedASlsOrdPaymentPlanItemDetailsType(); // ModifiedASlsOrdPaymentPlanItemDetailsType | New property values

            try
            {
                // Updates a payment plan item of a sales order.
                apiInstance.ASlsOrdPaymentPlanItemDetailsSalesOrderSalesOrderPaymentPlanItemPaymentPlanItemPatch(salesOrder, paymentPlanItem, modifiedASlsOrdPaymentPlanItemDetailsType);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HeaderPaymentPlanApi.ASlsOrdPaymentPlanItemDetailsSalesOrderSalesOrderPaymentPlanItemPaymentPlanItemPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ASlsOrdPaymentPlanItemDetailsSalesOrderSalesOrderPaymentPlanItemPaymentPlanItemPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates a payment plan item of a sales order.
    apiInstance.ASlsOrdPaymentPlanItemDetailsSalesOrderSalesOrderPaymentPlanItemPaymentPlanItemPatchWithHttpInfo(salesOrder, paymentPlanItem, modifiedASlsOrdPaymentPlanItemDetailsType);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling HeaderPaymentPlanApi.ASlsOrdPaymentPlanItemDetailsSalesOrderSalesOrderPaymentPlanItemPaymentPlanItemPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **salesOrder** | **string** | Sales Order |  |
| **paymentPlanItem** | **string** | Item for billing plan/invoice plan/payment cards |  |
| **modifiedASlsOrdPaymentPlanItemDetailsType** | [**ModifiedASlsOrdPaymentPlanItemDetailsType**](ModifiedASlsOrdPaymentPlanItemDetailsType.md) | New property values |  |

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

<a id="aslsordpaymentplanitemdetailssalesordersalesorderpaymentplanitempaymentplanitemtosalesorderget"></a>
# **ASlsOrdPaymentPlanItemDetailsSalesOrderSalesOrderPaymentPlanItemPaymentPlanItemToSalesOrderGet**
> ASalesOrderType ASlsOrdPaymentPlanItemDetailsSalesOrderSalesOrderPaymentPlanItemPaymentPlanItemToSalesOrderGet (string salesOrder, string paymentPlanItem, List<string>? select = null, List<string>? expand = null)

Reads the sales order header for a payment plan item.

Reads the sales order header data for a specific payment plan item. Consumers must pass the following key fields: sales order ID and payment plan item ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ASlsOrdPaymentPlanItemDetailsSalesOrderSalesOrderPaymentPlanItemPaymentPlanItemToSalesOrderGetExample
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

            var apiInstance = new HeaderPaymentPlanApi(config);
            var salesOrder = "salesOrder_example";  // string | Sales Order
            var paymentPlanItem = "paymentPlanItem_example";  // string | Item for billing plan/invoice plan/payment cards
            var select = new List<string>?(); // List<string>? | Select properties to be returned, see [Select](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=68) (optional) 
            var expand = new List<string>?(); // List<string>? | Expand related entities, see [Expand](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=63) (optional) 

            try
            {
                // Reads the sales order header for a payment plan item.
                ASalesOrderType result = apiInstance.ASlsOrdPaymentPlanItemDetailsSalesOrderSalesOrderPaymentPlanItemPaymentPlanItemToSalesOrderGet(salesOrder, paymentPlanItem, select, expand);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HeaderPaymentPlanApi.ASlsOrdPaymentPlanItemDetailsSalesOrderSalesOrderPaymentPlanItemPaymentPlanItemToSalesOrderGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ASlsOrdPaymentPlanItemDetailsSalesOrderSalesOrderPaymentPlanItemPaymentPlanItemToSalesOrderGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Reads the sales order header for a payment plan item.
    ApiResponse<ASalesOrderType> response = apiInstance.ASlsOrdPaymentPlanItemDetailsSalesOrderSalesOrderPaymentPlanItemPaymentPlanItemToSalesOrderGetWithHttpInfo(salesOrder, paymentPlanItem, select, expand);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling HeaderPaymentPlanApi.ASlsOrdPaymentPlanItemDetailsSalesOrderSalesOrderPaymentPlanItemPaymentPlanItemToSalesOrderGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **salesOrder** | **string** | Sales Order |  |
| **paymentPlanItem** | **string** | Item for billing plan/invoice plan/payment cards |  |
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

