# Org.OpenAPITools.Api.ItemPartnerApi

All URIs are relative to *https://:/sap/opu/odata/sap/API_SALES_ORDER_SRV*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ASalesOrderItemPartnerAddressSalesOrderSalesOrderSalesOrderItemSalesOrderItemPartnerFunctionPartnerFunctionAddressRepresentationCodeAddressRepresentationCodeToPartnerGet**](ItemPartnerApi.md#asalesorderitempartneraddresssalesordersalesordersalesorderitemsalesorderitempartnerfunctionpartnerfunctionaddressrepresentationcodeaddressrepresentationcodetopartnerget) | **GET** /A_SalesOrderItemPartnerAddress(SalesOrder&#x3D;&#39;{SalesOrder}&#39;,SalesOrderItem&#x3D;&#39;{SalesOrderItem}&#39;,PartnerFunction&#x3D;&#39;{PartnerFunction}&#39;,AddressRepresentationCode&#x3D;&#39;{AddressRepresentationCode}&#39;)/to_Partner | Reads the sales order item partner for an item partner address. |
| [**ASalesOrderItemPartnerGet**](ItemPartnerApi.md#asalesorderitempartnerget) | **GET** /A_SalesOrderItemPartner | Reads the item partners for all sales orders. |
| [**ASalesOrderItemPartnerPost**](ItemPartnerApi.md#asalesorderitempartnerpost) | **POST** /A_SalesOrderItemPartner | Creates a partner for a sales order item with a specific partner function. |
| [**ASalesOrderItemPartnerSalesOrderSalesOrderSalesOrderItemSalesOrderItemPartnerFunctionPartnerFunctionDelete**](ItemPartnerApi.md#asalesorderitempartnersalesordersalesordersalesorderitemsalesorderitempartnerfunctionpartnerfunctiondelete) | **DELETE** /A_SalesOrderItemPartner(SalesOrder&#x3D;&#39;{SalesOrder}&#39;,SalesOrderItem&#x3D;&#39;{SalesOrderItem}&#39;,PartnerFunction&#x3D;&#39;{PartnerFunction}&#39;) | Deletes a partner of a specific sales order item with a specific partner function. |
| [**ASalesOrderItemPartnerSalesOrderSalesOrderSalesOrderItemSalesOrderItemPartnerFunctionPartnerFunctionGet**](ItemPartnerApi.md#asalesorderitempartnersalesordersalesordersalesorderitemsalesorderitempartnerfunctionpartnerfunctionget) | **GET** /A_SalesOrderItemPartner(SalesOrder&#x3D;&#39;{SalesOrder}&#39;,SalesOrderItem&#x3D;&#39;{SalesOrderItem}&#39;,PartnerFunction&#x3D;&#39;{PartnerFunction}&#39;) | Reads an item partner of an item with a specific partner function in a specific sales order. |
| [**ASalesOrderItemPartnerSalesOrderSalesOrderSalesOrderItemSalesOrderItemPartnerFunctionPartnerFunctionPatch**](ItemPartnerApi.md#asalesorderitempartnersalesordersalesordersalesorderitemsalesorderitempartnerfunctionpartnerfunctionpatch) | **PATCH** /A_SalesOrderItemPartner(SalesOrder&#x3D;&#39;{SalesOrder}&#39;,SalesOrderItem&#x3D;&#39;{SalesOrderItem}&#39;,PartnerFunction&#x3D;&#39;{PartnerFunction}&#39;) | Updates a partner of a sales order item with a specific partner function. |
| [**ASalesOrderItemPartnerSalesOrderSalesOrderSalesOrderItemSalesOrderItemPartnerFunctionPartnerFunctionToAddressGet**](ItemPartnerApi.md#asalesorderitempartnersalesordersalesordersalesorderitemsalesorderitempartnerfunctionpartnerfunctiontoaddressget) | **GET** /A_SalesOrderItemPartner(SalesOrder&#x3D;&#39;{SalesOrder}&#39;,SalesOrderItem&#x3D;&#39;{SalesOrderItem}&#39;,PartnerFunction&#x3D;&#39;{PartnerFunction}&#39;)/to_Address | Reads the item address of a sales order item partner. |
| [**ASalesOrderItemPartnerSalesOrderSalesOrderSalesOrderItemSalesOrderItemPartnerFunctionPartnerFunctionToSalesOrderGet**](ItemPartnerApi.md#asalesorderitempartnersalesordersalesordersalesorderitemsalesorderitempartnerfunctionpartnerfunctiontosalesorderget) | **GET** /A_SalesOrderItemPartner(SalesOrder&#x3D;&#39;{SalesOrder}&#39;,SalesOrderItem&#x3D;&#39;{SalesOrderItem}&#39;,PartnerFunction&#x3D;&#39;{PartnerFunction}&#39;)/to_SalesOrder | Reads the sales order header of a partner function of a sales order item. |
| [**ASalesOrderItemPartnerSalesOrderSalesOrderSalesOrderItemSalesOrderItemPartnerFunctionPartnerFunctionToSalesOrderItemGet**](ItemPartnerApi.md#asalesorderitempartnersalesordersalesordersalesorderitemsalesorderitempartnerfunctionpartnerfunctiontosalesorderitemget) | **GET** /A_SalesOrderItemPartner(SalesOrder&#x3D;&#39;{SalesOrder}&#39;,SalesOrderItem&#x3D;&#39;{SalesOrderItem}&#39;,PartnerFunction&#x3D;&#39;{PartnerFunction}&#39;)/to_SalesOrderItem | Reads the sales order item for a partner function of a sales order item. |
| [**ASalesOrderItemSalesOrderSalesOrderSalesOrderItemSalesOrderItemToPartnerGet**](ItemPartnerApi.md#asalesorderitemsalesordersalesordersalesorderitemsalesorderitemtopartnerget) | **GET** /A_SalesOrderItem(SalesOrder&#x3D;&#39;{SalesOrder}&#39;,SalesOrderItem&#x3D;&#39;{SalesOrderItem}&#39;)/to_Partner | Reads the item partners of a specific sales order item. |
| [**ASalesOrderItemSalesOrderSalesOrderSalesOrderItemSalesOrderItemToPartnerPost**](ItemPartnerApi.md#asalesorderitemsalesordersalesordersalesorderitemsalesorderitemtopartnerpost) | **POST** /A_SalesOrderItem(SalesOrder&#x3D;&#39;{SalesOrder}&#39;,SalesOrderItem&#x3D;&#39;{SalesOrderItem}&#39;)/to_Partner | Creates an item partner for a specific sales order item. |

<a id="asalesorderitempartneraddresssalesordersalesordersalesorderitemsalesorderitempartnerfunctionpartnerfunctionaddressrepresentationcodeaddressrepresentationcodetopartnerget"></a>
# **ASalesOrderItemPartnerAddressSalesOrderSalesOrderSalesOrderItemSalesOrderItemPartnerFunctionPartnerFunctionAddressRepresentationCodeAddressRepresentationCodeToPartnerGet**
> ASalesOrderItemPartnerType ASalesOrderItemPartnerAddressSalesOrderSalesOrderSalesOrderItemSalesOrderItemPartnerFunctionPartnerFunctionAddressRepresentationCodeAddressRepresentationCodeToPartnerGet (string salesOrder, string salesOrderItem, string partnerFunction, string addressRepresentationCode, List<string>? select = null, List<string>? expand = null)

Reads the sales order item partner for an item partner address.

Reads the sales order item partner data for a specific item partner address. Consumers must pass the following key fields: sales order ID, item number, partner function, and the address representation code.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ASalesOrderItemPartnerAddressSalesOrderSalesOrderSalesOrderItemSalesOrderItemPartnerFunctionPartnerFunctionAddressRepresentationCodeAddressRepresentationCodeToPartnerGetExample
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

            var apiInstance = new ItemPartnerApi(config);
            var salesOrder = "salesOrder_example";  // string | Sales and Distribution Document Number
            var salesOrderItem = "salesOrderItem_example";  // string | Item number of the SD document
            var partnerFunction = "partnerFunction_example";  // string | Partner Function
            var addressRepresentationCode = "addressRepresentationCode_example";  // string | Version ID for International Addresses
            var select = new List<string>?(); // List<string>? | Select properties to be returned, see [Select](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=68) (optional) 
            var expand = new List<string>?(); // List<string>? | Expand related entities, see [Expand](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=63) (optional) 

            try
            {
                // Reads the sales order item partner for an item partner address.
                ASalesOrderItemPartnerType result = apiInstance.ASalesOrderItemPartnerAddressSalesOrderSalesOrderSalesOrderItemSalesOrderItemPartnerFunctionPartnerFunctionAddressRepresentationCodeAddressRepresentationCodeToPartnerGet(salesOrder, salesOrderItem, partnerFunction, addressRepresentationCode, select, expand);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ItemPartnerApi.ASalesOrderItemPartnerAddressSalesOrderSalesOrderSalesOrderItemSalesOrderItemPartnerFunctionPartnerFunctionAddressRepresentationCodeAddressRepresentationCodeToPartnerGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ASalesOrderItemPartnerAddressSalesOrderSalesOrderSalesOrderItemSalesOrderItemPartnerFunctionPartnerFunctionAddressRepresentationCodeAddressRepresentationCodeToPartnerGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Reads the sales order item partner for an item partner address.
    ApiResponse<ASalesOrderItemPartnerType> response = apiInstance.ASalesOrderItemPartnerAddressSalesOrderSalesOrderSalesOrderItemSalesOrderItemPartnerFunctionPartnerFunctionAddressRepresentationCodeAddressRepresentationCodeToPartnerGetWithHttpInfo(salesOrder, salesOrderItem, partnerFunction, addressRepresentationCode, select, expand);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ItemPartnerApi.ASalesOrderItemPartnerAddressSalesOrderSalesOrderSalesOrderItemSalesOrderItemPartnerFunctionPartnerFunctionAddressRepresentationCodeAddressRepresentationCodeToPartnerGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **salesOrder** | **string** | Sales and Distribution Document Number |  |
| **salesOrderItem** | **string** | Item number of the SD document |  |
| **partnerFunction** | **string** | Partner Function |  |
| **addressRepresentationCode** | **string** | Version ID for International Addresses |  |
| **select** | [**List&lt;string&gt;?**](string.md) | Select properties to be returned, see [Select](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page&#x3D;68) | [optional]  |
| **expand** | [**List&lt;string&gt;?**](string.md) | Expand related entities, see [Expand](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page&#x3D;63) | [optional]  |

### Return type

[**ASalesOrderItemPartnerType**](ASalesOrderItemPartnerType.md)

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

<a id="asalesorderitempartnerget"></a>
# **ASalesOrderItemPartnerGet**
> Wrapper12 ASalesOrderItemPartnerGet (int? top = null, int? skip = null, string? filter = null, string? inlinecount = null, List<string>? orderby = null, List<string>? select = null, List<string>? expand = null)

Reads the item partners for all sales orders.

Reads the partner data from the items of all sales orders in the system.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ASalesOrderItemPartnerGetExample
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

            var apiInstance = new ItemPartnerApi(config);
            var top = 50;  // int? | Show only the first n items, see [Paging - Top](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=66) (optional) 
            var skip = 56;  // int? | Skip the first n items, see [Paging - Skip](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=65) (optional) 
            var filter = "filter_example";  // string? | Filter items by property values, see [Filtering](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=64) (optional) 
            var inlinecount = "allpages";  // string? | Include count of items, see [Inlinecount](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=67) (optional) 
            var orderby = new List<string>?(); // List<string>? | Order items by property values, see [Sorting](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=65) (optional) 
            var select = new List<string>?(); // List<string>? | Select properties to be returned, see [Select](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=68) (optional) 
            var expand = new List<string>?(); // List<string>? | Expand related entities, see [Expand](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=63) (optional) 

            try
            {
                // Reads the item partners for all sales orders.
                Wrapper12 result = apiInstance.ASalesOrderItemPartnerGet(top, skip, filter, inlinecount, orderby, select, expand);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ItemPartnerApi.ASalesOrderItemPartnerGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ASalesOrderItemPartnerGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Reads the item partners for all sales orders.
    ApiResponse<Wrapper12> response = apiInstance.ASalesOrderItemPartnerGetWithHttpInfo(top, skip, filter, inlinecount, orderby, select, expand);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ItemPartnerApi.ASalesOrderItemPartnerGetWithHttpInfo: " + e.Message);
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

[**Wrapper12**](Wrapper12.md)

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

<a id="asalesorderitempartnerpost"></a>
# **ASalesOrderItemPartnerPost**
> ASalesOrderItemPartnerType ASalesOrderItemPartnerPost (APISALESORDERSRVASalesOrderItemPartnerTypeCreate aPISALESORDERSRVASalesOrderItemPartnerTypeCreate)

Creates a partner for a sales order item with a specific partner function.

Creates an item partner with a specific partner function for a specific sales order item. Consumers must pass the following key fields: sales order ID, item number, and partner function.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ASalesOrderItemPartnerPostExample
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

            var apiInstance = new ItemPartnerApi(config);
            var aPISALESORDERSRVASalesOrderItemPartnerTypeCreate = new APISALESORDERSRVASalesOrderItemPartnerTypeCreate(); // APISALESORDERSRVASalesOrderItemPartnerTypeCreate | New entity

            try
            {
                // Creates a partner for a sales order item with a specific partner function.
                ASalesOrderItemPartnerType result = apiInstance.ASalesOrderItemPartnerPost(aPISALESORDERSRVASalesOrderItemPartnerTypeCreate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ItemPartnerApi.ASalesOrderItemPartnerPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ASalesOrderItemPartnerPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a partner for a sales order item with a specific partner function.
    ApiResponse<ASalesOrderItemPartnerType> response = apiInstance.ASalesOrderItemPartnerPostWithHttpInfo(aPISALESORDERSRVASalesOrderItemPartnerTypeCreate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ItemPartnerApi.ASalesOrderItemPartnerPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **aPISALESORDERSRVASalesOrderItemPartnerTypeCreate** | [**APISALESORDERSRVASalesOrderItemPartnerTypeCreate**](APISALESORDERSRVASalesOrderItemPartnerTypeCreate.md) | New entity |  |

### Return type

[**ASalesOrderItemPartnerType**](ASalesOrderItemPartnerType.md)

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

<a id="asalesorderitempartnersalesordersalesordersalesorderitemsalesorderitempartnerfunctionpartnerfunctiondelete"></a>
# **ASalesOrderItemPartnerSalesOrderSalesOrderSalesOrderItemSalesOrderItemPartnerFunctionPartnerFunctionDelete**
> void ASalesOrderItemPartnerSalesOrderSalesOrderSalesOrderItemSalesOrderItemPartnerFunctionPartnerFunctionDelete (string salesOrder, string salesOrderItem, string partnerFunction)

Deletes a partner of a specific sales order item with a specific partner function.

Deletes an item partner with a specific partner function of a specific sales order item. Consumers must pass the following key fields: sales order ID, item number, and partner function.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ASalesOrderItemPartnerSalesOrderSalesOrderSalesOrderItemSalesOrderItemPartnerFunctionPartnerFunctionDeleteExample
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

            var apiInstance = new ItemPartnerApi(config);
            var salesOrder = "salesOrder_example";  // string | Sales Order
            var salesOrderItem = "salesOrderItem_example";  // string | Sales Order Item
            var partnerFunction = "partnerFunction_example";  // string | Partner Function

            try
            {
                // Deletes a partner of a specific sales order item with a specific partner function.
                apiInstance.ASalesOrderItemPartnerSalesOrderSalesOrderSalesOrderItemSalesOrderItemPartnerFunctionPartnerFunctionDelete(salesOrder, salesOrderItem, partnerFunction);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ItemPartnerApi.ASalesOrderItemPartnerSalesOrderSalesOrderSalesOrderItemSalesOrderItemPartnerFunctionPartnerFunctionDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ASalesOrderItemPartnerSalesOrderSalesOrderSalesOrderItemSalesOrderItemPartnerFunctionPartnerFunctionDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deletes a partner of a specific sales order item with a specific partner function.
    apiInstance.ASalesOrderItemPartnerSalesOrderSalesOrderSalesOrderItemSalesOrderItemPartnerFunctionPartnerFunctionDeleteWithHttpInfo(salesOrder, salesOrderItem, partnerFunction);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ItemPartnerApi.ASalesOrderItemPartnerSalesOrderSalesOrderSalesOrderItemSalesOrderItemPartnerFunctionPartnerFunctionDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **salesOrder** | **string** | Sales Order |  |
| **salesOrderItem** | **string** | Sales Order Item |  |
| **partnerFunction** | **string** | Partner Function |  |

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

<a id="asalesorderitempartnersalesordersalesordersalesorderitemsalesorderitempartnerfunctionpartnerfunctionget"></a>
# **ASalesOrderItemPartnerSalesOrderSalesOrderSalesOrderItemSalesOrderItemPartnerFunctionPartnerFunctionGet**
> ASalesOrderItemPartnerType ASalesOrderItemPartnerSalesOrderSalesOrderSalesOrderItemSalesOrderItemPartnerFunctionPartnerFunctionGet (string salesOrder, string salesOrderItem, string partnerFunction, List<string>? select = null, List<string>? expand = null)

Reads an item partner of an item with a specific partner function in a specific sales order.

Reads an item partner with a specific partner function of a specific sales order item. Consumers must pass the following key fields: sales order ID, item number, and partner function.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ASalesOrderItemPartnerSalesOrderSalesOrderSalesOrderItemSalesOrderItemPartnerFunctionPartnerFunctionGetExample
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

            var apiInstance = new ItemPartnerApi(config);
            var salesOrder = "salesOrder_example";  // string | Sales Order
            var salesOrderItem = "salesOrderItem_example";  // string | Sales Order Item
            var partnerFunction = "partnerFunction_example";  // string | Partner Function
            var select = new List<string>?(); // List<string>? | Select properties to be returned, see [Select](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=68) (optional) 
            var expand = new List<string>?(); // List<string>? | Expand related entities, see [Expand](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=63) (optional) 

            try
            {
                // Reads an item partner of an item with a specific partner function in a specific sales order.
                ASalesOrderItemPartnerType result = apiInstance.ASalesOrderItemPartnerSalesOrderSalesOrderSalesOrderItemSalesOrderItemPartnerFunctionPartnerFunctionGet(salesOrder, salesOrderItem, partnerFunction, select, expand);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ItemPartnerApi.ASalesOrderItemPartnerSalesOrderSalesOrderSalesOrderItemSalesOrderItemPartnerFunctionPartnerFunctionGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ASalesOrderItemPartnerSalesOrderSalesOrderSalesOrderItemSalesOrderItemPartnerFunctionPartnerFunctionGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Reads an item partner of an item with a specific partner function in a specific sales order.
    ApiResponse<ASalesOrderItemPartnerType> response = apiInstance.ASalesOrderItemPartnerSalesOrderSalesOrderSalesOrderItemSalesOrderItemPartnerFunctionPartnerFunctionGetWithHttpInfo(salesOrder, salesOrderItem, partnerFunction, select, expand);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ItemPartnerApi.ASalesOrderItemPartnerSalesOrderSalesOrderSalesOrderItemSalesOrderItemPartnerFunctionPartnerFunctionGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **salesOrder** | **string** | Sales Order |  |
| **salesOrderItem** | **string** | Sales Order Item |  |
| **partnerFunction** | **string** | Partner Function |  |
| **select** | [**List&lt;string&gt;?**](string.md) | Select properties to be returned, see [Select](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page&#x3D;68) | [optional]  |
| **expand** | [**List&lt;string&gt;?**](string.md) | Expand related entities, see [Expand](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page&#x3D;63) | [optional]  |

### Return type

[**ASalesOrderItemPartnerType**](ASalesOrderItemPartnerType.md)

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

<a id="asalesorderitempartnersalesordersalesordersalesorderitemsalesorderitempartnerfunctionpartnerfunctionpatch"></a>
# **ASalesOrderItemPartnerSalesOrderSalesOrderSalesOrderItemSalesOrderItemPartnerFunctionPartnerFunctionPatch**
> void ASalesOrderItemPartnerSalesOrderSalesOrderSalesOrderItemSalesOrderItemPartnerFunctionPartnerFunctionPatch (string salesOrder, string salesOrderItem, string partnerFunction, ModifiedASalesOrderItemPartnerType modifiedASalesOrderItemPartnerType)

Updates a partner of a sales order item with a specific partner function.

Updates an item partner with a specific partner function of a specific sales order item. Consumers must pass the following key fields: sales order ID, item number, and partner function.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ASalesOrderItemPartnerSalesOrderSalesOrderSalesOrderItemSalesOrderItemPartnerFunctionPartnerFunctionPatchExample
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

            var apiInstance = new ItemPartnerApi(config);
            var salesOrder = "salesOrder_example";  // string | Sales Order
            var salesOrderItem = "salesOrderItem_example";  // string | Sales Order Item
            var partnerFunction = "partnerFunction_example";  // string | Partner Function
            var modifiedASalesOrderItemPartnerType = new ModifiedASalesOrderItemPartnerType(); // ModifiedASalesOrderItemPartnerType | New property values

            try
            {
                // Updates a partner of a sales order item with a specific partner function.
                apiInstance.ASalesOrderItemPartnerSalesOrderSalesOrderSalesOrderItemSalesOrderItemPartnerFunctionPartnerFunctionPatch(salesOrder, salesOrderItem, partnerFunction, modifiedASalesOrderItemPartnerType);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ItemPartnerApi.ASalesOrderItemPartnerSalesOrderSalesOrderSalesOrderItemSalesOrderItemPartnerFunctionPartnerFunctionPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ASalesOrderItemPartnerSalesOrderSalesOrderSalesOrderItemSalesOrderItemPartnerFunctionPartnerFunctionPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates a partner of a sales order item with a specific partner function.
    apiInstance.ASalesOrderItemPartnerSalesOrderSalesOrderSalesOrderItemSalesOrderItemPartnerFunctionPartnerFunctionPatchWithHttpInfo(salesOrder, salesOrderItem, partnerFunction, modifiedASalesOrderItemPartnerType);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ItemPartnerApi.ASalesOrderItemPartnerSalesOrderSalesOrderSalesOrderItemSalesOrderItemPartnerFunctionPartnerFunctionPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **salesOrder** | **string** | Sales Order |  |
| **salesOrderItem** | **string** | Sales Order Item |  |
| **partnerFunction** | **string** | Partner Function |  |
| **modifiedASalesOrderItemPartnerType** | [**ModifiedASalesOrderItemPartnerType**](ModifiedASalesOrderItemPartnerType.md) | New property values |  |

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

<a id="asalesorderitempartnersalesordersalesordersalesorderitemsalesorderitempartnerfunctionpartnerfunctiontoaddressget"></a>
# **ASalesOrderItemPartnerSalesOrderSalesOrderSalesOrderItemSalesOrderItemPartnerFunctionPartnerFunctionToAddressGet**
> Wrapper21 ASalesOrderItemPartnerSalesOrderSalesOrderSalesOrderItemSalesOrderItemPartnerFunctionPartnerFunctionToAddressGet (string salesOrder, string salesOrderItem, string partnerFunction, int? top = null, int? skip = null, string? filter = null, string? inlinecount = null, List<string>? orderby = null, List<string>? select = null, List<string>? expand = null)

Reads the item address of a sales order item partner.

Reads the item address data for a specific sales order item partner. Consumers must pass the following key fields: sales order ID, item number, and partner function.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ASalesOrderItemPartnerSalesOrderSalesOrderSalesOrderItemSalesOrderItemPartnerFunctionPartnerFunctionToAddressGetExample
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

            var apiInstance = new ItemPartnerApi(config);
            var salesOrder = "salesOrder_example";  // string | Sales Order
            var salesOrderItem = "salesOrderItem_example";  // string | Sales Order Item
            var partnerFunction = "partnerFunction_example";  // string | Partner Function
            var top = 50;  // int? | Show only the first n items, see [Paging - Top](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=66) (optional) 
            var skip = 56;  // int? | Skip the first n items, see [Paging - Skip](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=65) (optional) 
            var filter = "filter_example";  // string? | Filter items by property values, see [Filtering](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=64) (optional) 
            var inlinecount = "allpages";  // string? | Include count of items, see [Inlinecount](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=67) (optional) 
            var orderby = new List<string>?(); // List<string>? | Order items by property values, see [Sorting](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=65) (optional) 
            var select = new List<string>?(); // List<string>? | Select properties to be returned, see [Select](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=68) (optional) 
            var expand = new List<string>?(); // List<string>? | Expand related entities, see [Expand](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=63) (optional) 

            try
            {
                // Reads the item address of a sales order item partner.
                Wrapper21 result = apiInstance.ASalesOrderItemPartnerSalesOrderSalesOrderSalesOrderItemSalesOrderItemPartnerFunctionPartnerFunctionToAddressGet(salesOrder, salesOrderItem, partnerFunction, top, skip, filter, inlinecount, orderby, select, expand);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ItemPartnerApi.ASalesOrderItemPartnerSalesOrderSalesOrderSalesOrderItemSalesOrderItemPartnerFunctionPartnerFunctionToAddressGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ASalesOrderItemPartnerSalesOrderSalesOrderSalesOrderItemSalesOrderItemPartnerFunctionPartnerFunctionToAddressGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Reads the item address of a sales order item partner.
    ApiResponse<Wrapper21> response = apiInstance.ASalesOrderItemPartnerSalesOrderSalesOrderSalesOrderItemSalesOrderItemPartnerFunctionPartnerFunctionToAddressGetWithHttpInfo(salesOrder, salesOrderItem, partnerFunction, top, skip, filter, inlinecount, orderby, select, expand);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ItemPartnerApi.ASalesOrderItemPartnerSalesOrderSalesOrderSalesOrderItemSalesOrderItemPartnerFunctionPartnerFunctionToAddressGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **salesOrder** | **string** | Sales Order |  |
| **salesOrderItem** | **string** | Sales Order Item |  |
| **partnerFunction** | **string** | Partner Function |  |
| **top** | **int?** | Show only the first n items, see [Paging - Top](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page&#x3D;66) | [optional]  |
| **skip** | **int?** | Skip the first n items, see [Paging - Skip](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page&#x3D;65) | [optional]  |
| **filter** | **string?** | Filter items by property values, see [Filtering](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page&#x3D;64) | [optional]  |
| **inlinecount** | **string?** | Include count of items, see [Inlinecount](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page&#x3D;67) | [optional]  |
| **orderby** | [**List&lt;string&gt;?**](string.md) | Order items by property values, see [Sorting](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page&#x3D;65) | [optional]  |
| **select** | [**List&lt;string&gt;?**](string.md) | Select properties to be returned, see [Select](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page&#x3D;68) | [optional]  |
| **expand** | [**List&lt;string&gt;?**](string.md) | Expand related entities, see [Expand](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page&#x3D;63) | [optional]  |

### Return type

[**Wrapper21**](Wrapper21.md)

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

<a id="asalesorderitempartnersalesordersalesordersalesorderitemsalesorderitempartnerfunctionpartnerfunctiontosalesorderget"></a>
# **ASalesOrderItemPartnerSalesOrderSalesOrderSalesOrderItemSalesOrderItemPartnerFunctionPartnerFunctionToSalesOrderGet**
> ASalesOrderType ASalesOrderItemPartnerSalesOrderSalesOrderSalesOrderItemSalesOrderItemPartnerFunctionPartnerFunctionToSalesOrderGet (string salesOrder, string salesOrderItem, string partnerFunction, List<string>? select = null, List<string>? expand = null)

Reads the sales order header of a partner function of a sales order item.

Reads the sales order header data for a specific item partner function. Consumers must pass the following key fields: sales order ID, item number, and partner function.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ASalesOrderItemPartnerSalesOrderSalesOrderSalesOrderItemSalesOrderItemPartnerFunctionPartnerFunctionToSalesOrderGetExample
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

            var apiInstance = new ItemPartnerApi(config);
            var salesOrder = "salesOrder_example";  // string | Sales Order
            var salesOrderItem = "salesOrderItem_example";  // string | Sales Order Item
            var partnerFunction = "partnerFunction_example";  // string | Partner Function
            var select = new List<string>?(); // List<string>? | Select properties to be returned, see [Select](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=68) (optional) 
            var expand = new List<string>?(); // List<string>? | Expand related entities, see [Expand](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=63) (optional) 

            try
            {
                // Reads the sales order header of a partner function of a sales order item.
                ASalesOrderType result = apiInstance.ASalesOrderItemPartnerSalesOrderSalesOrderSalesOrderItemSalesOrderItemPartnerFunctionPartnerFunctionToSalesOrderGet(salesOrder, salesOrderItem, partnerFunction, select, expand);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ItemPartnerApi.ASalesOrderItemPartnerSalesOrderSalesOrderSalesOrderItemSalesOrderItemPartnerFunctionPartnerFunctionToSalesOrderGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ASalesOrderItemPartnerSalesOrderSalesOrderSalesOrderItemSalesOrderItemPartnerFunctionPartnerFunctionToSalesOrderGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Reads the sales order header of a partner function of a sales order item.
    ApiResponse<ASalesOrderType> response = apiInstance.ASalesOrderItemPartnerSalesOrderSalesOrderSalesOrderItemSalesOrderItemPartnerFunctionPartnerFunctionToSalesOrderGetWithHttpInfo(salesOrder, salesOrderItem, partnerFunction, select, expand);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ItemPartnerApi.ASalesOrderItemPartnerSalesOrderSalesOrderSalesOrderItemSalesOrderItemPartnerFunctionPartnerFunctionToSalesOrderGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **salesOrder** | **string** | Sales Order |  |
| **salesOrderItem** | **string** | Sales Order Item |  |
| **partnerFunction** | **string** | Partner Function |  |
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

<a id="asalesorderitempartnersalesordersalesordersalesorderitemsalesorderitempartnerfunctionpartnerfunctiontosalesorderitemget"></a>
# **ASalesOrderItemPartnerSalesOrderSalesOrderSalesOrderItemSalesOrderItemPartnerFunctionPartnerFunctionToSalesOrderItemGet**
> ASalesOrderItemType ASalesOrderItemPartnerSalesOrderSalesOrderSalesOrderItemSalesOrderItemPartnerFunctionPartnerFunctionToSalesOrderItemGet (string salesOrder, string salesOrderItem, string partnerFunction, List<string>? select = null, List<string>? expand = null)

Reads the sales order item for a partner function of a sales order item.

Reads the sales order item data for a specific item partner function. Consumers must pass the following key fields: sales order ID, item number, and partner function.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ASalesOrderItemPartnerSalesOrderSalesOrderSalesOrderItemSalesOrderItemPartnerFunctionPartnerFunctionToSalesOrderItemGetExample
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

            var apiInstance = new ItemPartnerApi(config);
            var salesOrder = "salesOrder_example";  // string | Sales Order
            var salesOrderItem = "salesOrderItem_example";  // string | Sales Order Item
            var partnerFunction = "partnerFunction_example";  // string | Partner Function
            var select = new List<string>?(); // List<string>? | Select properties to be returned, see [Select](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=68) (optional) 
            var expand = new List<string>?(); // List<string>? | Expand related entities, see [Expand](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=63) (optional) 

            try
            {
                // Reads the sales order item for a partner function of a sales order item.
                ASalesOrderItemType result = apiInstance.ASalesOrderItemPartnerSalesOrderSalesOrderSalesOrderItemSalesOrderItemPartnerFunctionPartnerFunctionToSalesOrderItemGet(salesOrder, salesOrderItem, partnerFunction, select, expand);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ItemPartnerApi.ASalesOrderItemPartnerSalesOrderSalesOrderSalesOrderItemSalesOrderItemPartnerFunctionPartnerFunctionToSalesOrderItemGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ASalesOrderItemPartnerSalesOrderSalesOrderSalesOrderItemSalesOrderItemPartnerFunctionPartnerFunctionToSalesOrderItemGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Reads the sales order item for a partner function of a sales order item.
    ApiResponse<ASalesOrderItemType> response = apiInstance.ASalesOrderItemPartnerSalesOrderSalesOrderSalesOrderItemSalesOrderItemPartnerFunctionPartnerFunctionToSalesOrderItemGetWithHttpInfo(salesOrder, salesOrderItem, partnerFunction, select, expand);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ItemPartnerApi.ASalesOrderItemPartnerSalesOrderSalesOrderSalesOrderItemSalesOrderItemPartnerFunctionPartnerFunctionToSalesOrderItemGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **salesOrder** | **string** | Sales Order |  |
| **salesOrderItem** | **string** | Sales Order Item |  |
| **partnerFunction** | **string** | Partner Function |  |
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

<a id="asalesorderitemsalesordersalesordersalesorderitemsalesorderitemtopartnerget"></a>
# **ASalesOrderItemSalesOrderSalesOrderSalesOrderItemSalesOrderItemToPartnerGet**
> Wrapper12 ASalesOrderItemSalesOrderSalesOrderSalesOrderItemSalesOrderItemToPartnerGet (string salesOrder, string salesOrderItem, int? top = null, int? skip = null, string? filter = null, string? inlinecount = null, List<string>? orderby = null, List<string>? select = null, List<string>? expand = null)

Reads the item partners of a specific sales order item.

Reads the partner data for a specific item of a specific sales order. Consumers must pass the following key fields: sales order ID and item number.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ASalesOrderItemSalesOrderSalesOrderSalesOrderItemSalesOrderItemToPartnerGetExample
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

            var apiInstance = new ItemPartnerApi(config);
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
                // Reads the item partners of a specific sales order item.
                Wrapper12 result = apiInstance.ASalesOrderItemSalesOrderSalesOrderSalesOrderItemSalesOrderItemToPartnerGet(salesOrder, salesOrderItem, top, skip, filter, inlinecount, orderby, select, expand);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ItemPartnerApi.ASalesOrderItemSalesOrderSalesOrderSalesOrderItemSalesOrderItemToPartnerGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ASalesOrderItemSalesOrderSalesOrderSalesOrderItemSalesOrderItemToPartnerGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Reads the item partners of a specific sales order item.
    ApiResponse<Wrapper12> response = apiInstance.ASalesOrderItemSalesOrderSalesOrderSalesOrderItemSalesOrderItemToPartnerGetWithHttpInfo(salesOrder, salesOrderItem, top, skip, filter, inlinecount, orderby, select, expand);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ItemPartnerApi.ASalesOrderItemSalesOrderSalesOrderSalesOrderItemSalesOrderItemToPartnerGetWithHttpInfo: " + e.Message);
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

[**Wrapper12**](Wrapper12.md)

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

<a id="asalesorderitemsalesordersalesordersalesorderitemsalesorderitemtopartnerpost"></a>
# **ASalesOrderItemSalesOrderSalesOrderSalesOrderItemSalesOrderItemToPartnerPost**
> ASalesOrderItemPartnerType ASalesOrderItemSalesOrderSalesOrderSalesOrderItemSalesOrderItemToPartnerPost (string salesOrder, string salesOrderItem, APISALESORDERSRVASalesOrderItemPartnerTypeCreate aPISALESORDERSRVASalesOrderItemPartnerTypeCreate)

Creates an item partner for a specific sales order item.

Creates the partner data for a specific item of a specific sales order. Consumers must pass the following key fields: sales order ID and item number.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ASalesOrderItemSalesOrderSalesOrderSalesOrderItemSalesOrderItemToPartnerPostExample
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

            var apiInstance = new ItemPartnerApi(config);
            var salesOrder = "salesOrder_example";  // string | Sales Order
            var salesOrderItem = "salesOrderItem_example";  // string | Sales Order Item
            var aPISALESORDERSRVASalesOrderItemPartnerTypeCreate = new APISALESORDERSRVASalesOrderItemPartnerTypeCreate(); // APISALESORDERSRVASalesOrderItemPartnerTypeCreate | New entity

            try
            {
                // Creates an item partner for a specific sales order item.
                ASalesOrderItemPartnerType result = apiInstance.ASalesOrderItemSalesOrderSalesOrderSalesOrderItemSalesOrderItemToPartnerPost(salesOrder, salesOrderItem, aPISALESORDERSRVASalesOrderItemPartnerTypeCreate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ItemPartnerApi.ASalesOrderItemSalesOrderSalesOrderSalesOrderItemSalesOrderItemToPartnerPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ASalesOrderItemSalesOrderSalesOrderSalesOrderItemSalesOrderItemToPartnerPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates an item partner for a specific sales order item.
    ApiResponse<ASalesOrderItemPartnerType> response = apiInstance.ASalesOrderItemSalesOrderSalesOrderSalesOrderItemSalesOrderItemToPartnerPostWithHttpInfo(salesOrder, salesOrderItem, aPISALESORDERSRVASalesOrderItemPartnerTypeCreate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ItemPartnerApi.ASalesOrderItemSalesOrderSalesOrderSalesOrderItemSalesOrderItemToPartnerPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **salesOrder** | **string** | Sales Order |  |
| **salesOrderItem** | **string** | Sales Order Item |  |
| **aPISALESORDERSRVASalesOrderItemPartnerTypeCreate** | [**APISALESORDERSRVASalesOrderItemPartnerTypeCreate**](APISALESORDERSRVASalesOrderItemPartnerTypeCreate.md) | New entity |  |

### Return type

[**ASalesOrderItemPartnerType**](ASalesOrderItemPartnerType.md)

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

