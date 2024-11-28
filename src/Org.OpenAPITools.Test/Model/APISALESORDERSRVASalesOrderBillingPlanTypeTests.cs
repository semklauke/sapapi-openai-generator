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
    ///  Class for testing APISALESORDERSRVASalesOrderBillingPlanType
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class APISALESORDERSRVASalesOrderBillingPlanTypeTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for APISALESORDERSRVASalesOrderBillingPlanType
        //private APISALESORDERSRVASalesOrderBillingPlanType instance;

        public APISALESORDERSRVASalesOrderBillingPlanTypeTests()
        {
            // TODO uncomment below to create an instance of APISALESORDERSRVASalesOrderBillingPlanType
            //instance = new APISALESORDERSRVASalesOrderBillingPlanType();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of APISALESORDERSRVASalesOrderBillingPlanType
        /// </summary>
        [Fact]
        public void APISALESORDERSRVASalesOrderBillingPlanTypeInstanceTest()
        {
            // TODO uncomment below to test "IsType" APISALESORDERSRVASalesOrderBillingPlanType
            //Assert.IsType<APISALESORDERSRVASalesOrderBillingPlanType>(instance);
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
        /// Test the property 'BillingPlan'
        /// </summary>
        [Fact]
        public void BillingPlanTest()
        {
            // TODO unit test for the property 'BillingPlan'
        }

        /// <summary>
        /// Test the property 'BillingPlanStartDate'
        /// </summary>
        [Fact]
        public void BillingPlanStartDateTest()
        {
            // TODO unit test for the property 'BillingPlanStartDate'
        }

        /// <summary>
        /// Test the property 'BillingPlanStartDateRule'
        /// </summary>
        [Fact]
        public void BillingPlanStartDateRuleTest()
        {
            // TODO unit test for the property 'BillingPlanStartDateRule'
        }

        /// <summary>
        /// Test the property 'ReferenceBillingPlan'
        /// </summary>
        [Fact]
        public void ReferenceBillingPlanTest()
        {
            // TODO unit test for the property 'ReferenceBillingPlan'
        }

        /// <summary>
        /// Test the property 'BillingPlanCategory'
        /// </summary>
        [Fact]
        public void BillingPlanCategoryTest()
        {
            // TODO unit test for the property 'BillingPlanCategory'
        }

        /// <summary>
        /// Test the property 'BillingPlanType'
        /// </summary>
        [Fact]
        public void BillingPlanTypeTest()
        {
            // TODO unit test for the property 'BillingPlanType'
        }

        /// <summary>
        /// Test the property 'BillingPlanEndDate'
        /// </summary>
        [Fact]
        public void BillingPlanEndDateTest()
        {
            // TODO unit test for the property 'BillingPlanEndDate'
        }

        /// <summary>
        /// Test the property 'BillingPlanEndDateRule'
        /// </summary>
        [Fact]
        public void BillingPlanEndDateRuleTest()
        {
            // TODO unit test for the property 'BillingPlanEndDateRule'
        }

        /// <summary>
        /// Test the property 'BillingPlanSearchTerm'
        /// </summary>
        [Fact]
        public void BillingPlanSearchTermTest()
        {
            // TODO unit test for the property 'BillingPlanSearchTerm'
        }

        /// <summary>
        /// Test the property 'ToBillingPlanItem'
        /// </summary>
        [Fact]
        public void ToBillingPlanItemTest()
        {
            // TODO unit test for the property 'ToBillingPlanItem'
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
