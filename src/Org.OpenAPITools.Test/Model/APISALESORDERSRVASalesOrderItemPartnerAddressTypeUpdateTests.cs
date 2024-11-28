/*
 * Sales Order (A2X)
 *
 * In every API call, you can make use of the following operations:   - You can read entire sales orders or only parts of the data, using the provided filters.   - You can create sales orders. You can use deep insert requests, that is, you create a header plus at least one of the following entities: header partner, header partner address, header pricing element, header billing plan, header billing plan item, header text, payment plan, header related object, item, item partner, item partner address, item pricing element, item billing plan, item billing plan item, item text, and item related object.   If the header already exists, you can create the following sub-entities on their own: header partner, header pricing element, header text, payment plan, header related object, item partner, item pricing element, item text, and item related object.   - For existing sales orders, you can create new items. You can use deep insert requests, that is, you create an item plus at least one of the following entities: item partner, item partner address, item pricing element, item billing plan, item billing plan item, item text, and item related object. If the item already exists, you can create the following sub-entities on their own: item partner, item pricing element, item text, item related object, and item schedule line.   - For existing sales orders, you can update the following entities (that is, you can change the content of their properties): header, header partner, header partner address, header pricing element, header billing plan, header billing plan item, header text, payment plan, item, item partner, item partner address, item pricing element, item billing plan, item billing plan item, item text, and item schedule line.   - For existing sales orders, you can delete the following entities: header, header partner, header pricing element, header billing plan item, header text, payment plan, header related object, item, item partner, item pricing element, item billing plan item, item text, item related object, and item schedule line.   - You can accept or deny approval requests for sales orders that cannot be processed without the consent of an approver.
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Org.OpenAPITools.Model;
using Org.OpenAPITools.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Test.Model
{
    /// <summary>
    ///  Class for testing APISALESORDERSRVASalesOrderItemPartnerAddressTypeUpdate
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class APISALESORDERSRVASalesOrderItemPartnerAddressTypeUpdateTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for APISALESORDERSRVASalesOrderItemPartnerAddressTypeUpdate
        //private APISALESORDERSRVASalesOrderItemPartnerAddressTypeUpdate instance;

        public APISALESORDERSRVASalesOrderItemPartnerAddressTypeUpdateTests()
        {
            // TODO uncomment below to create an instance of APISALESORDERSRVASalesOrderItemPartnerAddressTypeUpdate
            //instance = new APISALESORDERSRVASalesOrderItemPartnerAddressTypeUpdate();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of APISALESORDERSRVASalesOrderItemPartnerAddressTypeUpdate
        /// </summary>
        [Fact]
        public void APISALESORDERSRVASalesOrderItemPartnerAddressTypeUpdateInstanceTest()
        {
            // TODO uncomment below to test "IsType" APISALESORDERSRVASalesOrderItemPartnerAddressTypeUpdate
            //Assert.IsType<APISALESORDERSRVASalesOrderItemPartnerAddressTypeUpdate>(instance);
        }

        /// <summary>
        /// Test the property 'CorrespondenceLanguage'
        /// </summary>
        [Fact]
        public void CorrespondenceLanguageTest()
        {
            // TODO unit test for the property 'CorrespondenceLanguage'
        }

        /// <summary>
        /// Test the property 'AddresseeFullName'
        /// </summary>
        [Fact]
        public void AddresseeFullNameTest()
        {
            // TODO unit test for the property 'AddresseeFullName'
        }

        /// <summary>
        /// Test the property 'OrganizationName1'
        /// </summary>
        [Fact]
        public void OrganizationName1Test()
        {
            // TODO unit test for the property 'OrganizationName1'
        }

        /// <summary>
        /// Test the property 'OrganizationName2'
        /// </summary>
        [Fact]
        public void OrganizationName2Test()
        {
            // TODO unit test for the property 'OrganizationName2'
        }

        /// <summary>
        /// Test the property 'OrganizationName3'
        /// </summary>
        [Fact]
        public void OrganizationName3Test()
        {
            // TODO unit test for the property 'OrganizationName3'
        }

        /// <summary>
        /// Test the property 'OrganizationName4'
        /// </summary>
        [Fact]
        public void OrganizationName4Test()
        {
            // TODO unit test for the property 'OrganizationName4'
        }

        /// <summary>
        /// Test the property 'CityName'
        /// </summary>
        [Fact]
        public void CityNameTest()
        {
            // TODO unit test for the property 'CityName'
        }

        /// <summary>
        /// Test the property 'DistrictName'
        /// </summary>
        [Fact]
        public void DistrictNameTest()
        {
            // TODO unit test for the property 'DistrictName'
        }

        /// <summary>
        /// Test the property 'PostalCode'
        /// </summary>
        [Fact]
        public void PostalCodeTest()
        {
            // TODO unit test for the property 'PostalCode'
        }

        /// <summary>
        /// Test the property 'StreetName'
        /// </summary>
        [Fact]
        public void StreetNameTest()
        {
            // TODO unit test for the property 'StreetName'
        }

        /// <summary>
        /// Test the property 'StreetPrefixName1'
        /// </summary>
        [Fact]
        public void StreetPrefixName1Test()
        {
            // TODO unit test for the property 'StreetPrefixName1'
        }

        /// <summary>
        /// Test the property 'StreetPrefixName2'
        /// </summary>
        [Fact]
        public void StreetPrefixName2Test()
        {
            // TODO unit test for the property 'StreetPrefixName2'
        }

        /// <summary>
        /// Test the property 'StreetSuffixName1'
        /// </summary>
        [Fact]
        public void StreetSuffixName1Test()
        {
            // TODO unit test for the property 'StreetSuffixName1'
        }

        /// <summary>
        /// Test the property 'StreetSuffixName2'
        /// </summary>
        [Fact]
        public void StreetSuffixName2Test()
        {
            // TODO unit test for the property 'StreetSuffixName2'
        }

        /// <summary>
        /// Test the property 'HouseNumber'
        /// </summary>
        [Fact]
        public void HouseNumberTest()
        {
            // TODO unit test for the property 'HouseNumber'
        }

        /// <summary>
        /// Test the property 'Country'
        /// </summary>
        [Fact]
        public void CountryTest()
        {
            // TODO unit test for the property 'Country'
        }

        /// <summary>
        /// Test the property 'Region'
        /// </summary>
        [Fact]
        public void RegionTest()
        {
            // TODO unit test for the property 'Region'
        }

        /// <summary>
        /// Test the property 'FormOfAddress'
        /// </summary>
        [Fact]
        public void FormOfAddressTest()
        {
            // TODO unit test for the property 'FormOfAddress'
        }

        /// <summary>
        /// Test the property 'TaxJurisdiction'
        /// </summary>
        [Fact]
        public void TaxJurisdictionTest()
        {
            // TODO unit test for the property 'TaxJurisdiction'
        }

        /// <summary>
        /// Test the property 'TransportZone'
        /// </summary>
        [Fact]
        public void TransportZoneTest()
        {
            // TODO unit test for the property 'TransportZone'
        }

        /// <summary>
        /// Test the property 'POBox'
        /// </summary>
        [Fact]
        public void POBoxTest()
        {
            // TODO unit test for the property 'POBox'
        }

        /// <summary>
        /// Test the property 'POBoxPostalCode'
        /// </summary>
        [Fact]
        public void POBoxPostalCodeTest()
        {
            // TODO unit test for the property 'POBoxPostalCode'
        }

        /// <summary>
        /// Test the property 'EmailAddress'
        /// </summary>
        [Fact]
        public void EmailAddressTest()
        {
            // TODO unit test for the property 'EmailAddress'
        }

        /// <summary>
        /// Test the property 'MobilePhoneCountry'
        /// </summary>
        [Fact]
        public void MobilePhoneCountryTest()
        {
            // TODO unit test for the property 'MobilePhoneCountry'
        }

        /// <summary>
        /// Test the property 'MobileNumber'
        /// </summary>
        [Fact]
        public void MobileNumberTest()
        {
            // TODO unit test for the property 'MobileNumber'
        }

        /// <summary>
        /// Test the property 'PhoneNumberCountry'
        /// </summary>
        [Fact]
        public void PhoneNumberCountryTest()
        {
            // TODO unit test for the property 'PhoneNumberCountry'
        }

        /// <summary>
        /// Test the property 'PhoneNumber'
        /// </summary>
        [Fact]
        public void PhoneNumberTest()
        {
            // TODO unit test for the property 'PhoneNumber'
        }

        /// <summary>
        /// Test the property 'PhoneExtensionNumber'
        /// </summary>
        [Fact]
        public void PhoneExtensionNumberTest()
        {
            // TODO unit test for the property 'PhoneExtensionNumber'
        }

        /// <summary>
        /// Test the property 'FaxNumberCountry'
        /// </summary>
        [Fact]
        public void FaxNumberCountryTest()
        {
            // TODO unit test for the property 'FaxNumberCountry'
        }

        /// <summary>
        /// Test the property 'FaxAreaCodeSubscriberNumber'
        /// </summary>
        [Fact]
        public void FaxAreaCodeSubscriberNumberTest()
        {
            // TODO unit test for the property 'FaxAreaCodeSubscriberNumber'
        }

        /// <summary>
        /// Test the property 'FaxExtensionNumber'
        /// </summary>
        [Fact]
        public void FaxExtensionNumberTest()
        {
            // TODO unit test for the property 'FaxExtensionNumber'
        }
    }
}
