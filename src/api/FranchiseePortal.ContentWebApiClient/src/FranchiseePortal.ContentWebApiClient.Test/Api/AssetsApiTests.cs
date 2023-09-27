/*
 * Goddard.ContentWebApi
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: v1
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

using FranchiseePortal.ContentWebApiClient.Client;
using FranchiseePortal.ContentWebApiClient.Api;
// uncomment below to import models
//using FranchiseePortal.ContentWebApiClient.Model;

namespace FranchiseePortal.ContentWebApiClient.Test.Api
{
    /// <summary>
    ///  Class for testing AssetsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class AssetsApiTests : IDisposable
    {
        private AssetsApi instance;

        public AssetsApiTests()
        {
            instance = new AssetsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of AssetsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' AssetsApi
            //Assert.IsType<AssetsApi>(instance);
        }

        /// <summary>
        /// Test ApiV1DcpAssetsCompleteUploadGet
        /// </summary>
        [Fact]
        public void ApiV1DcpAssetsCompleteUploadGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string path = null;
            //string uploadToken = null;
            //string fileName = null;
            //string mimeType = null;
            //var response = instance.ApiV1DcpAssetsCompleteUploadGet(path, uploadToken, fileName, mimeType);
            //Assert.IsType<CompleteUploadResponse>(response);
        }

        /// <summary>
        /// Test ApiV1DcpAssetsImageUploadLocationGet
        /// </summary>
        [Fact]
        public void ApiV1DcpAssetsImageUploadLocationGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string path = null;
            //string fileName = null;
            //int? fileSize = null;
            //var response = instance.ApiV1DcpAssetsImageUploadLocationGet(path, fileName, fileSize);
            //Assert.IsType<InitiateUploadResponse>(response);
        }

        /// <summary>
        /// Test ApiV1DcpAssetsImagesPathGet
        /// </summary>
        [Fact]
        public void ApiV1DcpAssetsImagesPathGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string path = null;
            //var response = instance.ApiV1DcpAssetsImagesPathGet(path);
            //Assert.IsType<List<OriginalAsset>>(response);
        }

        /// <summary>
        /// Test ApiV1DcpAssetsPublishPost
        /// </summary>
        [Fact]
        public void ApiV1DcpAssetsPublishPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string assetPath = null;
            //instance.ApiV1DcpAssetsPublishPost(assetPath);
        }

        /// <summary>
        /// Test ApiV1DcpAssetsSchoolHeroImagesGet
        /// </summary>
        [Fact]
        public void ApiV1DcpAssetsSchoolHeroImagesGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.ApiV1DcpAssetsSchoolHeroImagesGet();
            //Assert.IsType<List<OriginalAsset>>(response);
        }
    }
}
