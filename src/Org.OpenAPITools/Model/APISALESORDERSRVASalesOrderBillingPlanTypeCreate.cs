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
    /// APISALESORDERSRVASalesOrderBillingPlanTypeCreate
    /// </summary>
    [DataContract(Name = "API_SALES_ORDER_SRV.A_SalesOrderBillingPlanType-create")]
    public partial class APISALESORDERSRVASalesOrderBillingPlanTypeCreate : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="APISALESORDERSRVASalesOrderBillingPlanTypeCreate" /> class.
        /// </summary>
        /// <param name="billingPlanStartDate">Start Date of Billing/Invoicing Plan.</param>
        /// <param name="billingPlanStartDateRule">Rule for Origin of Start Date of Billing/Invoicing Plan.</param>
        /// <param name="referenceBillingPlan">Reference Billing Plan Number / Invoicing Plan Number.</param>
        /// <param name="toBillingPlanItem">toBillingPlanItem.</param>
        /// <param name="toSalesOrder">toSalesOrder.</param>
        public APISALESORDERSRVASalesOrderBillingPlanTypeCreate(string billingPlanStartDate = default(string), string billingPlanStartDateRule = default(string), string referenceBillingPlan = default(string), APISALESORDERSRVASalesOrderBillingPlanTypeCreateToBillingPlanItem toBillingPlanItem = default(APISALESORDERSRVASalesOrderBillingPlanTypeCreateToBillingPlanItem), APISALESORDERSRVASalesOrderTypeCreate toSalesOrder = default(APISALESORDERSRVASalesOrderTypeCreate))
        {
            this.BillingPlanStartDate = billingPlanStartDate;
            this.BillingPlanStartDateRule = billingPlanStartDateRule;
            this.ReferenceBillingPlan = referenceBillingPlan;
            this.ToBillingPlanItem = toBillingPlanItem;
            this.ToSalesOrder = toSalesOrder;
        }

        /// <summary>
        /// Start Date of Billing/Invoicing Plan
        /// </summary>
        /// <value>Start Date of Billing/Invoicing Plan</value>
        /*
        <example>/Date(1492041600000)/</example>
        */
        [DataMember(Name = "BillingPlanStartDate", EmitDefaultValue = true)]
        public string BillingPlanStartDate { get; set; }

        /// <summary>
        /// Rule for Origin of Start Date of Billing/Invoicing Plan
        /// </summary>
        /// <value>Rule for Origin of Start Date of Billing/Invoicing Plan</value>
        [DataMember(Name = "BillingPlanStartDateRule", EmitDefaultValue = true)]
        public string BillingPlanStartDateRule { get; set; }

        /// <summary>
        /// Reference Billing Plan Number / Invoicing Plan Number
        /// </summary>
        /// <value>Reference Billing Plan Number / Invoicing Plan Number</value>
        [DataMember(Name = "ReferenceBillingPlan", EmitDefaultValue = true)]
        public string ReferenceBillingPlan { get; set; }

        /// <summary>
        /// Gets or Sets ToBillingPlanItem
        /// </summary>
        [DataMember(Name = "to_BillingPlanItem", EmitDefaultValue = false)]
        public APISALESORDERSRVASalesOrderBillingPlanTypeCreateToBillingPlanItem ToBillingPlanItem { get; set; }

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
            sb.Append("class APISALESORDERSRVASalesOrderBillingPlanTypeCreate {\n");
            sb.Append("  BillingPlanStartDate: ").Append(BillingPlanStartDate).Append("\n");
            sb.Append("  BillingPlanStartDateRule: ").Append(BillingPlanStartDateRule).Append("\n");
            sb.Append("  ReferenceBillingPlan: ").Append(ReferenceBillingPlan).Append("\n");
            sb.Append("  ToBillingPlanItem: ").Append(ToBillingPlanItem).Append("\n");
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
            // BillingPlanStartDateRule (string) maxLength
            if (this.BillingPlanStartDateRule != null && this.BillingPlanStartDateRule.Length > 2)
            {
                yield return new ValidationResult("Invalid value for BillingPlanStartDateRule, length must be less than 2.", new [] { "BillingPlanStartDateRule" });
            }

            // ReferenceBillingPlan (string) maxLength
            if (this.ReferenceBillingPlan != null && this.ReferenceBillingPlan.Length > 10)
            {
                yield return new ValidationResult("Invalid value for ReferenceBillingPlan, length must be less than 10.", new [] { "ReferenceBillingPlan" });
            }

            yield break;
        }
    }

}
