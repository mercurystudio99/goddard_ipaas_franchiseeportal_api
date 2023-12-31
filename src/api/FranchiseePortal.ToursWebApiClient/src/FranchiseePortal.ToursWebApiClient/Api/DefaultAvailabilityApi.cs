/*
 * Goddard.ToursWebApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using FranchiseePortal.ToursWebApiClient.Client;
using FranchiseePortal.ToursWebApiClient.Model;

namespace FranchiseePortal.ToursWebApiClient.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IDefaultAvailabilityApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Gets default availability for specified tourDuration
        /// </summary>
        /// <exception cref="FranchiseePortal.ToursWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tourDuration">Default tour duration (30 or 60)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>AvailabilityDto</returns>
        AvailabilityDto ApiV1DefaultAvailabilityTourDurationGet(int tourDuration, int operationIndex = 0);

        /// <summary>
        /// Gets default availability for specified tourDuration
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="FranchiseePortal.ToursWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tourDuration">Default tour duration (30 or 60)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of AvailabilityDto</returns>
        ApiResponse<AvailabilityDto> ApiV1DefaultAvailabilityTourDurationGetWithHttpInfo(int tourDuration, int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IDefaultAvailabilityApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Gets default availability for specified tourDuration
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="FranchiseePortal.ToursWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tourDuration">Default tour duration (30 or 60)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AvailabilityDto</returns>
        System.Threading.Tasks.Task<AvailabilityDto> ApiV1DefaultAvailabilityTourDurationGetAsync(int tourDuration, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Gets default availability for specified tourDuration
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="FranchiseePortal.ToursWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tourDuration">Default tour duration (30 or 60)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AvailabilityDto)</returns>
        System.Threading.Tasks.Task<ApiResponse<AvailabilityDto>> ApiV1DefaultAvailabilityTourDurationGetWithHttpInfoAsync(int tourDuration, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IDefaultAvailabilityApi : IDefaultAvailabilityApiSync, IDefaultAvailabilityApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class DefaultAvailabilityApi : IDefaultAvailabilityApi
    {
        private FranchiseePortal.ToursWebApiClient.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultAvailabilityApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DefaultAvailabilityApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultAvailabilityApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DefaultAvailabilityApi(string basePath)
        {
            this.Configuration = FranchiseePortal.ToursWebApiClient.Client.Configuration.MergeConfigurations(
                FranchiseePortal.ToursWebApiClient.Client.GlobalConfiguration.Instance,
                new FranchiseePortal.ToursWebApiClient.Client.Configuration { BasePath = basePath }
            );
            this.Client = new FranchiseePortal.ToursWebApiClient.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new FranchiseePortal.ToursWebApiClient.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = FranchiseePortal.ToursWebApiClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultAvailabilityApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public DefaultAvailabilityApi(FranchiseePortal.ToursWebApiClient.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = FranchiseePortal.ToursWebApiClient.Client.Configuration.MergeConfigurations(
                FranchiseePortal.ToursWebApiClient.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new FranchiseePortal.ToursWebApiClient.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new FranchiseePortal.ToursWebApiClient.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = FranchiseePortal.ToursWebApiClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultAvailabilityApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public DefaultAvailabilityApi(FranchiseePortal.ToursWebApiClient.Client.ISynchronousClient client, FranchiseePortal.ToursWebApiClient.Client.IAsynchronousClient asyncClient, FranchiseePortal.ToursWebApiClient.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = FranchiseePortal.ToursWebApiClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public FranchiseePortal.ToursWebApiClient.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public FranchiseePortal.ToursWebApiClient.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public FranchiseePortal.ToursWebApiClient.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public FranchiseePortal.ToursWebApiClient.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets default availability for specified tourDuration 
        /// </summary>
        /// <exception cref="FranchiseePortal.ToursWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tourDuration">Default tour duration (30 or 60)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>AvailabilityDto</returns>
        public AvailabilityDto ApiV1DefaultAvailabilityTourDurationGet(int tourDuration, int operationIndex = 0)
        {
            FranchiseePortal.ToursWebApiClient.Client.ApiResponse<AvailabilityDto> localVarResponse = ApiV1DefaultAvailabilityTourDurationGetWithHttpInfo(tourDuration);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Gets default availability for specified tourDuration 
        /// </summary>
        /// <exception cref="FranchiseePortal.ToursWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tourDuration">Default tour duration (30 or 60)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of AvailabilityDto</returns>
        public FranchiseePortal.ToursWebApiClient.Client.ApiResponse<AvailabilityDto> ApiV1DefaultAvailabilityTourDurationGetWithHttpInfo(int tourDuration, int operationIndex = 0)
        {
            FranchiseePortal.ToursWebApiClient.Client.RequestOptions localVarRequestOptions = new FranchiseePortal.ToursWebApiClient.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "text/plain",
                "application/json",
                "text/json"
            };

            var localVarContentType = FranchiseePortal.ToursWebApiClient.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = FranchiseePortal.ToursWebApiClient.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("tourDuration", FranchiseePortal.ToursWebApiClient.Client.ClientUtils.ParameterToString(tourDuration)); // path parameter

            localVarRequestOptions.Operation = "DefaultAvailabilityApi.ApiV1DefaultAvailabilityTourDurationGet";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (ApiKeyAuth) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Ocp-Apim-Subscription-Key")))
            {
                localVarRequestOptions.HeaderParameters.Add("Ocp-Apim-Subscription-Key", this.Configuration.GetApiKeyWithPrefix("Ocp-Apim-Subscription-Key"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<AvailabilityDto>("/api/v1/default-availability/{tourDuration}", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ApiV1DefaultAvailabilityTourDurationGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Gets default availability for specified tourDuration 
        /// </summary>
        /// <exception cref="FranchiseePortal.ToursWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tourDuration">Default tour duration (30 or 60)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AvailabilityDto</returns>
        public async System.Threading.Tasks.Task<AvailabilityDto> ApiV1DefaultAvailabilityTourDurationGetAsync(int tourDuration, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            FranchiseePortal.ToursWebApiClient.Client.ApiResponse<AvailabilityDto> localVarResponse = await ApiV1DefaultAvailabilityTourDurationGetWithHttpInfoAsync(tourDuration, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Gets default availability for specified tourDuration 
        /// </summary>
        /// <exception cref="FranchiseePortal.ToursWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tourDuration">Default tour duration (30 or 60)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AvailabilityDto)</returns>
        public async System.Threading.Tasks.Task<FranchiseePortal.ToursWebApiClient.Client.ApiResponse<AvailabilityDto>> ApiV1DefaultAvailabilityTourDurationGetWithHttpInfoAsync(int tourDuration, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            FranchiseePortal.ToursWebApiClient.Client.RequestOptions localVarRequestOptions = new FranchiseePortal.ToursWebApiClient.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "text/plain",
                "application/json",
                "text/json"
            };

            var localVarContentType = FranchiseePortal.ToursWebApiClient.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = FranchiseePortal.ToursWebApiClient.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("tourDuration", FranchiseePortal.ToursWebApiClient.Client.ClientUtils.ParameterToString(tourDuration)); // path parameter

            localVarRequestOptions.Operation = "DefaultAvailabilityApi.ApiV1DefaultAvailabilityTourDurationGet";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (ApiKeyAuth) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Ocp-Apim-Subscription-Key")))
            {
                localVarRequestOptions.HeaderParameters.Add("Ocp-Apim-Subscription-Key", this.Configuration.GetApiKeyWithPrefix("Ocp-Apim-Subscription-Key"));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<AvailabilityDto>("/api/v1/default-availability/{tourDuration}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ApiV1DefaultAvailabilityTourDurationGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
