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
    /// APISALESORDERSRVASalesOrderScheduleLineTypeCreate
    /// </summary>
    [DataContract(Name = "API_SALES_ORDER_SRV.A_SalesOrderScheduleLineType-create")]
    public partial class APISALESORDERSRVASalesOrderScheduleLineTypeCreate : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="APISALESORDERSRVASalesOrderScheduleLineTypeCreate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected APISALESORDERSRVASalesOrderScheduleLineTypeCreate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="APISALESORDERSRVASalesOrderScheduleLineTypeCreate" /> class.
        /// </summary>
        /// <param name="scheduleLine">scheduleLine (required).</param>
        /// <param name="requestedDeliveryDate">Requested Delivery Date.</param>
        /// <param name="confirmedDeliveryDate">Confirmed Delivery Date.</param>
        /// <param name="orderQuantityUnit">orderQuantityUnit.</param>
        /// <param name="orderQuantitySAPUnit">SAP Unit Code for Order Quantity.</param>
        /// <param name="orderQuantityISOUnit">ISO Unit Code for Order Quantity.</param>
        /// <param name="scheduleLineOrderQuantity">Order Quantity in Sales Units.</param>
        /// <param name="confdOrderQtyByMatlAvailCheck">confdOrderQtyByMatlAvailCheck.</param>
        /// <param name="deliveredQtyInOrderQtyUnit">deliveredQtyInOrderQtyUnit.</param>
        /// <param name="openConfdDelivQtyInOrdQtyUnit">Open Confirmed Delivery Quantity.</param>
        /// <param name="correctedQtyInOrderQtyUnit">Corrected quantity in sales unit.</param>
        /// <param name="delivBlockReasonForSchedLine">Schedule Line Blocked for Delivery.</param>
        public APISALESORDERSRVASalesOrderScheduleLineTypeCreate(string scheduleLine = default(string), string requestedDeliveryDate = default(string), string confirmedDeliveryDate = default(string), string orderQuantityUnit = default(string), string orderQuantitySAPUnit = default(string), string orderQuantityISOUnit = default(string), decimal? scheduleLineOrderQuantity = default(decimal?), decimal? confdOrderQtyByMatlAvailCheck = default(decimal?), decimal? deliveredQtyInOrderQtyUnit = default(decimal?), decimal? openConfdDelivQtyInOrdQtyUnit = default(decimal?), decimal? correctedQtyInOrderQtyUnit = default(decimal?), string delivBlockReasonForSchedLine = default(string))
        {
            // to ensure "scheduleLine" is required (not null)
            if (scheduleLine == null)
            {
                throw new ArgumentNullException("scheduleLine is a required property for APISALESORDERSRVASalesOrderScheduleLineTypeCreate and cannot be null");
            }
            this.ScheduleLine = scheduleLine;
            this.RequestedDeliveryDate = requestedDeliveryDate;
            this.ConfirmedDeliveryDate = confirmedDeliveryDate;
            this.OrderQuantityUnit = orderQuantityUnit;
            this.OrderQuantitySAPUnit = orderQuantitySAPUnit;
            this.OrderQuantityISOUnit = orderQuantityISOUnit;
            this.ScheduleLineOrderQuantity = scheduleLineOrderQuantity;
            this.ConfdOrderQtyByMatlAvailCheck = confdOrderQtyByMatlAvailCheck;
            this.DeliveredQtyInOrderQtyUnit = deliveredQtyInOrderQtyUnit;
            this.OpenConfdDelivQtyInOrdQtyUnit = openConfdDelivQtyInOrdQtyUnit;
            this.CorrectedQtyInOrderQtyUnit = correctedQtyInOrderQtyUnit;
            this.DelivBlockReasonForSchedLine = delivBlockReasonForSchedLine;
        }

        /// <summary>
        /// Gets or Sets ScheduleLine
        /// </summary>
        [DataMember(Name = "ScheduleLine", IsRequired = true, EmitDefaultValue = true)]
        public string ScheduleLine { get; set; }

        /// <summary>
        /// Requested Delivery Date
        /// </summary>
        /// <value>Requested Delivery Date</value>
        /*
        <example>/Date(1492041600000)/</example>
        */
        [DataMember(Name = "RequestedDeliveryDate", EmitDefaultValue = true)]
        public string RequestedDeliveryDate { get; set; }

        /// <summary>
        /// Confirmed Delivery Date
        /// </summary>
        /// <value>Confirmed Delivery Date</value>
        /*
        <example>/Date(1492041600000)/</example>
        */
        [DataMember(Name = "ConfirmedDeliveryDate", EmitDefaultValue = true)]
        public string ConfirmedDeliveryDate { get; set; }

        /// <summary>
        /// Gets or Sets OrderQuantityUnit
        /// </summary>
        [DataMember(Name = "OrderQuantityUnit", EmitDefaultValue = true)]
        public string OrderQuantityUnit { get; set; }

        /// <summary>
        /// SAP Unit Code for Order Quantity
        /// </summary>
        /// <value>SAP Unit Code for Order Quantity</value>
        [DataMember(Name = "OrderQuantitySAPUnit", EmitDefaultValue = true)]
        public string OrderQuantitySAPUnit { get; set; }

        /// <summary>
        /// ISO Unit Code for Order Quantity
        /// </summary>
        /// <value>ISO Unit Code for Order Quantity</value>
        [DataMember(Name = "OrderQuantityISOUnit", EmitDefaultValue = true)]
        public string OrderQuantityISOUnit { get; set; }

        /// <summary>
        /// Order Quantity in Sales Units
        /// </summary>
        /// <value>Order Quantity in Sales Units</value>
        /*
        <example>0</example>
        */
        [DataMember(Name = "ScheduleLineOrderQuantity", EmitDefaultValue = true)]
        public decimal? ScheduleLineOrderQuantity { get; set; }

        /// <summary>
        /// Gets or Sets ConfdOrderQtyByMatlAvailCheck
        /// </summary>
        /*
        <example>0</example>
        */
        [DataMember(Name = "ConfdOrderQtyByMatlAvailCheck", EmitDefaultValue = true)]
        public decimal? ConfdOrderQtyByMatlAvailCheck { get; set; }

        /// <summary>
        /// Gets or Sets DeliveredQtyInOrderQtyUnit
        /// </summary>
        /*
        <example>0</example>
        */
        [DataMember(Name = "DeliveredQtyInOrderQtyUnit", EmitDefaultValue = true)]
        public decimal? DeliveredQtyInOrderQtyUnit { get; set; }

        /// <summary>
        /// Open Confirmed Delivery Quantity
        /// </summary>
        /// <value>Open Confirmed Delivery Quantity</value>
        /*
        <example>0</example>
        */
        [DataMember(Name = "OpenConfdDelivQtyInOrdQtyUnit", EmitDefaultValue = true)]
        public decimal? OpenConfdDelivQtyInOrdQtyUnit { get; set; }

        /// <summary>
        /// Corrected quantity in sales unit
        /// </summary>
        /// <value>Corrected quantity in sales unit</value>
        /*
        <example>0</example>
        */
        [DataMember(Name = "CorrectedQtyInOrderQtyUnit", EmitDefaultValue = true)]
        public decimal? CorrectedQtyInOrderQtyUnit { get; set; }

        /// <summary>
        /// Schedule Line Blocked for Delivery
        /// </summary>
        /// <value>Schedule Line Blocked for Delivery</value>
        [DataMember(Name = "DelivBlockReasonForSchedLine", EmitDefaultValue = true)]
        public string DelivBlockReasonForSchedLine { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class APISALESORDERSRVASalesOrderScheduleLineTypeCreate {\n");
            sb.Append("  ScheduleLine: ").Append(ScheduleLine).Append("\n");
            sb.Append("  RequestedDeliveryDate: ").Append(RequestedDeliveryDate).Append("\n");
            sb.Append("  ConfirmedDeliveryDate: ").Append(ConfirmedDeliveryDate).Append("\n");
            sb.Append("  OrderQuantityUnit: ").Append(OrderQuantityUnit).Append("\n");
            sb.Append("  OrderQuantitySAPUnit: ").Append(OrderQuantitySAPUnit).Append("\n");
            sb.Append("  OrderQuantityISOUnit: ").Append(OrderQuantityISOUnit).Append("\n");
            sb.Append("  ScheduleLineOrderQuantity: ").Append(ScheduleLineOrderQuantity).Append("\n");
            sb.Append("  ConfdOrderQtyByMatlAvailCheck: ").Append(ConfdOrderQtyByMatlAvailCheck).Append("\n");
            sb.Append("  DeliveredQtyInOrderQtyUnit: ").Append(DeliveredQtyInOrderQtyUnit).Append("\n");
            sb.Append("  OpenConfdDelivQtyInOrdQtyUnit: ").Append(OpenConfdDelivQtyInOrdQtyUnit).Append("\n");
            sb.Append("  CorrectedQtyInOrderQtyUnit: ").Append(CorrectedQtyInOrderQtyUnit).Append("\n");
            sb.Append("  DelivBlockReasonForSchedLine: ").Append(DelivBlockReasonForSchedLine).Append("\n");
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
            // ScheduleLine (string) maxLength
            if (this.ScheduleLine != null && this.ScheduleLine.Length > 4)
            {
                yield return new ValidationResult("Invalid value for ScheduleLine, length must be less than 4.", new [] { "ScheduleLine" });
            }

            // OrderQuantityUnit (string) maxLength
            if (this.OrderQuantityUnit != null && this.OrderQuantityUnit.Length > 3)
            {
                yield return new ValidationResult("Invalid value for OrderQuantityUnit, length must be less than 3.", new [] { "OrderQuantityUnit" });
            }

            // OrderQuantitySAPUnit (string) maxLength
            if (this.OrderQuantitySAPUnit != null && this.OrderQuantitySAPUnit.Length > 3)
            {
                yield return new ValidationResult("Invalid value for OrderQuantitySAPUnit, length must be less than 3.", new [] { "OrderQuantitySAPUnit" });
            }

            // OrderQuantityISOUnit (string) maxLength
            if (this.OrderQuantityISOUnit != null && this.OrderQuantityISOUnit.Length > 3)
            {
                yield return new ValidationResult("Invalid value for OrderQuantityISOUnit, length must be less than 3.", new [] { "OrderQuantityISOUnit" });
            }

            // DelivBlockReasonForSchedLine (string) maxLength
            if (this.DelivBlockReasonForSchedLine != null && this.DelivBlockReasonForSchedLine.Length > 2)
            {
                yield return new ValidationResult("Invalid value for DelivBlockReasonForSchedLine, length must be less than 2.", new [] { "DelivBlockReasonForSchedLine" });
            }

            yield break;
        }
    }

}
