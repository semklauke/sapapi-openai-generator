# Org.OpenAPITools.Model.APISALESORDERSRVASalesOrderItmSubsqntProcFlowTypeCreate

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SalesOrder** | **string** | Preceding sales and distribution document | 
**SalesOrderItem** | **string** | Preceding Item of an SD Document | 
**DocRelationshipUUID** | **Guid** | SD Unique Document Relationship Identification | 
**SubsequentDocument** | **string** | Subsequent Sales and Distribution Document | [optional] 
**SubsequentDocumentItem** | **string** | Subsequent Item of an SD Document | [optional] 
**SubsequentDocumentCategory** | **string** | Document Category of Subsequent Document | [optional] 
**ProcessFlowLevel** | **string** | Level of the document flow record | [optional] 
**RelatedProcFlowDocStsFieldName** | **string** |  | [optional] 
**SDProcessStatus** | **string** | Overall Processing Status (Item) | [optional] 
**AccountingTransferStatus** | **string** | Status for Transfer to Accounting | [optional] 
**PrelimBillingDocumentStatus** | **string** | Preliminary Billing Document Status | [optional] 
**SubsqntDocItmPrecdgDocument** | **string** | Preceding sales and distribution document | [optional] 
**SubsqntDocItmPrecdgDocItem** | **string** | Preceding Item of an SD Document | [optional] 
**SubsqntDocItmPrecdgDocCategory** | **string** | Document Category of Preceding SD Document | [optional] 
**CreationDate** | **string** | Record Creation Date | [optional] 
**CreationTime** | **string** | Entry time | [optional] 
**LastChangeDate** | **string** | Last Changed On | [optional] 
**ToSalesOrder** | [**APISALESORDERSRVASalesOrderTypeCreate**](APISALESORDERSRVASalesOrderTypeCreate.md) |  | [optional] 
**ToSalesOrderItem** | [**APISALESORDERSRVASalesOrderItemTypeCreate**](APISALESORDERSRVASalesOrderItemTypeCreate.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

