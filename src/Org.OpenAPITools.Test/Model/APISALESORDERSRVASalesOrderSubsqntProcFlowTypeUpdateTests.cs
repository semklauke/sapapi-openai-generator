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
    ///  Class for testing APISALESORDERSRVASalesOrderSubsqntProcFlowTypeUpdate
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class APISALESORDERSRVASalesOrderSubsqntProcFlowTypeUpdateTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for APISALESORDERSRVASalesOrderSubsqntProcFlowTypeUpdate
        //private APISALESORDERSRVASalesOrderSubsqntProcFlowTypeUpdate instance;

        public APISALESORDERSRVASalesOrderSubsqntProcFlowTypeUpdateTests()
        {
            // TODO uncomment below to create an instance of APISALESORDERSRVASalesOrderSubsqntProcFlowTypeUpdate
            //instance = new APISALESORDERSRVASalesOrderSubsqntProcFlowTypeUpdate();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of APISALESORDERSRVASalesOrderSubsqntProcFlowTypeUpdate
        /// </summary>
        [Fact]
        public void APISALESORDERSRVASalesOrderSubsqntProcFlowTypeUpdateInstanceTest()
        {
            // TODO uncomment below to test "IsType" APISALESORDERSRVASalesOrderSubsqntProcFlowTypeUpdate
            //Assert.IsType<APISALESORDERSRVASalesOrderSubsqntProcFlowTypeUpdate>(instance);
        }

        /// <summary>
        /// Test the property 'SubsequentDocument'
        /// </summary>
        [Fact]
        public void SubsequentDocumentTest()
        {
            // TODO unit test for the property 'SubsequentDocument'
        }

        /// <summary>
        /// Test the property 'SubsequentDocumentCategory'
        /// </summary>
        [Fact]
        public void SubsequentDocumentCategoryTest()
        {
            // TODO unit test for the property 'SubsequentDocumentCategory'
        }

        /// <summary>
        /// Test the property 'ProcessFlowLevel'
        /// </summary>
        [Fact]
        public void ProcessFlowLevelTest()
        {
            // TODO unit test for the property 'ProcessFlowLevel'
        }

        /// <summary>
        /// Test the property 'OverallSDProcessStatus'
        /// </summary>
        [Fact]
        public void OverallSDProcessStatusTest()
        {
            // TODO unit test for the property 'OverallSDProcessStatus'
        }

        /// <summary>
        /// Test the property 'CreationDate'
        /// </summary>
        [Fact]
        public void CreationDateTest()
        {
            // TODO unit test for the property 'CreationDate'
        }

        /// <summary>
        /// Test the property 'CreationTime'
        /// </summary>
        [Fact]
        public void CreationTimeTest()
        {
            // TODO unit test for the property 'CreationTime'
        }

        /// <summary>
        /// Test the property 'LastChangeDate'
        /// </summary>
        [Fact]
        public void LastChangeDateTest()
        {
            // TODO unit test for the property 'LastChangeDate'
        }
    }
}
