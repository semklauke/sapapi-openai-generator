/*
 * Sales Order (A2X)
 *
 * In every API call, you can make use of the following operations:   - You can read entire sales orders or only parts of the data, using the provided filters.   - You can create sales orders. You can use deep insert requests, that is, you create a header plus at least one of the following entities: header partner, header partner address, header pricing element, header billing plan, header billing plan item, header text, payment plan, header related object, item, item partner, item partner address, item pricing element, item billing plan, item billing plan item, item text, and item related object.   If the header already exists, you can create the following sub-entities on their own: header partner, header pricing element, header text, payment plan, header related object, item partner, item pricing element, item text, and item related object.   - For existing sales orders, you can create new items. You can use deep insert requests, that is, you create an item plus at least one of the following entities: item partner, item partner address, item pricing element, item billing plan, item billing plan item, item text, and item related object. If the item already exists, you can create the following sub-entities on their own: item partner, item pricing element, item text, item related object, and item schedule line.   - For existing sales orders, you can update the following entities (that is, you can change the content of their properties): header, header partner, header partner address, header pricing element, header billing plan, header billing plan item, header text, payment plan, item, item partner, item partner address, item pricing element, item billing plan, item billing plan item, item text, and item schedule line.   - For existing sales orders, you can delete the following entities: header, header partner, header pricing element, header billing plan item, header text, payment plan, header related object, item, item partner, item pricing element, item billing plan item, item text, item related object, and item schedule line.   - You can accept or deny approval requests for sales orders that cannot be processed without the consent of an approver.
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using Org.OpenAPITools.Client;
using Org.OpenAPITools.Api;
// uncomment below to import models
//using Org.OpenAPITools.Model;

namespace Org.OpenAPITools.Test.Api
{
    /// <summary>
    ///  Class for testing HeaderBillingPlanItemApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class HeaderBillingPlanItemApiTests : IDisposable
    {
        private HeaderBillingPlanItemApi instance;

        public HeaderBillingPlanItemApiTests()
        {
            instance = new HeaderBillingPlanItemApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of HeaderBillingPlanItemApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' HeaderBillingPlanItemApi
            //Assert.IsType<HeaderBillingPlanItemApi>(instance);
        }

        /// <summary>
        /// Test ASalesOrderBillingPlanItemGet
        /// </summary>
        [Fact]
        public void ASalesOrderBillingPlanItemGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? top = null;
            //int? skip = null;
            //string? filter = null;
            //string? inlinecount = null;
            //List<string>? orderby = null;
            //List<string>? select = null;
            //List<string>? expand = null;
            //var response = instance.ASalesOrderBillingPlanItemGet(top, skip, filter, inlinecount, orderby, select, expand);
            //Assert.IsType<Wrapper10>(response);
        }

        /// <summary>
        /// Test ASalesOrderBillingPlanItemPost
        /// </summary>
        [Fact]
        public void ASalesOrderBillingPlanItemPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //APISALESORDERSRVASalesOrderBillingPlanItemTypeCreate aPISALESORDERSRVASalesOrderBillingPlanItemTypeCreate = null;
            //var response = instance.ASalesOrderBillingPlanItemPost(aPISALESORDERSRVASalesOrderBillingPlanItemTypeCreate);
            //Assert.IsType<ASalesOrderBillingPlanItemType>(response);
        }

        /// <summary>
        /// Test ASalesOrderBillingPlanItemSalesOrderSalesOrderBillingPlanBillingPlanBillingPlanItemBillingPlanItemDelete
        /// </summary>
        [Fact]
        public void ASalesOrderBillingPlanItemSalesOrderSalesOrderBillingPlanBillingPlanBillingPlanItemBillingPlanItemDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string salesOrder = null;
            //string billingPlan = null;
            //string billingPlanItem = null;
            //instance.ASalesOrderBillingPlanItemSalesOrderSalesOrderBillingPlanBillingPlanBillingPlanItemBillingPlanItemDelete(salesOrder, billingPlan, billingPlanItem);
        }

        /// <summary>
        /// Test ASalesOrderBillingPlanItemSalesOrderSalesOrderBillingPlanBillingPlanBillingPlanItemBillingPlanItemGet
        /// </summary>
        [Fact]
        public void ASalesOrderBillingPlanItemSalesOrderSalesOrderBillingPlanBillingPlanBillingPlanItemBillingPlanItemGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string salesOrder = null;
            //string billingPlan = null;
            //string billingPlanItem = null;
            //List<string>? select = null;
            //List<string>? expand = null;
            //var response = instance.ASalesOrderBillingPlanItemSalesOrderSalesOrderBillingPlanBillingPlanBillingPlanItemBillingPlanItemGet(salesOrder, billingPlan, billingPlanItem, select, expand);
            //Assert.IsType<ASalesOrderBillingPlanItemType>(response);
        }

        /// <summary>
        /// Test ASalesOrderBillingPlanItemSalesOrderSalesOrderBillingPlanBillingPlanBillingPlanItemBillingPlanItemPatch
        /// </summary>
        [Fact]
        public void ASalesOrderBillingPlanItemSalesOrderSalesOrderBillingPlanBillingPlanBillingPlanItemBillingPlanItemPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string salesOrder = null;
            //string billingPlan = null;
            //string billingPlanItem = null;
            //ModifiedASalesOrderBillingPlanItemType modifiedASalesOrderBillingPlanItemType = null;
            //instance.ASalesOrderBillingPlanItemSalesOrderSalesOrderBillingPlanBillingPlanBillingPlanItemBillingPlanItemPatch(salesOrder, billingPlan, billingPlanItem, modifiedASalesOrderBillingPlanItemType);
        }

        /// <summary>
        /// Test ASalesOrderBillingPlanItemSalesOrderSalesOrderBillingPlanBillingPlanBillingPlanItemBillingPlanItemToBillingPlanGet
        /// </summary>
        [Fact]
        public void ASalesOrderBillingPlanItemSalesOrderSalesOrderBillingPlanBillingPlanBillingPlanItemBillingPlanItemToBillingPlanGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string salesOrder = null;
            //string billingPlan = null;
            //string billingPlanItem = null;
            //List<string>? select = null;
            //List<string>? expand = null;
            //var response = instance.ASalesOrderBillingPlanItemSalesOrderSalesOrderBillingPlanBillingPlanBillingPlanItemBillingPlanItemToBillingPlanGet(salesOrder, billingPlan, billingPlanItem, select, expand);
            //Assert.IsType<ASalesOrderBillingPlanType>(response);
        }

        /// <summary>
        /// Test ASalesOrderBillingPlanItemSalesOrderSalesOrderBillingPlanBillingPlanBillingPlanItemBillingPlanItemToSalesOrderGet
        /// </summary>
        [Fact]
        public void ASalesOrderBillingPlanItemSalesOrderSalesOrderBillingPlanBillingPlanBillingPlanItemBillingPlanItemToSalesOrderGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string salesOrder = null;
            //string billingPlan = null;
            //string billingPlanItem = null;
            //List<string>? select = null;
            //List<string>? expand = null;
            //var response = instance.ASalesOrderBillingPlanItemSalesOrderSalesOrderBillingPlanBillingPlanBillingPlanItemBillingPlanItemToSalesOrderGet(salesOrder, billingPlan, billingPlanItem, select, expand);
            //Assert.IsType<ASalesOrderType>(response);
        }

        /// <summary>
        /// Test ASalesOrderBillingPlanSalesOrderSalesOrderBillingPlanBillingPlanToBillingPlanItemGet
        /// </summary>
        [Fact]
        public void ASalesOrderBillingPlanSalesOrderSalesOrderBillingPlanBillingPlanToBillingPlanItemGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string salesOrder = null;
            //string billingPlan = null;
            //int? top = null;
            //int? skip = null;
            //string? filter = null;
            //string? inlinecount = null;
            //List<string>? orderby = null;
            //List<string>? select = null;
            //List<string>? expand = null;
            //var response = instance.ASalesOrderBillingPlanSalesOrderSalesOrderBillingPlanBillingPlanToBillingPlanItemGet(salesOrder, billingPlan, top, skip, filter, inlinecount, orderby, select, expand);
            //Assert.IsType<Wrapper10>(response);
        }

        /// <summary>
        /// Test ASalesOrderBillingPlanSalesOrderSalesOrderBillingPlanBillingPlanToBillingPlanItemPost
        /// </summary>
        [Fact]
        public void ASalesOrderBillingPlanSalesOrderSalesOrderBillingPlanBillingPlanToBillingPlanItemPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string salesOrder = null;
            //string billingPlan = null;
            //APISALESORDERSRVASalesOrderBillingPlanItemTypeCreate aPISALESORDERSRVASalesOrderBillingPlanItemTypeCreate = null;
            //var response = instance.ASalesOrderBillingPlanSalesOrderSalesOrderBillingPlanBillingPlanToBillingPlanItemPost(salesOrder, billingPlan, aPISALESORDERSRVASalesOrderBillingPlanItemTypeCreate);
            //Assert.IsType<ASalesOrderBillingPlanItemType>(response);
        }
    }
}
