# Org.OpenAPITools.Model.APISALESORDERSRVASlsOrdPaymentPlanItemDetailsTypeUpdate

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ElectronicPaymentType** | **string** | Electronic Payment: Payment Type | [optional] 
**ElectronicPayment** | **string** | Electronic Payment: Account Number | [optional] 
**EPaytValidityStartDate** | **string** | Electronic Payment: Valid from | [optional] 
**EPaytValidityEndDate** | **string** | Electronic Payment: Valid to | [optional] 
**ElectronicPaymentHolderName** | **string** | Electronic Payment: Name of Account Holder | [optional] 
**AuthorizedAmountInAuthznCrcy** | **decimal?** | Electronic Payment: Authorized Amount | [optional] 
**AuthorizationByDigitalPaytSrvc** | **string** | Electronic Payment: Authorization Number | [optional] 
**EPaytByDigitalPaymentSrvc** | **string** | Token for Digital Payment Integration in SD | [optional] 
**PaymentServiceProvider** | **string** | Payment Service Provider for Digital Payments | [optional] 
**PaymentByPaymentServicePrvdr** | **string** | Digital Payments: Payment ID from Payment Service Provider | [optional] 
**TransactionByPaytSrvcPrvdr** | **string** | SAP Digital Payments: Transaction ID of PSP | [optional] 
**MerchantByClearingHouse** | **string** | Electronic Payment: Merchant ID at Clearing House | [optional] 
**PaymentCardAuthznRelationID** | **string** | Unique identifier of a previous successful authorization | [optional] 
**MaximumToBeAuthorizedAmount** | **decimal?** | Value to be billed/calc. on date in billing/invoice plan | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

