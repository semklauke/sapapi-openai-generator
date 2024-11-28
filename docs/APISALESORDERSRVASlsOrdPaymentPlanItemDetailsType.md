# Org.OpenAPITools.Model.APISALESORDERSRVASlsOrdPaymentPlanItemDetailsType

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SalesOrder** | **string** |  | [optional] 
**PaymentPlanItem** | **string** | Item for billing plan/invoice plan/payment cards | [optional] 
**PaymentPlan** | **string** | Billing Plan Number / Invoicing Plan Number | [optional] 
**ElectronicPaymentType** | **string** | Electronic Payment: Payment Type | [optional] 
**ElectronicPayment** | **string** | Electronic Payment: Account Number | [optional] 
**EPaytValidityStartDate** | **string** | Electronic Payment: Valid from | [optional] 
**EPaytValidityEndDate** | **string** | Electronic Payment: Valid to | [optional] 
**ElectronicPaymentHolderName** | **string** | Electronic Payment: Name of Account Holder | [optional] 
**AuthorizedAmountInAuthznCrcy** | **decimal?** | Electronic Payment: Authorized Amount | [optional] 
**AuthorizationCurrency** | **string** | Currency Key | [optional] 
**AuthorizationByDigitalPaytSrvc** | **string** | Electronic Payment: Authorization Number | [optional] 
**AuthorizationByAcquirer** | **string** | Electronic Payment: Authorization Reference Code | [optional] 
**AuthorizationDate** | **string** | Electronic Payment: Authorization Date | [optional] 
**AuthorizationTime** | **string** | Electronic Payment: Authorization Time | [optional] 
**AuthorizationStatusName** | **string** | Payment cards: Result text | [optional] 
**EPaytByDigitalPaymentSrvc** | **string** | Token for Digital Payment Integration in SD | [optional] 
**ElectronicPaymentCallStatus** | **string** | Electronic Payment: Call Status | [optional] 
**EPaytAuthorizationResult** | **string** | Electronic Payment: Response to Authorization Checks | [optional] 
**EPaytToBeAuthorizedAmount** | **decimal?** | Electronic Payment: Amount to Be Authorized | [optional] 
**EPaytAuthorizationIsExpired** | **bool?** | Electronic Payment: Authorization Expired | [optional] 
**EPaytAmountIsChanged** | **bool?** | Electronic Payment: Amount Changed | [optional] 
**PreauthorizationIsRequested** | **bool?** | Electronic Payment: Preauthorization | [optional] 
**PaymentServiceProvider** | **string** | Payment Service Provider for Digital Payments | [optional] 
**PaymentByPaymentServicePrvdr** | **string** | Digital Payments: Payment ID from Payment Service Provider | [optional] 
**TransactionByPaytSrvcPrvdr** | **string** | SAP Digital Payments: Transaction ID of PSP | [optional] 
**MerchantByClearingHouse** | **string** | Electronic Payment: Merchant ID at Clearing House | [optional] 
**PaymentCardAuthznRelationID** | **string** | Unique identifier of a previous successful authorization | [optional] 
**MaximumToBeAuthorizedAmount** | **decimal?** | Value to be billed/calc. on date in billing/invoice plan | [optional] 
**PaytPlnForAuthorizationItem** | **string** | Higher-level payment card plan number for billing | [optional] 
**PaytPlnItmForAuthorizationItem** | **string** | Higher-level item in billing plan | [optional] 
**ToSalesOrder** | [**APISALESORDERSRVASalesOrderType**](APISALESORDERSRVASalesOrderType.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

