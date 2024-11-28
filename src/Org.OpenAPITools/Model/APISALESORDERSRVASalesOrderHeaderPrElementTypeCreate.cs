/*
 * Sales Order (A2X)
 *
 * In every API call, you can make use of the following operations:   - You can read entire sales orders or only parts of the data, using the provided filters.   - You can create sales orders. You can use deep insert requests, that is, you create a header plus at least one of the following entities: header partner, header partner address, header pricing element, header billing plan, header billing plan item, header text, payment plan, header related object, item, item partner, item partner address, item pricing element, item billing plan, item billing plan item, item text, and item related object.   If the header already exists, you can create the following sub-entities on their own: header partner, header pricing element, header text, payment plan, header related object, item partner, item pricing element, item text, and item related object.   - For existing sales orders, you can create new items. You can use deep insert requests, that is, you create an item plus at least one of the following entities: item partner, item partner address, item pricing element, item billing plan, item billing plan item, item text, and item related object. If the item already exists, you can create the following sub-entities on their own: item partner, item pricing element, item text, item related object, and item schedule line.   - For existing sales orders, you can update the following entities (that is, you can change the content of their properties): header, header partner, header partner address, header pricing element, header billing plan, header billing plan item, header text, payment plan, item, item partner, item partner address, item pricing element, item billing plan, item billing plan item, item text, and item schedule line.   - For existing sales orders, you can delete the following entities: header, header partner, header pricing element, header billing plan item, header text, payment plan, header related object, item, item partner, item pricing element, item billing plan item, item text, item related object, and item schedule line.   - You can accept or deny approval requests for sales orders that cannot be processed without the consent of an approver.
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// APISALESORDERSRVASalesOrderHeaderPrElementTypeCreate
    /// </summary>
    [DataContract(Name = "API_SALES_ORDER_SRV.A_SalesOrderHeaderPrElementType-create")]
    public partial class APISALESORDERSRVASalesOrderHeaderPrElementTypeCreate : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="APISALESORDERSRVASalesOrderHeaderPrElementTypeCreate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected APISALESORDERSRVASalesOrderHeaderPrElementTypeCreate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="APISALESORDERSRVASalesOrderHeaderPrElementTypeCreate" /> class.
        /// </summary>
        /// <param name="pricingProcedureStep">pricingProcedureStep (required).</param>
        /// <param name="pricingProcedureCounter">Condition Counter (required).</param>
        /// <param name="conditionType">conditionType.</param>
        /// <param name="conditionRateValue">Condition Amount or Percentage.</param>
        /// <param name="conditionCurrency">Currency Key.</param>
        /// <param name="conditionQuantity">Condition Pricing Unit.</param>
        /// <param name="conditionQuantityUnit">Condition Unit in the Document.</param>
        /// <param name="conditionQuantitySAPUnit">SAP Unit Code for Condition Quantity.</param>
        /// <param name="conditionQuantityISOUnit">ISO Unit Code for Condition Quantity.</param>
        /// <param name="transactionCurrency">SD Document Currency.</param>
        /// <param name="toSalesOrder">toSalesOrder.</param>
        public APISALESORDERSRVASalesOrderHeaderPrElementTypeCreate(string pricingProcedureStep = default(string), string pricingProcedureCounter = default(string), string conditionType = default(string), decimal? conditionRateValue = default(decimal?), string conditionCurrency = default(string), decimal? conditionQuantity = default(decimal?), string conditionQuantityUnit = default(string), string conditionQuantitySAPUnit = default(string), string conditionQuantityISOUnit = default(string), string transactionCurrency = default(string), APISALESORDERSRVASalesOrderTypeCreate toSalesOrder = default(APISALESORDERSRVASalesOrderTypeCreate))
        {
            // to ensure "pricingProcedureStep" is required (not null)
            if (pricingProcedureStep == null)
            {
                throw new ArgumentNullException("pricingProcedureStep is a required property for APISALESORDERSRVASalesOrderHeaderPrElementTypeCreate and cannot be null");
            }
            this.PricingProcedureStep = pricingProcedureStep;
            // to ensure "pricingProcedureCounter" is required (not null)
            if (pricingProcedureCounter == null)
            {
                throw new ArgumentNullException("pricingProcedureCounter is a required property for APISALESORDERSRVASalesOrderHeaderPrElementTypeCreate and cannot be null");
            }
            this.PricingProcedureCounter = pricingProcedureCounter;
            this.ConditionType = conditionType;
            this.ConditionRateValue = conditionRateValue;
            this.ConditionCurrency = conditionCurrency;
            this.ConditionQuantity = conditionQuantity;
            this.ConditionQuantityUnit = conditionQuantityUnit;
            this.ConditionQuantitySAPUnit = conditionQuantitySAPUnit;
            this.ConditionQuantityISOUnit = conditionQuantityISOUnit;
            this.TransactionCurrency = transactionCurrency;
            this.ToSalesOrder = toSalesOrder;
        }

        /// <summary>
        /// Gets or Sets PricingProcedureStep
        /// </summary>
        [DataMember(Name = "PricingProcedureStep", IsRequired = true, EmitDefaultValue = true)]
        public string PricingProcedureStep { get; set; }

        /// <summary>
        /// Condition Counter
        /// </summary>
        /// <value>Condition Counter</value>
        [DataMember(Name = "PricingProcedureCounter", IsRequired = true, EmitDefaultValue = true)]
        public string PricingProcedureCounter { get; set; }

        /// <summary>
        /// Gets or Sets ConditionType
        /// </summary>
        [DataMember(Name = "ConditionType", EmitDefaultValue = true)]
        public string ConditionType { get; set; }

        /// <summary>
        /// Condition Amount or Percentage
        /// </summary>
        /// <value>Condition Amount or Percentage</value>
        /*
        <example>0</example>
        */
        [DataMember(Name = "ConditionRateValue", EmitDefaultValue = true)]
        public decimal? ConditionRateValue { get; set; }

        /// <summary>
        /// Currency Key
        /// </summary>
        /// <value>Currency Key</value>
        [DataMember(Name = "ConditionCurrency", EmitDefaultValue = true)]
        public string ConditionCurrency { get; set; }

        /// <summary>
        /// Condition Pricing Unit
        /// </summary>
        /// <value>Condition Pricing Unit</value>
        /*
        <example>0</example>
        */
        [DataMember(Name = "ConditionQuantity", EmitDefaultValue = true)]
        public decimal? ConditionQuantity { get; set; }

        /// <summary>
        /// Condition Unit in the Document
        /// </summary>
        /// <value>Condition Unit in the Document</value>
        [DataMember(Name = "ConditionQuantityUnit", EmitDefaultValue = true)]
        public string ConditionQuantityUnit { get; set; }

        /// <summary>
        /// SAP Unit Code for Condition Quantity
        /// </summary>
        /// <value>SAP Unit Code for Condition Quantity</value>
        [DataMember(Name = "ConditionQuantitySAPUnit", EmitDefaultValue = true)]
        public string ConditionQuantitySAPUnit { get; set; }

        /// <summary>
        /// ISO Unit Code for Condition Quantity
        /// </summary>
        /// <value>ISO Unit Code for Condition Quantity</value>
        [DataMember(Name = "ConditionQuantityISOUnit", EmitDefaultValue = true)]
        public string ConditionQuantityISOUnit { get; set; }

        /// <summary>
        /// SD Document Currency
        /// </summary>
        /// <value>SD Document Currency</value>
        [DataMember(Name = "TransactionCurrency", EmitDefaultValue = true)]
        public string TransactionCurrency { get; set; }

        /// <summary>
        /// Gets or Sets ToSalesOrder
        /// </summary>
        [DataMember(Name = "to_SalesOrder", EmitDefaultValue = false)]
        public APISALESORDERSRVASalesOrderTypeCreate ToSalesOrder { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class APISALESORDERSRVASalesOrderHeaderPrElementTypeCreate {\n");
            sb.Append("  PricingProcedureStep: ").Append(PricingProcedureStep).Append("\n");
            sb.Append("  PricingProcedureCounter: ").Append(PricingProcedureCounter).Append("\n");
            sb.Append("  ConditionType: ").Append(ConditionType).Append("\n");
            sb.Append("  ConditionRateValue: ").Append(ConditionRateValue).Append("\n");
            sb.Append("  ConditionCurrency: ").Append(ConditionCurrency).Append("\n");
            sb.Append("  ConditionQuantity: ").Append(ConditionQuantity).Append("\n");
            sb.Append("  ConditionQuantityUnit: ").Append(ConditionQuantityUnit).Append("\n");
            sb.Append("  ConditionQuantitySAPUnit: ").Append(ConditionQuantitySAPUnit).Append("\n");
            sb.Append("  ConditionQuantityISOUnit: ").Append(ConditionQuantityISOUnit).Append("\n");
            sb.Append("  TransactionCurrency: ").Append(TransactionCurrency).Append("\n");
            sb.Append("  ToSalesOrder: ").Append(ToSalesOrder).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // PricingProcedureStep (string) maxLength
            if (this.PricingProcedureStep != null && this.PricingProcedureStep.Length > 3)
            {
                yield return new ValidationResult("Invalid value for PricingProcedureStep, length must be less than 3.", new [] { "PricingProcedureStep" });
            }

            // PricingProcedureCounter (string) maxLength
            if (this.PricingProcedureCounter != null && this.PricingProcedureCounter.Length > 3)
            {
                yield return new ValidationResult("Invalid value for PricingProcedureCounter, length must be less than 3.", new [] { "PricingProcedureCounter" });
            }

            // ConditionType (string) maxLength
            if (this.ConditionType != null && this.ConditionType.Length > 4)
            {
                yield return new ValidationResult("Invalid value for ConditionType, length must be less than 4.", new [] { "ConditionType" });
            }

            // ConditionCurrency (string) maxLength
            if (this.ConditionCurrency != null && this.ConditionCurrency.Length > 5)
            {
                yield return new ValidationResult("Invalid value for ConditionCurrency, length must be less than 5.", new [] { "ConditionCurrency" });
            }

            // ConditionQuantityUnit (string) maxLength
            if (this.ConditionQuantityUnit != null && this.ConditionQuantityUnit.Length > 3)
            {
                yield return new ValidationResult("Invalid value for ConditionQuantityUnit, length must be less than 3.", new [] { "ConditionQuantityUnit" });
            }

            // ConditionQuantitySAPUnit (string) maxLength
            if (this.ConditionQuantitySAPUnit != null && this.ConditionQuantitySAPUnit.Length > 3)
            {
                yield return new ValidationResult("Invalid value for ConditionQuantitySAPUnit, length must be less than 3.", new [] { "ConditionQuantitySAPUnit" });
            }

            // ConditionQuantityISOUnit (string) maxLength
            if (this.ConditionQuantityISOUnit != null && this.ConditionQuantityISOUnit.Length > 3)
            {
                yield return new ValidationResult("Invalid value for ConditionQuantityISOUnit, length must be less than 3.", new [] { "ConditionQuantityISOUnit" });
            }

            // TransactionCurrency (string) maxLength
            if (this.TransactionCurrency != null && this.TransactionCurrency.Length > 5)
            {
                yield return new ValidationResult("Invalid value for TransactionCurrency, length must be less than 5.", new [] { "TransactionCurrency" });
            }

            yield break;
        }
    }

}