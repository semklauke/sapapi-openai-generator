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
    ///  Class for testing APISALESORDERSRVASalesOrderHeaderPartnerType
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class APISALESORDERSRVASalesOrderHeaderPartnerTypeTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for APISALESORDERSRVASalesOrderHeaderPartnerType
        //private APISALESORDERSRVASalesOrderHeaderPartnerType instance;

        public APISALESORDERSRVASalesOrderHeaderPartnerTypeTests()
        {
            // TODO uncomment below to create an instance of APISALESORDERSRVASalesOrderHeaderPartnerType
            //instance = new APISALESORDERSRVASalesOrderHeaderPartnerType();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of APISALESORDERSRVASalesOrderHeaderPartnerType
        /// </summary>
        [Fact]
        public void APISALESORDERSRVASalesOrderHeaderPartnerTypeInstanceTest()
        {
            // TODO uncomment below to test "IsType" APISALESORDERSRVASalesOrderHeaderPartnerType
            //Assert.IsType<APISALESORDERSRVASalesOrderHeaderPartnerType>(instance);
        }

        /// <summary>
        /// Test the property 'SalesOrder'
        /// </summary>
        [Fact]
        public void SalesOrderTest()
        {
            // TODO unit test for the property 'SalesOrder'
        }

        /// <summary>
        /// Test the property 'PartnerFunction'
        /// </summary>
        [Fact]
        public void PartnerFunctionTest()
        {
            // TODO unit test for the property 'PartnerFunction'
        }

        /// <summary>
        /// Test the property 'PartnerFunctionInternalCode'
        /// </summary>
        [Fact]
        public void PartnerFunctionInternalCodeTest()
        {
            // TODO unit test for the property 'PartnerFunctionInternalCode'
        }

        /// <summary>
        /// Test the property 'Customer'
        /// </summary>
        [Fact]
        public void CustomerTest()
        {
            // TODO unit test for the property 'Customer'
        }

        /// <summary>
        /// Test the property 'Supplier'
        /// </summary>
        [Fact]
        public void SupplierTest()
        {
            // TODO unit test for the property 'Supplier'
        }

        /// <summary>
        /// Test the property 'Personnel'
        /// </summary>
        [Fact]
        public void PersonnelTest()
        {
            // TODO unit test for the property 'Personnel'
        }

        /// <summary>
        /// Test the property 'ContactPerson'
        /// </summary>
        [Fact]
        public void ContactPersonTest()
        {
            // TODO unit test for the property 'ContactPerson'
        }

        /// <summary>
        /// Test the property 'ReferenceBusinessPartner'
        /// </summary>
        [Fact]
        public void ReferenceBusinessPartnerTest()
        {
            // TODO unit test for the property 'ReferenceBusinessPartner'
        }

        /// <summary>
        /// Test the property 'AddressID'
        /// </summary>
        [Fact]
        public void AddressIDTest()
        {
            // TODO unit test for the property 'AddressID'
        }

        /// <summary>
        /// Test the property 'VATRegistration'
        /// </summary>
        [Fact]
        public void VATRegistrationTest()
        {
            // TODO unit test for the property 'VATRegistration'
        }

        /// <summary>
        /// Test the property 'ToAddress'
        /// </summary>
        [Fact]
        public void ToAddressTest()
        {
            // TODO unit test for the property 'ToAddress'
        }

        /// <summary>
        /// Test the property 'ToSalesOrder'
        /// </summary>
        [Fact]
        public void ToSalesOrderTest()
        {
            // TODO unit test for the property 'ToSalesOrder'
        }
    }
}
