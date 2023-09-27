/*
 * Goddard.ToursWebApi
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

using FranchiseePortal.ToursWebApiClient.Client;
using FranchiseePortal.ToursWebApiClient.Api;
// uncomment below to import models
//using FranchiseePortal.ToursWebApiClient.Model;

namespace FranchiseePortal.ToursWebApiClient.Test.Api
{
    /// <summary>
    ///  Class for testing SettingsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class SettingsApiTests : IDisposable
    {
        private SettingsApi instance;

        public SettingsApiTests()
        {
            instance = new SettingsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SettingsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' SettingsApi
            //Assert.IsType<SettingsApi>(instance);
        }

        /// <summary>
        /// Test ApiV1SettingsIdPut
        /// </summary>
        [Fact]
        public void ApiV1SettingsIdPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //SettingsDto settingsDto = null;
            //instance.ApiV1SettingsIdPut(id, settingsDto);
        }

        /// <summary>
        /// Test ApiV1SettingsPost
        /// </summary>
        [Fact]
        public void ApiV1SettingsPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SettingsDto settingsDto = null;
            //instance.ApiV1SettingsPost(settingsDto);
        }

        /// <summary>
        /// Test ApiV1SettingsSchoolIdGet
        /// </summary>
        [Fact]
        public void ApiV1SettingsSchoolIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string schoolId = null;
            //var response = instance.ApiV1SettingsSchoolIdGet(schoolId);
            //Assert.IsType<SettingsDto>(response);
        }
    }
}
