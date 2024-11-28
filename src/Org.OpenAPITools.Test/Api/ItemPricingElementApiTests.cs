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
    ///  Class for testing ItemPricingElementApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ItemPricingElementApiTests : IDisposable
    {
        private ItemPricingElementApi instance;

        public ItemPricingElementApiTests()
        {
            instance = new ItemPricingElementApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ItemPricingElementApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ItemPricingElementApi
            //Assert.IsType<ItemPricingElementApi>(instance);
        }

        /// <summary>
        /// Test ASalesOrderItemPrElementGet
        /// </summary>
        [Fact]
        public void ASalesOrderItemPrElementGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? top = null;
            //int? skip = null;
            //string? filter = null;
            //string? inlinecount = null;
            //List<string>? orderby = null;
            //List<string>? select = null;
            //List<string>? expand = null;
            //var response = instance.ASalesOrderItemPrElementGet(top, skip, filter, inlinecount, orderby, select, expand);
            //Assert.IsType<Wrapper14>(response);
        }

        /// <summary>
        /// Test ASalesOrderItemPrElementPost
        /// </summary>
        [Fact]
        public void ASalesOrderItemPrElementPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //APISALESORDERSRVASalesOrderItemPrElementTypeCreate aPISALESORDERSRVASalesOrderItemPrElementTypeCreate = null;
            //var response = instance.ASalesOrderItemPrElementPost(aPISALESORDERSRVASalesOrderItemPrElementTypeCreate);
            //Assert.IsType<ASalesOrderItemPrElementType>(response);
        }

        /// <summary>
        /// Test ASalesOrderItemPrElementSalesOrderSalesOrderSalesOrderItemSalesOrderItemPricingProcedureStepPricingProcedureStepPricingProcedureCounterPricingProcedureCounterDelete
        /// </summary>
        [Fact]
        public void ASalesOrderItemPrElementSalesOrderSalesOrderSalesOrderItemSalesOrderItemPricingProcedureStepPricingProcedureStepPricingProcedureCounterPricingProcedureCounterDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string salesOrder = null;
            //string salesOrderItem = null;
            //string pricingProcedureStep = null;
            //string pricingProcedureCounter = null;
            //instance.ASalesOrderItemPrElementSalesOrderSalesOrderSalesOrderItemSalesOrderItemPricingProcedureStepPricingProcedureStepPricingProcedureCounterPricingProcedureCounterDelete(salesOrder, salesOrderItem, pricingProcedureStep, pricingProcedureCounter);
        }

        /// <summary>
        /// Test ASalesOrderItemPrElementSalesOrderSalesOrderSalesOrderItemSalesOrderItemPricingProcedureStepPricingProcedureStepPricingProcedureCounterPricingProcedureCounterGet
        /// </summary>
        [Fact]
        public void ASalesOrderItemPrElementSalesOrderSalesOrderSalesOrderItemSalesOrderItemPricingProcedureStepPricingProcedureStepPricingProcedureCounterPricingProcedureCounterGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string salesOrder = null;
            //string salesOrderItem = null;
            //string pricingProcedureStep = null;
            //string pricingProcedureCounter = null;
            //List<string>? select = null;
            //List<string>? expand = null;
            //var response = instance.ASalesOrderItemPrElementSalesOrderSalesOrderSalesOrderItemSalesOrderItemPricingProcedureStepPricingProcedureStepPricingProcedureCounterPricingProcedureCounterGet(salesOrder, salesOrderItem, pricingProcedureStep, pricingProcedureCounter, select, expand);
            //Assert.IsType<ASalesOrderItemPrElementType>(response);
        }

        /// <summary>
        /// Test ASalesOrderItemPrElementSalesOrderSalesOrderSalesOrderItemSalesOrderItemPricingProcedureStepPricingProcedureStepPricingProcedureCounterPricingProcedureCounterPatch
        /// </summary>
        [Fact]
        public void ASalesOrderItemPrElementSalesOrderSalesOrderSalesOrderItemSalesOrderItemPricingProcedureStepPricingProcedureStepPricingProcedureCounterPricingProcedureCounterPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string salesOrder = null;
            //string salesOrderItem = null;
            //string pricingProcedureStep = null;
            //string pricingProcedureCounter = null;
            //ModifiedASalesOrderItemPrElementType modifiedASalesOrderItemPrElementType = null;
            //instance.ASalesOrderItemPrElementSalesOrderSalesOrderSalesOrderItemSalesOrderItemPricingProcedureStepPricingProcedureStepPricingProcedureCounterPricingProcedureCounterPatch(salesOrder, salesOrderItem, pricingProcedureStep, pricingProcedureCounter, modifiedASalesOrderItemPrElementType);
        }

        /// <summary>
        /// Test ASalesOrderItemPrElementSalesOrderSalesOrderSalesOrderItemSalesOrderItemPricingProcedureStepPricingProcedureStepPricingProcedureCounterPricingProcedureCounterToSalesOrderGet
        /// </summary>
        [Fact]
        public void ASalesOrderItemPrElementSalesOrderSalesOrderSalesOrderItemSalesOrderItemPricingProcedureStepPricingProcedureStepPricingProcedureCounterPricingProcedureCounterToSalesOrderGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string salesOrder = null;
            //string salesOrderItem = null;
            //string pricingProcedureStep = null;
            //string pricingProcedureCounter = null;
            //List<string>? select = null;
            //List<string>? expand = null;
            //var response = instance.ASalesOrderItemPrElementSalesOrderSalesOrderSalesOrderItemSalesOrderItemPricingProcedureStepPricingProcedureStepPricingProcedureCounterPricingProcedureCounterToSalesOrderGet(salesOrder, salesOrderItem, pricingProcedureStep, pricingProcedureCounter, select, expand);
            //Assert.IsType<ASalesOrderType>(response);
        }

        /// <summary>
        /// Test ASalesOrderItemPrElementSalesOrderSalesOrderSalesOrderItemSalesOrderItemPricingProcedureStepPricingProcedureStepPricingProcedureCounterPricingProcedureCounterToSalesOrderItemGet
        /// </summary>
        [Fact]
        public void ASalesOrderItemPrElementSalesOrderSalesOrderSalesOrderItemSalesOrderItemPricingProcedureStepPricingProcedureStepPricingProcedureCounterPricingProcedureCounterToSalesOrderItemGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string salesOrder = null;
            //string salesOrderItem = null;
            //string pricingProcedureStep = null;
            //string pricingProcedureCounter = null;
            //List<string>? select = null;
            //List<string>? expand = null;
            //var response = instance.ASalesOrderItemPrElementSalesOrderSalesOrderSalesOrderItemSalesOrderItemPricingProcedureStepPricingProcedureStepPricingProcedureCounterPricingProcedureCounterToSalesOrderItemGet(salesOrder, salesOrderItem, pricingProcedureStep, pricingProcedureCounter, select, expand);
            //Assert.IsType<ASalesOrderItemType>(response);
        }

        /// <summary>
        /// Test ASalesOrderItemSalesOrderSalesOrderSalesOrderItemSalesOrderItemToPricingElementGet
        /// </summary>
        [Fact]
        public void ASalesOrderItemSalesOrderSalesOrderSalesOrderItemSalesOrderItemToPricingElementGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string salesOrder = null;
            //string salesOrderItem = null;
            //int? top = null;
            //int? skip = null;
            //string? filter = null;
            //string? inlinecount = null;
            //List<string>? orderby = null;
            //List<string>? select = null;
            //List<string>? expand = null;
            //var response = instance.ASalesOrderItemSalesOrderSalesOrderSalesOrderItemSalesOrderItemToPricingElementGet(salesOrder, salesOrderItem, top, skip, filter, inlinecount, orderby, select, expand);
            //Assert.IsType<Wrapper14>(response);
        }

        /// <summary>
        /// Test ASalesOrderItemSalesOrderSalesOrderSalesOrderItemSalesOrderItemToPricingElementPost
        /// </summary>
        [Fact]
        public void ASalesOrderItemSalesOrderSalesOrderSalesOrderItemSalesOrderItemToPricingElementPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string salesOrder = null;
            //string salesOrderItem = null;
            //APISALESORDERSRVASalesOrderItemPrElementTypeCreate aPISALESORDERSRVASalesOrderItemPrElementTypeCreate = null;
            //var response = instance.ASalesOrderItemSalesOrderSalesOrderSalesOrderItemSalesOrderItemToPricingElementPost(salesOrder, salesOrderItem, aPISALESORDERSRVASalesOrderItemPrElementTypeCreate);
            //Assert.IsType<ASalesOrderItemPrElementType>(response);
        }
    }
}
