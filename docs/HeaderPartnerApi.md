# Org.OpenAPITools.Api.HeaderPartnerApi

All URIs are relative to *https://:/sap/opu/odata/sap/API_SALES_ORDER_SRV*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ASalesOrderHeaderPartnerGet**](HeaderPartnerApi.md#asalesorderheaderpartnerget) | **GET** /A_SalesOrderHeaderPartner | Reads the header partners of all sales orders. |
| [**ASalesOrderHeaderPartnerPost**](HeaderPartnerApi.md#asalesorderheaderpartnerpost) | **POST** /A_SalesOrderHeaderPartner | Creates a header partner for a specific sales order with a specific partner function. |
| [**ASalesOrderHeaderPartnerSalesOrderSalesOrderPartnerFunctionPartnerFunctionDelete**](HeaderPartnerApi.md#asalesorderheaderpartnersalesordersalesorderpartnerfunctionpartnerfunctiondelete) | **DELETE** /A_SalesOrderHeaderPartner(SalesOrder&#x3D;&#39;{SalesOrder}&#39;,PartnerFunction&#x3D;&#39;{PartnerFunction}&#39;) | Deletes a header partner of a specific sales order with a specific partner function. |
| [**ASalesOrderHeaderPartnerSalesOrderSalesOrderPartnerFunctionPartnerFunctionGet**](HeaderPartnerApi.md#asalesorderheaderpartnersalesordersalesorderpartnerfunctionpartnerfunctionget) | **GET** /A_SalesOrderHeaderPartner(SalesOrder&#x3D;&#39;{SalesOrder}&#39;,PartnerFunction&#x3D;&#39;{PartnerFunction}&#39;) | Reads the header partners of a sales order and a partner function. |
| [**ASalesOrderHeaderPartnerSalesOrderSalesOrderPartnerFunctionPartnerFunctionPatch**](HeaderPartnerApi.md#asalesorderheaderpartnersalesordersalesorderpartnerfunctionpartnerfunctionpatch) | **PATCH** /A_SalesOrderHeaderPartner(SalesOrder&#x3D;&#39;{SalesOrder}&#39;,PartnerFunction&#x3D;&#39;{PartnerFunction}&#39;) | Updates a header partner for a specific sales order with a specific partner function. |
| [**ASalesOrderHeaderPartnerSalesOrderSalesOrderPartnerFunctionPartnerFunctionToAddressGet**](HeaderPartnerApi.md#asalesorderheaderpartnersalesordersalesorderpartnerfunctionpartnerfunctiontoaddressget) | **GET** /A_SalesOrderHeaderPartner(SalesOrder&#x3D;&#39;{SalesOrder}&#39;,PartnerFunction&#x3D;&#39;{PartnerFunction}&#39;)/to_Address | Reads the address of a sales order header partner. |
| [**ASalesOrderHeaderPartnerSalesOrderSalesOrderPartnerFunctionPartnerFunctionToSalesOrderGet**](HeaderPartnerApi.md#asalesorderheaderpartnersalesordersalesorderpartnerfunctionpartnerfunctiontosalesorderget) | **GET** /A_SalesOrderHeaderPartner(SalesOrder&#x3D;&#39;{SalesOrder}&#39;,PartnerFunction&#x3D;&#39;{PartnerFunction}&#39;)/to_SalesOrder | Reads the sales order header for a header partner. |
| [**ASalesOrderPartnerAddressSalesOrderSalesOrderPartnerFunctionPartnerFunctionAddressRepresentationCodeAddressRepresentationCodeToPartnerGet**](HeaderPartnerApi.md#asalesorderpartneraddresssalesordersalesorderpartnerfunctionpartnerfunctionaddressrepresentationcodeaddressrepresentationcodetopartnerget) | **GET** /A_SalesOrderPartnerAddress(SalesOrder&#x3D;&#39;{SalesOrder}&#39;,PartnerFunction&#x3D;&#39;{PartnerFunction}&#39;,AddressRepresentationCode&#x3D;&#39;{AddressRepresentationCode}&#39;)/to_Partner | Reads the sales order header partner for a header partner address. |
| [**ASalesOrderSalesOrderToPartnerGet**](HeaderPartnerApi.md#asalesordersalesordertopartnerget) | **GET** /A_SalesOrder(&#39;{SalesOrder}&#39;)/to_Partner | Reads the header partners of a sales order. |
| [**ASalesOrderSalesOrderToPartnerPost**](HeaderPartnerApi.md#asalesordersalesordertopartnerpost) | **POST** /A_SalesOrder(&#39;{SalesOrder}&#39;)/to_Partner | Creates a header partner for a sales order. |

<a id="asalesorderheaderpartnerget"></a>
# **ASalesOrderHeaderPartnerGet**
> Wrapper2 ASalesOrderHeaderPartnerGet (int? top = null, int? skip = null, string? filter = null, string? inlinecount = null, List<string>? orderby = null, List<string>? select = null, List<string>? expand = null)

Reads the header partners of all sales orders.

Reads the partner data from the headers of all sales orders in the system. The data is relevant for all items for which no item-specific partners are maintained.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ASalesOrderHeaderPartnerGetExample
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

            var apiInstance = new HeaderPartnerApi(config);
            var top = 50;  // int? | Show only the first n items, see [Paging - Top](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=66) (optional) 
            var skip = 56;  // int? | Skip the first n items, see [Paging - Skip](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=65) (optional) 
            var filter = "filter_example";  // string? | Filter items by property values, see [Filtering](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=64) (optional) 
            var inlinecount = "allpages";  // string? | Include count of items, see [Inlinecount](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=67) (optional) 
            var orderby = new List<string>?(); // List<string>? | Order items by property values, see [Sorting](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=65) (optional) 
            var select = new List<string>?(); // List<string>? | Select properties to be returned, see [Select](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=68) (optional) 
            var expand = new List<string>?(); // List<string>? | Expand related entities, see [Expand](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=63) (optional) 

            try
            {
                // Reads the header partners of all sales orders.
                Wrapper2 result = apiInstance.ASalesOrderHeaderPartnerGet(top, skip, filter, inlinecount, orderby, select, expand);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HeaderPartnerApi.ASalesOrderHeaderPartnerGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ASalesOrderHeaderPartnerGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Reads the header partners of all sales orders.
    ApiResponse<Wrapper2> response = apiInstance.ASalesOrderHeaderPartnerGetWithHttpInfo(top, skip, filter, inlinecount, orderby, select, expand);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling HeaderPartnerApi.ASalesOrderHeaderPartnerGetWithHttpInfo: " + e.Message);
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

[**Wrapper2**](Wrapper2.md)

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

<a id="asalesorderheaderpartnerpost"></a>
# **ASalesOrderHeaderPartnerPost**
> ASalesOrderHeaderPartnerType ASalesOrderHeaderPartnerPost (APISALESORDERSRVASalesOrderHeaderPartnerTypeCreate aPISALESORDERSRVASalesOrderHeaderPartnerTypeCreate)

Creates a header partner for a specific sales order with a specific partner function.

Creates the data of a partner with a specific partner function for the header of a specific sales order. Consumers must pass the following key fields: sales order ID and partner function.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ASalesOrderHeaderPartnerPostExample
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

            var apiInstance = new HeaderPartnerApi(config);
            var aPISALESORDERSRVASalesOrderHeaderPartnerTypeCreate = new APISALESORDERSRVASalesOrderHeaderPartnerTypeCreate(); // APISALESORDERSRVASalesOrderHeaderPartnerTypeCreate | New entity

            try
            {
                // Creates a header partner for a specific sales order with a specific partner function.
                ASalesOrderHeaderPartnerType result = apiInstance.ASalesOrderHeaderPartnerPost(aPISALESORDERSRVASalesOrderHeaderPartnerTypeCreate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HeaderPartnerApi.ASalesOrderHeaderPartnerPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ASalesOrderHeaderPartnerPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a header partner for a specific sales order with a specific partner function.
    ApiResponse<ASalesOrderHeaderPartnerType> response = apiInstance.ASalesOrderHeaderPartnerPostWithHttpInfo(aPISALESORDERSRVASalesOrderHeaderPartnerTypeCreate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling HeaderPartnerApi.ASalesOrderHeaderPartnerPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **aPISALESORDERSRVASalesOrderHeaderPartnerTypeCreate** | [**APISALESORDERSRVASalesOrderHeaderPartnerTypeCreate**](APISALESORDERSRVASalesOrderHeaderPartnerTypeCreate.md) | New entity |  |

### Return type

[**ASalesOrderHeaderPartnerType**](ASalesOrderHeaderPartnerType.md)

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

<a id="asalesorderheaderpartnersalesordersalesorderpartnerfunctionpartnerfunctiondelete"></a>
# **ASalesOrderHeaderPartnerSalesOrderSalesOrderPartnerFunctionPartnerFunctionDelete**
> void ASalesOrderHeaderPartnerSalesOrderSalesOrderPartnerFunctionPartnerFunctionDelete (string salesOrder, string partnerFunction)

Deletes a header partner of a specific sales order with a specific partner function.

Delete the data of a partner with a specific partner function from the header of a specific sales order. Consumers must pass the following key fields: sales order ID and partner function.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ASalesOrderHeaderPartnerSalesOrderSalesOrderPartnerFunctionPartnerFunctionDeleteExample
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

            var apiInstance = new HeaderPartnerApi(config);
            var salesOrder = "salesOrder_example";  // string | Sales Order
            var partnerFunction = "partnerFunction_example";  // string | Partner Function

            try
            {
                // Deletes a header partner of a specific sales order with a specific partner function.
                apiInstance.ASalesOrderHeaderPartnerSalesOrderSalesOrderPartnerFunctionPartnerFunctionDelete(salesOrder, partnerFunction);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HeaderPartnerApi.ASalesOrderHeaderPartnerSalesOrderSalesOrderPartnerFunctionPartnerFunctionDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ASalesOrderHeaderPartnerSalesOrderSalesOrderPartnerFunctionPartnerFunctionDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deletes a header partner of a specific sales order with a specific partner function.
    apiInstance.ASalesOrderHeaderPartnerSalesOrderSalesOrderPartnerFunctionPartnerFunctionDeleteWithHttpInfo(salesOrder, partnerFunction);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling HeaderPartnerApi.ASalesOrderHeaderPartnerSalesOrderSalesOrderPartnerFunctionPartnerFunctionDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **salesOrder** | **string** | Sales Order |  |
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

<a id="asalesorderheaderpartnersalesordersalesorderpartnerfunctionpartnerfunctionget"></a>
# **ASalesOrderHeaderPartnerSalesOrderSalesOrderPartnerFunctionPartnerFunctionGet**
> ASalesOrderHeaderPartnerType ASalesOrderHeaderPartnerSalesOrderSalesOrderPartnerFunctionPartnerFunctionGet (string salesOrder, string partnerFunction, List<string>? select = null, List<string>? expand = null)

Reads the header partners of a sales order and a partner function.

Reads the data of partners with a specific partner function from the header of a specific sales order. Consumers must pass the following key fields: sales order ID and partner function.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ASalesOrderHeaderPartnerSalesOrderSalesOrderPartnerFunctionPartnerFunctionGetExample
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

            var apiInstance = new HeaderPartnerApi(config);
            var salesOrder = "salesOrder_example";  // string | Sales Order
            var partnerFunction = "partnerFunction_example";  // string | Partner Function
            var select = new List<string>?(); // List<string>? | Select properties to be returned, see [Select](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=68) (optional) 
            var expand = new List<string>?(); // List<string>? | Expand related entities, see [Expand](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=63) (optional) 

            try
            {
                // Reads the header partners of a sales order and a partner function.
                ASalesOrderHeaderPartnerType result = apiInstance.ASalesOrderHeaderPartnerSalesOrderSalesOrderPartnerFunctionPartnerFunctionGet(salesOrder, partnerFunction, select, expand);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HeaderPartnerApi.ASalesOrderHeaderPartnerSalesOrderSalesOrderPartnerFunctionPartnerFunctionGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ASalesOrderHeaderPartnerSalesOrderSalesOrderPartnerFunctionPartnerFunctionGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Reads the header partners of a sales order and a partner function.
    ApiResponse<ASalesOrderHeaderPartnerType> response = apiInstance.ASalesOrderHeaderPartnerSalesOrderSalesOrderPartnerFunctionPartnerFunctionGetWithHttpInfo(salesOrder, partnerFunction, select, expand);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling HeaderPartnerApi.ASalesOrderHeaderPartnerSalesOrderSalesOrderPartnerFunctionPartnerFunctionGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **salesOrder** | **string** | Sales Order |  |
| **partnerFunction** | **string** | Partner Function |  |
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

<a id="asalesorderheaderpartnersalesordersalesorderpartnerfunctionpartnerfunctionpatch"></a>
# **ASalesOrderHeaderPartnerSalesOrderSalesOrderPartnerFunctionPartnerFunctionPatch**
> void ASalesOrderHeaderPartnerSalesOrderSalesOrderPartnerFunctionPartnerFunctionPatch (string salesOrder, string partnerFunction, ModifiedASalesOrderHeaderPartnerType modifiedASalesOrderHeaderPartnerType)

Updates a header partner for a specific sales order with a specific partner function.

Updates the data of a partner with a specific partner function from the header of a specific sales order. Consumers must pass the following key fields: sales order ID and partner function.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ASalesOrderHeaderPartnerSalesOrderSalesOrderPartnerFunctionPartnerFunctionPatchExample
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

            var apiInstance = new HeaderPartnerApi(config);
            var salesOrder = "salesOrder_example";  // string | Sales Order
            var partnerFunction = "partnerFunction_example";  // string | Partner Function
            var modifiedASalesOrderHeaderPartnerType = new ModifiedASalesOrderHeaderPartnerType(); // ModifiedASalesOrderHeaderPartnerType | New property values

            try
            {
                // Updates a header partner for a specific sales order with a specific partner function.
                apiInstance.ASalesOrderHeaderPartnerSalesOrderSalesOrderPartnerFunctionPartnerFunctionPatch(salesOrder, partnerFunction, modifiedASalesOrderHeaderPartnerType);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HeaderPartnerApi.ASalesOrderHeaderPartnerSalesOrderSalesOrderPartnerFunctionPartnerFunctionPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ASalesOrderHeaderPartnerSalesOrderSalesOrderPartnerFunctionPartnerFunctionPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates a header partner for a specific sales order with a specific partner function.
    apiInstance.ASalesOrderHeaderPartnerSalesOrderSalesOrderPartnerFunctionPartnerFunctionPatchWithHttpInfo(salesOrder, partnerFunction, modifiedASalesOrderHeaderPartnerType);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling HeaderPartnerApi.ASalesOrderHeaderPartnerSalesOrderSalesOrderPartnerFunctionPartnerFunctionPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **salesOrder** | **string** | Sales Order |  |
| **partnerFunction** | **string** | Partner Function |  |
| **modifiedASalesOrderHeaderPartnerType** | [**ModifiedASalesOrderHeaderPartnerType**](ModifiedASalesOrderHeaderPartnerType.md) | New property values |  |

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

            var apiInstance = new HeaderPartnerApi(config);
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
                Debug.Print("Exception when calling HeaderPartnerApi.ASalesOrderHeaderPartnerSalesOrderSalesOrderPartnerFunctionPartnerFunctionToAddressGet: " + e.Message);
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
    Debug.Print("Exception when calling HeaderPartnerApi.ASalesOrderHeaderPartnerSalesOrderSalesOrderPartnerFunctionPartnerFunctionToAddressGetWithHttpInfo: " + e.Message);
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

<a id="asalesorderheaderpartnersalesordersalesorderpartnerfunctionpartnerfunctiontosalesorderget"></a>
# **ASalesOrderHeaderPartnerSalesOrderSalesOrderPartnerFunctionPartnerFunctionToSalesOrderGet**
> ASalesOrderType ASalesOrderHeaderPartnerSalesOrderSalesOrderPartnerFunctionPartnerFunctionToSalesOrderGet (string salesOrder, string partnerFunction, List<string>? select = null, List<string>? expand = null)

Reads the sales order header for a header partner.

Reads the sales order header data for a specific header partner function. Consumers must pass the following key fields: partner function and the sales order ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ASalesOrderHeaderPartnerSalesOrderSalesOrderPartnerFunctionPartnerFunctionToSalesOrderGetExample
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

            var apiInstance = new HeaderPartnerApi(config);
            var salesOrder = "salesOrder_example";  // string | Sales Order
            var partnerFunction = "partnerFunction_example";  // string | Partner Function
            var select = new List<string>?(); // List<string>? | Select properties to be returned, see [Select](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=68) (optional) 
            var expand = new List<string>?(); // List<string>? | Expand related entities, see [Expand](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=63) (optional) 

            try
            {
                // Reads the sales order header for a header partner.
                ASalesOrderType result = apiInstance.ASalesOrderHeaderPartnerSalesOrderSalesOrderPartnerFunctionPartnerFunctionToSalesOrderGet(salesOrder, partnerFunction, select, expand);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HeaderPartnerApi.ASalesOrderHeaderPartnerSalesOrderSalesOrderPartnerFunctionPartnerFunctionToSalesOrderGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ASalesOrderHeaderPartnerSalesOrderSalesOrderPartnerFunctionPartnerFunctionToSalesOrderGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Reads the sales order header for a header partner.
    ApiResponse<ASalesOrderType> response = apiInstance.ASalesOrderHeaderPartnerSalesOrderSalesOrderPartnerFunctionPartnerFunctionToSalesOrderGetWithHttpInfo(salesOrder, partnerFunction, select, expand);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling HeaderPartnerApi.ASalesOrderHeaderPartnerSalesOrderSalesOrderPartnerFunctionPartnerFunctionToSalesOrderGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **salesOrder** | **string** | Sales Order |  |
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

            var apiInstance = new HeaderPartnerApi(config);
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
                Debug.Print("Exception when calling HeaderPartnerApi.ASalesOrderPartnerAddressSalesOrderSalesOrderPartnerFunctionPartnerFunctionAddressRepresentationCodeAddressRepresentationCodeToPartnerGet: " + e.Message);
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
    Debug.Print("Exception when calling HeaderPartnerApi.ASalesOrderPartnerAddressSalesOrderSalesOrderPartnerFunctionPartnerFunctionAddressRepresentationCodeAddressRepresentationCodeToPartnerGetWithHttpInfo: " + e.Message);
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

<a id="asalesordersalesordertopartnerget"></a>
# **ASalesOrderSalesOrderToPartnerGet**
> Wrapper2 ASalesOrderSalesOrderToPartnerGet (string salesOrder, int? top = null, int? skip = null, string? filter = null, string? inlinecount = null, List<string>? orderby = null, List<string>? select = null, List<string>? expand = null)

Reads the header partners of a sales order.

Reads the partner data from the header of a specific sales order. Consumers must pass the sales order ID (key field). The data is relevant for all items for which no item-specific partners are maintained.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ASalesOrderSalesOrderToPartnerGetExample
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

            var apiInstance = new HeaderPartnerApi(config);
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
                // Reads the header partners of a sales order.
                Wrapper2 result = apiInstance.ASalesOrderSalesOrderToPartnerGet(salesOrder, top, skip, filter, inlinecount, orderby, select, expand);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HeaderPartnerApi.ASalesOrderSalesOrderToPartnerGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ASalesOrderSalesOrderToPartnerGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Reads the header partners of a sales order.
    ApiResponse<Wrapper2> response = apiInstance.ASalesOrderSalesOrderToPartnerGetWithHttpInfo(salesOrder, top, skip, filter, inlinecount, orderby, select, expand);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling HeaderPartnerApi.ASalesOrderSalesOrderToPartnerGetWithHttpInfo: " + e.Message);
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

[**Wrapper2**](Wrapper2.md)

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

<a id="asalesordersalesordertopartnerpost"></a>
# **ASalesOrderSalesOrderToPartnerPost**
> ASalesOrderHeaderPartnerType ASalesOrderSalesOrderToPartnerPost (string salesOrder, APISALESORDERSRVASalesOrderHeaderPartnerTypeCreate aPISALESORDERSRVASalesOrderHeaderPartnerTypeCreate)

Creates a header partner for a sales order.

Creates the partner data for a specific sales order header. Consumers must pass the sales order ID (key field). The data is relevant for all items for which no item-specific partners are maintained.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ASalesOrderSalesOrderToPartnerPostExample
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

            var apiInstance = new HeaderPartnerApi(config);
            var salesOrder = "salesOrder_example";  // string | Sales Order
            var aPISALESORDERSRVASalesOrderHeaderPartnerTypeCreate = new APISALESORDERSRVASalesOrderHeaderPartnerTypeCreate(); // APISALESORDERSRVASalesOrderHeaderPartnerTypeCreate | New entity

            try
            {
                // Creates a header partner for a sales order.
                ASalesOrderHeaderPartnerType result = apiInstance.ASalesOrderSalesOrderToPartnerPost(salesOrder, aPISALESORDERSRVASalesOrderHeaderPartnerTypeCreate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HeaderPartnerApi.ASalesOrderSalesOrderToPartnerPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ASalesOrderSalesOrderToPartnerPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a header partner for a sales order.
    ApiResponse<ASalesOrderHeaderPartnerType> response = apiInstance.ASalesOrderSalesOrderToPartnerPostWithHttpInfo(salesOrder, aPISALESORDERSRVASalesOrderHeaderPartnerTypeCreate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling HeaderPartnerApi.ASalesOrderSalesOrderToPartnerPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **salesOrder** | **string** | Sales Order |  |
| **aPISALESORDERSRVASalesOrderHeaderPartnerTypeCreate** | [**APISALESORDERSRVASalesOrderHeaderPartnerTypeCreate**](APISALESORDERSRVASalesOrderHeaderPartnerTypeCreate.md) | New entity |  |

### Return type

[**ASalesOrderHeaderPartnerType**](ASalesOrderHeaderPartnerType.md)

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

