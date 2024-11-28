# Org.OpenAPITools.Api.HeaderPartnerAddressApi

All URIs are relative to *https://:/sap/opu/odata/sap/API_SALES_ORDER_SRV*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ASalesOrderHeaderPartnerSalesOrderSalesOrderPartnerFunctionPartnerFunctionToAddressGet**](HeaderPartnerAddressApi.md#asalesorderheaderpartnersalesordersalesorderpartnerfunctionpartnerfunctiontoaddressget) | **GET** /A_SalesOrderHeaderPartner(SalesOrder&#x3D;&#39;{SalesOrder}&#39;,PartnerFunction&#x3D;&#39;{PartnerFunction}&#39;)/to_Address | Reads the address of a sales order header partner. |
| [**ASalesOrderPartnerAddressGet**](HeaderPartnerAddressApi.md#asalesorderpartneraddressget) | **GET** /A_SalesOrderPartnerAddress | Reads all addresses for header partners of sales orders. |
| [**ASalesOrderPartnerAddressSalesOrderSalesOrderPartnerFunctionPartnerFunctionAddressRepresentationCodeAddressRepresentationCodeGet**](HeaderPartnerAddressApi.md#asalesorderpartneraddresssalesordersalesorderpartnerfunctionpartnerfunctionaddressrepresentationcodeaddressrepresentationcodeget) | **GET** /A_SalesOrderPartnerAddress(SalesOrder&#x3D;&#39;{SalesOrder}&#39;,PartnerFunction&#x3D;&#39;{PartnerFunction}&#39;,AddressRepresentationCode&#x3D;&#39;{AddressRepresentationCode}&#39;) | Reads the address of a header partner of a sales order. |
| [**ASalesOrderPartnerAddressSalesOrderSalesOrderPartnerFunctionPartnerFunctionAddressRepresentationCodeAddressRepresentationCodePatch**](HeaderPartnerAddressApi.md#asalesorderpartneraddresssalesordersalesorderpartnerfunctionpartnerfunctionaddressrepresentationcodeaddressrepresentationcodepatch) | **PATCH** /A_SalesOrderPartnerAddress(SalesOrder&#x3D;&#39;{SalesOrder}&#39;,PartnerFunction&#x3D;&#39;{PartnerFunction}&#39;,AddressRepresentationCode&#x3D;&#39;{AddressRepresentationCode}&#39;) | Updates the address of a header partner of a sales order. |
| [**ASalesOrderPartnerAddressSalesOrderSalesOrderPartnerFunctionPartnerFunctionAddressRepresentationCodeAddressRepresentationCodeToPartnerGet**](HeaderPartnerAddressApi.md#asalesorderpartneraddresssalesordersalesorderpartnerfunctionpartnerfunctionaddressrepresentationcodeaddressrepresentationcodetopartnerget) | **GET** /A_SalesOrderPartnerAddress(SalesOrder&#x3D;&#39;{SalesOrder}&#39;,PartnerFunction&#x3D;&#39;{PartnerFunction}&#39;,AddressRepresentationCode&#x3D;&#39;{AddressRepresentationCode}&#39;)/to_Partner | Reads the sales order header partner for a header partner address. |
| [**ASalesOrderPartnerAddressSalesOrderSalesOrderPartnerFunctionPartnerFunctionAddressRepresentationCodeAddressRepresentationCodeToSalesOrderGet**](HeaderPartnerAddressApi.md#asalesorderpartneraddresssalesordersalesorderpartnerfunctionpartnerfunctionaddressrepresentationcodeaddressrepresentationcodetosalesorderget) | **GET** /A_SalesOrderPartnerAddress(SalesOrder&#x3D;&#39;{SalesOrder}&#39;,PartnerFunction&#x3D;&#39;{PartnerFunction}&#39;,AddressRepresentationCode&#x3D;&#39;{AddressRepresentationCode}&#39;)/to_SalesOrder | Reads the sales order for a header partner address. |

<a id="asalesorderheaderpartnersalesordersalesorderpartnerfunctionpartnerfunctiontoaddressget"></a>
# **ASalesOrderHeaderPartnerSalesOrderSalesOrderPartnerFunctionPartnerFunctionToAddressGet**
> Wrapper11 ASalesOrderHeaderPartnerSalesOrderSalesOrderPartnerFunctionPartnerFunctionToAddressGet (string salesOrder, string partnerFunction, int? top = null, int? skip = null, string? filter = null, string? inlinecount = null, List<string>? orderby = null, List<string>? select = null, List<string>? expand = null)

Reads the address of a sales order header partner.

Reads the header address data for a specific sales order header partner. Consumers must pass the following key fields: sales order ID and partner function.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ASalesOrderHeaderPartnerSalesOrderSalesOrderPartnerFunctionPartnerFunctionToAddressGetExample
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

            var apiInstance = new HeaderPartnerAddressApi(config);
            var salesOrder = "salesOrder_example";  // string | Sales Order
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
                // Reads the address of a sales order header partner.
                Wrapper11 result = apiInstance.ASalesOrderHeaderPartnerSalesOrderSalesOrderPartnerFunctionPartnerFunctionToAddressGet(salesOrder, partnerFunction, top, skip, filter, inlinecount, orderby, select, expand);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HeaderPartnerAddressApi.ASalesOrderHeaderPartnerSalesOrderSalesOrderPartnerFunctionPartnerFunctionToAddressGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ASalesOrderHeaderPartnerSalesOrderSalesOrderPartnerFunctionPartnerFunctionToAddressGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Reads the address of a sales order header partner.
    ApiResponse<Wrapper11> response = apiInstance.ASalesOrderHeaderPartnerSalesOrderSalesOrderPartnerFunctionPartnerFunctionToAddressGetWithHttpInfo(salesOrder, partnerFunction, top, skip, filter, inlinecount, orderby, select, expand);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling HeaderPartnerAddressApi.ASalesOrderHeaderPartnerSalesOrderSalesOrderPartnerFunctionPartnerFunctionToAddressGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **salesOrder** | **string** | Sales Order |  |
| **partnerFunction** | **string** | Partner Function |  |
| **top** | **int?** | Show only the first n items, see [Paging - Top](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page&#x3D;66) | [optional]  |
| **skip** | **int?** | Skip the first n items, see [Paging - Skip](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page&#x3D;65) | [optional]  |
| **filter** | **string?** | Filter items by property values, see [Filtering](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page&#x3D;64) | [optional]  |
| **inlinecount** | **string?** | Include count of items, see [Inlinecount](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page&#x3D;67) | [optional]  |
| **orderby** | [**List&lt;string&gt;?**](string.md) | Order items by property values, see [Sorting](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page&#x3D;65) | [optional]  |
| **select** | [**List&lt;string&gt;?**](string.md) | Select properties to be returned, see [Select](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page&#x3D;68) | [optional]  |
| **expand** | [**List&lt;string&gt;?**](string.md) | Expand related entities, see [Expand](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page&#x3D;63) | [optional]  |

### Return type

[**Wrapper11**](Wrapper11.md)

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

<a id="asalesorderpartneraddressget"></a>
# **ASalesOrderPartnerAddressGet**
> Wrapper11 ASalesOrderPartnerAddressGet (int? top = null, int? skip = null, string? filter = null, string? inlinecount = null, List<string>? orderby = null, List<string>? select = null, List<string>? expand = null)

Reads all addresses for header partners of sales orders.

Reads the address data of all header partners of sales orders in the system.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ASalesOrderPartnerAddressGetExample
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

            var apiInstance = new HeaderPartnerAddressApi(config);
            var top = 50;  // int? | Show only the first n items, see [Paging - Top](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=66) (optional) 
            var skip = 56;  // int? | Skip the first n items, see [Paging - Skip](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=65) (optional) 
            var filter = "filter_example";  // string? | Filter items by property values, see [Filtering](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=64) (optional) 
            var inlinecount = "allpages";  // string? | Include count of items, see [Inlinecount](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=67) (optional) 
            var orderby = new List<string>?(); // List<string>? | Order items by property values, see [Sorting](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=65) (optional) 
            var select = new List<string>?(); // List<string>? | Select properties to be returned, see [Select](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=68) (optional) 
            var expand = new List<string>?(); // List<string>? | Expand related entities, see [Expand](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=63) (optional) 

            try
            {
                // Reads all addresses for header partners of sales orders.
                Wrapper11 result = apiInstance.ASalesOrderPartnerAddressGet(top, skip, filter, inlinecount, orderby, select, expand);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HeaderPartnerAddressApi.ASalesOrderPartnerAddressGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ASalesOrderPartnerAddressGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Reads all addresses for header partners of sales orders.
    ApiResponse<Wrapper11> response = apiInstance.ASalesOrderPartnerAddressGetWithHttpInfo(top, skip, filter, inlinecount, orderby, select, expand);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling HeaderPartnerAddressApi.ASalesOrderPartnerAddressGetWithHttpInfo: " + e.Message);
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

[**Wrapper11**](Wrapper11.md)

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

<a id="asalesorderpartneraddresssalesordersalesorderpartnerfunctionpartnerfunctionaddressrepresentationcodeaddressrepresentationcodeget"></a>
# **ASalesOrderPartnerAddressSalesOrderSalesOrderPartnerFunctionPartnerFunctionAddressRepresentationCodeAddressRepresentationCodeGet**
> ASalesOrderPartnerAddressType ASalesOrderPartnerAddressSalesOrderSalesOrderPartnerFunctionPartnerFunctionAddressRepresentationCodeAddressRepresentationCodeGet (string salesOrder, string partnerFunction, string addressRepresentationCode, List<string>? select = null, List<string>? expand = null)

Reads the address of a header partner of a sales order.

Reads the header address data of a specific header partner of a sales order. Consumers must pass the following key fields: sales order ID, partner function, and the address representation code.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ASalesOrderPartnerAddressSalesOrderSalesOrderPartnerFunctionPartnerFunctionAddressRepresentationCodeAddressRepresentationCodeGetExample
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

            var apiInstance = new HeaderPartnerAddressApi(config);
            var salesOrder = "salesOrder_example";  // string | Sales and Distribution Document Number
            var partnerFunction = "partnerFunction_example";  // string | Partner Function
            var addressRepresentationCode = "addressRepresentationCode_example";  // string | Version ID for International Addresses
            var select = new List<string>?(); // List<string>? | Select properties to be returned, see [Select](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=68) (optional) 
            var expand = new List<string>?(); // List<string>? | Expand related entities, see [Expand](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=63) (optional) 

            try
            {
                // Reads the address of a header partner of a sales order.
                ASalesOrderPartnerAddressType result = apiInstance.ASalesOrderPartnerAddressSalesOrderSalesOrderPartnerFunctionPartnerFunctionAddressRepresentationCodeAddressRepresentationCodeGet(salesOrder, partnerFunction, addressRepresentationCode, select, expand);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HeaderPartnerAddressApi.ASalesOrderPartnerAddressSalesOrderSalesOrderPartnerFunctionPartnerFunctionAddressRepresentationCodeAddressRepresentationCodeGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ASalesOrderPartnerAddressSalesOrderSalesOrderPartnerFunctionPartnerFunctionAddressRepresentationCodeAddressRepresentationCodeGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Reads the address of a header partner of a sales order.
    ApiResponse<ASalesOrderPartnerAddressType> response = apiInstance.ASalesOrderPartnerAddressSalesOrderSalesOrderPartnerFunctionPartnerFunctionAddressRepresentationCodeAddressRepresentationCodeGetWithHttpInfo(salesOrder, partnerFunction, addressRepresentationCode, select, expand);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling HeaderPartnerAddressApi.ASalesOrderPartnerAddressSalesOrderSalesOrderPartnerFunctionPartnerFunctionAddressRepresentationCodeAddressRepresentationCodeGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **salesOrder** | **string** | Sales and Distribution Document Number |  |
| **partnerFunction** | **string** | Partner Function |  |
| **addressRepresentationCode** | **string** | Version ID for International Addresses |  |
| **select** | [**List&lt;string&gt;?**](string.md) | Select properties to be returned, see [Select](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page&#x3D;68) | [optional]  |
| **expand** | [**List&lt;string&gt;?**](string.md) | Expand related entities, see [Expand](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page&#x3D;63) | [optional]  |

### Return type

[**ASalesOrderPartnerAddressType**](ASalesOrderPartnerAddressType.md)

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

<a id="asalesorderpartneraddresssalesordersalesorderpartnerfunctionpartnerfunctionaddressrepresentationcodeaddressrepresentationcodepatch"></a>
# **ASalesOrderPartnerAddressSalesOrderSalesOrderPartnerFunctionPartnerFunctionAddressRepresentationCodeAddressRepresentationCodePatch**
> void ASalesOrderPartnerAddressSalesOrderSalesOrderPartnerFunctionPartnerFunctionAddressRepresentationCodeAddressRepresentationCodePatch (string salesOrder, string partnerFunction, string addressRepresentationCode, ModifiedASalesOrderPartnerAddressType modifiedASalesOrderPartnerAddressType)

Updates the address of a header partner of a sales order.

Updates the header address data of a specific header partner of a sales order. Consumers must pass the following key fields: sales order ID, partner function, and the address representation code.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ASalesOrderPartnerAddressSalesOrderSalesOrderPartnerFunctionPartnerFunctionAddressRepresentationCodeAddressRepresentationCodePatchExample
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

            var apiInstance = new HeaderPartnerAddressApi(config);
            var salesOrder = "salesOrder_example";  // string | Sales and Distribution Document Number
            var partnerFunction = "partnerFunction_example";  // string | Partner Function
            var addressRepresentationCode = "addressRepresentationCode_example";  // string | Version ID for International Addresses
            var modifiedASalesOrderPartnerAddressType = new ModifiedASalesOrderPartnerAddressType(); // ModifiedASalesOrderPartnerAddressType | New property values

            try
            {
                // Updates the address of a header partner of a sales order.
                apiInstance.ASalesOrderPartnerAddressSalesOrderSalesOrderPartnerFunctionPartnerFunctionAddressRepresentationCodeAddressRepresentationCodePatch(salesOrder, partnerFunction, addressRepresentationCode, modifiedASalesOrderPartnerAddressType);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HeaderPartnerAddressApi.ASalesOrderPartnerAddressSalesOrderSalesOrderPartnerFunctionPartnerFunctionAddressRepresentationCodeAddressRepresentationCodePatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ASalesOrderPartnerAddressSalesOrderSalesOrderPartnerFunctionPartnerFunctionAddressRepresentationCodeAddressRepresentationCodePatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates the address of a header partner of a sales order.
    apiInstance.ASalesOrderPartnerAddressSalesOrderSalesOrderPartnerFunctionPartnerFunctionAddressRepresentationCodeAddressRepresentationCodePatchWithHttpInfo(salesOrder, partnerFunction, addressRepresentationCode, modifiedASalesOrderPartnerAddressType);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling HeaderPartnerAddressApi.ASalesOrderPartnerAddressSalesOrderSalesOrderPartnerFunctionPartnerFunctionAddressRepresentationCodeAddressRepresentationCodePatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **salesOrder** | **string** | Sales and Distribution Document Number |  |
| **partnerFunction** | **string** | Partner Function |  |
| **addressRepresentationCode** | **string** | Version ID for International Addresses |  |
| **modifiedASalesOrderPartnerAddressType** | [**ModifiedASalesOrderPartnerAddressType**](ModifiedASalesOrderPartnerAddressType.md) | New property values |  |

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

<a id="asalesorderpartneraddresssalesordersalesorderpartnerfunctionpartnerfunctionaddressrepresentationcodeaddressrepresentationcodetopartnerget"></a>
# **ASalesOrderPartnerAddressSalesOrderSalesOrderPartnerFunctionPartnerFunctionAddressRepresentationCodeAddressRepresentationCodeToPartnerGet**
> ASalesOrderHeaderPartnerType ASalesOrderPartnerAddressSalesOrderSalesOrderPartnerFunctionPartnerFunctionAddressRepresentationCodeAddressRepresentationCodeToPartnerGet (string salesOrder, string partnerFunction, string addressRepresentationCode, List<string>? select = null, List<string>? expand = null)

Reads the sales order header partner for a header partner address.

Reads the sales order header partner data for a specific header partner address. Consumers must pass the following key fields: sales order ID, partner function, and the address representation code.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ASalesOrderPartnerAddressSalesOrderSalesOrderPartnerFunctionPartnerFunctionAddressRepresentationCodeAddressRepresentationCodeToPartnerGetExample
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

            var apiInstance = new HeaderPartnerAddressApi(config);
            var salesOrder = "salesOrder_example";  // string | Sales and Distribution Document Number
            var partnerFunction = "partnerFunction_example";  // string | Partner Function
            var addressRepresentationCode = "addressRepresentationCode_example";  // string | Version ID for International Addresses
            var select = new List<string>?(); // List<string>? | Select properties to be returned, see [Select](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=68) (optional) 
            var expand = new List<string>?(); // List<string>? | Expand related entities, see [Expand](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=63) (optional) 

            try
            {
                // Reads the sales order header partner for a header partner address.
                ASalesOrderHeaderPartnerType result = apiInstance.ASalesOrderPartnerAddressSalesOrderSalesOrderPartnerFunctionPartnerFunctionAddressRepresentationCodeAddressRepresentationCodeToPartnerGet(salesOrder, partnerFunction, addressRepresentationCode, select, expand);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HeaderPartnerAddressApi.ASalesOrderPartnerAddressSalesOrderSalesOrderPartnerFunctionPartnerFunctionAddressRepresentationCodeAddressRepresentationCodeToPartnerGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ASalesOrderPartnerAddressSalesOrderSalesOrderPartnerFunctionPartnerFunctionAddressRepresentationCodeAddressRepresentationCodeToPartnerGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Reads the sales order header partner for a header partner address.
    ApiResponse<ASalesOrderHeaderPartnerType> response = apiInstance.ASalesOrderPartnerAddressSalesOrderSalesOrderPartnerFunctionPartnerFunctionAddressRepresentationCodeAddressRepresentationCodeToPartnerGetWithHttpInfo(salesOrder, partnerFunction, addressRepresentationCode, select, expand);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling HeaderPartnerAddressApi.ASalesOrderPartnerAddressSalesOrderSalesOrderPartnerFunctionPartnerFunctionAddressRepresentationCodeAddressRepresentationCodeToPartnerGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **salesOrder** | **string** | Sales and Distribution Document Number |  |
| **partnerFunction** | **string** | Partner Function |  |
| **addressRepresentationCode** | **string** | Version ID for International Addresses |  |
| **select** | [**List&lt;string&gt;?**](string.md) | Select properties to be returned, see [Select](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page&#x3D;68) | [optional]  |
| **expand** | [**List&lt;string&gt;?**](string.md) | Expand related entities, see [Expand](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page&#x3D;63) | [optional]  |

### Return type

[**ASalesOrderHeaderPartnerType**](ASalesOrderHeaderPartnerType.md)

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

<a id="asalesorderpartneraddresssalesordersalesorderpartnerfunctionpartnerfunctionaddressrepresentationcodeaddressrepresentationcodetosalesorderget"></a>
# **ASalesOrderPartnerAddressSalesOrderSalesOrderPartnerFunctionPartnerFunctionAddressRepresentationCodeAddressRepresentationCodeToSalesOrderGet**
> ASalesOrderType ASalesOrderPartnerAddressSalesOrderSalesOrderPartnerFunctionPartnerFunctionAddressRepresentationCodeAddressRepresentationCodeToSalesOrderGet (string salesOrder, string partnerFunction, string addressRepresentationCode, List<string>? select = null, List<string>? expand = null)

Reads the sales order for a header partner address.

Reads the sales order data for a specific partner address. Consumers must pass the following key fields: sales order ID and the address representation code.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ASalesOrderPartnerAddressSalesOrderSalesOrderPartnerFunctionPartnerFunctionAddressRepresentationCodeAddressRepresentationCodeToSalesOrderGetExample
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

            var apiInstance = new HeaderPartnerAddressApi(config);
            var salesOrder = "salesOrder_example";  // string | Sales and Distribution Document Number
            var partnerFunction = "partnerFunction_example";  // string | Partner Function
            var addressRepresentationCode = "addressRepresentationCode_example";  // string | Version ID for International Addresses
            var select = new List<string>?(); // List<string>? | Select properties to be returned, see [Select](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=68) (optional) 
            var expand = new List<string>?(); // List<string>? | Expand related entities, see [Expand](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=63) (optional) 

            try
            {
                // Reads the sales order for a header partner address.
                ASalesOrderType result = apiInstance.ASalesOrderPartnerAddressSalesOrderSalesOrderPartnerFunctionPartnerFunctionAddressRepresentationCodeAddressRepresentationCodeToSalesOrderGet(salesOrder, partnerFunction, addressRepresentationCode, select, expand);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HeaderPartnerAddressApi.ASalesOrderPartnerAddressSalesOrderSalesOrderPartnerFunctionPartnerFunctionAddressRepresentationCodeAddressRepresentationCodeToSalesOrderGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ASalesOrderPartnerAddressSalesOrderSalesOrderPartnerFunctionPartnerFunctionAddressRepresentationCodeAddressRepresentationCodeToSalesOrderGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Reads the sales order for a header partner address.
    ApiResponse<ASalesOrderType> response = apiInstance.ASalesOrderPartnerAddressSalesOrderSalesOrderPartnerFunctionPartnerFunctionAddressRepresentationCodeAddressRepresentationCodeToSalesOrderGetWithHttpInfo(salesOrder, partnerFunction, addressRepresentationCode, select, expand);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling HeaderPartnerAddressApi.ASalesOrderPartnerAddressSalesOrderSalesOrderPartnerFunctionPartnerFunctionAddressRepresentationCodeAddressRepresentationCodeToSalesOrderGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **salesOrder** | **string** | Sales and Distribution Document Number |  |
| **partnerFunction** | **string** | Partner Function |  |
| **addressRepresentationCode** | **string** | Version ID for International Addresses |  |
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

