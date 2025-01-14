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
    ///  Class for testing APISALESORDERSRVASalesOrderItemRelatedObjectTypeCreate
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class APISALESORDERSRVASalesOrderItemRelatedObjectTypeCreateTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for APISALESORDERSRVASalesOrderItemRelatedObjectTypeCreate
        //private APISALESORDERSRVASalesOrderItemRelatedObjectTypeCreate instance;

        public APISALESORDERSRVASalesOrderItemRelatedObjectTypeCreateTests()
        {
            // TODO uncomment below to create an instance of APISALESORDERSRVASalesOrderItemRelatedObjectTypeCreate
            //instance = new APISALESORDERSRVASalesOrderItemRelatedObjectTypeCreate();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of APISALESORDERSRVASalesOrderItemRelatedObjectTypeCreate
        /// </summary>
        [Fact]
        public void APISALESORDERSRVASalesOrderItemRelatedObjectTypeCreateInstanceTest()
        {
            // TODO uncomment below to test "IsType" APISALESORDERSRVASalesOrderItemRelatedObjectTypeCreate
            //Assert.IsType<APISALESORDERSRVASalesOrderItemRelatedObjectTypeCreate>(instance);
        }

        /// <summary>
        /// Test the property 'SDDocumentRelatedObjectType'
        /// </summary>
        [Fact]
        public void SDDocumentRelatedObjectTypeTest()
        {
            // TODO unit test for the property 'SDDocumentRelatedObjectType'
        }

        /// <summary>
        /// Test the property 'SDDocRelatedObjectSystem'
        /// </summary>
        [Fact]
        public void SDDocRelatedObjectSystemTest()
        {
            // TODO unit test for the property 'SDDocRelatedObjectSystem'
        }

        /// <summary>
        /// Test the property 'SDDocRelatedObjectReference1'
        /// </summary>
        [Fact]
        public void SDDocRelatedObjectReference1Test()
        {
            // TODO unit test for the property 'SDDocRelatedObjectReference1'
        }

        /// <summary>
        /// Test the property 'SDDocRelatedObjectReference2'
        /// </summary>
        [Fact]
        public void SDDocRelatedObjectReference2Test()
        {
            // TODO unit test for the property 'SDDocRelatedObjectReference2'
        }

        /// <summary>
        /// Test the property 'ToSalesOrder'
        /// </summary>
        [Fact]
        public void ToSalesOrderTest()
        {
            // TODO unit test for the property 'ToSalesOrder'
        }

        /// <summary>
        /// Test the property 'ToSalesOrderItem'
        /// </summary>
        [Fact]
        public void ToSalesOrderItemTest()
        {
            // TODO unit test for the property 'ToSalesOrderItem'
        }
    }
}
