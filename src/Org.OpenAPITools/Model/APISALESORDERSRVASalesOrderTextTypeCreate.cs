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
    /// APISALESORDERSRVASalesOrderTextTypeCreate
    /// </summary>
    [DataContract(Name = "API_SALES_ORDER_SRV.A_SalesOrderTextType-create")]
    public partial class APISALESORDERSRVASalesOrderTextTypeCreate : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="APISALESORDERSRVASalesOrderTextTypeCreate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected APISALESORDERSRVASalesOrderTextTypeCreate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="APISALESORDERSRVASalesOrderTextTypeCreate" /> class.
        /// </summary>
        /// <param name="language">language (required).</param>
        /// <param name="longTextID">longTextID (required).</param>
        /// <param name="longText">longText.</param>
        /// <param name="toSalesOrder">toSalesOrder.</param>
        public APISALESORDERSRVASalesOrderTextTypeCreate(string language = default(string), string longTextID = default(string), string longText = default(string), APISALESORDERSRVASalesOrderTypeCreate toSalesOrder = default(APISALESORDERSRVASalesOrderTypeCreate))
        {
            // to ensure "language" is required (not null)
            if (language == null)
            {
                throw new ArgumentNullException("language is a required property for APISALESORDERSRVASalesOrderTextTypeCreate and cannot be null");
            }
            this.Language = language;
            // to ensure "longTextID" is required (not null)
            if (longTextID == null)
            {
                throw new ArgumentNullException("longTextID is a required property for APISALESORDERSRVASalesOrderTextTypeCreate and cannot be null");
            }
            this.LongTextID = longTextID;
            this.LongText = longText;
            this.ToSalesOrder = toSalesOrder;
        }

        /// <summary>
        /// Gets or Sets Language
        /// </summary>
        [DataMember(Name = "Language", IsRequired = true, EmitDefaultValue = true)]
        public string Language { get; set; }

        /// <summary>
        /// Gets or Sets LongTextID
        /// </summary>
        [DataMember(Name = "LongTextID", IsRequired = true, EmitDefaultValue = true)]
        public string LongTextID { get; set; }

        /// <summary>
        /// Gets or Sets LongText
        /// </summary>
        [DataMember(Name = "LongText", EmitDefaultValue = true)]
        public string LongText { get; set; }

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
            sb.Append("class APISALESORDERSRVASalesOrderTextTypeCreate {\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  LongTextID: ").Append(LongTextID).Append("\n");
            sb.Append("  LongText: ").Append(LongText).Append("\n");
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
            // Language (string) maxLength
            if (this.Language != null && this.Language.Length > 2)
            {
                yield return new ValidationResult("Invalid value for Language, length must be less than 2.", new [] { "Language" });
            }

            // LongTextID (string) maxLength
            if (this.LongTextID != null && this.LongTextID.Length > 4)
            {
                yield return new ValidationResult("Invalid value for LongTextID, length must be less than 4.", new [] { "LongTextID" });
            }

            yield break;
        }
    }

}
