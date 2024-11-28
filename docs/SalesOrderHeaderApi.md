# Org.OpenAPITools.Api.SalesOrderHeaderApi

All URIs are relative to *https://:/sap/opu/odata/sap/API_SALES_ORDER_SRV*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ASalesOrderBillingPlanItemSalesOrderSalesOrderBillingPlanBillingPlanBillingPlanItemBillingPlanItemToSalesOrderGet**](SalesOrderHeaderApi.md#asalesorderbillingplanitemsalesordersalesorderbillingplanbillingplanbillingplanitembillingplanitemtosalesorderget) | **GET** /A_SalesOrderBillingPlanItem(SalesOrder&#x3D;&#39;{SalesOrder}&#39;,BillingPlan&#x3D;&#39;{BillingPlan}&#39;,BillingPlanItem&#x3D;&#39;{BillingPlanItem}&#39;)/to_SalesOrder | Reads the sales order header for a billing plan item of a sales order. |
| [**ASalesOrderBillingPlanSalesOrderSalesOrderBillingPlanBillingPlanToSalesOrderGet**](SalesOrderHeaderApi.md#asalesorderbillingplansalesordersalesorderbillingplanbillingplantosalesorderget) | **GET** /A_SalesOrderBillingPlan(SalesOrder&#x3D;&#39;{SalesOrder}&#39;,BillingPlan&#x3D;&#39;{BillingPlan}&#39;)/to_SalesOrder | Reads the sales order header for a billing plan. |
| [**ASalesOrderGet**](SalesOrderHeaderApi.md#asalesorderget) | **GET** /A_SalesOrder | Reads all sales order headers. |
| [**ASalesOrderHeaderPartnerSalesOrderSalesOrderPartnerFunctionPartnerFunctionToSalesOrderGet**](SalesOrderHeaderApi.md#asalesorderheaderpartnersalesordersalesorderpartnerfunctionpartnerfunctiontosalesorderget) | **GET** /A_SalesOrderHeaderPartner(SalesOrder&#x3D;&#39;{SalesOrder}&#39;,PartnerFunction&#x3D;&#39;{PartnerFunction}&#39;)/to_SalesOrder | Reads the sales order header for a header partner. |
| [**ASalesOrderHeaderPrElementSalesOrderSalesOrderPricingProcedureStepPricingProcedureStepPricingProcedureCounterPricingProcedureCounterToSalesOrderGet**](SalesOrderHeaderApi.md#asalesorderheaderprelementsalesordersalesorderpricingproceduresteppricingproceduresteppricingprocedurecounterpricingprocedurecountertosalesorderget) | **GET** /A_SalesOrderHeaderPrElement(SalesOrder&#x3D;&#39;{SalesOrder}&#39;,PricingProcedureStep&#x3D;&#39;{PricingProcedureStep}&#39;,PricingProcedureCounter&#x3D;&#39;{PricingProcedureCounter}&#39;)/to_SalesOrder | Reads the sales order header for a pricing element. |
| [**ASalesOrderItemBillingPlanSalesOrderSalesOrderSalesOrderItemSalesOrderItemBillingPlanBillingPlanToSalesOrderGet**](SalesOrderHeaderApi.md#asalesorderitembillingplansalesordersalesordersalesorderitemsalesorderitembillingplanbillingplantosalesorderget) | **GET** /A_SalesOrderItemBillingPlan(SalesOrder&#x3D;&#39;{SalesOrder}&#39;,SalesOrderItem&#x3D;&#39;{SalesOrderItem}&#39;,BillingPlan&#x3D;&#39;{BillingPlan}&#39;)/to_SalesOrder | Reads the sales order header for an item billing plan. |
| [**ASalesOrderItemPartnerAddressSalesOrderSalesOrderSalesOrderItemSalesOrderItemPartnerFunctionPartnerFunctionAddressRepresentationCodeAddressRepresentationCodeToSalesOrderGet**](SalesOrderHeaderApi.md#asalesorderitempartneraddresssalesordersalesordersalesorderitemsalesorderitempartnerfunctionpartnerfunctionaddressrepresentationcodeaddressrepresentationcodetosalesorderget) | **GET** /A_SalesOrderItemPartnerAddress(SalesOrder&#x3D;&#39;{SalesOrder}&#39;,SalesOrderItem&#x3D;&#39;{SalesOrderItem}&#39;,PartnerFunction&#x3D;&#39;{PartnerFunction}&#39;,AddressRepresentationCode&#x3D;&#39;{AddressRepresentationCode}&#39;)/to_SalesOrder | Get related to_SalesOrder |
| [**ASalesOrderItemPartnerSalesOrderSalesOrderSalesOrderItemSalesOrderItemPartnerFunctionPartnerFunctionToSalesOrderGet**](SalesOrderHeaderApi.md#asalesorderitempartnersalesordersalesordersalesorderitemsalesorderitempartnerfunctionpartnerfunctiontosalesorderget) | **GET** /A_SalesOrderItemPartner(SalesOrder&#x3D;&#39;{SalesOrder}&#39;,SalesOrderItem&#x3D;&#39;{SalesOrderItem}&#39;,PartnerFunction&#x3D;&#39;{PartnerFunction}&#39;)/to_SalesOrder | Reads the sales order header of a partner function of a sales order item. |
| [**ASalesOrderItemPrElementSalesOrderSalesOrderSalesOrderItemSalesOrderItemPricingProcedureStepPricingProcedureStepPricingProcedureCounterPricingProcedureCounterToSalesOrderGet**](SalesOrderHeaderApi.md#asalesorderitemprelementsalesordersalesordersalesorderitemsalesorderitempricingproceduresteppricingproceduresteppricingprocedurecounterpricingprocedurecountertosalesorderget) | **GET** /A_SalesOrderItemPrElement(SalesOrder&#x3D;&#39;{SalesOrder}&#39;,SalesOrderItem&#x3D;&#39;{SalesOrderItem}&#39;,PricingProcedureStep&#x3D;&#39;{PricingProcedureStep}&#39;,PricingProcedureCounter&#x3D;&#39;{PricingProcedureCounter}&#39;)/to_SalesOrder | Reads the sales order header for a pricing element. |
| [**ASalesOrderItemRelatedObjectSalesOrderSalesOrderSalesOrderItemSalesOrderItemSDDocRelatedObjectSequenceNmbrSDDocRelatedObjectSequenceNmbrToSalesOrderGet**](SalesOrderHeaderApi.md#asalesorderitemrelatedobjectsalesordersalesordersalesorderitemsalesorderitemsddocrelatedobjectsequencenmbrsddocrelatedobjectsequencenmbrtosalesorderget) | **GET** /A_SalesOrderItemRelatedObject(SalesOrder&#x3D;&#39;{SalesOrder}&#39;,SalesOrderItem&#x3D;&#39;{SalesOrderItem}&#39;,SDDocRelatedObjectSequenceNmbr&#x3D;&#39;{SDDocRelatedObjectSequenceNmbr}&#39;)/to_SalesOrder | Reads the sales order header for a related object of a sales order item. |
| [**ASalesOrderItemSalesOrderSalesOrderSalesOrderItemSalesOrderItemToSalesOrderGet**](SalesOrderHeaderApi.md#asalesorderitemsalesordersalesordersalesorderitemsalesorderitemtosalesorderget) | **GET** /A_SalesOrderItem(SalesOrder&#x3D;&#39;{SalesOrder}&#39;,SalesOrderItem&#x3D;&#39;{SalesOrderItem}&#39;)/to_SalesOrder | Reads the sales order header of a sales order item. |
| [**ASalesOrderItemTextSalesOrderSalesOrderSalesOrderItemSalesOrderItemLanguageLanguageLongTextIDLongTextIDToSalesOrderGet**](SalesOrderHeaderApi.md#asalesorderitemtextsalesordersalesordersalesorderitemsalesorderitemlanguagelanguagelongtextidlongtextidtosalesorderget) | **GET** /A_SalesOrderItemText(SalesOrder&#x3D;&#39;{SalesOrder}&#39;,SalesOrderItem&#x3D;&#39;{SalesOrderItem}&#39;,Language&#x3D;&#39;{Language}&#39;,LongTextID&#x3D;&#39;{LongTextID}&#39;)/to_SalesOrder | Reads the sales order header for a text of a sales order item. |
| [**ASalesOrderItmPrecdgProcFlowSalesOrderSalesOrderSalesOrderItemSalesOrderItemDocRelationshipUUIDguidDocRelationshipUUIDToSalesOrderGet**](SalesOrderHeaderApi.md#asalesorderitmprecdgprocflowsalesordersalesordersalesorderitemsalesorderitemdocrelationshipuuidguiddocrelationshipuuidtosalesorderget) | **GET** /A_SalesOrderItmPrecdgProcFlow(SalesOrder&#x3D;&#39;{SalesOrder}&#39;,SalesOrderItem&#x3D;&#39;{SalesOrderItem}&#39;,DocRelationshipUUID&#x3D;guid&#39;{DocRelationshipUUID}&#39;)/to_SalesOrder | Reads the sales order header data of a preceding item of a sales order. |
| [**ASalesOrderItmSubsqntProcFlowSalesOrderSalesOrderSalesOrderItemSalesOrderItemDocRelationshipUUIDguidDocRelationshipUUIDToSalesOrderGet**](SalesOrderHeaderApi.md#asalesorderitmsubsqntprocflowsalesordersalesordersalesorderitemsalesorderitemdocrelationshipuuidguiddocrelationshipuuidtosalesorderget) | **GET** /A_SalesOrderItmSubsqntProcFlow(SalesOrder&#x3D;&#39;{SalesOrder}&#39;,SalesOrderItem&#x3D;&#39;{SalesOrderItem}&#39;,DocRelationshipUUID&#x3D;guid&#39;{DocRelationshipUUID}&#39;)/to_SalesOrder | Reads the sales order header data for a subsequent item of a sales order. |
| [**ASalesOrderPartnerAddressSalesOrderSalesOrderPartnerFunctionPartnerFunctionAddressRepresentationCodeAddressRepresentationCodeToSalesOrderGet**](SalesOrderHeaderApi.md#asalesorderpartneraddresssalesordersalesorderpartnerfunctionpartnerfunctionaddressrepresentationcodeaddressrepresentationcodetosalesorderget) | **GET** /A_SalesOrderPartnerAddress(SalesOrder&#x3D;&#39;{SalesOrder}&#39;,PartnerFunction&#x3D;&#39;{PartnerFunction}&#39;,AddressRepresentationCode&#x3D;&#39;{AddressRepresentationCode}&#39;)/to_SalesOrder | Reads the sales order for a header partner address. |
| [**ASalesOrderPost**](SalesOrderHeaderApi.md#asalesorderpost) | **POST** /A_SalesOrder | Creates a sales order. |
| [**ASalesOrderPrecdgProcFlowSalesOrderSalesOrderDocRelationshipUUIDguidDocRelationshipUUIDToSalesOrderGet**](SalesOrderHeaderApi.md#asalesorderprecdgprocflowsalesordersalesorderdocrelationshipuuidguiddocrelationshipuuidtosalesorderget) | **GET** /A_SalesOrderPrecdgProcFlow(SalesOrder&#x3D;&#39;{SalesOrder}&#39;,DocRelationshipUUID&#x3D;guid&#39;{DocRelationshipUUID}&#39;)/to_SalesOrder | Reads the sales order header data for a preceding document of a sales order. |
| [**ASalesOrderRelatedObjectSalesOrderSalesOrderSDDocRelatedObjectSequenceNmbrSDDocRelatedObjectSequenceNmbrToSalesOrderGet**](SalesOrderHeaderApi.md#asalesorderrelatedobjectsalesordersalesordersddocrelatedobjectsequencenmbrsddocrelatedobjectsequencenmbrtosalesorderget) | **GET** /A_SalesOrderRelatedObject(SalesOrder&#x3D;&#39;{SalesOrder}&#39;,SDDocRelatedObjectSequenceNmbr&#x3D;&#39;{SDDocRelatedObjectSequenceNmbr}&#39;)/to_SalesOrder | Reads the sales order header for a related object. |
| [**ASalesOrderSalesOrderDelete**](SalesOrderHeaderApi.md#asalesordersalesorderdelete) | **DELETE** /A_SalesOrder(&#39;{SalesOrder}&#39;) | Deletes a sales order. |
| [**ASalesOrderSalesOrderGet**](SalesOrderHeaderApi.md#asalesordersalesorderget) | **GET** /A_SalesOrder(&#39;{SalesOrder}&#39;) | Reads the header of a sales order. |
| [**ASalesOrderSalesOrderPatch**](SalesOrderHeaderApi.md#asalesordersalesorderpatch) | **PATCH** /A_SalesOrder(&#39;{SalesOrder}&#39;) | Updates a sales order. |
| [**ASalesOrderSalesOrderToBillingPlanGet**](SalesOrderHeaderApi.md#asalesordersalesordertobillingplanget) | **GET** /A_SalesOrder(&#39;{SalesOrder}&#39;)/to_BillingPlan | Reads the billing plan of a sales order. |
| [**ASalesOrderSalesOrderToItemGet**](SalesOrderHeaderApi.md#asalesordersalesordertoitemget) | **GET** /A_SalesOrder(&#39;{SalesOrder}&#39;)/to_Item | Reads all items of a sales order. |
| [**ASalesOrderSalesOrderToItemPost**](SalesOrderHeaderApi.md#asalesordersalesordertoitempost) | **POST** /A_SalesOrder(&#39;{SalesOrder}&#39;)/to_Item | Creates a sales order item for a sales order. |
| [**ASalesOrderSalesOrderToPartnerGet**](SalesOrderHeaderApi.md#asalesordersalesordertopartnerget) | **GET** /A_SalesOrder(&#39;{SalesOrder}&#39;)/to_Partner | Reads the header partners of a sales order. |
| [**ASalesOrderSalesOrderToPartnerPost**](SalesOrderHeaderApi.md#asalesordersalesordertopartnerpost) | **POST** /A_SalesOrder(&#39;{SalesOrder}&#39;)/to_Partner | Creates a header partner for a sales order. |
| [**ASalesOrderSalesOrderToPaymentPlanItemDetailsGet**](SalesOrderHeaderApi.md#asalesordersalesordertopaymentplanitemdetailsget) | **GET** /A_SalesOrder(&#39;{SalesOrder}&#39;)/to_PaymentPlanItemDetails | Reads the header payment plan of a specific sales order. |
| [**ASalesOrderSalesOrderToPaymentPlanItemDetailsPost**](SalesOrderHeaderApi.md#asalesordersalesordertopaymentplanitemdetailspost) | **POST** /A_SalesOrder(&#39;{SalesOrder}&#39;)/to_PaymentPlanItemDetails | Creates a header payment plan for a specific sales order. |
| [**ASalesOrderSalesOrderToPrecedingProcFlowDocGet**](SalesOrderHeaderApi.md#asalesordersalesordertoprecedingprocflowdocget) | **GET** /A_SalesOrder(&#39;{SalesOrder}&#39;)/to_PrecedingProcFlowDoc | Get entities from related to_PrecedingProcFlowDoc |
| [**ASalesOrderSalesOrderToPricingElementGet**](SalesOrderHeaderApi.md#asalesordersalesordertopricingelementget) | **GET** /A_SalesOrder(&#39;{SalesOrder}&#39;)/to_PricingElement | Reads the pricing element of a sales order. |
| [**ASalesOrderSalesOrderToPricingElementPost**](SalesOrderHeaderApi.md#asalesordersalesordertopricingelementpost) | **POST** /A_SalesOrder(&#39;{SalesOrder}&#39;)/to_PricingElement | Creates a header pricing element for a specific sales order. |
| [**ASalesOrderSalesOrderToRelatedObjectGet**](SalesOrderHeaderApi.md#asalesordersalesordertorelatedobjectget) | **GET** /A_SalesOrder(&#39;{SalesOrder}&#39;)/to_RelatedObject | Reads the related objects of a sales order header. |
| [**ASalesOrderSalesOrderToRelatedObjectPost**](SalesOrderHeaderApi.md#asalesordersalesordertorelatedobjectpost) | **POST** /A_SalesOrder(&#39;{SalesOrder}&#39;)/to_RelatedObject | Creates a related object for a sales order header. |
| [**ASalesOrderSalesOrderToSubsequentProcFlowDocGet**](SalesOrderHeaderApi.md#asalesordersalesordertosubsequentprocflowdocget) | **GET** /A_SalesOrder(&#39;{SalesOrder}&#39;)/to_SubsequentProcFlowDoc | Get entities from related to_SubsequentProcFlowDoc |
| [**ASalesOrderSalesOrderToTextGet**](SalesOrderHeaderApi.md#asalesordersalesordertotextget) | **GET** /A_SalesOrder(&#39;{SalesOrder}&#39;)/to_Text | Reads the header texts of a sales order. |
| [**ASalesOrderSalesOrderToTextPost**](SalesOrderHeaderApi.md#asalesordersalesordertotextpost) | **POST** /A_SalesOrder(&#39;{SalesOrder}&#39;)/to_Text | Creates a header text for a sales order. |
| [**ASalesOrderSubsqntProcFlowSalesOrderSalesOrderDocRelationshipUUIDguidDocRelationshipUUIDToSalesOrderGet**](SalesOrderHeaderApi.md#asalesordersubsqntprocflowsalesordersalesorderdocrelationshipuuidguiddocrelationshipuuidtosalesorderget) | **GET** /A_SalesOrderSubsqntProcFlow(SalesOrder&#x3D;&#39;{SalesOrder}&#39;,DocRelationshipUUID&#x3D;guid&#39;{DocRelationshipUUID}&#39;)/to_SalesOrder | Reads the sales order header data for a subsequent document of a sales order. |
| [**ASalesOrderTextSalesOrderSalesOrderLanguageLanguageLongTextIDLongTextIDToSalesOrderGet**](SalesOrderHeaderApi.md#asalesordertextsalesordersalesorderlanguagelanguagelongtextidlongtextidtosalesorderget) | **GET** /A_SalesOrderText(SalesOrder&#x3D;&#39;{SalesOrder}&#39;,Language&#x3D;&#39;{Language}&#39;,LongTextID&#x3D;&#39;{LongTextID}&#39;)/to_SalesOrder | Reads the sales order header for a header text. |
| [**ASlsOrdPaymentPlanItemDetailsSalesOrderSalesOrderPaymentPlanItemPaymentPlanItemToSalesOrderGet**](SalesOrderHeaderApi.md#aslsordpaymentplanitemdetailssalesordersalesorderpaymentplanitempaymentplanitemtosalesorderget) | **GET** /A_SlsOrdPaymentPlanItemDetails(SalesOrder&#x3D;&#39;{SalesOrder}&#39;,PaymentPlanItem&#x3D;&#39;{PaymentPlanItem}&#39;)/to_SalesOrder | Reads the sales order header for a payment plan item. |
| [**ASlsOrderItemBillingPlanItemSalesOrderSalesOrderSalesOrderItemSalesOrderItemBillingPlanBillingPlanBillingPlanItemBillingPlanItemToSalesOrderGet**](SalesOrderHeaderApi.md#aslsorderitembillingplanitemsalesordersalesordersalesorderitemsalesorderitembillingplanbillingplanbillingplanitembillingplanitemtosalesorderget) | **GET** /A_SlsOrderItemBillingPlanItem(SalesOrder&#x3D;&#39;{SalesOrder}&#39;,SalesOrderItem&#x3D;&#39;{SalesOrderItem}&#39;,BillingPlan&#x3D;&#39;{BillingPlan}&#39;,BillingPlanItem&#x3D;&#39;{BillingPlanItem}&#39;)/to_SalesOrder | Reads the sales order header for an item billing plan item. |

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

            var apiInstance = new SalesOrderHeaderApi(config);
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
                Debug.Print("Exception when calling SalesOrderHeaderApi.ASalesOrderBillingPlanItemSalesOrderSalesOrderBillingPlanBillingPlanBillingPlanItemBillingPlanItemToSalesOrderGet: " + e.Message);
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
    Debug.Print("Exception when calling SalesOrderHeaderApi.ASalesOrderBillingPlanItemSalesOrderSalesOrderBillingPlanBillingPlanBillingPlanItemBillingPlanItemToSalesOrderGetWithHttpInfo: " + e.Message);
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

<a id="asalesorderbillingplansalesordersalesorderbillingplanbillingplantosalesorderget"></a>
# **ASalesOrderBillingPlanSalesOrderSalesOrderBillingPlanBillingPlanToSalesOrderGet**
> ASalesOrderType ASalesOrderBillingPlanSalesOrderSalesOrderBillingPlanBillingPlanToSalesOrderGet (string salesOrder, string billingPlan, List<string>? select = null, List<string>? expand = null)

Reads the sales order header for a billing plan.

Reads the sales order header data for a specific header billing plan. Consumers must pass the following key fields: sales order ID and number of the header billing plan.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ASalesOrderBillingPlanSalesOrderSalesOrderBillingPlanBillingPlanToSalesOrderGetExample
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

            var apiInstance = new SalesOrderHeaderApi(config);
            var salesOrder = "salesOrder_example";  // string | Sales Order
            var billingPlan = "billingPlan_example";  // string | Billing/Invoicing Plan Number
            var select = new List<string>?(); // List<string>? | Select properties to be returned, see [Select](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=68) (optional) 
            var expand = new List<string>?(); // List<string>? | Expand related entities, see [Expand](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=63) (optional) 

            try
            {
                // Reads the sales order header for a billing plan.
                ASalesOrderType result = apiInstance.ASalesOrderBillingPlanSalesOrderSalesOrderBillingPlanBillingPlanToSalesOrderGet(salesOrder, billingPlan, select, expand);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SalesOrderHeaderApi.ASalesOrderBillingPlanSalesOrderSalesOrderBillingPlanBillingPlanToSalesOrderGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ASalesOrderBillingPlanSalesOrderSalesOrderBillingPlanBillingPlanToSalesOrderGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Reads the sales order header for a billing plan.
    ApiResponse<ASalesOrderType> response = apiInstance.ASalesOrderBillingPlanSalesOrderSalesOrderBillingPlanBillingPlanToSalesOrderGetWithHttpInfo(salesOrder, billingPlan, select, expand);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SalesOrderHeaderApi.ASalesOrderBillingPlanSalesOrderSalesOrderBillingPlanBillingPlanToSalesOrderGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **salesOrder** | **string** | Sales Order |  |
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

<a id="asalesorderget"></a>
# **ASalesOrderGet**
> Wrapper ASalesOrderGet (int? top = null, int? skip = null, string? filter = null, string? inlinecount = null, List<string>? orderby = null, List<string>? select = null, List<string>? expand = null)

Reads all sales order headers.

Reads the header data of all sales orders in the system.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ASalesOrderGetExample
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

            var apiInstance = new SalesOrderHeaderApi(config);
            var top = 50;  // int? | Show only the first n items, see [Paging - Top](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=66) (optional) 
            var skip = 56;  // int? | Skip the first n items, see [Paging - Skip](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=65) (optional) 
            var filter = "filter_example";  // string? | Filter items by property values, see [Filtering](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=64) (optional) 
            var inlinecount = "allpages";  // string? | Include count of items, see [Inlinecount](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=67) (optional) 
            var orderby = new List<string>?(); // List<string>? | Order items by property values, see [Sorting](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=65) (optional) 
            var select = new List<string>?(); // List<string>? | Select properties to be returned, see [Select](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=68) (optional) 
            var expand = new List<string>?(); // List<string>? | Expand related entities, see [Expand](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=63) (optional) 

            try
            {
                // Reads all sales order headers.
                Wrapper result = apiInstance.ASalesOrderGet(top, skip, filter, inlinecount, orderby, select, expand);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SalesOrderHeaderApi.ASalesOrderGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ASalesOrderGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Reads all sales order headers.
    ApiResponse<Wrapper> response = apiInstance.ASalesOrderGetWithHttpInfo(top, skip, filter, inlinecount, orderby, select, expand);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SalesOrderHeaderApi.ASalesOrderGetWithHttpInfo: " + e.Message);
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

[**Wrapper**](Wrapper.md)

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

            var apiInstance = new SalesOrderHeaderApi(config);
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
                Debug.Print("Exception when calling SalesOrderHeaderApi.ASalesOrderHeaderPartnerSalesOrderSalesOrderPartnerFunctionPartnerFunctionToSalesOrderGet: " + e.Message);
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
    Debug.Print("Exception when calling SalesOrderHeaderApi.ASalesOrderHeaderPartnerSalesOrderSalesOrderPartnerFunctionPartnerFunctionToSalesOrderGetWithHttpInfo: " + e.Message);
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

            var apiInstance = new SalesOrderHeaderApi(config);
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
                Debug.Print("Exception when calling SalesOrderHeaderApi.ASalesOrderHeaderPrElementSalesOrderSalesOrderPricingProcedureStepPricingProcedureStepPricingProcedureCounterPricingProcedureCounterToSalesOrderGet: " + e.Message);
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
    Debug.Print("Exception when calling SalesOrderHeaderApi.ASalesOrderHeaderPrElementSalesOrderSalesOrderPricingProcedureStepPricingProcedureStepPricingProcedureCounterPricingProcedureCounterToSalesOrderGetWithHttpInfo: " + e.Message);
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

            var apiInstance = new SalesOrderHeaderApi(config);
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
                Debug.Print("Exception when calling SalesOrderHeaderApi.ASalesOrderItemBillingPlanSalesOrderSalesOrderSalesOrderItemSalesOrderItemBillingPlanBillingPlanToSalesOrderGet: " + e.Message);
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
    Debug.Print("Exception when calling SalesOrderHeaderApi.ASalesOrderItemBillingPlanSalesOrderSalesOrderSalesOrderItemSalesOrderItemBillingPlanBillingPlanToSalesOrderGetWithHttpInfo: " + e.Message);
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

<a id="asalesorderitempartneraddresssalesordersalesordersalesorderitemsalesorderitempartnerfunctionpartnerfunctionaddressrepresentationcodeaddressrepresentationcodetosalesorderget"></a>
# **ASalesOrderItemPartnerAddressSalesOrderSalesOrderSalesOrderItemSalesOrderItemPartnerFunctionPartnerFunctionAddressRepresentationCodeAddressRepresentationCodeToSalesOrderGet**
> ASalesOrderType ASalesOrderItemPartnerAddressSalesOrderSalesOrderSalesOrderItemSalesOrderItemPartnerFunctionPartnerFunctionAddressRepresentationCodeAddressRepresentationCodeToSalesOrderGet (string salesOrder, string salesOrderItem, string partnerFunction, string addressRepresentationCode, List<string>? select = null, List<string>? expand = null)

Get related to_SalesOrder

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ASalesOrderItemPartnerAddressSalesOrderSalesOrderSalesOrderItemSalesOrderItemPartnerFunctionPartnerFunctionAddressRepresentationCodeAddressRepresentationCodeToSalesOrderGetExample
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

            var apiInstance = new SalesOrderHeaderApi(config);
            var salesOrder = "salesOrder_example";  // string | Sales and Distribution Document Number
            var salesOrderItem = "salesOrderItem_example";  // string | Item number of the SD document
            var partnerFunction = "partnerFunction_example";  // string | Partner Function
            var addressRepresentationCode = "addressRepresentationCode_example";  // string | Version ID for International Addresses
            var select = new List<string>?(); // List<string>? | Select properties to be returned, see [Select](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=68) (optional) 
            var expand = new List<string>?(); // List<string>? | Expand related entities, see [Expand](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=63) (optional) 

            try
            {
                // Get related to_SalesOrder
                ASalesOrderType result = apiInstance.ASalesOrderItemPartnerAddressSalesOrderSalesOrderSalesOrderItemSalesOrderItemPartnerFunctionPartnerFunctionAddressRepresentationCodeAddressRepresentationCodeToSalesOrderGet(salesOrder, salesOrderItem, partnerFunction, addressRepresentationCode, select, expand);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SalesOrderHeaderApi.ASalesOrderItemPartnerAddressSalesOrderSalesOrderSalesOrderItemSalesOrderItemPartnerFunctionPartnerFunctionAddressRepresentationCodeAddressRepresentationCodeToSalesOrderGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ASalesOrderItemPartnerAddressSalesOrderSalesOrderSalesOrderItemSalesOrderItemPartnerFunctionPartnerFunctionAddressRepresentationCodeAddressRepresentationCodeToSalesOrderGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get related to_SalesOrder
    ApiResponse<ASalesOrderType> response = apiInstance.ASalesOrderItemPartnerAddressSalesOrderSalesOrderSalesOrderItemSalesOrderItemPartnerFunctionPartnerFunctionAddressRepresentationCodeAddressRepresentationCodeToSalesOrderGetWithHttpInfo(salesOrder, salesOrderItem, partnerFunction, addressRepresentationCode, select, expand);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SalesOrderHeaderApi.ASalesOrderItemPartnerAddressSalesOrderSalesOrderSalesOrderItemSalesOrderItemPartnerFunctionPartnerFunctionAddressRepresentationCodeAddressRepresentationCodeToSalesOrderGetWithHttpInfo: " + e.Message);
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

            var apiInstance = new SalesOrderHeaderApi(config);
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
                Debug.Print("Exception when calling SalesOrderHeaderApi.ASalesOrderItemPartnerSalesOrderSalesOrderSalesOrderItemSalesOrderItemPartnerFunctionPartnerFunctionToSalesOrderGet: " + e.Message);
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
    Debug.Print("Exception when calling SalesOrderHeaderApi.ASalesOrderItemPartnerSalesOrderSalesOrderSalesOrderItemSalesOrderItemPartnerFunctionPartnerFunctionToSalesOrderGetWithHttpInfo: " + e.Message);
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

            var apiInstance = new SalesOrderHeaderApi(config);
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
                Debug.Print("Exception when calling SalesOrderHeaderApi.ASalesOrderItemPrElementSalesOrderSalesOrderSalesOrderItemSalesOrderItemPricingProcedureStepPricingProcedureStepPricingProcedureCounterPricingProcedureCounterToSalesOrderGet: " + e.Message);
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
    Debug.Print("Exception when calling SalesOrderHeaderApi.ASalesOrderItemPrElementSalesOrderSalesOrderSalesOrderItemSalesOrderItemPricingProcedureStepPricingProcedureStepPricingProcedureCounterPricingProcedureCounterToSalesOrderGetWithHttpInfo: " + e.Message);
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

<a id="asalesorderitemrelatedobjectsalesordersalesordersalesorderitemsalesorderitemsddocrelatedobjectsequencenmbrsddocrelatedobjectsequencenmbrtosalesorderget"></a>
# **ASalesOrderItemRelatedObjectSalesOrderSalesOrderSalesOrderItemSalesOrderItemSDDocRelatedObjectSequenceNmbrSDDocRelatedObjectSequenceNmbrToSalesOrderGet**
> ASalesOrderType ASalesOrderItemRelatedObjectSalesOrderSalesOrderSalesOrderItemSalesOrderItemSDDocRelatedObjectSequenceNmbrSDDocRelatedObjectSequenceNmbrToSalesOrderGet (string salesOrder, string salesOrderItem, string sDDocRelatedObjectSequenceNmbr, List<string>? select = null, List<string>? expand = null)

Reads the sales order header for a related object of a sales order item.

Reads the sales order header data for a specific related object of a specific sales order item. Consumers must pass the following key fields: sales order ID, item number, and sequence number.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ASalesOrderItemRelatedObjectSalesOrderSalesOrderSalesOrderItemSalesOrderItemSDDocRelatedObjectSequenceNmbrSDDocRelatedObjectSequenceNmbrToSalesOrderGetExample
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

            var apiInstance = new SalesOrderHeaderApi(config);
            var salesOrder = "salesOrder_example";  // string | Sales Order
            var salesOrderItem = "salesOrderItem_example";  // string | Sales Order Item
            var sDDocRelatedObjectSequenceNmbr = "sDDocRelatedObjectSequenceNmbr_example";  // string | Sequence Number of the Related Object of an SD Document
            var select = new List<string>?(); // List<string>? | Select properties to be returned, see [Select](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=68) (optional) 
            var expand = new List<string>?(); // List<string>? | Expand related entities, see [Expand](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=63) (optional) 

            try
            {
                // Reads the sales order header for a related object of a sales order item.
                ASalesOrderType result = apiInstance.ASalesOrderItemRelatedObjectSalesOrderSalesOrderSalesOrderItemSalesOrderItemSDDocRelatedObjectSequenceNmbrSDDocRelatedObjectSequenceNmbrToSalesOrderGet(salesOrder, salesOrderItem, sDDocRelatedObjectSequenceNmbr, select, expand);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SalesOrderHeaderApi.ASalesOrderItemRelatedObjectSalesOrderSalesOrderSalesOrderItemSalesOrderItemSDDocRelatedObjectSequenceNmbrSDDocRelatedObjectSequenceNmbrToSalesOrderGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ASalesOrderItemRelatedObjectSalesOrderSalesOrderSalesOrderItemSalesOrderItemSDDocRelatedObjectSequenceNmbrSDDocRelatedObjectSequenceNmbrToSalesOrderGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Reads the sales order header for a related object of a sales order item.
    ApiResponse<ASalesOrderType> response = apiInstance.ASalesOrderItemRelatedObjectSalesOrderSalesOrderSalesOrderItemSalesOrderItemSDDocRelatedObjectSequenceNmbrSDDocRelatedObjectSequenceNmbrToSalesOrderGetWithHttpInfo(salesOrder, salesOrderItem, sDDocRelatedObjectSequenceNmbr, select, expand);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SalesOrderHeaderApi.ASalesOrderItemRelatedObjectSalesOrderSalesOrderSalesOrderItemSalesOrderItemSDDocRelatedObjectSequenceNmbrSDDocRelatedObjectSequenceNmbrToSalesOrderGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **salesOrder** | **string** | Sales Order |  |
| **salesOrderItem** | **string** | Sales Order Item |  |
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

<a id="asalesorderitemsalesordersalesordersalesorderitemsalesorderitemtosalesorderget"></a>
# **ASalesOrderItemSalesOrderSalesOrderSalesOrderItemSalesOrderItemToSalesOrderGet**
> ASalesOrderType ASalesOrderItemSalesOrderSalesOrderSalesOrderItemSalesOrderItemToSalesOrderGet (string salesOrder, string salesOrderItem, List<string>? select = null, List<string>? expand = null)

Reads the sales order header of a sales order item.

Reads the sales order header data for a specific item. Consumers must pass the following key fields: sales order ID and item number.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ASalesOrderItemSalesOrderSalesOrderSalesOrderItemSalesOrderItemToSalesOrderGetExample
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

            var apiInstance = new SalesOrderHeaderApi(config);
            var salesOrder = "salesOrder_example";  // string | Sales Order
            var salesOrderItem = "salesOrderItem_example";  // string | Sales Order Item
            var select = new List<string>?(); // List<string>? | Select properties to be returned, see [Select](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=68) (optional) 
            var expand = new List<string>?(); // List<string>? | Expand related entities, see [Expand](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=63) (optional) 

            try
            {
                // Reads the sales order header of a sales order item.
                ASalesOrderType result = apiInstance.ASalesOrderItemSalesOrderSalesOrderSalesOrderItemSalesOrderItemToSalesOrderGet(salesOrder, salesOrderItem, select, expand);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SalesOrderHeaderApi.ASalesOrderItemSalesOrderSalesOrderSalesOrderItemSalesOrderItemToSalesOrderGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ASalesOrderItemSalesOrderSalesOrderSalesOrderItemSalesOrderItemToSalesOrderGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Reads the sales order header of a sales order item.
    ApiResponse<ASalesOrderType> response = apiInstance.ASalesOrderItemSalesOrderSalesOrderSalesOrderItemSalesOrderItemToSalesOrderGetWithHttpInfo(salesOrder, salesOrderItem, select, expand);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SalesOrderHeaderApi.ASalesOrderItemSalesOrderSalesOrderSalesOrderItemSalesOrderItemToSalesOrderGetWithHttpInfo: " + e.Message);
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

            var apiInstance = new SalesOrderHeaderApi(config);
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
                Debug.Print("Exception when calling SalesOrderHeaderApi.ASalesOrderItemTextSalesOrderSalesOrderSalesOrderItemSalesOrderItemLanguageLanguageLongTextIDLongTextIDToSalesOrderGet: " + e.Message);
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
    Debug.Print("Exception when calling SalesOrderHeaderApi.ASalesOrderItemTextSalesOrderSalesOrderSalesOrderItemSalesOrderItemLanguageLanguageLongTextIDLongTextIDToSalesOrderGetWithHttpInfo: " + e.Message);
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

<a id="asalesorderitmprecdgprocflowsalesordersalesordersalesorderitemsalesorderitemdocrelationshipuuidguiddocrelationshipuuidtosalesorderget"></a>
# **ASalesOrderItmPrecdgProcFlowSalesOrderSalesOrderSalesOrderItemSalesOrderItemDocRelationshipUUIDguidDocRelationshipUUIDToSalesOrderGet**
> ASalesOrderType ASalesOrderItmPrecdgProcFlowSalesOrderSalesOrderSalesOrderItemSalesOrderItemDocRelationshipUUIDguidDocRelationshipUUIDToSalesOrderGet (string salesOrder, string salesOrderItem, Guid docRelationshipUUID, List<string>? select = null, List<string>? expand = null)

Reads the sales order header data of a preceding item of a sales order.

Reads the sales order header data for specific preceding item of a sales order item. Consumers must pass the following key fields: sales order ID, sales order item number, and document relationship UUID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ASalesOrderItmPrecdgProcFlowSalesOrderSalesOrderSalesOrderItemSalesOrderItemDocRelationshipUUIDguidDocRelationshipUUIDToSalesOrderGetExample
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

            var apiInstance = new SalesOrderHeaderApi(config);
            var salesOrder = "salesOrder_example";  // string | Subsequent Sales and Distribution Document
            var salesOrderItem = "salesOrderItem_example";  // string | Subsequent Item of an SD Document
            var docRelationshipUUID = 01234567-89ab-cdef-0123-456789abcdef;  // Guid | SD Unique Document Relationship Identification
            var select = new List<string>?(); // List<string>? | Select properties to be returned, see [Select](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=68) (optional) 
            var expand = new List<string>?(); // List<string>? | Expand related entities, see [Expand](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=63) (optional) 

            try
            {
                // Reads the sales order header data of a preceding item of a sales order.
                ASalesOrderType result = apiInstance.ASalesOrderItmPrecdgProcFlowSalesOrderSalesOrderSalesOrderItemSalesOrderItemDocRelationshipUUIDguidDocRelationshipUUIDToSalesOrderGet(salesOrder, salesOrderItem, docRelationshipUUID, select, expand);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SalesOrderHeaderApi.ASalesOrderItmPrecdgProcFlowSalesOrderSalesOrderSalesOrderItemSalesOrderItemDocRelationshipUUIDguidDocRelationshipUUIDToSalesOrderGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ASalesOrderItmPrecdgProcFlowSalesOrderSalesOrderSalesOrderItemSalesOrderItemDocRelationshipUUIDguidDocRelationshipUUIDToSalesOrderGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Reads the sales order header data of a preceding item of a sales order.
    ApiResponse<ASalesOrderType> response = apiInstance.ASalesOrderItmPrecdgProcFlowSalesOrderSalesOrderSalesOrderItemSalesOrderItemDocRelationshipUUIDguidDocRelationshipUUIDToSalesOrderGetWithHttpInfo(salesOrder, salesOrderItem, docRelationshipUUID, select, expand);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SalesOrderHeaderApi.ASalesOrderItmPrecdgProcFlowSalesOrderSalesOrderSalesOrderItemSalesOrderItemDocRelationshipUUIDguidDocRelationshipUUIDToSalesOrderGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **salesOrder** | **string** | Subsequent Sales and Distribution Document |  |
| **salesOrderItem** | **string** | Subsequent Item of an SD Document |  |
| **docRelationshipUUID** | **Guid** | SD Unique Document Relationship Identification |  |
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

<a id="asalesorderitmsubsqntprocflowsalesordersalesordersalesorderitemsalesorderitemdocrelationshipuuidguiddocrelationshipuuidtosalesorderget"></a>
# **ASalesOrderItmSubsqntProcFlowSalesOrderSalesOrderSalesOrderItemSalesOrderItemDocRelationshipUUIDguidDocRelationshipUUIDToSalesOrderGet**
> ASalesOrderType ASalesOrderItmSubsqntProcFlowSalesOrderSalesOrderSalesOrderItemSalesOrderItemDocRelationshipUUIDguidDocRelationshipUUIDToSalesOrderGet (string salesOrder, string salesOrderItem, Guid docRelationshipUUID, List<string>? select = null, List<string>? expand = null)

Reads the sales order header data for a subsequent item of a sales order.

Reads the sales order header data for a specific subsequent item of a sales order item. Consumers must pass the following key fields: sales order ID, sales order item number, and document relationship UUID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ASalesOrderItmSubsqntProcFlowSalesOrderSalesOrderSalesOrderItemSalesOrderItemDocRelationshipUUIDguidDocRelationshipUUIDToSalesOrderGetExample
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

            var apiInstance = new SalesOrderHeaderApi(config);
            var salesOrder = "salesOrder_example";  // string | Preceding sales and distribution document
            var salesOrderItem = "salesOrderItem_example";  // string | Preceding Item of an SD Document
            var docRelationshipUUID = 01234567-89ab-cdef-0123-456789abcdef;  // Guid | SD Unique Document Relationship Identification
            var select = new List<string>?(); // List<string>? | Select properties to be returned, see [Select](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=68) (optional) 
            var expand = new List<string>?(); // List<string>? | Expand related entities, see [Expand](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=63) (optional) 

            try
            {
                // Reads the sales order header data for a subsequent item of a sales order.
                ASalesOrderType result = apiInstance.ASalesOrderItmSubsqntProcFlowSalesOrderSalesOrderSalesOrderItemSalesOrderItemDocRelationshipUUIDguidDocRelationshipUUIDToSalesOrderGet(salesOrder, salesOrderItem, docRelationshipUUID, select, expand);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SalesOrderHeaderApi.ASalesOrderItmSubsqntProcFlowSalesOrderSalesOrderSalesOrderItemSalesOrderItemDocRelationshipUUIDguidDocRelationshipUUIDToSalesOrderGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ASalesOrderItmSubsqntProcFlowSalesOrderSalesOrderSalesOrderItemSalesOrderItemDocRelationshipUUIDguidDocRelationshipUUIDToSalesOrderGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Reads the sales order header data for a subsequent item of a sales order.
    ApiResponse<ASalesOrderType> response = apiInstance.ASalesOrderItmSubsqntProcFlowSalesOrderSalesOrderSalesOrderItemSalesOrderItemDocRelationshipUUIDguidDocRelationshipUUIDToSalesOrderGetWithHttpInfo(salesOrder, salesOrderItem, docRelationshipUUID, select, expand);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SalesOrderHeaderApi.ASalesOrderItmSubsqntProcFlowSalesOrderSalesOrderSalesOrderItemSalesOrderItemDocRelationshipUUIDguidDocRelationshipUUIDToSalesOrderGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **salesOrder** | **string** | Preceding sales and distribution document |  |
| **salesOrderItem** | **string** | Preceding Item of an SD Document |  |
| **docRelationshipUUID** | **Guid** | SD Unique Document Relationship Identification |  |
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

            var apiInstance = new SalesOrderHeaderApi(config);
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
                Debug.Print("Exception when calling SalesOrderHeaderApi.ASalesOrderPartnerAddressSalesOrderSalesOrderPartnerFunctionPartnerFunctionAddressRepresentationCodeAddressRepresentationCodeToSalesOrderGet: " + e.Message);
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
    Debug.Print("Exception when calling SalesOrderHeaderApi.ASalesOrderPartnerAddressSalesOrderSalesOrderPartnerFunctionPartnerFunctionAddressRepresentationCodeAddressRepresentationCodeToSalesOrderGetWithHttpInfo: " + e.Message);
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

<a id="asalesorderpost"></a>
# **ASalesOrderPost**
> ASalesOrderType ASalesOrderPost (APISALESORDERSRVASalesOrderTypeCreate aPISALESORDERSRVASalesOrderTypeCreate)

Creates a sales order.

Creates a sales order header. Consumers can create a sales order with all possible sub-entities (for example, header partners or items) using deep insert requests or create a single sales order header.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ASalesOrderPostExample
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

            var apiInstance = new SalesOrderHeaderApi(config);
            var aPISALESORDERSRVASalesOrderTypeCreate = new APISALESORDERSRVASalesOrderTypeCreate(); // APISALESORDERSRVASalesOrderTypeCreate | New entity

            try
            {
                // Creates a sales order.
                ASalesOrderType result = apiInstance.ASalesOrderPost(aPISALESORDERSRVASalesOrderTypeCreate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SalesOrderHeaderApi.ASalesOrderPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ASalesOrderPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a sales order.
    ApiResponse<ASalesOrderType> response = apiInstance.ASalesOrderPostWithHttpInfo(aPISALESORDERSRVASalesOrderTypeCreate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SalesOrderHeaderApi.ASalesOrderPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **aPISALESORDERSRVASalesOrderTypeCreate** | [**APISALESORDERSRVASalesOrderTypeCreate**](APISALESORDERSRVASalesOrderTypeCreate.md) | New entity |  |

### Return type

[**ASalesOrderType**](ASalesOrderType.md)

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

<a id="asalesorderprecdgprocflowsalesordersalesorderdocrelationshipuuidguiddocrelationshipuuidtosalesorderget"></a>
# **ASalesOrderPrecdgProcFlowSalesOrderSalesOrderDocRelationshipUUIDguidDocRelationshipUUIDToSalesOrderGet**
> ASalesOrderType ASalesOrderPrecdgProcFlowSalesOrderSalesOrderDocRelationshipUUIDguidDocRelationshipUUIDToSalesOrderGet (string salesOrder, Guid docRelationshipUUID, List<string>? select = null, List<string>? expand = null)

Reads the sales order header data for a preceding document of a sales order.

Read the sales order header data for a preceding document of a specific sales order. Consumers must pass the following key fields: sales order ID and document relationship UUID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ASalesOrderPrecdgProcFlowSalesOrderSalesOrderDocRelationshipUUIDguidDocRelationshipUUIDToSalesOrderGetExample
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

            var apiInstance = new SalesOrderHeaderApi(config);
            var salesOrder = "salesOrder_example";  // string | Subsequent Sales and Distribution Document
            var docRelationshipUUID = 01234567-89ab-cdef-0123-456789abcdef;  // Guid | SD Unique Document Relationship Identification
            var select = new List<string>?(); // List<string>? | Select properties to be returned, see [Select](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=68) (optional) 
            var expand = new List<string>?(); // List<string>? | Expand related entities, see [Expand](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=63) (optional) 

            try
            {
                // Reads the sales order header data for a preceding document of a sales order.
                ASalesOrderType result = apiInstance.ASalesOrderPrecdgProcFlowSalesOrderSalesOrderDocRelationshipUUIDguidDocRelationshipUUIDToSalesOrderGet(salesOrder, docRelationshipUUID, select, expand);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SalesOrderHeaderApi.ASalesOrderPrecdgProcFlowSalesOrderSalesOrderDocRelationshipUUIDguidDocRelationshipUUIDToSalesOrderGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ASalesOrderPrecdgProcFlowSalesOrderSalesOrderDocRelationshipUUIDguidDocRelationshipUUIDToSalesOrderGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Reads the sales order header data for a preceding document of a sales order.
    ApiResponse<ASalesOrderType> response = apiInstance.ASalesOrderPrecdgProcFlowSalesOrderSalesOrderDocRelationshipUUIDguidDocRelationshipUUIDToSalesOrderGetWithHttpInfo(salesOrder, docRelationshipUUID, select, expand);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SalesOrderHeaderApi.ASalesOrderPrecdgProcFlowSalesOrderSalesOrderDocRelationshipUUIDguidDocRelationshipUUIDToSalesOrderGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **salesOrder** | **string** | Subsequent Sales and Distribution Document |  |
| **docRelationshipUUID** | **Guid** | SD Unique Document Relationship Identification |  |
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

            var apiInstance = new SalesOrderHeaderApi(config);
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
                Debug.Print("Exception when calling SalesOrderHeaderApi.ASalesOrderRelatedObjectSalesOrderSalesOrderSDDocRelatedObjectSequenceNmbrSDDocRelatedObjectSequenceNmbrToSalesOrderGet: " + e.Message);
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
    Debug.Print("Exception when calling SalesOrderHeaderApi.ASalesOrderRelatedObjectSalesOrderSalesOrderSDDocRelatedObjectSequenceNmbrSDDocRelatedObjectSequenceNmbrToSalesOrderGetWithHttpInfo: " + e.Message);
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

<a id="asalesordersalesorderdelete"></a>
# **ASalesOrderSalesOrderDelete**
> void ASalesOrderSalesOrderDelete (string salesOrder)

Deletes a sales order.

Deletes the header data of a specific sales order. Consumers must pass the sales order ID (key field).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ASalesOrderSalesOrderDeleteExample
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

            var apiInstance = new SalesOrderHeaderApi(config);
            var salesOrder = "salesOrder_example";  // string | Sales Order

            try
            {
                // Deletes a sales order.
                apiInstance.ASalesOrderSalesOrderDelete(salesOrder);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SalesOrderHeaderApi.ASalesOrderSalesOrderDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ASalesOrderSalesOrderDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deletes a sales order.
    apiInstance.ASalesOrderSalesOrderDeleteWithHttpInfo(salesOrder);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SalesOrderHeaderApi.ASalesOrderSalesOrderDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **salesOrder** | **string** | Sales Order |  |

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

<a id="asalesordersalesorderget"></a>
# **ASalesOrderSalesOrderGet**
> ASalesOrderType ASalesOrderSalesOrderGet (string salesOrder, List<string>? select = null, List<string>? expand = null)

Reads the header of a sales order.

Reads the header data of a specific sales order. Consumers must pass the sales order ID (key field).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ASalesOrderSalesOrderGetExample
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

            var apiInstance = new SalesOrderHeaderApi(config);
            var salesOrder = "salesOrder_example";  // string | Sales Order
            var select = new List<string>?(); // List<string>? | Select properties to be returned, see [Select](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=68) (optional) 
            var expand = new List<string>?(); // List<string>? | Expand related entities, see [Expand](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=63) (optional) 

            try
            {
                // Reads the header of a sales order.
                ASalesOrderType result = apiInstance.ASalesOrderSalesOrderGet(salesOrder, select, expand);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SalesOrderHeaderApi.ASalesOrderSalesOrderGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ASalesOrderSalesOrderGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Reads the header of a sales order.
    ApiResponse<ASalesOrderType> response = apiInstance.ASalesOrderSalesOrderGetWithHttpInfo(salesOrder, select, expand);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SalesOrderHeaderApi.ASalesOrderSalesOrderGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **salesOrder** | **string** | Sales Order |  |
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

<a id="asalesordersalesorderpatch"></a>
# **ASalesOrderSalesOrderPatch**
> void ASalesOrderSalesOrderPatch (string salesOrder, ModifiedASalesOrderType modifiedASalesOrderType)

Updates a sales order.

Updates the header data of a specific sales order. Consumers must pass the sales order ID (key field).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ASalesOrderSalesOrderPatchExample
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

            var apiInstance = new SalesOrderHeaderApi(config);
            var salesOrder = "salesOrder_example";  // string | Sales Order
            var modifiedASalesOrderType = new ModifiedASalesOrderType(); // ModifiedASalesOrderType | New property values

            try
            {
                // Updates a sales order.
                apiInstance.ASalesOrderSalesOrderPatch(salesOrder, modifiedASalesOrderType);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SalesOrderHeaderApi.ASalesOrderSalesOrderPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ASalesOrderSalesOrderPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates a sales order.
    apiInstance.ASalesOrderSalesOrderPatchWithHttpInfo(salesOrder, modifiedASalesOrderType);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SalesOrderHeaderApi.ASalesOrderSalesOrderPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **salesOrder** | **string** | Sales Order |  |
| **modifiedASalesOrderType** | [**ModifiedASalesOrderType**](ModifiedASalesOrderType.md) | New property values |  |

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

<a id="asalesordersalesordertobillingplanget"></a>
# **ASalesOrderSalesOrderToBillingPlanGet**
> ASalesOrderBillingPlanType ASalesOrderSalesOrderToBillingPlanGet (string salesOrder, List<string>? select = null, List<string>? expand = null)

Reads the billing plan of a sales order.

Reads the billing plan data for a specific sales order. Consumers must pass the following key field: sales order ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ASalesOrderSalesOrderToBillingPlanGetExample
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

            var apiInstance = new SalesOrderHeaderApi(config);
            var salesOrder = "salesOrder_example";  // string | Sales Order
            var select = new List<string>?(); // List<string>? | Select properties to be returned, see [Select](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=68) (optional) 
            var expand = new List<string>?(); // List<string>? | Expand related entities, see [Expand](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=63) (optional) 

            try
            {
                // Reads the billing plan of a sales order.
                ASalesOrderBillingPlanType result = apiInstance.ASalesOrderSalesOrderToBillingPlanGet(salesOrder, select, expand);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SalesOrderHeaderApi.ASalesOrderSalesOrderToBillingPlanGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ASalesOrderSalesOrderToBillingPlanGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Reads the billing plan of a sales order.
    ApiResponse<ASalesOrderBillingPlanType> response = apiInstance.ASalesOrderSalesOrderToBillingPlanGetWithHttpInfo(salesOrder, select, expand);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SalesOrderHeaderApi.ASalesOrderSalesOrderToBillingPlanGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **salesOrder** | **string** | Sales Order |  |
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

<a id="asalesordersalesordertoitemget"></a>
# **ASalesOrderSalesOrderToItemGet**
> Wrapper1 ASalesOrderSalesOrderToItemGet (string salesOrder, int? top = null, int? skip = null, string? filter = null, string? inlinecount = null, List<string>? orderby = null, List<string>? select = null, List<string>? expand = null)

Reads all items of a sales order.

Reads all item data of a specific sales order. Consumers must pass the sales order ID (key field).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ASalesOrderSalesOrderToItemGetExample
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

            var apiInstance = new SalesOrderHeaderApi(config);
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
                // Reads all items of a sales order.
                Wrapper1 result = apiInstance.ASalesOrderSalesOrderToItemGet(salesOrder, top, skip, filter, inlinecount, orderby, select, expand);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SalesOrderHeaderApi.ASalesOrderSalesOrderToItemGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ASalesOrderSalesOrderToItemGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Reads all items of a sales order.
    ApiResponse<Wrapper1> response = apiInstance.ASalesOrderSalesOrderToItemGetWithHttpInfo(salesOrder, top, skip, filter, inlinecount, orderby, select, expand);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SalesOrderHeaderApi.ASalesOrderSalesOrderToItemGetWithHttpInfo: " + e.Message);
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

[**Wrapper1**](Wrapper1.md)

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

<a id="asalesordersalesordertoitempost"></a>
# **ASalesOrderSalesOrderToItemPost**
> ASalesOrderItemType ASalesOrderSalesOrderToItemPost (string salesOrder, APISALESORDERSRVASalesOrderItemTypeCreate aPISALESORDERSRVASalesOrderItemTypeCreate)

Creates a sales order item for a sales order.

Creates a sales order item for a specific sales order. Consumers can create an item with all possible sub-entities (for example, item partners or item texts) using deep insert requests or create a single item. Consumers must pass the sales order ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ASalesOrderSalesOrderToItemPostExample
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

            var apiInstance = new SalesOrderHeaderApi(config);
            var salesOrder = "salesOrder_example";  // string | Sales Order
            var aPISALESORDERSRVASalesOrderItemTypeCreate = new APISALESORDERSRVASalesOrderItemTypeCreate(); // APISALESORDERSRVASalesOrderItemTypeCreate | New entity

            try
            {
                // Creates a sales order item for a sales order.
                ASalesOrderItemType result = apiInstance.ASalesOrderSalesOrderToItemPost(salesOrder, aPISALESORDERSRVASalesOrderItemTypeCreate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SalesOrderHeaderApi.ASalesOrderSalesOrderToItemPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ASalesOrderSalesOrderToItemPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a sales order item for a sales order.
    ApiResponse<ASalesOrderItemType> response = apiInstance.ASalesOrderSalesOrderToItemPostWithHttpInfo(salesOrder, aPISALESORDERSRVASalesOrderItemTypeCreate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SalesOrderHeaderApi.ASalesOrderSalesOrderToItemPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **salesOrder** | **string** | Sales Order |  |
| **aPISALESORDERSRVASalesOrderItemTypeCreate** | [**APISALESORDERSRVASalesOrderItemTypeCreate**](APISALESORDERSRVASalesOrderItemTypeCreate.md) | New entity |  |

### Return type

[**ASalesOrderItemType**](ASalesOrderItemType.md)

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

            var apiInstance = new SalesOrderHeaderApi(config);
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
                Debug.Print("Exception when calling SalesOrderHeaderApi.ASalesOrderSalesOrderToPartnerGet: " + e.Message);
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
    Debug.Print("Exception when calling SalesOrderHeaderApi.ASalesOrderSalesOrderToPartnerGetWithHttpInfo: " + e.Message);
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

            var apiInstance = new SalesOrderHeaderApi(config);
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
                Debug.Print("Exception when calling SalesOrderHeaderApi.ASalesOrderSalesOrderToPartnerPost: " + e.Message);
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
    Debug.Print("Exception when calling SalesOrderHeaderApi.ASalesOrderSalesOrderToPartnerPostWithHttpInfo: " + e.Message);
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

            var apiInstance = new SalesOrderHeaderApi(config);
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
                Debug.Print("Exception when calling SalesOrderHeaderApi.ASalesOrderSalesOrderToPaymentPlanItemDetailsGet: " + e.Message);
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
    Debug.Print("Exception when calling SalesOrderHeaderApi.ASalesOrderSalesOrderToPaymentPlanItemDetailsGetWithHttpInfo: " + e.Message);
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

            var apiInstance = new SalesOrderHeaderApi(config);
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
                Debug.Print("Exception when calling SalesOrderHeaderApi.ASalesOrderSalesOrderToPaymentPlanItemDetailsPost: " + e.Message);
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
    Debug.Print("Exception when calling SalesOrderHeaderApi.ASalesOrderSalesOrderToPaymentPlanItemDetailsPostWithHttpInfo: " + e.Message);
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

<a id="asalesordersalesordertoprecedingprocflowdocget"></a>
# **ASalesOrderSalesOrderToPrecedingProcFlowDocGet**
> Wrapper4 ASalesOrderSalesOrderToPrecedingProcFlowDocGet (string salesOrder, int? top = null, int? skip = null, string? filter = null, string? inlinecount = null, List<string>? orderby = null, List<string>? select = null, List<string>? expand = null)

Get entities from related to_PrecedingProcFlowDoc

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ASalesOrderSalesOrderToPrecedingProcFlowDocGetExample
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

            var apiInstance = new SalesOrderHeaderApi(config);
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
                // Get entities from related to_PrecedingProcFlowDoc
                Wrapper4 result = apiInstance.ASalesOrderSalesOrderToPrecedingProcFlowDocGet(salesOrder, top, skip, filter, inlinecount, orderby, select, expand);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SalesOrderHeaderApi.ASalesOrderSalesOrderToPrecedingProcFlowDocGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ASalesOrderSalesOrderToPrecedingProcFlowDocGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get entities from related to_PrecedingProcFlowDoc
    ApiResponse<Wrapper4> response = apiInstance.ASalesOrderSalesOrderToPrecedingProcFlowDocGetWithHttpInfo(salesOrder, top, skip, filter, inlinecount, orderby, select, expand);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SalesOrderHeaderApi.ASalesOrderSalesOrderToPrecedingProcFlowDocGetWithHttpInfo: " + e.Message);
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

[**Wrapper4**](Wrapper4.md)

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

            var apiInstance = new SalesOrderHeaderApi(config);
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
                Debug.Print("Exception when calling SalesOrderHeaderApi.ASalesOrderSalesOrderToPricingElementGet: " + e.Message);
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
    Debug.Print("Exception when calling SalesOrderHeaderApi.ASalesOrderSalesOrderToPricingElementGetWithHttpInfo: " + e.Message);
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

            var apiInstance = new SalesOrderHeaderApi(config);
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
                Debug.Print("Exception when calling SalesOrderHeaderApi.ASalesOrderSalesOrderToPricingElementPost: " + e.Message);
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
    Debug.Print("Exception when calling SalesOrderHeaderApi.ASalesOrderSalesOrderToPricingElementPostWithHttpInfo: " + e.Message);
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

            var apiInstance = new SalesOrderHeaderApi(config);
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
                Debug.Print("Exception when calling SalesOrderHeaderApi.ASalesOrderSalesOrderToRelatedObjectGet: " + e.Message);
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
    Debug.Print("Exception when calling SalesOrderHeaderApi.ASalesOrderSalesOrderToRelatedObjectGetWithHttpInfo: " + e.Message);
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

            var apiInstance = new SalesOrderHeaderApi(config);
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
                Debug.Print("Exception when calling SalesOrderHeaderApi.ASalesOrderSalesOrderToRelatedObjectPost: " + e.Message);
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
    Debug.Print("Exception when calling SalesOrderHeaderApi.ASalesOrderSalesOrderToRelatedObjectPostWithHttpInfo: " + e.Message);
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

<a id="asalesordersalesordertosubsequentprocflowdocget"></a>
# **ASalesOrderSalesOrderToSubsequentProcFlowDocGet**
> Wrapper7 ASalesOrderSalesOrderToSubsequentProcFlowDocGet (string salesOrder, int? top = null, int? skip = null, string? filter = null, string? inlinecount = null, List<string>? orderby = null, List<string>? select = null, List<string>? expand = null)

Get entities from related to_SubsequentProcFlowDoc

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ASalesOrderSalesOrderToSubsequentProcFlowDocGetExample
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

            var apiInstance = new SalesOrderHeaderApi(config);
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
                // Get entities from related to_SubsequentProcFlowDoc
                Wrapper7 result = apiInstance.ASalesOrderSalesOrderToSubsequentProcFlowDocGet(salesOrder, top, skip, filter, inlinecount, orderby, select, expand);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SalesOrderHeaderApi.ASalesOrderSalesOrderToSubsequentProcFlowDocGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ASalesOrderSalesOrderToSubsequentProcFlowDocGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get entities from related to_SubsequentProcFlowDoc
    ApiResponse<Wrapper7> response = apiInstance.ASalesOrderSalesOrderToSubsequentProcFlowDocGetWithHttpInfo(salesOrder, top, skip, filter, inlinecount, orderby, select, expand);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SalesOrderHeaderApi.ASalesOrderSalesOrderToSubsequentProcFlowDocGetWithHttpInfo: " + e.Message);
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

[**Wrapper7**](Wrapper7.md)

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

<a id="asalesordersalesordertotextget"></a>
# **ASalesOrderSalesOrderToTextGet**
> Wrapper8 ASalesOrderSalesOrderToTextGet (string salesOrder, int? top = null, int? skip = null, string? filter = null, string? inlinecount = null, List<string>? orderby = null, List<string>? select = null, List<string>? expand = null)

Reads the header texts of a sales order.

Reads the text data from the header of a specific sales order. Consumers must pass the sales order ID (key field).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ASalesOrderSalesOrderToTextGetExample
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

            var apiInstance = new SalesOrderHeaderApi(config);
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
                // Reads the header texts of a sales order.
                Wrapper8 result = apiInstance.ASalesOrderSalesOrderToTextGet(salesOrder, top, skip, filter, inlinecount, orderby, select, expand);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SalesOrderHeaderApi.ASalesOrderSalesOrderToTextGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ASalesOrderSalesOrderToTextGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Reads the header texts of a sales order.
    ApiResponse<Wrapper8> response = apiInstance.ASalesOrderSalesOrderToTextGetWithHttpInfo(salesOrder, top, skip, filter, inlinecount, orderby, select, expand);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SalesOrderHeaderApi.ASalesOrderSalesOrderToTextGetWithHttpInfo: " + e.Message);
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

[**Wrapper8**](Wrapper8.md)

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

<a id="asalesordersalesordertotextpost"></a>
# **ASalesOrderSalesOrderToTextPost**
> ASalesOrderTextType ASalesOrderSalesOrderToTextPost (string salesOrder, APISALESORDERSRVASalesOrderTextTypeCreate aPISALESORDERSRVASalesOrderTextTypeCreate)

Creates a header text for a sales order.

Creates the text data for a specific sales order header. Consumers must pass the sales order ID (key field).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ASalesOrderSalesOrderToTextPostExample
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

            var apiInstance = new SalesOrderHeaderApi(config);
            var salesOrder = "salesOrder_example";  // string | Sales Order
            var aPISALESORDERSRVASalesOrderTextTypeCreate = new APISALESORDERSRVASalesOrderTextTypeCreate(); // APISALESORDERSRVASalesOrderTextTypeCreate | New entity

            try
            {
                // Creates a header text for a sales order.
                ASalesOrderTextType result = apiInstance.ASalesOrderSalesOrderToTextPost(salesOrder, aPISALESORDERSRVASalesOrderTextTypeCreate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SalesOrderHeaderApi.ASalesOrderSalesOrderToTextPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ASalesOrderSalesOrderToTextPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a header text for a sales order.
    ApiResponse<ASalesOrderTextType> response = apiInstance.ASalesOrderSalesOrderToTextPostWithHttpInfo(salesOrder, aPISALESORDERSRVASalesOrderTextTypeCreate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SalesOrderHeaderApi.ASalesOrderSalesOrderToTextPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **salesOrder** | **string** | Sales Order |  |
| **aPISALESORDERSRVASalesOrderTextTypeCreate** | [**APISALESORDERSRVASalesOrderTextTypeCreate**](APISALESORDERSRVASalesOrderTextTypeCreate.md) | New entity |  |

### Return type

[**ASalesOrderTextType**](ASalesOrderTextType.md)

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

<a id="asalesordersubsqntprocflowsalesordersalesorderdocrelationshipuuidguiddocrelationshipuuidtosalesorderget"></a>
# **ASalesOrderSubsqntProcFlowSalesOrderSalesOrderDocRelationshipUUIDguidDocRelationshipUUIDToSalesOrderGet**
> ASalesOrderType ASalesOrderSubsqntProcFlowSalesOrderSalesOrderDocRelationshipUUIDguidDocRelationshipUUIDToSalesOrderGet (string salesOrder, Guid docRelationshipUUID, List<string>? select = null, List<string>? expand = null)

Reads the sales order header data for a subsequent document of a sales order.

Read the sales order header data for a subsequent document of a specific sales order. Consumers must pass the following key fields: sales order ID and document relationship UUID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ASalesOrderSubsqntProcFlowSalesOrderSalesOrderDocRelationshipUUIDguidDocRelationshipUUIDToSalesOrderGetExample
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

            var apiInstance = new SalesOrderHeaderApi(config);
            var salesOrder = "salesOrder_example";  // string | Preceding sales and distribution document
            var docRelationshipUUID = 01234567-89ab-cdef-0123-456789abcdef;  // Guid | SD Unique Document Relationship Identification
            var select = new List<string>?(); // List<string>? | Select properties to be returned, see [Select](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=68) (optional) 
            var expand = new List<string>?(); // List<string>? | Expand related entities, see [Expand](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=63) (optional) 

            try
            {
                // Reads the sales order header data for a subsequent document of a sales order.
                ASalesOrderType result = apiInstance.ASalesOrderSubsqntProcFlowSalesOrderSalesOrderDocRelationshipUUIDguidDocRelationshipUUIDToSalesOrderGet(salesOrder, docRelationshipUUID, select, expand);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SalesOrderHeaderApi.ASalesOrderSubsqntProcFlowSalesOrderSalesOrderDocRelationshipUUIDguidDocRelationshipUUIDToSalesOrderGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ASalesOrderSubsqntProcFlowSalesOrderSalesOrderDocRelationshipUUIDguidDocRelationshipUUIDToSalesOrderGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Reads the sales order header data for a subsequent document of a sales order.
    ApiResponse<ASalesOrderType> response = apiInstance.ASalesOrderSubsqntProcFlowSalesOrderSalesOrderDocRelationshipUUIDguidDocRelationshipUUIDToSalesOrderGetWithHttpInfo(salesOrder, docRelationshipUUID, select, expand);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SalesOrderHeaderApi.ASalesOrderSubsqntProcFlowSalesOrderSalesOrderDocRelationshipUUIDguidDocRelationshipUUIDToSalesOrderGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **salesOrder** | **string** | Preceding sales and distribution document |  |
| **docRelationshipUUID** | **Guid** | SD Unique Document Relationship Identification |  |
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

<a id="asalesordertextsalesordersalesorderlanguagelanguagelongtextidlongtextidtosalesorderget"></a>
# **ASalesOrderTextSalesOrderSalesOrderLanguageLanguageLongTextIDLongTextIDToSalesOrderGet**
> ASalesOrderType ASalesOrderTextSalesOrderSalesOrderLanguageLanguageLongTextIDLongTextIDToSalesOrderGet (string salesOrder, string language, string longTextID, List<string>? select = null, List<string>? expand = null)

Reads the sales order header for a header text.

Reads the sales order header data for a specific header text. Consumers must pass the following key fields: sales order ID, language, and text ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ASalesOrderTextSalesOrderSalesOrderLanguageLanguageLongTextIDLongTextIDToSalesOrderGetExample
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

            var apiInstance = new SalesOrderHeaderApi(config);
            var salesOrder = "salesOrder_example";  // string | Sales Order
            var language = "language_example";  // string | Language Key
            var longTextID = "longTextID_example";  // string | Text ID
            var select = new List<string>?(); // List<string>? | Select properties to be returned, see [Select](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=68) (optional) 
            var expand = new List<string>?(); // List<string>? | Expand related entities, see [Expand](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=63) (optional) 

            try
            {
                // Reads the sales order header for a header text.
                ASalesOrderType result = apiInstance.ASalesOrderTextSalesOrderSalesOrderLanguageLanguageLongTextIDLongTextIDToSalesOrderGet(salesOrder, language, longTextID, select, expand);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SalesOrderHeaderApi.ASalesOrderTextSalesOrderSalesOrderLanguageLanguageLongTextIDLongTextIDToSalesOrderGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ASalesOrderTextSalesOrderSalesOrderLanguageLanguageLongTextIDLongTextIDToSalesOrderGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Reads the sales order header for a header text.
    ApiResponse<ASalesOrderType> response = apiInstance.ASalesOrderTextSalesOrderSalesOrderLanguageLanguageLongTextIDLongTextIDToSalesOrderGetWithHttpInfo(salesOrder, language, longTextID, select, expand);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SalesOrderHeaderApi.ASalesOrderTextSalesOrderSalesOrderLanguageLanguageLongTextIDLongTextIDToSalesOrderGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **salesOrder** | **string** | Sales Order |  |
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

            var apiInstance = new SalesOrderHeaderApi(config);
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
                Debug.Print("Exception when calling SalesOrderHeaderApi.ASlsOrdPaymentPlanItemDetailsSalesOrderSalesOrderPaymentPlanItemPaymentPlanItemToSalesOrderGet: " + e.Message);
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
    Debug.Print("Exception when calling SalesOrderHeaderApi.ASlsOrdPaymentPlanItemDetailsSalesOrderSalesOrderPaymentPlanItemPaymentPlanItemToSalesOrderGetWithHttpInfo: " + e.Message);
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

<a id="aslsorderitembillingplanitemsalesordersalesordersalesorderitemsalesorderitembillingplanbillingplanbillingplanitembillingplanitemtosalesorderget"></a>
# **ASlsOrderItemBillingPlanItemSalesOrderSalesOrderSalesOrderItemSalesOrderItemBillingPlanBillingPlanBillingPlanItemBillingPlanItemToSalesOrderGet**
> ASalesOrderType ASlsOrderItemBillingPlanItemSalesOrderSalesOrderSalesOrderItemSalesOrderItemBillingPlanBillingPlanBillingPlanItemBillingPlanItemToSalesOrderGet (string salesOrder, string salesOrderItem, string billingPlan, string billingPlanItem, List<string>? select = null, List<string>? expand = null)

Reads the sales order header for an item billing plan item.

Reads the sales order header data for a specific billing plan item of a sales order item. Consumers must pass the following key fields: sales order ID, item number, number of the item billing plan, and item number of the item billing plan.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ASlsOrderItemBillingPlanItemSalesOrderSalesOrderSalesOrderItemSalesOrderItemBillingPlanBillingPlanBillingPlanItemBillingPlanItemToSalesOrderGetExample
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

            var apiInstance = new SalesOrderHeaderApi(config);
            var salesOrder = "salesOrder_example";  // string | Sales Order
            var salesOrderItem = "salesOrderItem_example";  // string | Sales Order Item
            var billingPlan = "billingPlan_example";  // string | Billing/Invoicing Plan Number
            var billingPlanItem = "billingPlanItem_example";  // string | Item for billing plan/invoice plan/payment cards
            var select = new List<string>?(); // List<string>? | Select properties to be returned, see [Select](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=68) (optional) 
            var expand = new List<string>?(); // List<string>? | Expand related entities, see [Expand](https://help.sap.com/doc/5890d27be418427993fafa6722cdc03b/Cloud/en-US/OdataV2.pdf#page=63) (optional) 

            try
            {
                // Reads the sales order header for an item billing plan item.
                ASalesOrderType result = apiInstance.ASlsOrderItemBillingPlanItemSalesOrderSalesOrderSalesOrderItemSalesOrderItemBillingPlanBillingPlanBillingPlanItemBillingPlanItemToSalesOrderGet(salesOrder, salesOrderItem, billingPlan, billingPlanItem, select, expand);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SalesOrderHeaderApi.ASlsOrderItemBillingPlanItemSalesOrderSalesOrderSalesOrderItemSalesOrderItemBillingPlanBillingPlanBillingPlanItemBillingPlanItemToSalesOrderGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ASlsOrderItemBillingPlanItemSalesOrderSalesOrderSalesOrderItemSalesOrderItemBillingPlanBillingPlanBillingPlanItemBillingPlanItemToSalesOrderGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Reads the sales order header for an item billing plan item.
    ApiResponse<ASalesOrderType> response = apiInstance.ASlsOrderItemBillingPlanItemSalesOrderSalesOrderSalesOrderItemSalesOrderItemBillingPlanBillingPlanBillingPlanItemBillingPlanItemToSalesOrderGetWithHttpInfo(salesOrder, salesOrderItem, billingPlan, billingPlanItem, select, expand);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SalesOrderHeaderApi.ASlsOrderItemBillingPlanItemSalesOrderSalesOrderSalesOrderItemSalesOrderItemBillingPlanBillingPlanBillingPlanItemBillingPlanItemToSalesOrderGetWithHttpInfo: " + e.Message);
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

