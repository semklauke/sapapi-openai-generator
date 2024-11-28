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
    ///  Class for testing APISALESORDERSRVASalesOrderPrecdgProcFlowType
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class APISALESORDERSRVASalesOrderPrecdgProcFlowTypeTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for APISALESORDERSRVASalesOrderPrecdgProcFlowType
        //private APISALESORDERSRVASalesOrderPrecdgProcFlowType instance;

        public APISALESORDERSRVASalesOrderPrecdgProcFlowTypeTests()
        {
            // TODO uncomment below to create an instance of APISALESORDERSRVASalesOrderPrecdgProcFlowType
            //instance = new APISALESORDERSRVASalesOrderPrecdgProcFlowType();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of APISALESORDERSRVASalesOrderPrecdgProcFlowType
        /// </summary>
        [Fact]
        public void APISALESORDERSRVASalesOrderPrecdgProcFlowTypeInstanceTest()
        {
            // TODO uncomment below to test "IsType" APISALESORDERSRVASalesOrderPrecdgProcFlowType
            //Assert.IsType<APISALESORDERSRVASalesOrderPrecdgProcFlowType>(instance);
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
        /// Test the property 'DocRelationshipUUID'
        /// </summary>
        [Fact]
        public void DocRelationshipUUIDTest()
        {
            // TODO unit test for the property 'DocRelationshipUUID'
        }

        /// <summary>
        /// Test the property 'PrecedingDocument'
        /// </summary>
        [Fact]
        public void PrecedingDocumentTest()
        {
            // TODO unit test for the property 'PrecedingDocument'
        }

        /// <summary>
        /// Test the property 'PrecedingDocumentCategory'
        /// </summary>
        [Fact]
        public void PrecedingDocumentCategoryTest()
        {
            // TODO unit test for the property 'PrecedingDocumentCategory'
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