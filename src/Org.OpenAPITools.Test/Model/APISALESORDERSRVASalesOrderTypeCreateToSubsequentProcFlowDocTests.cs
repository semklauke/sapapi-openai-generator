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
    ///  Class for testing APISALESORDERSRVASalesOrderTypeCreateToSubsequentProcFlowDoc
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class APISALESORDERSRVASalesOrderTypeCreateToSubsequentProcFlowDocTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for APISALESORDERSRVASalesOrderTypeCreateToSubsequentProcFlowDoc
        //private APISALESORDERSRVASalesOrderTypeCreateToSubsequentProcFlowDoc instance;

        public APISALESORDERSRVASalesOrderTypeCreateToSubsequentProcFlowDocTests()
        {
            // TODO uncomment below to create an instance of APISALESORDERSRVASalesOrderTypeCreateToSubsequentProcFlowDoc
            //instance = new APISALESORDERSRVASalesOrderTypeCreateToSubsequentProcFlowDoc();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of APISALESORDERSRVASalesOrderTypeCreateToSubsequentProcFlowDoc
        /// </summary>
        [Fact]
        public void APISALESORDERSRVASalesOrderTypeCreateToSubsequentProcFlowDocInstanceTest()
        {
            // TODO uncomment below to test "IsType" APISALESORDERSRVASalesOrderTypeCreateToSubsequentProcFlowDoc
            //Assert.IsType<APISALESORDERSRVASalesOrderTypeCreateToSubsequentProcFlowDoc>(instance);
        }

        /// <summary>
        /// Test the property 'Results'
        /// </summary>
        [Fact]
        public void ResultsTest()
        {
            // TODO unit test for the property 'Results'
        }
    }
}
