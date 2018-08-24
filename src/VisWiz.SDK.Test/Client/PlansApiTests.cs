/* 
 * VisWiz.io API Documentation
 *
 * This SDK allows you to query and create new projects, builds or images within the VisWiz service. 
 *
 * OpenAPI spec version: 1.1.0
 * Contact: support@viswiz.io
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using VisWiz.SDK.Client;
using VisWiz.SDK.Client;
using VisWiz.SDK.Model;

namespace VisWiz.SDK.Test
{
    /// <summary>
    ///  Class for testing PlansApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class PlansApiTests
    {
        private PlansApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new PlansApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of PlansApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' PlansApi
            //Assert.IsInstanceOfType(typeof(PlansApi), instance, "instance is a PlansApi");
        }

        
        /// <summary>
        /// Test CancelPlan
        /// </summary>
        [Test]
        public void CancelPlanTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //instance.CancelPlan();
            
        }
        
        /// <summary>
        /// Test GetPlans
        /// </summary>
        [Test]
        public void GetPlansTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetPlans();
            //Assert.IsInstanceOf<InlineResponse200> (response, "response is InlineResponse200");
        }
        
    }

}
