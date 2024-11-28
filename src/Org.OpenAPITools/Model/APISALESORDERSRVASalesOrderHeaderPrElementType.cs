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
    /// APISALESORDERSRVASalesOrderHeaderPrElementType
    /// </summary>
    [DataContract(Name = "API_SALES_ORDER_SRV.A_SalesOrderHeaderPrElementType")]
    public partial class APISALESORDERSRVASalesOrderHeaderPrElementType : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="APISALESORDERSRVASalesOrderHeaderPrElementType" /> class.
        /// </summary>
        /// <param name="salesOrder">salesOrder.</param>
        /// <param name="pricingProcedureStep">pricingProcedureStep.</param>
        /// <param name="pricingProcedureCounter">Condition Counter.</param>
        /// <param name="conditionType">conditionType.</param>
        /// <param name="pricingDateTime">Timestamp for Pricing.</param>
        /// <param name="priceConditionDeterminationDte">Condition Pricing Date.</param>
        /// <param name="conditionCalculationType">Calculation Type for Condition.</param>
        /// <param name="conditionBaseValue">conditionBaseValue.</param>
        /// <param name="conditionRateValue">Condition Amount or Percentage.</param>
        /// <param name="conditionCurrency">Currency Key.</param>
        /// <param name="conditionQuantity">Condition Pricing Unit.</param>
        /// <param name="conditionQuantityUnit">Condition Unit in the Document.</param>
        /// <param name="conditionQuantitySAPUnit">SAP Unit Code for Condition Quantity.</param>
        /// <param name="conditionQuantityISOUnit">ISO Unit Code for Condition Quantity.</param>
        /// <param name="conditionCategory">Condition Category (Examples: Tax, Freight, Price, Cost).</param>
        /// <param name="conditionIsForStatistics">Condition is used for statistics.</param>
        /// <param name="pricingScaleType">pricingScaleType.</param>
        /// <param name="conditionOrigin">Origin of the Condition.</param>
        /// <param name="isGroupCondition">isGroupCondition.</param>
        /// <param name="conditionRecord">Number of Condition Record.</param>
        /// <param name="conditionSequentialNumber">Sequential Number of the Condition.</param>
        /// <param name="taxCode">Tax on Sales/Purchases Code.</param>
        /// <param name="withholdingTaxCode">Withholding Tax Code.</param>
        /// <param name="cndnRoundingOffDiffAmount">Rounding-Off Difference of the Condition.</param>
        /// <param name="conditionAmount">conditionAmount.</param>
        /// <param name="transactionCurrency">SD Document Currency.</param>
        /// <param name="conditionControl">conditionControl.</param>
        /// <param name="conditionInactiveReason">Condition is Inactive.</param>
        /// <param name="conditionClass">conditionClass.</param>
        /// <param name="prcgProcedureCounterForHeader">Condition Counter (Header).</param>
        /// <param name="factorForConditionBasisValue">factorForConditionBasisValue.</param>
        /// <param name="structureCondition">structureCondition.</param>
        /// <param name="periodFactorForCndnBasisValue">periodFactorForCndnBasisValue.</param>
        /// <param name="pricingScaleBasis">Scale Basis Indicator.</param>
        /// <param name="conditionScaleBasisValue">Scale Base Value.</param>
        /// <param name="conditionScaleBasisUnit">Condition Scale Unit of Measure.</param>
        /// <param name="conditionScaleBasisCurrency">conditionScaleBasisCurrency.</param>
        /// <param name="cndnIsRelevantForIntcoBilling">Condition for Intercompany Billing.</param>
        /// <param name="conditionIsManuallyChanged">Condition Changed Manually.</param>
        /// <param name="conditionIsForConfiguration">Condition Used for Variant Configuration.</param>
        /// <param name="variantCondition">Variant Condition Key.</param>
        /// <param name="toSalesOrder">toSalesOrder.</param>
        public APISALESORDERSRVASalesOrderHeaderPrElementType(string salesOrder = default(string), string pricingProcedureStep = default(string), string pricingProcedureCounter = default(string), string conditionType = default(string), string pricingDateTime = default(string), string priceConditionDeterminationDte = default(string), string conditionCalculationType = default(string), decimal? conditionBaseValue = default(decimal?), decimal? conditionRateValue = default(decimal?), string conditionCurrency = default(string), decimal? conditionQuantity = default(decimal?), string conditionQuantityUnit = default(string), string conditionQuantitySAPUnit = default(string), string conditionQuantityISOUnit = default(string), string conditionCategory = default(string), bool? conditionIsForStatistics = default(bool?), string pricingScaleType = default(string), string conditionOrigin = default(string), string isGroupCondition = default(string), string conditionRecord = default(string), string conditionSequentialNumber = default(string), string taxCode = default(string), string withholdingTaxCode = default(string), decimal? cndnRoundingOffDiffAmount = default(decimal?), decimal? conditionAmount = default(decimal?), string transactionCurrency = default(string), string conditionControl = default(string), string conditionInactiveReason = default(string), string conditionClass = default(string), string prcgProcedureCounterForHeader = default(string), ConditionFactor factorForConditionBasisValue = default(ConditionFactor), string structureCondition = default(string), ConditionFactor1 periodFactorForCndnBasisValue = default(ConditionFactor1), string pricingScaleBasis = default(string), decimal? conditionScaleBasisValue = default(decimal?), string conditionScaleBasisUnit = default(string), string conditionScaleBasisCurrency = default(string), bool? cndnIsRelevantForIntcoBilling = default(bool?), bool? conditionIsManuallyChanged = default(bool?), bool? conditionIsForConfiguration = default(bool?), string variantCondition = default(string), APISALESORDERSRVASalesOrderType toSalesOrder = default(APISALESORDERSRVASalesOrderType))
        {
            this.SalesOrder = salesOrder;
            this.PricingProcedureStep = pricingProcedureStep;
            this.PricingProcedureCounter = pricingProcedureCounter;
            this.ConditionType = conditionType;
            this.PricingDateTime = pricingDateTime;
            this.PriceConditionDeterminationDte = priceConditionDeterminationDte;
            this.ConditionCalculationType = conditionCalculationType;
            this.ConditionBaseValue = conditionBaseValue;
            this.ConditionRateValue = conditionRateValue;
            this.ConditionCurrency = conditionCurrency;
            this.ConditionQuantity = conditionQuantity;
            this.ConditionQuantityUnit = conditionQuantityUnit;
            this.ConditionQuantitySAPUnit = conditionQuantitySAPUnit;
            this.ConditionQuantityISOUnit = conditionQuantityISOUnit;
            this.ConditionCategory = conditionCategory;
            this.ConditionIsForStatistics = conditionIsForStatistics;
            this.PricingScaleType = pricingScaleType;
            this.ConditionOrigin = conditionOrigin;
            this.IsGroupCondition = isGroupCondition;
            this.ConditionRecord = conditionRecord;
            this.ConditionSequentialNumber = conditionSequentialNumber;
            this.TaxCode = taxCode;
            this.WithholdingTaxCode = withholdingTaxCode;
            this.CndnRoundingOffDiffAmount = cndnRoundingOffDiffAmount;
            this.ConditionAmount = conditionAmount;
            this.TransactionCurrency = transactionCurrency;
            this.ConditionControl = conditionControl;
            this.ConditionInactiveReason = conditionInactiveReason;
            this.ConditionClass = conditionClass;
            this.PrcgProcedureCounterForHeader = prcgProcedureCounterForHeader;
            this.FactorForConditionBasisValue = factorForConditionBasisValue;
            this.StructureCondition = structureCondition;
            this.PeriodFactorForCndnBasisValue = periodFactorForCndnBasisValue;
            this.PricingScaleBasis = pricingScaleBasis;
            this.ConditionScaleBasisValue = conditionScaleBasisValue;
            this.ConditionScaleBasisUnit = conditionScaleBasisUnit;
            this.ConditionScaleBasisCurrency = conditionScaleBasisCurrency;
            this.CndnIsRelevantForIntcoBilling = cndnIsRelevantForIntcoBilling;
            this.ConditionIsManuallyChanged = conditionIsManuallyChanged;
            this.ConditionIsForConfiguration = conditionIsForConfiguration;
            this.VariantCondition = variantCondition;
            this.ToSalesOrder = toSalesOrder;
        }

        /// <summary>
        /// Gets or Sets SalesOrder
        /// </summary>
        [DataMember(Name = "SalesOrder", EmitDefaultValue = false)]
        public string SalesOrder { get; set; }

        /// <summary>
        /// Gets or Sets PricingProcedureStep
        /// </summary>
        [DataMember(Name = "PricingProcedureStep", EmitDefaultValue = false)]
        public string PricingProcedureStep { get; set; }

        /// <summary>
        /// Condition Counter
        /// </summary>
        /// <value>Condition Counter</value>
        [DataMember(Name = "PricingProcedureCounter", EmitDefaultValue = false)]
        public string PricingProcedureCounter { get; set; }

        /// <summary>
        /// Gets or Sets ConditionType
        /// </summary>
        [DataMember(Name = "ConditionType", EmitDefaultValue = true)]
        public string ConditionType { get; set; }

        /// <summary>
        /// Timestamp for Pricing
        /// </summary>
        /// <value>Timestamp for Pricing</value>
        [DataMember(Name = "PricingDateTime", EmitDefaultValue = true)]
        public string PricingDateTime { get; set; }

        /// <summary>
        /// Condition Pricing Date
        /// </summary>
        /// <value>Condition Pricing Date</value>
        /*
        <example>/Date(1492041600000)/</example>
        */
        [DataMember(Name = "PriceConditionDeterminationDte", EmitDefaultValue = true)]
        public string PriceConditionDeterminationDte { get; set; }

        /// <summary>
        /// Calculation Type for Condition
        /// </summary>
        /// <value>Calculation Type for Condition</value>
        [DataMember(Name = "ConditionCalculationType", EmitDefaultValue = true)]
        public string ConditionCalculationType { get; set; }

        /// <summary>
        /// Gets or Sets ConditionBaseValue
        /// </summary>
        /*
        <example>0</example>
        */
        [DataMember(Name = "ConditionBaseValue", EmitDefaultValue = true)]
        public decimal? ConditionBaseValue { get; set; }

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
        /// Condition Category (Examples: Tax, Freight, Price, Cost)
        /// </summary>
        /// <value>Condition Category (Examples: Tax, Freight, Price, Cost)</value>
        [DataMember(Name = "ConditionCategory", EmitDefaultValue = true)]
        public string ConditionCategory { get; set; }

        /// <summary>
        /// Condition is used for statistics
        /// </summary>
        /// <value>Condition is used for statistics</value>
        [DataMember(Name = "ConditionIsForStatistics", EmitDefaultValue = true)]
        public bool? ConditionIsForStatistics { get; set; }

        /// <summary>
        /// Gets or Sets PricingScaleType
        /// </summary>
        [DataMember(Name = "PricingScaleType", EmitDefaultValue = true)]
        public string PricingScaleType { get; set; }

        /// <summary>
        /// Origin of the Condition
        /// </summary>
        /// <value>Origin of the Condition</value>
        [DataMember(Name = "ConditionOrigin", EmitDefaultValue = true)]
        public string ConditionOrigin { get; set; }

        /// <summary>
        /// Gets or Sets IsGroupCondition
        /// </summary>
        [DataMember(Name = "IsGroupCondition", EmitDefaultValue = true)]
        public string IsGroupCondition { get; set; }

        /// <summary>
        /// Number of Condition Record
        /// </summary>
        /// <value>Number of Condition Record</value>
        [DataMember(Name = "ConditionRecord", EmitDefaultValue = true)]
        public string ConditionRecord { get; set; }

        /// <summary>
        /// Sequential Number of the Condition
        /// </summary>
        /// <value>Sequential Number of the Condition</value>
        [DataMember(Name = "ConditionSequentialNumber", EmitDefaultValue = true)]
        public string ConditionSequentialNumber { get; set; }

        /// <summary>
        /// Tax on Sales/Purchases Code
        /// </summary>
        /// <value>Tax on Sales/Purchases Code</value>
        [DataMember(Name = "TaxCode", EmitDefaultValue = true)]
        public string TaxCode { get; set; }

        /// <summary>
        /// Withholding Tax Code
        /// </summary>
        /// <value>Withholding Tax Code</value>
        [DataMember(Name = "WithholdingTaxCode", EmitDefaultValue = true)]
        public string WithholdingTaxCode { get; set; }

        /// <summary>
        /// Rounding-Off Difference of the Condition
        /// </summary>
        /// <value>Rounding-Off Difference of the Condition</value>
        /*
        <example>0</example>
        */
        [DataMember(Name = "CndnRoundingOffDiffAmount", EmitDefaultValue = true)]
        public decimal? CndnRoundingOffDiffAmount { get; set; }

        /// <summary>
        /// Gets or Sets ConditionAmount
        /// </summary>
        /*
        <example>0</example>
        */
        [DataMember(Name = "ConditionAmount", EmitDefaultValue = true)]
        public decimal? ConditionAmount { get; set; }

        /// <summary>
        /// SD Document Currency
        /// </summary>
        /// <value>SD Document Currency</value>
        [DataMember(Name = "TransactionCurrency", EmitDefaultValue = true)]
        public string TransactionCurrency { get; set; }

        /// <summary>
        /// Gets or Sets ConditionControl
        /// </summary>
        [DataMember(Name = "ConditionControl", EmitDefaultValue = true)]
        public string ConditionControl { get; set; }

        /// <summary>
        /// Condition is Inactive
        /// </summary>
        /// <value>Condition is Inactive</value>
        [DataMember(Name = "ConditionInactiveReason", EmitDefaultValue = true)]
        public string ConditionInactiveReason { get; set; }

        /// <summary>
        /// Gets or Sets ConditionClass
        /// </summary>
        [DataMember(Name = "ConditionClass", EmitDefaultValue = true)]
        public string ConditionClass { get; set; }

        /// <summary>
        /// Condition Counter (Header)
        /// </summary>
        /// <value>Condition Counter (Header)</value>
        [DataMember(Name = "PrcgProcedureCounterForHeader", EmitDefaultValue = true)]
        public string PrcgProcedureCounterForHeader { get; set; }

        /// <summary>
        /// Gets or Sets FactorForConditionBasisValue
        /// </summary>
        [DataMember(Name = "FactorForConditionBasisValue", EmitDefaultValue = true)]
        public ConditionFactor FactorForConditionBasisValue { get; set; }

        /// <summary>
        /// Gets or Sets StructureCondition
        /// </summary>
        [DataMember(Name = "StructureCondition", EmitDefaultValue = true)]
        public string StructureCondition { get; set; }

        /// <summary>
        /// Gets or Sets PeriodFactorForCndnBasisValue
        /// </summary>
        [DataMember(Name = "PeriodFactorForCndnBasisValue", EmitDefaultValue = true)]
        public ConditionFactor1 PeriodFactorForCndnBasisValue { get; set; }

        /// <summary>
        /// Scale Basis Indicator
        /// </summary>
        /// <value>Scale Basis Indicator</value>
        [DataMember(Name = "PricingScaleBasis", EmitDefaultValue = true)]
        public string PricingScaleBasis { get; set; }

        /// <summary>
        /// Scale Base Value
        /// </summary>
        /// <value>Scale Base Value</value>
        /*
        <example>0</example>
        */
        [DataMember(Name = "ConditionScaleBasisValue", EmitDefaultValue = true)]
        public decimal? ConditionScaleBasisValue { get; set; }

        /// <summary>
        /// Condition Scale Unit of Measure
        /// </summary>
        /// <value>Condition Scale Unit of Measure</value>
        [DataMember(Name = "ConditionScaleBasisUnit", EmitDefaultValue = true)]
        public string ConditionScaleBasisUnit { get; set; }

        /// <summary>
        /// Gets or Sets ConditionScaleBasisCurrency
        /// </summary>
        [DataMember(Name = "ConditionScaleBasisCurrency", EmitDefaultValue = true)]
        public string ConditionScaleBasisCurrency { get; set; }

        /// <summary>
        /// Condition for Intercompany Billing
        /// </summary>
        /// <value>Condition for Intercompany Billing</value>
        [DataMember(Name = "CndnIsRelevantForIntcoBilling", EmitDefaultValue = true)]
        public bool? CndnIsRelevantForIntcoBilling { get; set; }

        /// <summary>
        /// Condition Changed Manually
        /// </summary>
        /// <value>Condition Changed Manually</value>
        [DataMember(Name = "ConditionIsManuallyChanged", EmitDefaultValue = true)]
        public bool? ConditionIsManuallyChanged { get; set; }

        /// <summary>
        /// Condition Used for Variant Configuration
        /// </summary>
        /// <value>Condition Used for Variant Configuration</value>
        [DataMember(Name = "ConditionIsForConfiguration", EmitDefaultValue = true)]
        public bool? ConditionIsForConfiguration { get; set; }

        /// <summary>
        /// Variant Condition Key
        /// </summary>
        /// <value>Variant Condition Key</value>
        [DataMember(Name = "VariantCondition", EmitDefaultValue = true)]
        public string VariantCondition { get; set; }

        /// <summary>
        /// Gets or Sets ToSalesOrder
        /// </summary>
        [DataMember(Name = "to_SalesOrder", EmitDefaultValue = false)]
        public APISALESORDERSRVASalesOrderType ToSalesOrder { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class APISALESORDERSRVASalesOrderHeaderPrElementType {\n");
            sb.Append("  SalesOrder: ").Append(SalesOrder).Append("\n");
            sb.Append("  PricingProcedureStep: ").Append(PricingProcedureStep).Append("\n");
            sb.Append("  PricingProcedureCounter: ").Append(PricingProcedureCounter).Append("\n");
            sb.Append("  ConditionType: ").Append(ConditionType).Append("\n");
            sb.Append("  PricingDateTime: ").Append(PricingDateTime).Append("\n");
            sb.Append("  PriceConditionDeterminationDte: ").Append(PriceConditionDeterminationDte).Append("\n");
            sb.Append("  ConditionCalculationType: ").Append(ConditionCalculationType).Append("\n");
            sb.Append("  ConditionBaseValue: ").Append(ConditionBaseValue).Append("\n");
            sb.Append("  ConditionRateValue: ").Append(ConditionRateValue).Append("\n");
            sb.Append("  ConditionCurrency: ").Append(ConditionCurrency).Append("\n");
            sb.Append("  ConditionQuantity: ").Append(ConditionQuantity).Append("\n");
            sb.Append("  ConditionQuantityUnit: ").Append(ConditionQuantityUnit).Append("\n");
            sb.Append("  ConditionQuantitySAPUnit: ").Append(ConditionQuantitySAPUnit).Append("\n");
            sb.Append("  ConditionQuantityISOUnit: ").Append(ConditionQuantityISOUnit).Append("\n");
            sb.Append("  ConditionCategory: ").Append(ConditionCategory).Append("\n");
            sb.Append("  ConditionIsForStatistics: ").Append(ConditionIsForStatistics).Append("\n");
            sb.Append("  PricingScaleType: ").Append(PricingScaleType).Append("\n");
            sb.Append("  ConditionOrigin: ").Append(ConditionOrigin).Append("\n");
            sb.Append("  IsGroupCondition: ").Append(IsGroupCondition).Append("\n");
            sb.Append("  ConditionRecord: ").Append(ConditionRecord).Append("\n");
            sb.Append("  ConditionSequentialNumber: ").Append(ConditionSequentialNumber).Append("\n");
            sb.Append("  TaxCode: ").Append(TaxCode).Append("\n");
            sb.Append("  WithholdingTaxCode: ").Append(WithholdingTaxCode).Append("\n");
            sb.Append("  CndnRoundingOffDiffAmount: ").Append(CndnRoundingOffDiffAmount).Append("\n");
            sb.Append("  ConditionAmount: ").Append(ConditionAmount).Append("\n");
            sb.Append("  TransactionCurrency: ").Append(TransactionCurrency).Append("\n");
            sb.Append("  ConditionControl: ").Append(ConditionControl).Append("\n");
            sb.Append("  ConditionInactiveReason: ").Append(ConditionInactiveReason).Append("\n");
            sb.Append("  ConditionClass: ").Append(ConditionClass).Append("\n");
            sb.Append("  PrcgProcedureCounterForHeader: ").Append(PrcgProcedureCounterForHeader).Append("\n");
            sb.Append("  FactorForConditionBasisValue: ").Append(FactorForConditionBasisValue).Append("\n");
            sb.Append("  StructureCondition: ").Append(StructureCondition).Append("\n");
            sb.Append("  PeriodFactorForCndnBasisValue: ").Append(PeriodFactorForCndnBasisValue).Append("\n");
            sb.Append("  PricingScaleBasis: ").Append(PricingScaleBasis).Append("\n");
            sb.Append("  ConditionScaleBasisValue: ").Append(ConditionScaleBasisValue).Append("\n");
            sb.Append("  ConditionScaleBasisUnit: ").Append(ConditionScaleBasisUnit).Append("\n");
            sb.Append("  ConditionScaleBasisCurrency: ").Append(ConditionScaleBasisCurrency).Append("\n");
            sb.Append("  CndnIsRelevantForIntcoBilling: ").Append(CndnIsRelevantForIntcoBilling).Append("\n");
            sb.Append("  ConditionIsManuallyChanged: ").Append(ConditionIsManuallyChanged).Append("\n");
            sb.Append("  ConditionIsForConfiguration: ").Append(ConditionIsForConfiguration).Append("\n");
            sb.Append("  VariantCondition: ").Append(VariantCondition).Append("\n");
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
            // SalesOrder (string) maxLength
            if (this.SalesOrder != null && this.SalesOrder.Length > 10)
            {
                yield return new ValidationResult("Invalid value for SalesOrder, length must be less than 10.", new [] { "SalesOrder" });
            }

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

            // PricingDateTime (string) maxLength
            if (this.PricingDateTime != null && this.PricingDateTime.Length > 14)
            {
                yield return new ValidationResult("Invalid value for PricingDateTime, length must be less than 14.", new [] { "PricingDateTime" });
            }

            // ConditionCalculationType (string) maxLength
            if (this.ConditionCalculationType != null && this.ConditionCalculationType.Length > 3)
            {
                yield return new ValidationResult("Invalid value for ConditionCalculationType, length must be less than 3.", new [] { "ConditionCalculationType" });
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

            // ConditionCategory (string) maxLength
            if (this.ConditionCategory != null && this.ConditionCategory.Length > 1)
            {
                yield return new ValidationResult("Invalid value for ConditionCategory, length must be less than 1.", new [] { "ConditionCategory" });
            }

            // PricingScaleType (string) maxLength
            if (this.PricingScaleType != null && this.PricingScaleType.Length > 1)
            {
                yield return new ValidationResult("Invalid value for PricingScaleType, length must be less than 1.", new [] { "PricingScaleType" });
            }

            // ConditionOrigin (string) maxLength
            if (this.ConditionOrigin != null && this.ConditionOrigin.Length > 1)
            {
                yield return new ValidationResult("Invalid value for ConditionOrigin, length must be less than 1.", new [] { "ConditionOrigin" });
            }

            // IsGroupCondition (string) maxLength
            if (this.IsGroupCondition != null && this.IsGroupCondition.Length > 1)
            {
                yield return new ValidationResult("Invalid value for IsGroupCondition, length must be less than 1.", new [] { "IsGroupCondition" });
            }

            // ConditionRecord (string) maxLength
            if (this.ConditionRecord != null && this.ConditionRecord.Length > 10)
            {
                yield return new ValidationResult("Invalid value for ConditionRecord, length must be less than 10.", new [] { "ConditionRecord" });
            }

            // ConditionSequentialNumber (string) maxLength
            if (this.ConditionSequentialNumber != null && this.ConditionSequentialNumber.Length > 3)
            {
                yield return new ValidationResult("Invalid value for ConditionSequentialNumber, length must be less than 3.", new [] { "ConditionSequentialNumber" });
            }

            // TaxCode (string) maxLength
            if (this.TaxCode != null && this.TaxCode.Length > 2)
            {
                yield return new ValidationResult("Invalid value for TaxCode, length must be less than 2.", new [] { "TaxCode" });
            }

            // WithholdingTaxCode (string) maxLength
            if (this.WithholdingTaxCode != null && this.WithholdingTaxCode.Length > 2)
            {
                yield return new ValidationResult("Invalid value for WithholdingTaxCode, length must be less than 2.", new [] { "WithholdingTaxCode" });
            }

            // TransactionCurrency (string) maxLength
            if (this.TransactionCurrency != null && this.TransactionCurrency.Length > 5)
            {
                yield return new ValidationResult("Invalid value for TransactionCurrency, length must be less than 5.", new [] { "TransactionCurrency" });
            }

            // ConditionControl (string) maxLength
            if (this.ConditionControl != null && this.ConditionControl.Length > 1)
            {
                yield return new ValidationResult("Invalid value for ConditionControl, length must be less than 1.", new [] { "ConditionControl" });
            }

            // ConditionInactiveReason (string) maxLength
            if (this.ConditionInactiveReason != null && this.ConditionInactiveReason.Length > 1)
            {
                yield return new ValidationResult("Invalid value for ConditionInactiveReason, length must be less than 1.", new [] { "ConditionInactiveReason" });
            }

            // ConditionClass (string) maxLength
            if (this.ConditionClass != null && this.ConditionClass.Length > 1)
            {
                yield return new ValidationResult("Invalid value for ConditionClass, length must be less than 1.", new [] { "ConditionClass" });
            }

            // PrcgProcedureCounterForHeader (string) maxLength
            if (this.PrcgProcedureCounterForHeader != null && this.PrcgProcedureCounterForHeader.Length > 3)
            {
                yield return new ValidationResult("Invalid value for PrcgProcedureCounterForHeader, length must be less than 3.", new [] { "PrcgProcedureCounterForHeader" });
            }

            // StructureCondition (string) maxLength
            if (this.StructureCondition != null && this.StructureCondition.Length > 1)
            {
                yield return new ValidationResult("Invalid value for StructureCondition, length must be less than 1.", new [] { "StructureCondition" });
            }

            // PricingScaleBasis (string) maxLength
            if (this.PricingScaleBasis != null && this.PricingScaleBasis.Length > 3)
            {
                yield return new ValidationResult("Invalid value for PricingScaleBasis, length must be less than 3.", new [] { "PricingScaleBasis" });
            }

            // ConditionScaleBasisUnit (string) maxLength
            if (this.ConditionScaleBasisUnit != null && this.ConditionScaleBasisUnit.Length > 3)
            {
                yield return new ValidationResult("Invalid value for ConditionScaleBasisUnit, length must be less than 3.", new [] { "ConditionScaleBasisUnit" });
            }

            // ConditionScaleBasisCurrency (string) maxLength
            if (this.ConditionScaleBasisCurrency != null && this.ConditionScaleBasisCurrency.Length > 5)
            {
                yield return new ValidationResult("Invalid value for ConditionScaleBasisCurrency, length must be less than 5.", new [] { "ConditionScaleBasisCurrency" });
            }

            // VariantCondition (string) maxLength
            if (this.VariantCondition != null && this.VariantCondition.Length > 26)
            {
                yield return new ValidationResult("Invalid value for VariantCondition, length must be less than 26.", new [] { "VariantCondition" });
            }

            yield break;
        }
    }

}