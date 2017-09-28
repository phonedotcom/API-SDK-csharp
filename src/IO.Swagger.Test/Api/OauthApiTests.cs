/* 
 * Phone.com API
 *
 * This is a Phone.com api Swagger definition
 *
 * OpenAPI spec version: 1.0.0
 * Contact: apisupport@phone.com
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

using IO.Swagger.Client;
using IO.Swagger.Api;
using IO.Swagger.Model;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing OauthApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class OauthApiTests
    {
        private OauthApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new OauthApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of OauthApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' OauthApi
            //Assert.IsInstanceOfType(typeof(OauthApi), instance, "instance is a OauthApi");
        }

        
        /// <summary>
        /// Test CreateOauthAccessToken
        /// </summary>
        [Test]
        public void CreateOauthAccessTokenTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CreateOauthParams data = null;
            //var response = instance.CreateOauthAccessToken(data);
            //Assert.IsInstanceOf<OauthAccessToken> (response, "response is OauthAccessToken");
        }
        
        /// <summary>
        /// Test CreateOauthAuthorization
        /// </summary>
        [Test]
        public void CreateOauthAuthorizationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string clientId = null;
            //string responseType = null;
            //string scope = null;
            //string redirectUri = null;
            //instance.CreateOauthAuthorization(clientId, responseType, scope, redirectUri);
            
        }
        
        /// <summary>
        /// Test GetOauthAccessToken
        /// </summary>
        [Test]
        public void GetOauthAccessTokenTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetOauthAccessToken();
            //Assert.IsInstanceOf<GetOauthAccessToken> (response, "response is GetOauthAccessToken");
        }
        
    }

}