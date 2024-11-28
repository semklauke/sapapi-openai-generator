# Org.OpenAPITools.Api.HeaderPricingElementApi

All URIs are relative to *https://:/sap/opu/odata/sap/API_SALES_ORDER_SRV*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ASalesOrderHeaderPrElementGet**](HeaderPricingElementApi.md#asalesorderheaderprelementget) | **GET** /A_SalesOrderHeaderPrElement | Reads the header pricing elements of all sales orders. |
| [**ASalesOrderHeaderPrElementPost**](HeaderPricingElementApi.md#asalesorderheaderprelementpost) | **POST** /A_SalesOrderHeaderPrElement | Creates a header pricing element for a sales order. |
| [**ASalesOrderHeaderPrElementSalesOrderSalesOrderPricingProcedureStepPricingProcedureStepPricingProcedureCounterPricingProcedureCounterDelete**](HeaderPricingElementApi.md#asalesorderheaderprelementsalesordersalesorderpricingproceduresteppricingproceduresteppricingprocedurecounterpricingprocedurecounterdelete) | **DELETE** /A_SalesOrderHeaderPrElement(SalesOrder&#x3D;&#39;{SalesOrder}&#39;,PricingProcedureStep&#x3D;&#39;{PricingProcedureStep}&#39;,PricingProcedureCounter&#x3D;&#39;{PricingProcedureCounter}&#39;) | Deletes a header pricing element for a sales order. |
| [**ASalesOrderHeaderPrElementSalesOrderSalesOrderPricingProcedureStepPricingProcedureStepPricingProcedureCounterPricingProcedureCounterGet**](HeaderPricingElementApi.md#asalesorderheaderprelementsalesordersalesorderpricingproceduresteppricingproceduresteppricingprocedurecounterpricingprocedurecounterget) | **GET** /A_SalesOrderHeaderPrElement(SalesOrder&#x3D;&#39;{SalesOrder}&#39;,PricingProcedureStep&#x3D;&#39;{PricingProcedureStep}&#39;,PricingProcedureCounter&#x3D;&#39;{PricingProcedureCounter}&#39;) | Reads the header pricing element for a sales order. |
| [**ASalesOrderHeaderPrElementSalesOrderSalesOrderPricingProcedureStepPricingProcedureStepPricingProcedureCounterPricingProcedureCounterPatch**](HeaderPricingElementApi.md#asalesorderheaderprelementsalesordersalesorderpricingproceduresteppricingproceduresteppricingprocedurecounterpricingprocedurecounterpatch) | **PATCH** /A_SalesOrderHeaderPrElement(SalesOrder&#x3D;&#39;{SalesOrder}&#39;,PricingProcedureStep&#x3D;&#39;{PricingProcedureStep}&#39;,PricingProcedureCounter&#x3D;&#39;{PricingProcedureCounter}&#39;) | Updates a header pricing element for a sales order. |
| [**ASalesOrderHeaderPrElementSalesOrderSalesOrderPricingProcedureStepPricingProcedureStepPricingProcedureCounterPricingProcedureCounterToSalesOrderGet**](HeaderPricingElementApi.md#asalesorderheaderprelementsalesordersalesorderpricingproceduresteppricingproceduresteppricingprocedurecounterpricingprocedurecountertosalesorderget) | **GET** /A_SalesOrderHeaderPrElement(SalesOrder&#x3D;&#39;{SalesOrder}&#39;,PricingProcedureStep&#x3D;&#39;{PricingProcedureStep}&#39;,PricingProcedureCounter&#x3D;&#39;{PricingProcedureCounter}&#39;)/to_SalesOrder | Reads the sales order header for a pricing element. |
| [**ASalesOrderSalesOrderToPricingElementGet**](HeaderPricingElementApi.md#asalesordersalesordertopricingelementget) | **GET** /A_SalesOrder(&#39;{SalesOrder}&#39;)/to_PricingElement | Reads the pricing element of a sales order. |
| [**ASalesOrderSalesOrderToPricingElementPost**](HeaderPricingElementApi.md#asalesordersalesordertopricingelementpost) | **POST** /A_SalesOrder(&#39;{SalesOrder}&#39;)/to_PricingElement | Creates a header pricing element for a specific sales order. |

<a id="asalesorderheaderprelementget"></a>
# **ASalesOrderHeaderPrElementGet**
> Wrapper5 ASalesOrderHeaderPrElementGet (int? top = null, int? skip = null, string? filter = null, string? inlinecount = null, List<string>? orderby = null, List<string>? select = null, List<string>? expand = null)

Reads the header pricing elements of all sales orders.

Reads the pricing element data from the headers of all sales orders in the system.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ASalesOrderHeaderPrElementGetExample
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

            var apiInstance = new HeaderPricingElementApi(config);
            var top = 50;  // int? | Show only the first n items, see [Paging - Top](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=66) (optional) 
            var skip = 56;  // int? | Skip the first n items, see [Paging - Skip](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=65) (optional) 
            var filter = "filter_example";  // string? | Filter items by property values, see [Filtering](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=64) (optional) 
            var inlinecount = "allpages";  // string? | Include count of items, see [Inlinecount](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=67) (optional) 
            var orderby = new List<string>?(); // List<string>? | Order items by property values, see [Sorting](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=65) (optional) 
            var select = new List<string>?(); // List<string>? | Select properties to be returned, see [Select](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=68) (optional) 
            var expand = new List<string>?(); // List<string>? | Expand related entities, see [Expand](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=63) (optional) 

            try
            {
                // Reads the header pricing elements of all sales orders.
                Wrapper5 result = apiInstance.ASalesOrderHeaderPrElementGet(top, skip, filter, inlinecount, orderby, select, expand);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HeaderPricingElementApi.ASalesOrderHeaderPrElementGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ASalesOrderHeaderPrElementGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Reads the header pricing elements of all sales orders.
    ApiResponse<Wrapper5> response = apiInstance.ASalesOrderHeaderPrElementGetWithHttpInfo(top, skip, filter, inlinecount, orderby, select, expand);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling HeaderPricingElementApi.ASalesOrderHeaderPrElementGetWithHttpInfo: " + e.Message);
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

[**Wrapper5**](Wrapper5.md)

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

<a id="asalesorderheaderprelementpost"></a>
# **ASalesOrderHeaderPrElementPost**
> ASalesOrderHeaderPrElementType ASalesOrderHeaderPrElementPost (APISALESORDERSRVASalesOrderHeaderPrElementTypeCreate aPISALESORDERSRVASalesOrderHeaderPrElementTypeCreate)

Creates a header pricing element for a sales order.

Creates the pricing element data for the header of a specific sales order. Consumers must pass the following key fields: sales order ID, pricing procedure step, and pricing procedure counter.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ASalesOrderHeaderPrElementPostExample
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

            var apiInstance = new HeaderPricingElementApi(config);
            var aPISALESORDERSRVASalesOrderHeaderPrElementTypeCreate = new APISALESORDERSRVASalesOrderHeaderPrElementTypeCreate(); // APISALESORDERSRVASalesOrderHeaderPrElementTypeCreate | New entity

            try
            {
                // Creates a header pricing element for a sales order.
                ASalesOrderHeaderPrElementType result = apiInstance.ASalesOrderHeaderPrElementPost(aPISALESORDERSRVASalesOrderHeaderPrElementTypeCreate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HeaderPricingElementApi.ASalesOrderHeaderPrElementPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ASalesOrderHeaderPrElementPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a header pricing element for a sales order.
    ApiResponse<ASalesOrderHeaderPrElementType> response = apiInstance.ASalesOrderHeaderPrElementPostWithHttpInfo(aPISALESORDERSRVASalesOrderHeaderPrElementTypeCreate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling HeaderPricingElementApi.ASalesOrderHeaderPrElementPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **aPISALESORDERSRVASalesOrderHeaderPrElementTypeCreate** | [**APISALESORDERSRVASalesOrderHeaderPrElementTypeCreate**](APISALESORDERSRVASalesOrderHeaderPrElementTypeCreate.md) | New entity |  |

### Return type

[**ASalesOrderHeaderPrElementType**](ASalesOrderHeaderPrElementType.md)

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

<a id="asalesorderheaderprelementsalesordersalesorderpricingproceduresteppricingproceduresteppricingprocedurecounterpricingprocedurecounterdelete"></a>
# **ASalesOrderHeaderPrElementSalesOrderSalesOrderPricingProcedureStepPricingProcedureStepPricingProcedureCounterPricingProcedureCounterDelete**
> void ASalesOrderHeaderPrElementSalesOrderSalesOrderPricingProcedureStepPricingProcedureStepPricingProcedureCounterPricingProcedureCounterDelete (string salesOrder, string pricingProcedureStep, string pricingProcedureCounter)

Deletes a header pricing element for a sales order.

Deletes the pricing element data from the header of a specific sales order. Consumers must pass the following key fields: sales order ID, pricing procedure step, and pricing procedure counter.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ASalesOrderHeaderPrElementSalesOrderSalesOrderPricingProcedureStepPricingProcedureStepPricingProcedureCounterPricingProcedureCounterDeleteExample
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

            var apiInstance = new HeaderPricingElementApi(config);
            var salesOrder = "salesOrder_example";  // string | Sales Order
            var pricingProcedureStep = "pricingProcedureStep_example";  // string | Step Number
            var pricingProcedureCounter = "pricingProcedureCounter_example";  // string | Condition Counter

            try
            {
                // Deletes a header pricing element for a sales order.
                apiInstance.ASalesOrderHeaderPrElementSalesOrderSalesOrderPricingProcedureStepPricingProcedureStepPricingProcedureCounterPricingProcedureCounterDelete(salesOrder, pricingProcedureStep, pricingProcedureCounter);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HeaderPricingElementApi.ASalesOrderHeaderPrElementSalesOrderSalesOrderPricingProcedureStepPricingProcedureStepPricingProcedureCounterPricingProcedureCounterDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ASalesOrderHeaderPrElementSalesOrderSalesOrderPricingProcedureStepPricingProcedureStepPricingProcedureCounterPricingProcedureCounterDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deletes a header pricing element for a sales order.
    apiInstance.ASalesOrderHeaderPrElementSalesOrderSalesOrderPricingProcedureStepPricingProcedureStepPricingProcedureCounterPricingProcedureCounterDeleteWithHttpInfo(salesOrder, pricingProcedureStep, pricingProcedureCounter);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling HeaderPricingElementApi.ASalesOrderHeaderPrElementSalesOrderSalesOrderPricingProcedureStepPricingProcedureStepPricingProcedureCounterPricingProcedureCounterDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **salesOrder** | **string** | Sales Order |  |
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

<a id="asalesorderheaderprelementsalesordersalesorderpricingproceduresteppricingproceduresteppricingprocedurecounterpricingprocedurecounterget"></a>
# **ASalesOrderHeaderPrElementSalesOrderSalesOrderPricingProcedureStepPricingProcedureStepPricingProcedureCounterPricingProcedureCounterGet**
> ASalesOrderHeaderPrElementType ASalesOrderHeaderPrElementSalesOrderSalesOrderPricingProcedureStepPricingProcedureStepPricingProcedureCounterPricingProcedureCounterGet (string salesOrder, string pricingProcedureStep, string pricingProcedureCounter, List<string>? select = null, List<string>? expand = null)

Reads the header pricing element for a sales order.

Reads the pricing element data from the header of a specific sales order. Consumers must pass the following key fields: sales order ID, pricing procedure step, and pricing procedure counter.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ASalesOrderHeaderPrElementSalesOrderSalesOrderPricingProcedureStepPricingProcedureStepPricingProcedureCounterPricingProcedureCounterGetExample
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

            var apiInstance = new HeaderPricingElementApi(config);
            var salesOrder = "salesOrder_example";  // string | Sales Order
            var pricingProcedureStep = "pricingProcedureStep_example";  // string | Step Number
            var pricingProcedureCounter = "pricingProcedureCounter_example";  // string | Condition Counter
            var select = new List<string>?(); // List<string>? | Select properties to be returned, see [Select](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=68) (optional) 
            var expand = new List<string>?(); // List<string>? | Expand related entities, see [Expand](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=63) (optional) 

            try
            {
                // Reads the header pricing element for a sales order.
                ASalesOrderHeaderPrElementType result = apiInstance.ASalesOrderHeaderPrElementSalesOrderSalesOrderPricingProcedureStepPricingProcedureStepPricingProcedureCounterPricingProcedureCounterGet(salesOrder, pricingProcedureStep, pricingProcedureCounter, select, expand);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HeaderPricingElementApi.ASalesOrderHeaderPrElementSalesOrderSalesOrderPricingProcedureStepPricingProcedureStepPricingProcedureCounterPricingProcedureCounterGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ASalesOrderHeaderPrElementSalesOrderSalesOrderPricingProcedureStepPricingProcedureStepPricingProcedureCounterPricingProcedureCounterGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Reads the header pricing element for a sales order.
    ApiResponse<ASalesOrderHeaderPrElementType> response = apiInstance.ASalesOrderHeaderPrElementSalesOrderSalesOrderPricingProcedureStepPricingProcedureStepPricingProcedureCounterPricingProcedureCounterGetWithHttpInfo(salesOrder, pricingProcedureStep, pricingProcedureCounter, select, expand);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling HeaderPricingElementApi.ASalesOrderHeaderPrElementSalesOrderSalesOrderPricingProcedureStepPricingProcedureStepPricingProcedureCounterPricingProcedureCounterGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **salesOrder** | **string** | Sales Order |  |
| **pricingProcedureStep** | **string** | Step Number |  |
| **pricingProcedureCounter** | **string** | Condition Counter |  |
| **select** | [**List&lt;string&gt;?**](string.md) | Select properties to be returned, see [Select](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page&#x3D;68) | [optional]  |
| **expand** | [**List&lt;string&gt;?**](string.md) | Expand related entities, see [Expand](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page&#x3D;63) | [optional]  |

### Return type

[**ASalesOrderHeaderPrElementType**](ASalesOrderHeaderPrElementType.md)

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

<a id="asalesorderheaderprelementsalesordersalesorderpricingproceduresteppricingproceduresteppricingprocedurecounterpricingprocedurecounterpatch"></a>
# **ASalesOrderHeaderPrElementSalesOrderSalesOrderPricingProcedureStepPricingProcedureStepPricingProcedureCounterPricingProcedureCounterPatch**
> void ASalesOrderHeaderPrElementSalesOrderSalesOrderPricingProcedureStepPricingProcedureStepPricingProcedureCounterPricingProcedureCounterPatch (string salesOrder, string pricingProcedureStep, string pricingProcedureCounter, ModifiedASalesOrderHeaderPrElementType modifiedASalesOrderHeaderPrElementType)

Updates a header pricing element for a sales order.

Updates the pricing element data from the header of a specific sales order. Consumers must pass the following key fields: sales order ID, pricing procedure step, and pricing procedure counter.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ASalesOrderHeaderPrElementSalesOrderSalesOrderPricingProcedureStepPricingProcedureStepPricingProcedureCounterPricingProcedureCounterPatchExample
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

            var apiInstance = new HeaderPricingElementApi(config);
            var salesOrder = "salesOrder_example";  // string | Sales Order
            var pricingProcedureStep = "pricingProcedureStep_example";  // string | Step Number
            var pricingProcedureCounter = "pricingProcedureCounter_example";  // string | Condition Counter
            var modifiedASalesOrderHeaderPrElementType = new ModifiedASalesOrderHeaderPrElementType(); // ModifiedASalesOrderHeaderPrElementType | New property values

            try
            {
                // Updates a header pricing element for a sales order.
                apiInstance.ASalesOrderHeaderPrElementSalesOrderSalesOrderPricingProcedureStepPricingProcedureStepPricingProcedureCounterPricingProcedureCounterPatch(salesOrder, pricingProcedureStep, pricingProcedureCounter, modifiedASalesOrderHeaderPrElementType);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HeaderPricingElementApi.ASalesOrderHeaderPrElementSalesOrderSalesOrderPricingProcedureStepPricingProcedureStepPricingProcedureCounterPricingProcedureCounterPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ASalesOrderHeaderPrElementSalesOrderSalesOrderPricingProcedureStepPricingProcedureStepPricingProcedureCounterPricingProcedureCounterPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates a header pricing element for a sales order.
    apiInstance.ASalesOrderHeaderPrElementSalesOrderSalesOrderPricingProcedureStepPricingProcedureStepPricingProcedureCounterPricingProcedureCounterPatchWithHttpInfo(salesOrder, pricingProcedureStep, pricingProcedureCounter, modifiedASalesOrderHeaderPrElementType);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling HeaderPricingElementApi.ASalesOrderHeaderPrElementSalesOrderSalesOrderPricingProcedureStepPricingProcedureStepPricingProcedureCounterPricingProcedureCounterPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **salesOrder** | **string** | Sales Order |  |
| **pricingProcedureStep** | **string** | Step Number |  |
| **pricingProcedureCounter** | **string** | Condition Counter |  |
| **modifiedASalesOrderHeaderPrElementType** | [**ModifiedASalesOrderHeaderPrElementType**](ModifiedASalesOrderHeaderPrElementType.md) | New property values |  |

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

<a id="asalesorderheaderprelementsalesordersalesorderpricingproceduresteppricingproceduresteppricingprocedurecounterpricingprocedurecountertosalesorderget"></a>
# **ASalesOrderHeaderPrElementSalesOrderSalesOrderPricingProcedureStepPricingProcedureStepPricingProcedureCounterPricingProcedureCounterToSalesOrderGet**
> ASalesOrderType ASalesOrderHeaderPrElementSalesOrderSalesOrderPricingProcedureStepPricingProcedureStepPricingProcedureCounterPricingProcedureCounterToSalesOrderGet (string salesOrder, string pricingProcedureStep, string pricingProcedureCounter, List<string>? select = null, List<string>? expand = null)

Reads the sales order header for a pricing element.

Reads the sales order header data for a specific pricing element. Consumers must pass the following key fields: sales order ID, pricing procedure step, and pricing procedure counter.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ASalesOrderHeaderPrElementSalesOrderSalesOrderPricingProcedureStepPricingProcedureStepPricingProcedureCounterPricingProcedureCounterToSalesOrderGetExample
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

            var apiInstance = new HeaderPricingElementApi(config);
            var salesOrder = "salesOrder_example";  // string | Sales Order
            var pricingProcedureStep = "pricingProcedureStep_example";  // string | Step Number
            var pricingProcedureCounter = "pricingProcedureCounter_example";  // string | Condition Counter
            var select = new List<string>?(); // List<string>? | Select properties to be returned, see [Select](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=68) (optional) 
            var expand = new List<string>?(); // List<string>? | Expand related entities, see [Expand](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=63) (optional) 

            try
            {
                // Reads the sales order header for a pricing element.
                ASalesOrderType result = apiInstance.ASalesOrderHeaderPrElementSalesOrderSalesOrderPricingProcedureStepPricingProcedureStepPricingProcedureCounterPricingProcedureCounterToSalesOrderGet(salesOrder, pricingProcedureStep, pricingProcedureCounter, select, expand);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HeaderPricingElementApi.ASalesOrderHeaderPrElementSalesOrderSalesOrderPricingProcedureStepPricingProcedureStepPricingProcedureCounterPricingProcedureCounterToSalesOrderGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ASalesOrderHeaderPrElementSalesOrderSalesOrderPricingProcedureStepPricingProcedureStepPricingProcedureCounterPricingProcedureCounterToSalesOrderGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Reads the sales order header for a pricing element.
    ApiResponse<ASalesOrderType> response = apiInstance.ASalesOrderHeaderPrElementSalesOrderSalesOrderPricingProcedureStepPricingProcedureStepPricingProcedureCounterPricingProcedureCounterToSalesOrderGetWithHttpInfo(salesOrder, pricingProcedureStep, pricingProcedureCounter, select, expand);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling HeaderPricingElementApi.ASalesOrderHeaderPrElementSalesOrderSalesOrderPricingProcedureStepPricingProcedureStepPricingProcedureCounterPricingProcedureCounterToSalesOrderGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **salesOrder** | **string** | Sales Order |  |
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

<a id="asalesordersalesordertopricingelementget"></a>
# **ASalesOrderSalesOrderToPricingElementGet**
> Wrapper5 ASalesOrderSalesOrderToPricingElementGet (string salesOrder, int? top = null, int? skip = null, string? filter = null, string? inlinecount = null, List<string>? orderby = null, List<string>? select = null, List<string>? expand = null)

Reads the pricing element of a sales order.

Reads the pricing element data from the header of a specific sales order. Consumers must pass the sales order ID (key field).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ASalesOrderSalesOrderToPricingElementGetExample
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

            var apiInstance = new HeaderPricingElementApi(config);
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
                // Reads the pricing element of a sales order.
                Wrapper5 result = apiInstance.ASalesOrderSalesOrderToPricingElementGet(salesOrder, top, skip, filter, inlinecount, orderby, select, expand);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HeaderPricingElementApi.ASalesOrderSalesOrderToPricingElementGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ASalesOrderSalesOrderToPricingElementGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Reads the pricing element of a sales order.
    ApiResponse<Wrapper5> response = apiInstance.ASalesOrderSalesOrderToPricingElementGetWithHttpInfo(salesOrder, top, skip, filter, inlinecount, orderby, select, expand);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling HeaderPricingElementApi.ASalesOrderSalesOrderToPricingElementGetWithHttpInfo: " + e.Message);
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

[**Wrapper5**](Wrapper5.md)

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

<a id="asalesordersalesordertopricingelementpost"></a>
# **ASalesOrderSalesOrderToPricingElementPost**
> ASalesOrderHeaderPrElementType ASalesOrderSalesOrderToPricingElementPost (string salesOrder, APISALESORDERSRVASalesOrderHeaderPrElementTypeCreate aPISALESORDERSRVASalesOrderHeaderPrElementTypeCreate)

Creates a header pricing element for a specific sales order.

Creates the pricing element data for a specific sales order header. Consumers must pass the sales order ID (key field).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ASalesOrderSalesOrderToPricingElementPostExample
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

            var apiInstance = new HeaderPricingElementApi(config);
            var salesOrder = "salesOrder_example";  // string | Sales Order
            var aPISALESORDERSRVASalesOrderHeaderPrElementTypeCreate = new APISALESORDERSRVASalesOrderHeaderPrElementTypeCreate(); // APISALESORDERSRVASalesOrderHeaderPrElementTypeCreate | New entity

            try
            {
                // Creates a header pricing element for a specific sales order.
                ASalesOrderHeaderPrElementType result = apiInstance.ASalesOrderSalesOrderToPricingElementPost(salesOrder, aPISALESORDERSRVASalesOrderHeaderPrElementTypeCreate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HeaderPricingElementApi.ASalesOrderSalesOrderToPricingElementPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ASalesOrderSalesOrderToPricingElementPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a header pricing element for a specific sales order.
    ApiResponse<ASalesOrderHeaderPrElementType> response = apiInstance.ASalesOrderSalesOrderToPricingElementPostWithHttpInfo(salesOrder, aPISALESORDERSRVASalesOrderHeaderPrElementTypeCreate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling HeaderPricingElementApi.ASalesOrderSalesOrderToPricingElementPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **salesOrder** | **string** | Sales Order |  |
| **aPISALESORDERSRVASalesOrderHeaderPrElementTypeCreate** | [**APISALESORDERSRVASalesOrderHeaderPrElementTypeCreate**](APISALESORDERSRVASalesOrderHeaderPrElementTypeCreate.md) | New entity |  |

### Return type

[**ASalesOrderHeaderPrElementType**](ASalesOrderHeaderPrElementType.md)

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

