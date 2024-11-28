# Org.OpenAPITools.Api.ItemTextApi

All URIs are relative to *https://:/sap/opu/odata/sap/API_SALES_ORDER_SRV*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ASalesOrderItemSalesOrderSalesOrderSalesOrderItemSalesOrderItemToTextGet**](ItemTextApi.md#asalesorderitemsalesordersalesordersalesorderitemsalesorderitemtotextget) | **GET** /A_SalesOrderItem(SalesOrder&#x3D;&#39;{SalesOrder}&#39;,SalesOrderItem&#x3D;&#39;{SalesOrderItem}&#39;)/to_Text | Reads the text of a sales order item. |
| [**ASalesOrderItemSalesOrderSalesOrderSalesOrderItemSalesOrderItemToTextPost**](ItemTextApi.md#asalesorderitemsalesordersalesordersalesorderitemsalesorderitemtotextpost) | **POST** /A_SalesOrderItem(SalesOrder&#x3D;&#39;{SalesOrder}&#39;,SalesOrderItem&#x3D;&#39;{SalesOrderItem}&#39;)/to_Text | Creates a text for a specific sales order item. |
| [**ASalesOrderItemTextGet**](ItemTextApi.md#asalesorderitemtextget) | **GET** /A_SalesOrderItemText | Reads item texts of all sales orders. |
| [**ASalesOrderItemTextPost**](ItemTextApi.md#asalesorderitemtextpost) | **POST** /A_SalesOrderItemText | Creates an item text. |
| [**ASalesOrderItemTextSalesOrderSalesOrderSalesOrderItemSalesOrderItemLanguageLanguageLongTextIDLongTextIDDelete**](ItemTextApi.md#asalesorderitemtextsalesordersalesordersalesorderitemsalesorderitemlanguagelanguagelongtextidlongtextiddelete) | **DELETE** /A_SalesOrderItemText(SalesOrder&#x3D;&#39;{SalesOrder}&#39;,SalesOrderItem&#x3D;&#39;{SalesOrderItem}&#39;,Language&#x3D;&#39;{Language}&#39;,LongTextID&#x3D;&#39;{LongTextID}&#39;) | Deletes an item text. |
| [**ASalesOrderItemTextSalesOrderSalesOrderSalesOrderItemSalesOrderItemLanguageLanguageLongTextIDLongTextIDGet**](ItemTextApi.md#asalesorderitemtextsalesordersalesordersalesorderitemsalesorderitemlanguagelanguagelongtextidlongtextidget) | **GET** /A_SalesOrderItemText(SalesOrder&#x3D;&#39;{SalesOrder}&#39;,SalesOrderItem&#x3D;&#39;{SalesOrderItem}&#39;,Language&#x3D;&#39;{Language}&#39;,LongTextID&#x3D;&#39;{LongTextID}&#39;) | Reads an item text. |
| [**ASalesOrderItemTextSalesOrderSalesOrderSalesOrderItemSalesOrderItemLanguageLanguageLongTextIDLongTextIDPatch**](ItemTextApi.md#asalesorderitemtextsalesordersalesordersalesorderitemsalesorderitemlanguagelanguagelongtextidlongtextidpatch) | **PATCH** /A_SalesOrderItemText(SalesOrder&#x3D;&#39;{SalesOrder}&#39;,SalesOrderItem&#x3D;&#39;{SalesOrderItem}&#39;,Language&#x3D;&#39;{Language}&#39;,LongTextID&#x3D;&#39;{LongTextID}&#39;) | Updates an item text. |
| [**ASalesOrderItemTextSalesOrderSalesOrderSalesOrderItemSalesOrderItemLanguageLanguageLongTextIDLongTextIDToSalesOrderGet**](ItemTextApi.md#asalesorderitemtextsalesordersalesordersalesorderitemsalesorderitemlanguagelanguagelongtextidlongtextidtosalesorderget) | **GET** /A_SalesOrderItemText(SalesOrder&#x3D;&#39;{SalesOrder}&#39;,SalesOrderItem&#x3D;&#39;{SalesOrderItem}&#39;,Language&#x3D;&#39;{Language}&#39;,LongTextID&#x3D;&#39;{LongTextID}&#39;)/to_SalesOrder | Reads the sales order header for a text of a sales order item. |
| [**ASalesOrderItemTextSalesOrderSalesOrderSalesOrderItemSalesOrderItemLanguageLanguageLongTextIDLongTextIDToSalesOrderItemGet**](ItemTextApi.md#asalesorderitemtextsalesordersalesordersalesorderitemsalesorderitemlanguagelanguagelongtextidlongtextidtosalesorderitemget) | **GET** /A_SalesOrderItemText(SalesOrder&#x3D;&#39;{SalesOrder}&#39;,SalesOrderItem&#x3D;&#39;{SalesOrderItem}&#39;,Language&#x3D;&#39;{Language}&#39;,LongTextID&#x3D;&#39;{LongTextID}&#39;)/to_SalesOrderItem | Reads the sales order item for an item text. |

<a id="asalesorderitemsalesordersalesordersalesorderitemsalesorderitemtotextget"></a>
# **ASalesOrderItemSalesOrderSalesOrderSalesOrderItemSalesOrderItemToTextGet**
> Wrapper18 ASalesOrderItemSalesOrderSalesOrderSalesOrderItemSalesOrderItemToTextGet (string salesOrder, string salesOrderItem, int? top = null, int? skip = null, string? filter = null, string? inlinecount = null, List<string>? orderby = null, List<string>? select = null, List<string>? expand = null)

Reads the text of a sales order item.

Reads the text data for a specific item. Consumers must pass the following key fields: sales order ID and item number.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ASalesOrderItemSalesOrderSalesOrderSalesOrderItemSalesOrderItemToTextGetExample
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

            var apiInstance = new ItemTextApi(config);
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
                // Reads the text of a sales order item.
                Wrapper18 result = apiInstance.ASalesOrderItemSalesOrderSalesOrderSalesOrderItemSalesOrderItemToTextGet(salesOrder, salesOrderItem, top, skip, filter, inlinecount, orderby, select, expand);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ItemTextApi.ASalesOrderItemSalesOrderSalesOrderSalesOrderItemSalesOrderItemToTextGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ASalesOrderItemSalesOrderSalesOrderSalesOrderItemSalesOrderItemToTextGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Reads the text of a sales order item.
    ApiResponse<Wrapper18> response = apiInstance.ASalesOrderItemSalesOrderSalesOrderSalesOrderItemSalesOrderItemToTextGetWithHttpInfo(salesOrder, salesOrderItem, top, skip, filter, inlinecount, orderby, select, expand);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ItemTextApi.ASalesOrderItemSalesOrderSalesOrderSalesOrderItemSalesOrderItemToTextGetWithHttpInfo: " + e.Message);
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

[**Wrapper18**](Wrapper18.md)

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

<a id="asalesorderitemsalesordersalesordersalesorderitemsalesorderitemtotextpost"></a>
# **ASalesOrderItemSalesOrderSalesOrderSalesOrderItemSalesOrderItemToTextPost**
> ASalesOrderItemTextType ASalesOrderItemSalesOrderSalesOrderSalesOrderItemSalesOrderItemToTextPost (string salesOrder, string salesOrderItem, APISALESORDERSRVASalesOrderItemTextTypeCreate aPISALESORDERSRVASalesOrderItemTextTypeCreate)

Creates a text for a specific sales order item.

Creates the text data for a specific item. Consumers must pass the following key fields: sales order ID and item number.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ASalesOrderItemSalesOrderSalesOrderSalesOrderItemSalesOrderItemToTextPostExample
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

            var apiInstance = new ItemTextApi(config);
            var salesOrder = "salesOrder_example";  // string | Sales Order
            var salesOrderItem = "salesOrderItem_example";  // string | Sales Order Item
            var aPISALESORDERSRVASalesOrderItemTextTypeCreate = new APISALESORDERSRVASalesOrderItemTextTypeCreate(); // APISALESORDERSRVASalesOrderItemTextTypeCreate | New entity

            try
            {
                // Creates a text for a specific sales order item.
                ASalesOrderItemTextType result = apiInstance.ASalesOrderItemSalesOrderSalesOrderSalesOrderItemSalesOrderItemToTextPost(salesOrder, salesOrderItem, aPISALESORDERSRVASalesOrderItemTextTypeCreate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ItemTextApi.ASalesOrderItemSalesOrderSalesOrderSalesOrderItemSalesOrderItemToTextPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ASalesOrderItemSalesOrderSalesOrderSalesOrderItemSalesOrderItemToTextPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a text for a specific sales order item.
    ApiResponse<ASalesOrderItemTextType> response = apiInstance.ASalesOrderItemSalesOrderSalesOrderSalesOrderItemSalesOrderItemToTextPostWithHttpInfo(salesOrder, salesOrderItem, aPISALESORDERSRVASalesOrderItemTextTypeCreate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ItemTextApi.ASalesOrderItemSalesOrderSalesOrderSalesOrderItemSalesOrderItemToTextPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **salesOrder** | **string** | Sales Order |  |
| **salesOrderItem** | **string** | Sales Order Item |  |
| **aPISALESORDERSRVASalesOrderItemTextTypeCreate** | [**APISALESORDERSRVASalesOrderItemTextTypeCreate**](APISALESORDERSRVASalesOrderItemTextTypeCreate.md) | New entity |  |

### Return type

[**ASalesOrderItemTextType**](ASalesOrderItemTextType.md)

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

<a id="asalesorderitemtextget"></a>
# **ASalesOrderItemTextGet**
> Wrapper18 ASalesOrderItemTextGet (int? top = null, int? skip = null, string? filter = null, string? inlinecount = null, List<string>? orderby = null, List<string>? select = null, List<string>? expand = null)

Reads item texts of all sales orders.

Reads the text data from the items of all sales orders in the system.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ASalesOrderItemTextGetExample
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

            var apiInstance = new ItemTextApi(config);
            var top = 50;  // int? | Show only the first n items, see [Paging - Top](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=66) (optional) 
            var skip = 56;  // int? | Skip the first n items, see [Paging - Skip](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=65) (optional) 
            var filter = "filter_example";  // string? | Filter items by property values, see [Filtering](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=64) (optional) 
            var inlinecount = "allpages";  // string? | Include count of items, see [Inlinecount](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=67) (optional) 
            var orderby = new List<string>?(); // List<string>? | Order items by property values, see [Sorting](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=65) (optional) 
            var select = new List<string>?(); // List<string>? | Select properties to be returned, see [Select](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=68) (optional) 
            var expand = new List<string>?(); // List<string>? | Expand related entities, see [Expand](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=63) (optional) 

            try
            {
                // Reads item texts of all sales orders.
                Wrapper18 result = apiInstance.ASalesOrderItemTextGet(top, skip, filter, inlinecount, orderby, select, expand);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ItemTextApi.ASalesOrderItemTextGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ASalesOrderItemTextGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Reads item texts of all sales orders.
    ApiResponse<Wrapper18> response = apiInstance.ASalesOrderItemTextGetWithHttpInfo(top, skip, filter, inlinecount, orderby, select, expand);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ItemTextApi.ASalesOrderItemTextGetWithHttpInfo: " + e.Message);
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

[**Wrapper18**](Wrapper18.md)

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

<a id="asalesorderitemtextpost"></a>
# **ASalesOrderItemTextPost**
> ASalesOrderItemTextType ASalesOrderItemTextPost (APISALESORDERSRVASalesOrderItemTextTypeCreate aPISALESORDERSRVASalesOrderItemTextTypeCreate)

Creates an item text.

Creates a specific item text in a specific language. Consumers must pass the following key fields: sales order ID, item number, language, and text ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ASalesOrderItemTextPostExample
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

            var apiInstance = new ItemTextApi(config);
            var aPISALESORDERSRVASalesOrderItemTextTypeCreate = new APISALESORDERSRVASalesOrderItemTextTypeCreate(); // APISALESORDERSRVASalesOrderItemTextTypeCreate | New entity

            try
            {
                // Creates an item text.
                ASalesOrderItemTextType result = apiInstance.ASalesOrderItemTextPost(aPISALESORDERSRVASalesOrderItemTextTypeCreate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ItemTextApi.ASalesOrderItemTextPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ASalesOrderItemTextPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates an item text.
    ApiResponse<ASalesOrderItemTextType> response = apiInstance.ASalesOrderItemTextPostWithHttpInfo(aPISALESORDERSRVASalesOrderItemTextTypeCreate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ItemTextApi.ASalesOrderItemTextPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **aPISALESORDERSRVASalesOrderItemTextTypeCreate** | [**APISALESORDERSRVASalesOrderItemTextTypeCreate**](APISALESORDERSRVASalesOrderItemTextTypeCreate.md) | New entity |  |

### Return type

[**ASalesOrderItemTextType**](ASalesOrderItemTextType.md)

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

<a id="asalesorderitemtextsalesordersalesordersalesorderitemsalesorderitemlanguagelanguagelongtextidlongtextiddelete"></a>
# **ASalesOrderItemTextSalesOrderSalesOrderSalesOrderItemSalesOrderItemLanguageLanguageLongTextIDLongTextIDDelete**
> void ASalesOrderItemTextSalesOrderSalesOrderSalesOrderItemSalesOrderItemLanguageLanguageLongTextIDLongTextIDDelete (string salesOrder, string salesOrderItem, string language, string longTextID)

Deletes an item text.

Deletes a specific item text in a specific language. Consumers must pass the following key fields: sales order ID, item number, language, and text ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ASalesOrderItemTextSalesOrderSalesOrderSalesOrderItemSalesOrderItemLanguageLanguageLongTextIDLongTextIDDeleteExample
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

            var apiInstance = new ItemTextApi(config);
            var salesOrder = "salesOrder_example";  // string | Sales Order
            var salesOrderItem = "salesOrderItem_example";  // string | Sales Order Item
            var language = "language_example";  // string | Language Key
            var longTextID = "longTextID_example";  // string | Text ID

            try
            {
                // Deletes an item text.
                apiInstance.ASalesOrderItemTextSalesOrderSalesOrderSalesOrderItemSalesOrderItemLanguageLanguageLongTextIDLongTextIDDelete(salesOrder, salesOrderItem, language, longTextID);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ItemTextApi.ASalesOrderItemTextSalesOrderSalesOrderSalesOrderItemSalesOrderItemLanguageLanguageLongTextIDLongTextIDDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ASalesOrderItemTextSalesOrderSalesOrderSalesOrderItemSalesOrderItemLanguageLanguageLongTextIDLongTextIDDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deletes an item text.
    apiInstance.ASalesOrderItemTextSalesOrderSalesOrderSalesOrderItemSalesOrderItemLanguageLanguageLongTextIDLongTextIDDeleteWithHttpInfo(salesOrder, salesOrderItem, language, longTextID);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ItemTextApi.ASalesOrderItemTextSalesOrderSalesOrderSalesOrderItemSalesOrderItemLanguageLanguageLongTextIDLongTextIDDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **salesOrder** | **string** | Sales Order |  |
| **salesOrderItem** | **string** | Sales Order Item |  |
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

<a id="asalesorderitemtextsalesordersalesordersalesorderitemsalesorderitemlanguagelanguagelongtextidlongtextidget"></a>
# **ASalesOrderItemTextSalesOrderSalesOrderSalesOrderItemSalesOrderItemLanguageLanguageLongTextIDLongTextIDGet**
> ASalesOrderItemTextType ASalesOrderItemTextSalesOrderSalesOrderSalesOrderItemSalesOrderItemLanguageLanguageLongTextIDLongTextIDGet (string salesOrder, string salesOrderItem, string language, string longTextID, List<string>? select = null, List<string>? expand = null)

Reads an item text.

Reads a specific item text in a specific language. Consumers must pass the following key fields: sales order ID, item number, language, and text ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ASalesOrderItemTextSalesOrderSalesOrderSalesOrderItemSalesOrderItemLanguageLanguageLongTextIDLongTextIDGetExample
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

            var apiInstance = new ItemTextApi(config);
            var salesOrder = "salesOrder_example";  // string | Sales Order
            var salesOrderItem = "salesOrderItem_example";  // string | Sales Order Item
            var language = "language_example";  // string | Language Key
            var longTextID = "longTextID_example";  // string | Text ID
            var select = new List<string>?(); // List<string>? | Select properties to be returned, see [Select](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=68) (optional) 
            var expand = new List<string>?(); // List<string>? | Expand related entities, see [Expand](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=63) (optional) 

            try
            {
                // Reads an item text.
                ASalesOrderItemTextType result = apiInstance.ASalesOrderItemTextSalesOrderSalesOrderSalesOrderItemSalesOrderItemLanguageLanguageLongTextIDLongTextIDGet(salesOrder, salesOrderItem, language, longTextID, select, expand);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ItemTextApi.ASalesOrderItemTextSalesOrderSalesOrderSalesOrderItemSalesOrderItemLanguageLanguageLongTextIDLongTextIDGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ASalesOrderItemTextSalesOrderSalesOrderSalesOrderItemSalesOrderItemLanguageLanguageLongTextIDLongTextIDGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Reads an item text.
    ApiResponse<ASalesOrderItemTextType> response = apiInstance.ASalesOrderItemTextSalesOrderSalesOrderSalesOrderItemSalesOrderItemLanguageLanguageLongTextIDLongTextIDGetWithHttpInfo(salesOrder, salesOrderItem, language, longTextID, select, expand);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ItemTextApi.ASalesOrderItemTextSalesOrderSalesOrderSalesOrderItemSalesOrderItemLanguageLanguageLongTextIDLongTextIDGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **salesOrder** | **string** | Sales Order |  |
| **salesOrderItem** | **string** | Sales Order Item |  |
| **language** | **string** | Language Key |  |
| **longTextID** | **string** | Text ID |  |
| **select** | [**List&lt;string&gt;?**](string.md) | Select properties to be returned, see [Select](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page&#x3D;68) | [optional]  |
| **expand** | [**List&lt;string&gt;?**](string.md) | Expand related entities, see [Expand](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page&#x3D;63) | [optional]  |

### Return type

[**ASalesOrderItemTextType**](ASalesOrderItemTextType.md)

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

<a id="asalesorderitemtextsalesordersalesordersalesorderitemsalesorderitemlanguagelanguagelongtextidlongtextidpatch"></a>
# **ASalesOrderItemTextSalesOrderSalesOrderSalesOrderItemSalesOrderItemLanguageLanguageLongTextIDLongTextIDPatch**
> void ASalesOrderItemTextSalesOrderSalesOrderSalesOrderItemSalesOrderItemLanguageLanguageLongTextIDLongTextIDPatch (string salesOrder, string salesOrderItem, string language, string longTextID, ModifiedASalesOrderItemTextType modifiedASalesOrderItemTextType)

Updates an item text.

Updates a specific item text in a specific language. Consumers must pass the following key fields: sales order ID, sales order item number, language, and text ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ASalesOrderItemTextSalesOrderSalesOrderSalesOrderItemSalesOrderItemLanguageLanguageLongTextIDLongTextIDPatchExample
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

            var apiInstance = new ItemTextApi(config);
            var salesOrder = "salesOrder_example";  // string | Sales Order
            var salesOrderItem = "salesOrderItem_example";  // string | Sales Order Item
            var language = "language_example";  // string | Language Key
            var longTextID = "longTextID_example";  // string | Text ID
            var modifiedASalesOrderItemTextType = new ModifiedASalesOrderItemTextType(); // ModifiedASalesOrderItemTextType | New property values

            try
            {
                // Updates an item text.
                apiInstance.ASalesOrderItemTextSalesOrderSalesOrderSalesOrderItemSalesOrderItemLanguageLanguageLongTextIDLongTextIDPatch(salesOrder, salesOrderItem, language, longTextID, modifiedASalesOrderItemTextType);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ItemTextApi.ASalesOrderItemTextSalesOrderSalesOrderSalesOrderItemSalesOrderItemLanguageLanguageLongTextIDLongTextIDPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ASalesOrderItemTextSalesOrderSalesOrderSalesOrderItemSalesOrderItemLanguageLanguageLongTextIDLongTextIDPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates an item text.
    apiInstance.ASalesOrderItemTextSalesOrderSalesOrderSalesOrderItemSalesOrderItemLanguageLanguageLongTextIDLongTextIDPatchWithHttpInfo(salesOrder, salesOrderItem, language, longTextID, modifiedASalesOrderItemTextType);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ItemTextApi.ASalesOrderItemTextSalesOrderSalesOrderSalesOrderItemSalesOrderItemLanguageLanguageLongTextIDLongTextIDPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **salesOrder** | **string** | Sales Order |  |
| **salesOrderItem** | **string** | Sales Order Item |  |
| **language** | **string** | Language Key |  |
| **longTextID** | **string** | Text ID |  |
| **modifiedASalesOrderItemTextType** | [**ModifiedASalesOrderItemTextType**](ModifiedASalesOrderItemTextType.md) | New property values |  |

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

<a id="asalesorderitemtextsalesordersalesordersalesorderitemsalesorderitemlanguagelanguagelongtextidlongtextidtosalesorderget"></a>
# **ASalesOrderItemTextSalesOrderSalesOrderSalesOrderItemSalesOrderItemLanguageLanguageLongTextIDLongTextIDToSalesOrderGet**
> ASalesOrderType ASalesOrderItemTextSalesOrderSalesOrderSalesOrderItemSalesOrderItemLanguageLanguageLongTextIDLongTextIDToSalesOrderGet (string salesOrder, string salesOrderItem, string language, string longTextID, List<string>? select = null, List<string>? expand = null)

Reads the sales order header for a text of a sales order item.

Reads the sales order header data for a specific text of a specific sales order item in a specific language. Consumers must pass the following key fields: sales order ID, item number, language, and text ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ASalesOrderItemTextSalesOrderSalesOrderSalesOrderItemSalesOrderItemLanguageLanguageLongTextIDLongTextIDToSalesOrderGetExample
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

            var apiInstance = new ItemTextApi(config);
            var salesOrder = "salesOrder_example";  // string | Sales Order
            var salesOrderItem = "salesOrderItem_example";  // string | Sales Order Item
            var language = "language_example";  // string | Language Key
            var longTextID = "longTextID_example";  // string | Text ID
            var select = new List<string>?(); // List<string>? | Select properties to be returned, see [Select](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=68) (optional) 
            var expand = new List<string>?(); // List<string>? | Expand related entities, see [Expand](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=63) (optional) 

            try
            {
                // Reads the sales order header for a text of a sales order item.
                ASalesOrderType result = apiInstance.ASalesOrderItemTextSalesOrderSalesOrderSalesOrderItemSalesOrderItemLanguageLanguageLongTextIDLongTextIDToSalesOrderGet(salesOrder, salesOrderItem, language, longTextID, select, expand);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ItemTextApi.ASalesOrderItemTextSalesOrderSalesOrderSalesOrderItemSalesOrderItemLanguageLanguageLongTextIDLongTextIDToSalesOrderGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ASalesOrderItemTextSalesOrderSalesOrderSalesOrderItemSalesOrderItemLanguageLanguageLongTextIDLongTextIDToSalesOrderGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Reads the sales order header for a text of a sales order item.
    ApiResponse<ASalesOrderType> response = apiInstance.ASalesOrderItemTextSalesOrderSalesOrderSalesOrderItemSalesOrderItemLanguageLanguageLongTextIDLongTextIDToSalesOrderGetWithHttpInfo(salesOrder, salesOrderItem, language, longTextID, select, expand);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ItemTextApi.ASalesOrderItemTextSalesOrderSalesOrderSalesOrderItemSalesOrderItemLanguageLanguageLongTextIDLongTextIDToSalesOrderGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **salesOrder** | **string** | Sales Order |  |
| **salesOrderItem** | **string** | Sales Order Item |  |
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

<a id="asalesorderitemtextsalesordersalesordersalesorderitemsalesorderitemlanguagelanguagelongtextidlongtextidtosalesorderitemget"></a>
# **ASalesOrderItemTextSalesOrderSalesOrderSalesOrderItemSalesOrderItemLanguageLanguageLongTextIDLongTextIDToSalesOrderItemGet**
> ASalesOrderItemType ASalesOrderItemTextSalesOrderSalesOrderSalesOrderItemSalesOrderItemLanguageLanguageLongTextIDLongTextIDToSalesOrderItemGet (string salesOrder, string salesOrderItem, string language, string longTextID, List<string>? select = null, List<string>? expand = null)

Reads the sales order item for an item text.

Reads the sales order item data for a specific text in a specific language. Consumers must pass the following key fields: sales order ID, item number, language, and text ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ASalesOrderItemTextSalesOrderSalesOrderSalesOrderItemSalesOrderItemLanguageLanguageLongTextIDLongTextIDToSalesOrderItemGetExample
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

            var apiInstance = new ItemTextApi(config);
            var salesOrder = "salesOrder_example";  // string | Sales Order
            var salesOrderItem = "salesOrderItem_example";  // string | Sales Order Item
            var language = "language_example";  // string | Language Key
            var longTextID = "longTextID_example";  // string | Text ID
            var select = new List<string>?(); // List<string>? | Select properties to be returned, see [Select](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=68) (optional) 
            var expand = new List<string>?(); // List<string>? | Expand related entities, see [Expand](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=63) (optional) 

            try
            {
                // Reads the sales order item for an item text.
                ASalesOrderItemType result = apiInstance.ASalesOrderItemTextSalesOrderSalesOrderSalesOrderItemSalesOrderItemLanguageLanguageLongTextIDLongTextIDToSalesOrderItemGet(salesOrder, salesOrderItem, language, longTextID, select, expand);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ItemTextApi.ASalesOrderItemTextSalesOrderSalesOrderSalesOrderItemSalesOrderItemLanguageLanguageLongTextIDLongTextIDToSalesOrderItemGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ASalesOrderItemTextSalesOrderSalesOrderSalesOrderItemSalesOrderItemLanguageLanguageLongTextIDLongTextIDToSalesOrderItemGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Reads the sales order item for an item text.
    ApiResponse<ASalesOrderItemType> response = apiInstance.ASalesOrderItemTextSalesOrderSalesOrderSalesOrderItemSalesOrderItemLanguageLanguageLongTextIDLongTextIDToSalesOrderItemGetWithHttpInfo(salesOrder, salesOrderItem, language, longTextID, select, expand);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ItemTextApi.ASalesOrderItemTextSalesOrderSalesOrderSalesOrderItemSalesOrderItemLanguageLanguageLongTextIDLongTextIDToSalesOrderItemGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **salesOrder** | **string** | Sales Order |  |
| **salesOrderItem** | **string** | Sales Order Item |  |
| **language** | **string** | Language Key |  |
| **longTextID** | **string** | Text ID |  |
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

