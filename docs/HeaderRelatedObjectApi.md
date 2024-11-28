# Org.OpenAPITools.Api.HeaderRelatedObjectApi

All URIs are relative to *https://:/sap/opu/odata/sap/API_SALES_ORDER_SRV*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ASalesOrderRelatedObjectGet**](HeaderRelatedObjectApi.md#asalesorderrelatedobjectget) | **GET** /A_SalesOrderRelatedObject | Reads related objects from the headers of all sales orders. |
| [**ASalesOrderRelatedObjectPost**](HeaderRelatedObjectApi.md#asalesorderrelatedobjectpost) | **POST** /A_SalesOrderRelatedObject | Creates a related object for a sales order header. |
| [**ASalesOrderRelatedObjectSalesOrderSalesOrderSDDocRelatedObjectSequenceNmbrSDDocRelatedObjectSequenceNmbrDelete**](HeaderRelatedObjectApi.md#asalesorderrelatedobjectsalesordersalesordersddocrelatedobjectsequencenmbrsddocrelatedobjectsequencenmbrdelete) | **DELETE** /A_SalesOrderRelatedObject(SalesOrder&#x3D;&#39;{SalesOrder}&#39;,SDDocRelatedObjectSequenceNmbr&#x3D;&#39;{SDDocRelatedObjectSequenceNmbr}&#39;) | Deletes a related object from a sales order header. |
| [**ASalesOrderRelatedObjectSalesOrderSalesOrderSDDocRelatedObjectSequenceNmbrSDDocRelatedObjectSequenceNmbrGet**](HeaderRelatedObjectApi.md#asalesorderrelatedobjectsalesordersalesordersddocrelatedobjectsequencenmbrsddocrelatedobjectsequencenmbrget) | **GET** /A_SalesOrderRelatedObject(SalesOrder&#x3D;&#39;{SalesOrder}&#39;,SDDocRelatedObjectSequenceNmbr&#x3D;&#39;{SDDocRelatedObjectSequenceNmbr}&#39;) | Reads a related object from the header of a specific sales order. |
| [**ASalesOrderRelatedObjectSalesOrderSalesOrderSDDocRelatedObjectSequenceNmbrSDDocRelatedObjectSequenceNmbrToSalesOrderGet**](HeaderRelatedObjectApi.md#asalesorderrelatedobjectsalesordersalesordersddocrelatedobjectsequencenmbrsddocrelatedobjectsequencenmbrtosalesorderget) | **GET** /A_SalesOrderRelatedObject(SalesOrder&#x3D;&#39;{SalesOrder}&#39;,SDDocRelatedObjectSequenceNmbr&#x3D;&#39;{SDDocRelatedObjectSequenceNmbr}&#39;)/to_SalesOrder | Reads the sales order header for a related object. |
| [**ASalesOrderSalesOrderToRelatedObjectGet**](HeaderRelatedObjectApi.md#asalesordersalesordertorelatedobjectget) | **GET** /A_SalesOrder(&#39;{SalesOrder}&#39;)/to_RelatedObject | Reads the related objects of a sales order header. |
| [**ASalesOrderSalesOrderToRelatedObjectPost**](HeaderRelatedObjectApi.md#asalesordersalesordertorelatedobjectpost) | **POST** /A_SalesOrder(&#39;{SalesOrder}&#39;)/to_RelatedObject | Creates a related object for a sales order header. |

<a id="asalesorderrelatedobjectget"></a>
# **ASalesOrderRelatedObjectGet**
> Wrapper6 ASalesOrderRelatedObjectGet (int? top = null, int? skip = null, string? filter = null, string? inlinecount = null, List<string>? orderby = null, List<string>? select = null, List<string>? expand = null)

Reads related objects from the headers of all sales orders.

Reads the data for related objects from the headers of all sales orders in the system.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ASalesOrderRelatedObjectGetExample
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

            var apiInstance = new HeaderRelatedObjectApi(config);
            var top = 50;  // int? | Show only the first n items, see [Paging - Top](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=66) (optional) 
            var skip = 56;  // int? | Skip the first n items, see [Paging - Skip](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=65) (optional) 
            var filter = "filter_example";  // string? | Filter items by property values, see [Filtering](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=64) (optional) 
            var inlinecount = "allpages";  // string? | Include count of items, see [Inlinecount](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=67) (optional) 
            var orderby = new List<string>?(); // List<string>? | Order items by property values, see [Sorting](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=65) (optional) 
            var select = new List<string>?(); // List<string>? | Select properties to be returned, see [Select](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=68) (optional) 
            var expand = new List<string>?(); // List<string>? | Expand related entities, see [Expand](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=63) (optional) 

            try
            {
                // Reads related objects from the headers of all sales orders.
                Wrapper6 result = apiInstance.ASalesOrderRelatedObjectGet(top, skip, filter, inlinecount, orderby, select, expand);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HeaderRelatedObjectApi.ASalesOrderRelatedObjectGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ASalesOrderRelatedObjectGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Reads related objects from the headers of all sales orders.
    ApiResponse<Wrapper6> response = apiInstance.ASalesOrderRelatedObjectGetWithHttpInfo(top, skip, filter, inlinecount, orderby, select, expand);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling HeaderRelatedObjectApi.ASalesOrderRelatedObjectGetWithHttpInfo: " + e.Message);
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

[**Wrapper6**](Wrapper6.md)

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

<a id="asalesorderrelatedobjectpost"></a>
# **ASalesOrderRelatedObjectPost**
> ASalesOrderRelatedObjectType ASalesOrderRelatedObjectPost (APISALESORDERSRVASalesOrderRelatedObjectTypeCreate aPISALESORDERSRVASalesOrderRelatedObjectTypeCreate)

Creates a related object for a sales order header.

Creates the data for a related object for the header of a specific sales order. Consumers must pass the following key fields: sales order ID, related object type, and related object reference 1.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ASalesOrderRelatedObjectPostExample
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

            var apiInstance = new HeaderRelatedObjectApi(config);
            var aPISALESORDERSRVASalesOrderRelatedObjectTypeCreate = new APISALESORDERSRVASalesOrderRelatedObjectTypeCreate(); // APISALESORDERSRVASalesOrderRelatedObjectTypeCreate | New entity

            try
            {
                // Creates a related object for a sales order header.
                ASalesOrderRelatedObjectType result = apiInstance.ASalesOrderRelatedObjectPost(aPISALESORDERSRVASalesOrderRelatedObjectTypeCreate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HeaderRelatedObjectApi.ASalesOrderRelatedObjectPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ASalesOrderRelatedObjectPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a related object for a sales order header.
    ApiResponse<ASalesOrderRelatedObjectType> response = apiInstance.ASalesOrderRelatedObjectPostWithHttpInfo(aPISALESORDERSRVASalesOrderRelatedObjectTypeCreate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling HeaderRelatedObjectApi.ASalesOrderRelatedObjectPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **aPISALESORDERSRVASalesOrderRelatedObjectTypeCreate** | [**APISALESORDERSRVASalesOrderRelatedObjectTypeCreate**](APISALESORDERSRVASalesOrderRelatedObjectTypeCreate.md) | New entity |  |

### Return type

[**ASalesOrderRelatedObjectType**](ASalesOrderRelatedObjectType.md)

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

<a id="asalesorderrelatedobjectsalesordersalesordersddocrelatedobjectsequencenmbrsddocrelatedobjectsequencenmbrdelete"></a>
# **ASalesOrderRelatedObjectSalesOrderSalesOrderSDDocRelatedObjectSequenceNmbrSDDocRelatedObjectSequenceNmbrDelete**
> void ASalesOrderRelatedObjectSalesOrderSalesOrderSDDocRelatedObjectSequenceNmbrSDDocRelatedObjectSequenceNmbrDelete (string salesOrder, string sDDocRelatedObjectSequenceNmbr)

Deletes a related object from a sales order header.

Deletes the data for a related object from the header of a specific sales order. Consumers must pass the following key fields: sales order ID and sequence number of the related object.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ASalesOrderRelatedObjectSalesOrderSalesOrderSDDocRelatedObjectSequenceNmbrSDDocRelatedObjectSequenceNmbrDeleteExample
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

            var apiInstance = new HeaderRelatedObjectApi(config);
            var salesOrder = "salesOrder_example";  // string | Sales Order
            var sDDocRelatedObjectSequenceNmbr = "sDDocRelatedObjectSequenceNmbr_example";  // string | Sequence Number of the Related Object of an SD Document

            try
            {
                // Deletes a related object from a sales order header.
                apiInstance.ASalesOrderRelatedObjectSalesOrderSalesOrderSDDocRelatedObjectSequenceNmbrSDDocRelatedObjectSequenceNmbrDelete(salesOrder, sDDocRelatedObjectSequenceNmbr);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HeaderRelatedObjectApi.ASalesOrderRelatedObjectSalesOrderSalesOrderSDDocRelatedObjectSequenceNmbrSDDocRelatedObjectSequenceNmbrDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ASalesOrderRelatedObjectSalesOrderSalesOrderSDDocRelatedObjectSequenceNmbrSDDocRelatedObjectSequenceNmbrDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deletes a related object from a sales order header.
    apiInstance.ASalesOrderRelatedObjectSalesOrderSalesOrderSDDocRelatedObjectSequenceNmbrSDDocRelatedObjectSequenceNmbrDeleteWithHttpInfo(salesOrder, sDDocRelatedObjectSequenceNmbr);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling HeaderRelatedObjectApi.ASalesOrderRelatedObjectSalesOrderSalesOrderSDDocRelatedObjectSequenceNmbrSDDocRelatedObjectSequenceNmbrDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **salesOrder** | **string** | Sales Order |  |
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

<a id="asalesorderrelatedobjectsalesordersalesordersddocrelatedobjectsequencenmbrsddocrelatedobjectsequencenmbrget"></a>
# **ASalesOrderRelatedObjectSalesOrderSalesOrderSDDocRelatedObjectSequenceNmbrSDDocRelatedObjectSequenceNmbrGet**
> ASalesOrderRelatedObjectType ASalesOrderRelatedObjectSalesOrderSalesOrderSDDocRelatedObjectSequenceNmbrSDDocRelatedObjectSequenceNmbrGet (string salesOrder, string sDDocRelatedObjectSequenceNmbr, List<string>? select = null, List<string>? expand = null)

Reads a related object from the header of a specific sales order.

Reads the data for a related object from the header of a specific sales order. Consumers must pass the following key fields: sales order ID and sequence number of the related object.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ASalesOrderRelatedObjectSalesOrderSalesOrderSDDocRelatedObjectSequenceNmbrSDDocRelatedObjectSequenceNmbrGetExample
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

            var apiInstance = new HeaderRelatedObjectApi(config);
            var salesOrder = "salesOrder_example";  // string | Sales Order
            var sDDocRelatedObjectSequenceNmbr = "sDDocRelatedObjectSequenceNmbr_example";  // string | Sequence Number of the Related Object of an SD Document
            var select = new List<string>?(); // List<string>? | Select properties to be returned, see [Select](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=68) (optional) 
            var expand = new List<string>?(); // List<string>? | Expand related entities, see [Expand](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=63) (optional) 

            try
            {
                // Reads a related object from the header of a specific sales order.
                ASalesOrderRelatedObjectType result = apiInstance.ASalesOrderRelatedObjectSalesOrderSalesOrderSDDocRelatedObjectSequenceNmbrSDDocRelatedObjectSequenceNmbrGet(salesOrder, sDDocRelatedObjectSequenceNmbr, select, expand);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HeaderRelatedObjectApi.ASalesOrderRelatedObjectSalesOrderSalesOrderSDDocRelatedObjectSequenceNmbrSDDocRelatedObjectSequenceNmbrGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ASalesOrderRelatedObjectSalesOrderSalesOrderSDDocRelatedObjectSequenceNmbrSDDocRelatedObjectSequenceNmbrGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Reads a related object from the header of a specific sales order.
    ApiResponse<ASalesOrderRelatedObjectType> response = apiInstance.ASalesOrderRelatedObjectSalesOrderSalesOrderSDDocRelatedObjectSequenceNmbrSDDocRelatedObjectSequenceNmbrGetWithHttpInfo(salesOrder, sDDocRelatedObjectSequenceNmbr, select, expand);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling HeaderRelatedObjectApi.ASalesOrderRelatedObjectSalesOrderSalesOrderSDDocRelatedObjectSequenceNmbrSDDocRelatedObjectSequenceNmbrGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **salesOrder** | **string** | Sales Order |  |
| **sDDocRelatedObjectSequenceNmbr** | **string** | Sequence Number of the Related Object of an SD Document |  |
| **select** | [**List&lt;string&gt;?**](string.md) | Select properties to be returned, see [Select](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page&#x3D;68) | [optional]  |
| **expand** | [**List&lt;string&gt;?**](string.md) | Expand related entities, see [Expand](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page&#x3D;63) | [optional]  |

### Return type

[**ASalesOrderRelatedObjectType**](ASalesOrderRelatedObjectType.md)

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

<a id="asalesorderrelatedobjectsalesordersalesordersddocrelatedobjectsequencenmbrsddocrelatedobjectsequencenmbrtosalesorderget"></a>
# **ASalesOrderRelatedObjectSalesOrderSalesOrderSDDocRelatedObjectSequenceNmbrSDDocRelatedObjectSequenceNmbrToSalesOrderGet**
> ASalesOrderType ASalesOrderRelatedObjectSalesOrderSalesOrderSDDocRelatedObjectSequenceNmbrSDDocRelatedObjectSequenceNmbrToSalesOrderGet (string salesOrder, string sDDocRelatedObjectSequenceNmbr, List<string>? select = null, List<string>? expand = null)

Reads the sales order header for a related object.

Reads the sales order header data for a specific related object. Consumers must pass the following key fields: sales order ID and sequence number.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ASalesOrderRelatedObjectSalesOrderSalesOrderSDDocRelatedObjectSequenceNmbrSDDocRelatedObjectSequenceNmbrToSalesOrderGetExample
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

            var apiInstance = new HeaderRelatedObjectApi(config);
            var salesOrder = "salesOrder_example";  // string | Sales Order
            var sDDocRelatedObjectSequenceNmbr = "sDDocRelatedObjectSequenceNmbr_example";  // string | Sequence Number of the Related Object of an SD Document
            var select = new List<string>?(); // List<string>? | Select properties to be returned, see [Select](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=68) (optional) 
            var expand = new List<string>?(); // List<string>? | Expand related entities, see [Expand](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=63) (optional) 

            try
            {
                // Reads the sales order header for a related object.
                ASalesOrderType result = apiInstance.ASalesOrderRelatedObjectSalesOrderSalesOrderSDDocRelatedObjectSequenceNmbrSDDocRelatedObjectSequenceNmbrToSalesOrderGet(salesOrder, sDDocRelatedObjectSequenceNmbr, select, expand);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HeaderRelatedObjectApi.ASalesOrderRelatedObjectSalesOrderSalesOrderSDDocRelatedObjectSequenceNmbrSDDocRelatedObjectSequenceNmbrToSalesOrderGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ASalesOrderRelatedObjectSalesOrderSalesOrderSDDocRelatedObjectSequenceNmbrSDDocRelatedObjectSequenceNmbrToSalesOrderGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Reads the sales order header for a related object.
    ApiResponse<ASalesOrderType> response = apiInstance.ASalesOrderRelatedObjectSalesOrderSalesOrderSDDocRelatedObjectSequenceNmbrSDDocRelatedObjectSequenceNmbrToSalesOrderGetWithHttpInfo(salesOrder, sDDocRelatedObjectSequenceNmbr, select, expand);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling HeaderRelatedObjectApi.ASalesOrderRelatedObjectSalesOrderSalesOrderSDDocRelatedObjectSequenceNmbrSDDocRelatedObjectSequenceNmbrToSalesOrderGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **salesOrder** | **string** | Sales Order |  |
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

<a id="asalesordersalesordertorelatedobjectget"></a>
# **ASalesOrderSalesOrderToRelatedObjectGet**
> Wrapper6 ASalesOrderSalesOrderToRelatedObjectGet (string salesOrder, int? top = null, int? skip = null, string? filter = null, string? inlinecount = null, List<string>? orderby = null, List<string>? select = null, List<string>? expand = null)

Reads the related objects of a sales order header.

Reads the data for related objects from the header of a specific sales order. Consumers must pass the sales order ID (key field).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ASalesOrderSalesOrderToRelatedObjectGetExample
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

            var apiInstance = new HeaderRelatedObjectApi(config);
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
                // Reads the related objects of a sales order header.
                Wrapper6 result = apiInstance.ASalesOrderSalesOrderToRelatedObjectGet(salesOrder, top, skip, filter, inlinecount, orderby, select, expand);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HeaderRelatedObjectApi.ASalesOrderSalesOrderToRelatedObjectGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ASalesOrderSalesOrderToRelatedObjectGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Reads the related objects of a sales order header.
    ApiResponse<Wrapper6> response = apiInstance.ASalesOrderSalesOrderToRelatedObjectGetWithHttpInfo(salesOrder, top, skip, filter, inlinecount, orderby, select, expand);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling HeaderRelatedObjectApi.ASalesOrderSalesOrderToRelatedObjectGetWithHttpInfo: " + e.Message);
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

[**Wrapper6**](Wrapper6.md)

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

<a id="asalesordersalesordertorelatedobjectpost"></a>
# **ASalesOrderSalesOrderToRelatedObjectPost**
> ASalesOrderRelatedObjectType ASalesOrderSalesOrderToRelatedObjectPost (string salesOrder, APISALESORDERSRVASalesOrderRelatedObjectTypeCreate aPISALESORDERSRVASalesOrderRelatedObjectTypeCreate)

Creates a related object for a sales order header.

Creates the data for a related object for the header of a specific sales order. Consumers must pass the sales order ID (key field), the related object type, and the related object reference 1.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ASalesOrderSalesOrderToRelatedObjectPostExample
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

            var apiInstance = new HeaderRelatedObjectApi(config);
            var salesOrder = "salesOrder_example";  // string | Sales Order
            var aPISALESORDERSRVASalesOrderRelatedObjectTypeCreate = new APISALESORDERSRVASalesOrderRelatedObjectTypeCreate(); // APISALESORDERSRVASalesOrderRelatedObjectTypeCreate | New entity

            try
            {
                // Creates a related object for a sales order header.
                ASalesOrderRelatedObjectType result = apiInstance.ASalesOrderSalesOrderToRelatedObjectPost(salesOrder, aPISALESORDERSRVASalesOrderRelatedObjectTypeCreate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HeaderRelatedObjectApi.ASalesOrderSalesOrderToRelatedObjectPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ASalesOrderSalesOrderToRelatedObjectPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a related object for a sales order header.
    ApiResponse<ASalesOrderRelatedObjectType> response = apiInstance.ASalesOrderSalesOrderToRelatedObjectPostWithHttpInfo(salesOrder, aPISALESORDERSRVASalesOrderRelatedObjectTypeCreate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling HeaderRelatedObjectApi.ASalesOrderSalesOrderToRelatedObjectPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **salesOrder** | **string** | Sales Order |  |
| **aPISALESORDERSRVASalesOrderRelatedObjectTypeCreate** | [**APISALESORDERSRVASalesOrderRelatedObjectTypeCreate**](APISALESORDERSRVASalesOrderRelatedObjectTypeCreate.md) | New entity |  |

### Return type

[**ASalesOrderRelatedObjectType**](ASalesOrderRelatedObjectType.md)

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

