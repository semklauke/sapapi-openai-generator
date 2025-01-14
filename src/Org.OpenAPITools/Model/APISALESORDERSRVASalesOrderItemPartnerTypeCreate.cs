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
    /// APISALESORDERSRVASalesOrderItemPartnerTypeCreate
    /// </summary>
    [DataContract(Name = "API_SALES_ORDER_SRV.A_SalesOrderItemPartnerType-create")]
    public partial class APISALESORDERSRVASalesOrderItemPartnerTypeCreate : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="APISALESORDERSRVASalesOrderItemPartnerTypeCreate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected APISALESORDERSRVASalesOrderItemPartnerTypeCreate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="APISALESORDERSRVASalesOrderItemPartnerTypeCreate" /> class.
        /// </summary>
        /// <param name="partnerFunction">partnerFunction (required).</param>
        /// <param name="customer">Customer Number.</param>
        /// <param name="supplier">Account Number of Supplier.</param>
        /// <param name="personnel">personnel.</param>
        /// <param name="contactPerson">Number of Contact Person.</param>
        /// <param name="addressID">addressID.</param>
        /// <param name="vATRegistration">VAT Registration Number.</param>
        /// <param name="toAddress">toAddress.</param>
        /// <param name="toSalesOrder">toSalesOrder.</param>
        /// <param name="toSalesOrderItem">toSalesOrderItem.</param>
        public APISALESORDERSRVASalesOrderItemPartnerTypeCreate(string partnerFunction = default(string), string customer = default(string), string supplier = default(string), string personnel = default(string), string contactPerson = default(string), string addressID = default(string), string vATRegistration = default(string), APISALESORDERSRVASalesOrderItemPartnerTypeCreateToAddress toAddress = default(APISALESORDERSRVASalesOrderItemPartnerTypeCreateToAddress), APISALESORDERSRVASalesOrderTypeCreate toSalesOrder = default(APISALESORDERSRVASalesOrderTypeCreate), APISALESORDERSRVASalesOrderItemTypeCreate toSalesOrderItem = default(APISALESORDERSRVASalesOrderItemTypeCreate))
        {
            // to ensure "partnerFunction" is required (not null)
            if (partnerFunction == null)
            {
                throw new ArgumentNullException("partnerFunction is a required property for APISALESORDERSRVASalesOrderItemPartnerTypeCreate and cannot be null");
            }
            this.PartnerFunction = partnerFunction;
            this.Customer = customer;
            this.Supplier = supplier;
            this.Personnel = personnel;
            this.ContactPerson = contactPerson;
            this.AddressID = addressID;
            this.VATRegistration = vATRegistration;
            this.ToAddress = toAddress;
            this.ToSalesOrder = toSalesOrder;
            this.ToSalesOrderItem = toSalesOrderItem;
        }

        /// <summary>
        /// Gets or Sets PartnerFunction
        /// </summary>
        [DataMember(Name = "PartnerFunction", IsRequired = true, EmitDefaultValue = true)]
        public string PartnerFunction { get; set; }

        /// <summary>
        /// Customer Number
        /// </summary>
        /// <value>Customer Number</value>
        [DataMember(Name = "Customer", EmitDefaultValue = true)]
        public string Customer { get; set; }

        /// <summary>
        /// Account Number of Supplier
        /// </summary>
        /// <value>Account Number of Supplier</value>
        [DataMember(Name = "Supplier", EmitDefaultValue = true)]
        public string Supplier { get; set; }

        /// <summary>
        /// Gets or Sets Personnel
        /// </summary>
        [DataMember(Name = "Personnel", EmitDefaultValue = true)]
        public string Personnel { get; set; }

        /// <summary>
        /// Number of Contact Person
        /// </summary>
        /// <value>Number of Contact Person</value>
        [DataMember(Name = "ContactPerson", EmitDefaultValue = true)]
        public string ContactPerson { get; set; }

        /// <summary>
        /// Gets or Sets AddressID
        /// </summary>
        [DataMember(Name = "AddressID", EmitDefaultValue = true)]
        public string AddressID { get; set; }

        /// <summary>
        /// VAT Registration Number
        /// </summary>
        /// <value>VAT Registration Number</value>
        [DataMember(Name = "VATRegistration", EmitDefaultValue = true)]
        public string VATRegistration { get; set; }

        /// <summary>
        /// Gets or Sets ToAddress
        /// </summary>
        [DataMember(Name = "to_Address", EmitDefaultValue = false)]
        public APISALESORDERSRVASalesOrderItemPartnerTypeCreateToAddress ToAddress { get; set; }

        /// <summary>
        /// Gets or Sets ToSalesOrder
        /// </summary>
        [DataMember(Name = "to_SalesOrder", EmitDefaultValue = false)]
        public APISALESORDERSRVASalesOrderTypeCreate ToSalesOrder { get; set; }

        /// <summary>
        /// Gets or Sets ToSalesOrderItem
        /// </summary>
        [DataMember(Name = "to_SalesOrderItem", EmitDefaultValue = false)]
        public APISALESORDERSRVASalesOrderItemTypeCreate ToSalesOrderItem { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class APISALESORDERSRVASalesOrderItemPartnerTypeCreate {\n");
            sb.Append("  PartnerFunction: ").Append(PartnerFunction).Append("\n");
            sb.Append("  Customer: ").Append(Customer).Append("\n");
            sb.Append("  Supplier: ").Append(Supplier).Append("\n");
            sb.Append("  Personnel: ").Append(Personnel).Append("\n");
            sb.Append("  ContactPerson: ").Append(ContactPerson).Append("\n");
            sb.Append("  AddressID: ").Append(AddressID).Append("\n");
            sb.Append("  VATRegistration: ").Append(VATRegistration).Append("\n");
            sb.Append("  ToAddress: ").Append(ToAddress).Append("\n");
            sb.Append("  ToSalesOrder: ").Append(ToSalesOrder).Append("\n");
            sb.Append("  ToSalesOrderItem: ").Append(ToSalesOrderItem).Append("\n");
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
            // PartnerFunction (string) maxLength
            if (this.PartnerFunction != null && this.PartnerFunction.Length > 2)
            {
                yield return new ValidationResult("Invalid value for PartnerFunction, length must be less than 2.", new [] { "PartnerFunction" });
            }

            // Customer (string) maxLength
            if (this.Customer != null && this.Customer.Length > 10)
            {
                yield return new ValidationResult("Invalid value for Customer, length must be less than 10.", new [] { "Customer" });
            }

            // Supplier (string) maxLength
            if (this.Supplier != null && this.Supplier.Length > 10)
            {
                yield return new ValidationResult("Invalid value for Supplier, length must be less than 10.", new [] { "Supplier" });
            }

            // Personnel (string) maxLength
            if (this.Personnel != null && this.Personnel.Length > 8)
            {
                yield return new ValidationResult("Invalid value for Personnel, length must be less than 8.", new [] { "Personnel" });
            }

            // ContactPerson (string) maxLength
            if (this.ContactPerson != null && this.ContactPerson.Length > 10)
            {
                yield return new ValidationResult("Invalid value for ContactPerson, length must be less than 10.", new [] { "ContactPerson" });
            }

            // AddressID (string) maxLength
            if (this.AddressID != null && this.AddressID.Length > 10)
            {
                yield return new ValidationResult("Invalid value for AddressID, length must be less than 10.", new [] { "AddressID" });
            }

            // VATRegistration (string) maxLength
            if (this.VATRegistration != null && this.VATRegistration.Length > 20)
            {
                yield return new ValidationResult("Invalid value for VATRegistration, length must be less than 20.", new [] { "VATRegistration" });
            }

            yield break;
        }
    }

}
