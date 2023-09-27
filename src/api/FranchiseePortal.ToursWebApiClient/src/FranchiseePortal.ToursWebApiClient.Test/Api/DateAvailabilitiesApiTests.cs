/*
 * Goddard.ToursWebApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
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
    ///  Class for testing DateAvailabilitiesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class DateAvailabilitiesApiTests : IDisposable
    {
        private DateAvailabilitiesApi instance;

        public DateAvailabilitiesApiTests()
        {
            instance = new DateAvailabilitiesApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of DateAvailabilitiesApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' DateAvailabilitiesApi
            //Assert.IsType<DateAvailabilitiesApi>(instance);
        }

        /// <summary>
        /// Test ApiV1SchoolsSchoolIdDateAvailabilitiesDateGet
        /// </summary>
        [Fact]
        public void ApiV1SchoolsSchoolIdDateAvailabilitiesDateGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string schoolId = null;
            //DateTime date = null;
            //var response = instance.ApiV1SchoolsSchoolIdDateAvailabilitiesDateGet(schoolId, date);
            //Assert.IsType<DateAvailabilityDto>(response);
        }

        /// <summary>
        /// Test ApiV1SchoolsSchoolIdDateAvailabilitiesDatePut
        /// </summary>
        [Fact]
        public void ApiV1SchoolsSchoolIdDateAvailabilitiesDatePutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string schoolId = null;
            //DateTime date = null;
            //DateAvailabilityInputDto dateAvailabilityInputDto = null;
            //var response = instance.ApiV1SchoolsSchoolIdDateAvailabilitiesDatePut(schoolId, date, dateAvailabilityInputDto);
            //Assert.IsType<DateAvailabilityDto>(response);
        }
    }
}
