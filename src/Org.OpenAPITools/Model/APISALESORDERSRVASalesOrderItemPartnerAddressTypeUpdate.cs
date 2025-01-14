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
    /// APISALESORDERSRVASalesOrderItemPartnerAddressTypeUpdate
    /// </summary>
    [DataContract(Name = "API_SALES_ORDER_SRV.A_SalesOrderItemPartnerAddressType-update")]
    public partial class APISALESORDERSRVASalesOrderItemPartnerAddressTypeUpdate : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="APISALESORDERSRVASalesOrderItemPartnerAddressTypeUpdate" /> class.
        /// </summary>
        /// <param name="correspondenceLanguage">correspondenceLanguage.</param>
        /// <param name="addresseeFullName">Full Name of Person.</param>
        /// <param name="organizationName1">Name 1.</param>
        /// <param name="organizationName2">organizationName2.</param>
        /// <param name="organizationName3">organizationName3.</param>
        /// <param name="organizationName4">organizationName4.</param>
        /// <param name="cityName">cityName.</param>
        /// <param name="districtName">districtName.</param>
        /// <param name="postalCode">City Postal Code.</param>
        /// <param name="streetName">streetName.</param>
        /// <param name="streetPrefixName1">Street 2.</param>
        /// <param name="streetPrefixName2">streetPrefixName2.</param>
        /// <param name="streetSuffixName1">streetSuffixName1.</param>
        /// <param name="streetSuffixName2">streetSuffixName2.</param>
        /// <param name="houseNumber">houseNumber.</param>
        /// <param name="country">country.</param>
        /// <param name="region">Region (State, Province, County).</param>
        /// <param name="formOfAddress">Form-of-Address Key.</param>
        /// <param name="taxJurisdiction">taxJurisdiction.</param>
        /// <param name="transportZone">Transportation zone to or from which the goods are delivered.</param>
        /// <param name="pOBox">pOBox.</param>
        /// <param name="pOBoxPostalCode">pOBoxPostalCode.</param>
        /// <param name="emailAddress">emailAddress.</param>
        /// <param name="mobilePhoneCountry">Country/Region for Telephone/Fax Number.</param>
        /// <param name="mobileNumber">Telephone No.: Dialing Code and Number.</param>
        /// <param name="phoneNumberCountry">Country/Region for Telephone/Fax Number.</param>
        /// <param name="phoneNumber">Telephone No.: Dialing Code and Number.</param>
        /// <param name="phoneExtensionNumber">Telephone no.: Extension.</param>
        /// <param name="faxNumberCountry">Country/Region for Telephone/Fax Number.</param>
        /// <param name="faxAreaCodeSubscriberNumber">Fax Number: Dialing Code and Number.</param>
        /// <param name="faxExtensionNumber">Fax no.: Extension.</param>
        public APISALESORDERSRVASalesOrderItemPartnerAddressTypeUpdate(string correspondenceLanguage = default(string), string addresseeFullName = default(string), string organizationName1 = default(string), string organizationName2 = default(string), string organizationName3 = default(string), string organizationName4 = default(string), string cityName = default(string), string districtName = default(string), string postalCode = default(string), string streetName = default(string), string streetPrefixName1 = default(string), string streetPrefixName2 = default(string), string streetSuffixName1 = default(string), string streetSuffixName2 = default(string), string houseNumber = default(string), string country = default(string), string region = default(string), string formOfAddress = default(string), string taxJurisdiction = default(string), string transportZone = default(string), string pOBox = default(string), string pOBoxPostalCode = default(string), string emailAddress = default(string), string mobilePhoneCountry = default(string), string mobileNumber = default(string), string phoneNumberCountry = default(string), string phoneNumber = default(string), string phoneExtensionNumber = default(string), string faxNumberCountry = default(string), string faxAreaCodeSubscriberNumber = default(string), string faxExtensionNumber = default(string))
        {
            this.CorrespondenceLanguage = correspondenceLanguage;
            this.AddresseeFullName = addresseeFullName;
            this.OrganizationName1 = organizationName1;
            this.OrganizationName2 = organizationName2;
            this.OrganizationName3 = organizationName3;
            this.OrganizationName4 = organizationName4;
            this.CityName = cityName;
            this.DistrictName = districtName;
            this.PostalCode = postalCode;
            this.StreetName = streetName;
            this.StreetPrefixName1 = streetPrefixName1;
            this.StreetPrefixName2 = streetPrefixName2;
            this.StreetSuffixName1 = streetSuffixName1;
            this.StreetSuffixName2 = streetSuffixName2;
            this.HouseNumber = houseNumber;
            this.Country = country;
            this.Region = region;
            this.FormOfAddress = formOfAddress;
            this.TaxJurisdiction = taxJurisdiction;
            this.TransportZone = transportZone;
            this.POBox = pOBox;
            this.POBoxPostalCode = pOBoxPostalCode;
            this.EmailAddress = emailAddress;
            this.MobilePhoneCountry = mobilePhoneCountry;
            this.MobileNumber = mobileNumber;
            this.PhoneNumberCountry = phoneNumberCountry;
            this.PhoneNumber = phoneNumber;
            this.PhoneExtensionNumber = phoneExtensionNumber;
            this.FaxNumberCountry = faxNumberCountry;
            this.FaxAreaCodeSubscriberNumber = faxAreaCodeSubscriberNumber;
            this.FaxExtensionNumber = faxExtensionNumber;
        }

        /// <summary>
        /// Gets or Sets CorrespondenceLanguage
        /// </summary>
        [DataMember(Name = "CorrespondenceLanguage", EmitDefaultValue = true)]
        public string CorrespondenceLanguage { get; set; }

        /// <summary>
        /// Full Name of Person
        /// </summary>
        /// <value>Full Name of Person</value>
        [DataMember(Name = "AddresseeFullName", EmitDefaultValue = true)]
        public string AddresseeFullName { get; set; }

        /// <summary>
        /// Name 1
        /// </summary>
        /// <value>Name 1</value>
        [DataMember(Name = "OrganizationName1", EmitDefaultValue = true)]
        public string OrganizationName1 { get; set; }

        /// <summary>
        /// Gets or Sets OrganizationName2
        /// </summary>
        [DataMember(Name = "OrganizationName2", EmitDefaultValue = true)]
        public string OrganizationName2 { get; set; }

        /// <summary>
        /// Gets or Sets OrganizationName3
        /// </summary>
        [DataMember(Name = "OrganizationName3", EmitDefaultValue = true)]
        public string OrganizationName3 { get; set; }

        /// <summary>
        /// Gets or Sets OrganizationName4
        /// </summary>
        [DataMember(Name = "OrganizationName4", EmitDefaultValue = true)]
        public string OrganizationName4 { get; set; }

        /// <summary>
        /// Gets or Sets CityName
        /// </summary>
        [DataMember(Name = "CityName", EmitDefaultValue = true)]
        public string CityName { get; set; }

        /// <summary>
        /// Gets or Sets DistrictName
        /// </summary>
        [DataMember(Name = "DistrictName", EmitDefaultValue = true)]
        public string DistrictName { get; set; }

        /// <summary>
        /// City Postal Code
        /// </summary>
        /// <value>City Postal Code</value>
        [DataMember(Name = "PostalCode", EmitDefaultValue = true)]
        public string PostalCode { get; set; }

        /// <summary>
        /// Gets or Sets StreetName
        /// </summary>
        [DataMember(Name = "StreetName", EmitDefaultValue = true)]
        public string StreetName { get; set; }

        /// <summary>
        /// Street 2
        /// </summary>
        /// <value>Street 2</value>
        [DataMember(Name = "StreetPrefixName1", EmitDefaultValue = true)]
        public string StreetPrefixName1 { get; set; }

        /// <summary>
        /// Gets or Sets StreetPrefixName2
        /// </summary>
        [DataMember(Name = "StreetPrefixName2", EmitDefaultValue = true)]
        public string StreetPrefixName2 { get; set; }

        /// <summary>
        /// Gets or Sets StreetSuffixName1
        /// </summary>
        [DataMember(Name = "StreetSuffixName1", EmitDefaultValue = true)]
        public string StreetSuffixName1 { get; set; }

        /// <summary>
        /// Gets or Sets StreetSuffixName2
        /// </summary>
        [DataMember(Name = "StreetSuffixName2", EmitDefaultValue = true)]
        public string StreetSuffixName2 { get; set; }

        /// <summary>
        /// Gets or Sets HouseNumber
        /// </summary>
        [DataMember(Name = "HouseNumber", EmitDefaultValue = true)]
        public string HouseNumber { get; set; }

        /// <summary>
        /// Gets or Sets Country
        /// </summary>
        [DataMember(Name = "Country", EmitDefaultValue = true)]
        public string Country { get; set; }

        /// <summary>
        /// Region (State, Province, County)
        /// </summary>
        /// <value>Region (State, Province, County)</value>
        [DataMember(Name = "Region", EmitDefaultValue = true)]
        public string Region { get; set; }

        /// <summary>
        /// Form-of-Address Key
        /// </summary>
        /// <value>Form-of-Address Key</value>
        [DataMember(Name = "FormOfAddress", EmitDefaultValue = true)]
        public string FormOfAddress { get; set; }

        /// <summary>
        /// Gets or Sets TaxJurisdiction
        /// </summary>
        [DataMember(Name = "TaxJurisdiction", EmitDefaultValue = true)]
        public string TaxJurisdiction { get; set; }

        /// <summary>
        /// Transportation zone to or from which the goods are delivered
        /// </summary>
        /// <value>Transportation zone to or from which the goods are delivered</value>
        [DataMember(Name = "TransportZone", EmitDefaultValue = true)]
        public string TransportZone { get; set; }

        /// <summary>
        /// Gets or Sets POBox
        /// </summary>
        [DataMember(Name = "POBox", EmitDefaultValue = true)]
        public string POBox { get; set; }

        /// <summary>
        /// Gets or Sets POBoxPostalCode
        /// </summary>
        [DataMember(Name = "POBoxPostalCode", EmitDefaultValue = true)]
        public string POBoxPostalCode { get; set; }

        /// <summary>
        /// Gets or Sets EmailAddress
        /// </summary>
        [DataMember(Name = "EmailAddress", EmitDefaultValue = true)]
        public string EmailAddress { get; set; }

        /// <summary>
        /// Country/Region for Telephone/Fax Number
        /// </summary>
        /// <value>Country/Region for Telephone/Fax Number</value>
        [DataMember(Name = "MobilePhoneCountry", EmitDefaultValue = true)]
        public string MobilePhoneCountry { get; set; }

        /// <summary>
        /// Telephone No.: Dialing Code and Number
        /// </summary>
        /// <value>Telephone No.: Dialing Code and Number</value>
        [DataMember(Name = "MobileNumber", EmitDefaultValue = true)]
        public string MobileNumber { get; set; }

        /// <summary>
        /// Country/Region for Telephone/Fax Number
        /// </summary>
        /// <value>Country/Region for Telephone/Fax Number</value>
        [DataMember(Name = "PhoneNumberCountry", EmitDefaultValue = true)]
        public string PhoneNumberCountry { get; set; }

        /// <summary>
        /// Telephone No.: Dialing Code and Number
        /// </summary>
        /// <value>Telephone No.: Dialing Code and Number</value>
        [DataMember(Name = "PhoneNumber", EmitDefaultValue = true)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Telephone no.: Extension
        /// </summary>
        /// <value>Telephone no.: Extension</value>
        [DataMember(Name = "PhoneExtensionNumber", EmitDefaultValue = true)]
        public string PhoneExtensionNumber { get; set; }

        /// <summary>
        /// Country/Region for Telephone/Fax Number
        /// </summary>
        /// <value>Country/Region for Telephone/Fax Number</value>
        [DataMember(Name = "FaxNumberCountry", EmitDefaultValue = true)]
        public string FaxNumberCountry { get; set; }

        /// <summary>
        /// Fax Number: Dialing Code and Number
        /// </summary>
        /// <value>Fax Number: Dialing Code and Number</value>
        [DataMember(Name = "FaxAreaCodeSubscriberNumber", EmitDefaultValue = true)]
        public string FaxAreaCodeSubscriberNumber { get; set; }

        /// <summary>
        /// Fax no.: Extension
        /// </summary>
        /// <value>Fax no.: Extension</value>
        [DataMember(Name = "FaxExtensionNumber", EmitDefaultValue = true)]
        public string FaxExtensionNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class APISALESORDERSRVASalesOrderItemPartnerAddressTypeUpdate {\n");
            sb.Append("  CorrespondenceLanguage: ").Append(CorrespondenceLanguage).Append("\n");
            sb.Append("  AddresseeFullName: ").Append(AddresseeFullName).Append("\n");
            sb.Append("  OrganizationName1: ").Append(OrganizationName1).Append("\n");
            sb.Append("  OrganizationName2: ").Append(OrganizationName2).Append("\n");
            sb.Append("  OrganizationName3: ").Append(OrganizationName3).Append("\n");
            sb.Append("  OrganizationName4: ").Append(OrganizationName4).Append("\n");
            sb.Append("  CityName: ").Append(CityName).Append("\n");
            sb.Append("  DistrictName: ").Append(DistrictName).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  StreetName: ").Append(StreetName).Append("\n");
            sb.Append("  StreetPrefixName1: ").Append(StreetPrefixName1).Append("\n");
            sb.Append("  StreetPrefixName2: ").Append(StreetPrefixName2).Append("\n");
            sb.Append("  StreetSuffixName1: ").Append(StreetSuffixName1).Append("\n");
            sb.Append("  StreetSuffixName2: ").Append(StreetSuffixName2).Append("\n");
            sb.Append("  HouseNumber: ").Append(HouseNumber).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  Region: ").Append(Region).Append("\n");
            sb.Append("  FormOfAddress: ").Append(FormOfAddress).Append("\n");
            sb.Append("  TaxJurisdiction: ").Append(TaxJurisdiction).Append("\n");
            sb.Append("  TransportZone: ").Append(TransportZone).Append("\n");
            sb.Append("  POBox: ").Append(POBox).Append("\n");
            sb.Append("  POBoxPostalCode: ").Append(POBoxPostalCode).Append("\n");
            sb.Append("  EmailAddress: ").Append(EmailAddress).Append("\n");
            sb.Append("  MobilePhoneCountry: ").Append(MobilePhoneCountry).Append("\n");
            sb.Append("  MobileNumber: ").Append(MobileNumber).Append("\n");
            sb.Append("  PhoneNumberCountry: ").Append(PhoneNumberCountry).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  PhoneExtensionNumber: ").Append(PhoneExtensionNumber).Append("\n");
            sb.Append("  FaxNumberCountry: ").Append(FaxNumberCountry).Append("\n");
            sb.Append("  FaxAreaCodeSubscriberNumber: ").Append(FaxAreaCodeSubscriberNumber).Append("\n");
            sb.Append("  FaxExtensionNumber: ").Append(FaxExtensionNumber).Append("\n");
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
            // CorrespondenceLanguage (string) maxLength
            if (this.CorrespondenceLanguage != null && this.CorrespondenceLanguage.Length > 2)
            {
                yield return new ValidationResult("Invalid value for CorrespondenceLanguage, length must be less than 2.", new [] { "CorrespondenceLanguage" });
            }

            // AddresseeFullName (string) maxLength
            if (this.AddresseeFullName != null && this.AddresseeFullName.Length > 80)
            {
                yield return new ValidationResult("Invalid value for AddresseeFullName, length must be less than 80.", new [] { "AddresseeFullName" });
            }

            // OrganizationName1 (string) maxLength
            if (this.OrganizationName1 != null && this.OrganizationName1.Length > 40)
            {
                yield return new ValidationResult("Invalid value for OrganizationName1, length must be less than 40.", new [] { "OrganizationName1" });
            }

            // OrganizationName2 (string) maxLength
            if (this.OrganizationName2 != null && this.OrganizationName2.Length > 40)
            {
                yield return new ValidationResult("Invalid value for OrganizationName2, length must be less than 40.", new [] { "OrganizationName2" });
            }

            // OrganizationName3 (string) maxLength
            if (this.OrganizationName3 != null && this.OrganizationName3.Length > 40)
            {
                yield return new ValidationResult("Invalid value for OrganizationName3, length must be less than 40.", new [] { "OrganizationName3" });
            }

            // OrganizationName4 (string) maxLength
            if (this.OrganizationName4 != null && this.OrganizationName4.Length > 40)
            {
                yield return new ValidationResult("Invalid value for OrganizationName4, length must be less than 40.", new [] { "OrganizationName4" });
            }

            // CityName (string) maxLength
            if (this.CityName != null && this.CityName.Length > 40)
            {
                yield return new ValidationResult("Invalid value for CityName, length must be less than 40.", new [] { "CityName" });
            }

            // DistrictName (string) maxLength
            if (this.DistrictName != null && this.DistrictName.Length > 40)
            {
                yield return new ValidationResult("Invalid value for DistrictName, length must be less than 40.", new [] { "DistrictName" });
            }

            // PostalCode (string) maxLength
            if (this.PostalCode != null && this.PostalCode.Length > 10)
            {
                yield return new ValidationResult("Invalid value for PostalCode, length must be less than 10.", new [] { "PostalCode" });
            }

            // StreetName (string) maxLength
            if (this.StreetName != null && this.StreetName.Length > 60)
            {
                yield return new ValidationResult("Invalid value for StreetName, length must be less than 60.", new [] { "StreetName" });
            }

            // StreetPrefixName1 (string) maxLength
            if (this.StreetPrefixName1 != null && this.StreetPrefixName1.Length > 40)
            {
                yield return new ValidationResult("Invalid value for StreetPrefixName1, length must be less than 40.", new [] { "StreetPrefixName1" });
            }

            // StreetPrefixName2 (string) maxLength
            if (this.StreetPrefixName2 != null && this.StreetPrefixName2.Length > 40)
            {
                yield return new ValidationResult("Invalid value for StreetPrefixName2, length must be less than 40.", new [] { "StreetPrefixName2" });
            }

            // StreetSuffixName1 (string) maxLength
            if (this.StreetSuffixName1 != null && this.StreetSuffixName1.Length > 40)
            {
                yield return new ValidationResult("Invalid value for StreetSuffixName1, length must be less than 40.", new [] { "StreetSuffixName1" });
            }

            // StreetSuffixName2 (string) maxLength
            if (this.StreetSuffixName2 != null && this.StreetSuffixName2.Length > 40)
            {
                yield return new ValidationResult("Invalid value for StreetSuffixName2, length must be less than 40.", new [] { "StreetSuffixName2" });
            }

            // HouseNumber (string) maxLength
            if (this.HouseNumber != null && this.HouseNumber.Length > 10)
            {
                yield return new ValidationResult("Invalid value for HouseNumber, length must be less than 10.", new [] { "HouseNumber" });
            }

            // Country (string) maxLength
            if (this.Country != null && this.Country.Length > 3)
            {
                yield return new ValidationResult("Invalid value for Country, length must be less than 3.", new [] { "Country" });
            }

            // Region (string) maxLength
            if (this.Region != null && this.Region.Length > 3)
            {
                yield return new ValidationResult("Invalid value for Region, length must be less than 3.", new [] { "Region" });
            }

            // FormOfAddress (string) maxLength
            if (this.FormOfAddress != null && this.FormOfAddress.Length > 4)
            {
                yield return new ValidationResult("Invalid value for FormOfAddress, length must be less than 4.", new [] { "FormOfAddress" });
            }

            // TaxJurisdiction (string) maxLength
            if (this.TaxJurisdiction != null && this.TaxJurisdiction.Length > 15)
            {
                yield return new ValidationResult("Invalid value for TaxJurisdiction, length must be less than 15.", new [] { "TaxJurisdiction" });
            }

            // TransportZone (string) maxLength
            if (this.TransportZone != null && this.TransportZone.Length > 10)
            {
                yield return new ValidationResult("Invalid value for TransportZone, length must be less than 10.", new [] { "TransportZone" });
            }

            // POBox (string) maxLength
            if (this.POBox != null && this.POBox.Length > 10)
            {
                yield return new ValidationResult("Invalid value for POBox, length must be less than 10.", new [] { "POBox" });
            }

            // POBoxPostalCode (string) maxLength
            if (this.POBoxPostalCode != null && this.POBoxPostalCode.Length > 10)
            {
                yield return new ValidationResult("Invalid value for POBoxPostalCode, length must be less than 10.", new [] { "POBoxPostalCode" });
            }

            // EmailAddress (string) maxLength
            if (this.EmailAddress != null && this.EmailAddress.Length > 241)
            {
                yield return new ValidationResult("Invalid value for EmailAddress, length must be less than 241.", new [] { "EmailAddress" });
            }

            // MobilePhoneCountry (string) maxLength
            if (this.MobilePhoneCountry != null && this.MobilePhoneCountry.Length > 3)
            {
                yield return new ValidationResult("Invalid value for MobilePhoneCountry, length must be less than 3.", new [] { "MobilePhoneCountry" });
            }

            // MobileNumber (string) maxLength
            if (this.MobileNumber != null && this.MobileNumber.Length > 30)
            {
                yield return new ValidationResult("Invalid value for MobileNumber, length must be less than 30.", new [] { "MobileNumber" });
            }

            // PhoneNumberCountry (string) maxLength
            if (this.PhoneNumberCountry != null && this.PhoneNumberCountry.Length > 3)
            {
                yield return new ValidationResult("Invalid value for PhoneNumberCountry, length must be less than 3.", new [] { "PhoneNumberCountry" });
            }

            // PhoneNumber (string) maxLength
            if (this.PhoneNumber != null && this.PhoneNumber.Length > 30)
            {
                yield return new ValidationResult("Invalid value for PhoneNumber, length must be less than 30.", new [] { "PhoneNumber" });
            }

            // PhoneExtensionNumber (string) maxLength
            if (this.PhoneExtensionNumber != null && this.PhoneExtensionNumber.Length > 10)
            {
                yield return new ValidationResult("Invalid value for PhoneExtensionNumber, length must be less than 10.", new [] { "PhoneExtensionNumber" });
            }

            // FaxNumberCountry (string) maxLength
            if (this.FaxNumberCountry != null && this.FaxNumberCountry.Length > 3)
            {
                yield return new ValidationResult("Invalid value for FaxNumberCountry, length must be less than 3.", new [] { "FaxNumberCountry" });
            }

            // FaxAreaCodeSubscriberNumber (string) maxLength
            if (this.FaxAreaCodeSubscriberNumber != null && this.FaxAreaCodeSubscriberNumber.Length > 30)
            {
                yield return new ValidationResult("Invalid value for FaxAreaCodeSubscriberNumber, length must be less than 30.", new [] { "FaxAreaCodeSubscriberNumber" });
            }

            // FaxExtensionNumber (string) maxLength
            if (this.FaxExtensionNumber != null && this.FaxExtensionNumber.Length > 10)
            {
                yield return new ValidationResult("Invalid value for FaxExtensionNumber, length must be less than 10.", new [] { "FaxExtensionNumber" });
            }

            yield break;
        }
    }

}
