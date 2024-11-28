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
    /// APISALESORDERSRVASalesOrderRelatedObjectType
    /// </summary>
    [DataContract(Name = "API_SALES_ORDER_SRV.A_SalesOrderRelatedObjectType")]
    public partial class APISALESORDERSRVASalesOrderRelatedObjectType : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="APISALESORDERSRVASalesOrderRelatedObjectType" /> class.
        /// </summary>
        /// <param name="salesOrder">salesOrder.</param>
        /// <param name="sDDocRelatedObjectSequenceNmbr">Sequence Number of the Related Object of an SD Document.</param>
        /// <param name="sDDocumentRelatedObjectType">Type of the Related Object of an SD Document.</param>
        /// <param name="sDDocRelatedObjectSystem">System of the Related Object of an SD Document.</param>
        /// <param name="sDDocRelatedObjectReference1">Reference of the Related Object of an SD Document.</param>
        /// <param name="sDDocRelatedObjectReference2">Reference of the Related Object of an SD Document.</param>
        /// <param name="toSalesOrder">toSalesOrder.</param>
        public APISALESORDERSRVASalesOrderRelatedObjectType(string salesOrder = default(string), string sDDocRelatedObjectSequenceNmbr = default(string), string sDDocumentRelatedObjectType = default(string), string sDDocRelatedObjectSystem = default(string), string sDDocRelatedObjectReference1 = default(string), string sDDocRelatedObjectReference2 = default(string), APISALESORDERSRVASalesOrderType toSalesOrder = default(APISALESORDERSRVASalesOrderType))
        {
            this.SalesOrder = salesOrder;
            this.SDDocRelatedObjectSequenceNmbr = sDDocRelatedObjectSequenceNmbr;
            this.SDDocumentRelatedObjectType = sDDocumentRelatedObjectType;
            this.SDDocRelatedObjectSystem = sDDocRelatedObjectSystem;
            this.SDDocRelatedObjectReference1 = sDDocRelatedObjectReference1;
            this.SDDocRelatedObjectReference2 = sDDocRelatedObjectReference2;
            this.ToSalesOrder = toSalesOrder;
        }

        /// <summary>
        /// Gets or Sets SalesOrder
        /// </summary>
        [DataMember(Name = "SalesOrder", EmitDefaultValue = false)]
        public string SalesOrder { get; set; }

        /// <summary>
        /// Sequence Number of the Related Object of an SD Document
        /// </summary>
        /// <value>Sequence Number of the Related Object of an SD Document</value>
        [DataMember(Name = "SDDocRelatedObjectSequenceNmbr", EmitDefaultValue = false)]
        public string SDDocRelatedObjectSequenceNmbr { get; set; }

        /// <summary>
        /// Type of the Related Object of an SD Document
        /// </summary>
        /// <value>Type of the Related Object of an SD Document</value>
        [DataMember(Name = "SDDocumentRelatedObjectType", EmitDefaultValue = true)]
        public string SDDocumentRelatedObjectType { get; set; }

        /// <summary>
        /// System of the Related Object of an SD Document
        /// </summary>
        /// <value>System of the Related Object of an SD Document</value>
        [DataMember(Name = "SDDocRelatedObjectSystem", EmitDefaultValue = true)]
        public string SDDocRelatedObjectSystem { get; set; }

        /// <summary>
        /// Reference of the Related Object of an SD Document
        /// </summary>
        /// <value>Reference of the Related Object of an SD Document</value>
        [DataMember(Name = "SDDocRelatedObjectReference1", EmitDefaultValue = true)]
        public string SDDocRelatedObjectReference1 { get; set; }

        /// <summary>
        /// Reference of the Related Object of an SD Document
        /// </summary>
        /// <value>Reference of the Related Object of an SD Document</value>
        [DataMember(Name = "SDDocRelatedObjectReference2", EmitDefaultValue = true)]
        public string SDDocRelatedObjectReference2 { get; set; }

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
            sb.Append("class APISALESORDERSRVASalesOrderRelatedObjectType {\n");
            sb.Append("  SalesOrder: ").Append(SalesOrder).Append("\n");
            sb.Append("  SDDocRelatedObjectSequenceNmbr: ").Append(SDDocRelatedObjectSequenceNmbr).Append("\n");
            sb.Append("  SDDocumentRelatedObjectType: ").Append(SDDocumentRelatedObjectType).Append("\n");
            sb.Append("  SDDocRelatedObjectSystem: ").Append(SDDocRelatedObjectSystem).Append("\n");
            sb.Append("  SDDocRelatedObjectReference1: ").Append(SDDocRelatedObjectReference1).Append("\n");
            sb.Append("  SDDocRelatedObjectReference2: ").Append(SDDocRelatedObjectReference2).Append("\n");
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

            // SDDocRelatedObjectSequenceNmbr (string) maxLength
            if (this.SDDocRelatedObjectSequenceNmbr != null && this.SDDocRelatedObjectSequenceNmbr.Length > 4)
            {
                yield return new ValidationResult("Invalid value for SDDocRelatedObjectSequenceNmbr, length must be less than 4.", new [] { "SDDocRelatedObjectSequenceNmbr" });
            }

            // SDDocumentRelatedObjectType (string) maxLength
            if (this.SDDocumentRelatedObjectType != null && this.SDDocumentRelatedObjectType.Length > 5)
            {
                yield return new ValidationResult("Invalid value for SDDocumentRelatedObjectType, length must be less than 5.", new [] { "SDDocumentRelatedObjectType" });
            }

            // SDDocRelatedObjectSystem (string) maxLength
            if (this.SDDocRelatedObjectSystem != null && this.SDDocRelatedObjectSystem.Length > 60)
            {
                yield return new ValidationResult("Invalid value for SDDocRelatedObjectSystem, length must be less than 60.", new [] { "SDDocRelatedObjectSystem" });
            }

            // SDDocRelatedObjectReference1 (string) maxLength
            if (this.SDDocRelatedObjectReference1 != null && this.SDDocRelatedObjectReference1.Length > 60)
            {
                yield return new ValidationResult("Invalid value for SDDocRelatedObjectReference1, length must be less than 60.", new [] { "SDDocRelatedObjectReference1" });
            }

            // SDDocRelatedObjectReference2 (string) maxLength
            if (this.SDDocRelatedObjectReference2 != null && this.SDDocRelatedObjectReference2.Length > 60)
            {
                yield return new ValidationResult("Invalid value for SDDocRelatedObjectReference2, length must be less than 60.", new [] { "SDDocRelatedObjectReference2" });
            }

            yield break;
        }
    }

}
