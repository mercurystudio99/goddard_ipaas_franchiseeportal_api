/*
 * Goddard iPaaS Leads API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0
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

using FranchiseePortal.LeadsWebApiClient.Client;
using FranchiseePortal.LeadsWebApiClient.Api;
// uncomment below to import models
//using FranchiseePortal.LeadsWebApiClient.Model;

namespace FranchiseePortal.LeadsWebApiClient.Test.Api
{
    /// <summary>
    ///  Class for testing ValidationApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ValidationApiTests : IDisposable
    {
        private ValidationApi instance;

        public ValidationApiTests()
        {
            instance = new ValidationApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ValidationApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ValidationApi
            //Assert.IsType<ValidationApi>(instance);
        }

        /// <summary>
        /// Test ApiV1ValidationEmailPost
        /// </summary>
        [Fact]
        public void ApiV1ValidationEmailPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ApiV1ValidationEmailPostRequest apiV1ValidationEmailPostRequest = null;
            //var response = instance.ApiV1ValidationEmailPost(apiV1ValidationEmailPostRequest);
            //Assert.IsType<EmailValidationResult>(response);
        }

        /// <summary>
        /// Test ApiV1ValidationPhonePost
        /// </summary>
        [Fact]
        public void ApiV1ValidationPhonePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ApiV1ValidationPhonePostRequest apiV1ValidationPhonePostRequest = null;
            //var response = instance.ApiV1ValidationPhonePost(apiV1ValidationPhonePostRequest);
            //Assert.IsType<PhoneValidationResult>(response);
        }
    }
}
