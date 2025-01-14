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
    /// APISALESORDERSRVASalesOrderSubsqntProcFlowTypeUpdate
    /// </summary>
    [DataContract(Name = "API_SALES_ORDER_SRV.A_SalesOrderSubsqntProcFlowType-update")]
    public partial class APISALESORDERSRVASalesOrderSubsqntProcFlowTypeUpdate : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="APISALESORDERSRVASalesOrderSubsqntProcFlowTypeUpdate" /> class.
        /// </summary>
        /// <param name="subsequentDocument">Subsequent Sales and Distribution Document.</param>
        /// <param name="subsequentDocumentCategory">Document Category of Subsequent Document.</param>
        /// <param name="processFlowLevel">Level of the document flow record.</param>
        /// <param name="overallSDProcessStatus">Overall Processing Status (Header/All Items).</param>
        /// <param name="creationDate">Record Creation Date.</param>
        /// <param name="creationTime">Entry time.</param>
        /// <param name="lastChangeDate">Last Changed On.</param>
        public APISALESORDERSRVASalesOrderSubsqntProcFlowTypeUpdate(string subsequentDocument = default(string), string subsequentDocumentCategory = default(string), string processFlowLevel = default(string), string overallSDProcessStatus = default(string), string creationDate = default(string), string creationTime = default(string), string lastChangeDate = default(string))
        {
            this.SubsequentDocument = subsequentDocument;
            this.SubsequentDocumentCategory = subsequentDocumentCategory;
            this.ProcessFlowLevel = processFlowLevel;
            this.OverallSDProcessStatus = overallSDProcessStatus;
            this.CreationDate = creationDate;
            this.CreationTime = creationTime;
            this.LastChangeDate = lastChangeDate;
        }

        /// <summary>
        /// Subsequent Sales and Distribution Document
        /// </summary>
        /// <value>Subsequent Sales and Distribution Document</value>
        [DataMember(Name = "SubsequentDocument", EmitDefaultValue = true)]
        public string SubsequentDocument { get; set; }

        /// <summary>
        /// Document Category of Subsequent Document
        /// </summary>
        /// <value>Document Category of Subsequent Document</value>
        [DataMember(Name = "SubsequentDocumentCategory", EmitDefaultValue = true)]
        public string SubsequentDocumentCategory { get; set; }

        /// <summary>
        /// Level of the document flow record
        /// </summary>
        /// <value>Level of the document flow record</value>
        [DataMember(Name = "ProcessFlowLevel", EmitDefaultValue = true)]
        public string ProcessFlowLevel { get; set; }

        /// <summary>
        /// Overall Processing Status (Header/All Items)
        /// </summary>
        /// <value>Overall Processing Status (Header/All Items)</value>
        [DataMember(Name = "OverallSDProcessStatus", EmitDefaultValue = true)]
        public string OverallSDProcessStatus { get; set; }

        /// <summary>
        /// Record Creation Date
        /// </summary>
        /// <value>Record Creation Date</value>
        /*
        <example>/Date(1492041600000)/</example>
        */
        [DataMember(Name = "CreationDate", EmitDefaultValue = true)]
        public string CreationDate { get; set; }

        /// <summary>
        /// Entry time
        /// </summary>
        /// <value>Entry time</value>
        /*
        <example>PT15H51M04S</example>
        */
        [DataMember(Name = "CreationTime", EmitDefaultValue = true)]
        public string CreationTime { get; set; }

        /// <summary>
        /// Last Changed On
        /// </summary>
        /// <value>Last Changed On</value>
        /*
        <example>/Date(1492041600000)/</example>
        */
        [DataMember(Name = "LastChangeDate", EmitDefaultValue = true)]
        public string LastChangeDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class APISALESORDERSRVASalesOrderSubsqntProcFlowTypeUpdate {\n");
            sb.Append("  SubsequentDocument: ").Append(SubsequentDocument).Append("\n");
            sb.Append("  SubsequentDocumentCategory: ").Append(SubsequentDocumentCategory).Append("\n");
            sb.Append("  ProcessFlowLevel: ").Append(ProcessFlowLevel).Append("\n");
            sb.Append("  OverallSDProcessStatus: ").Append(OverallSDProcessStatus).Append("\n");
            sb.Append("  CreationDate: ").Append(CreationDate).Append("\n");
            sb.Append("  CreationTime: ").Append(CreationTime).Append("\n");
            sb.Append("  LastChangeDate: ").Append(LastChangeDate).Append("\n");
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
            // SubsequentDocument (string) maxLength
            if (this.SubsequentDocument != null && this.SubsequentDocument.Length > 10)
            {
                yield return new ValidationResult("Invalid value for SubsequentDocument, length must be less than 10.", new [] { "SubsequentDocument" });
            }

            // SubsequentDocumentCategory (string) maxLength
            if (this.SubsequentDocumentCategory != null && this.SubsequentDocumentCategory.Length > 4)
            {
                yield return new ValidationResult("Invalid value for SubsequentDocumentCategory, length must be less than 4.", new [] { "SubsequentDocumentCategory" });
            }

            // ProcessFlowLevel (string) maxLength
            if (this.ProcessFlowLevel != null && this.ProcessFlowLevel.Length > 2)
            {
                yield return new ValidationResult("Invalid value for ProcessFlowLevel, length must be less than 2.", new [] { "ProcessFlowLevel" });
            }

            // OverallSDProcessStatus (string) maxLength
            if (this.OverallSDProcessStatus != null && this.OverallSDProcessStatus.Length > 1)
            {
                yield return new ValidationResult("Invalid value for OverallSDProcessStatus, length must be less than 1.", new [] { "OverallSDProcessStatus" });
            }

            yield break;
        }
    }

}
