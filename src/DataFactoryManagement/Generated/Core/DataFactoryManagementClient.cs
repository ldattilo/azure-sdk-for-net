// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Hyak.Common;
using Microsoft.Azure;
using Microsoft.Azure.Management.DataFactories.Common.Models;
using Microsoft.Azure.Management.DataFactories.Core;

namespace Microsoft.Azure.Management.DataFactories.Core
{
    public partial class DataFactoryManagementClient : ServiceClient<DataFactoryManagementClient>, IDataFactoryManagementClient
    {
        private Uri _baseUri;
        
        /// <summary>
        /// The URI used as the base for all Service Management requests.
        /// </summary>
        public Uri BaseUri
        {
            get { return this._baseUri; }
            set { this._baseUri = value; }
        }
        
        private SubscriptionCloudCredentials _credentials;
        
        /// <summary>
        /// When you create a Windows Azure subscription, it is uniquely
        /// identified by a subscription ID. The subscription ID forms part of
        /// the URI for every call that you make to the Service Management
        /// API. The Windows Azure Service ManagementAPI use mutual
        /// authentication of management certificates over SSL to ensure that
        /// a request made to the service is secure. No anonymous requests are
        /// allowed.
        /// </summary>
        public SubscriptionCloudCredentials Credentials
        {
            get { return this._credentials; }
            set { this._credentials = value; }
        }
        
        private int _longRunningOperationInitialTimeout;
        
        /// <summary>
        /// Gets or sets the initial timeout for Long Running Operations.
        /// </summary>
        public int LongRunningOperationInitialTimeout
        {
            get { return this._longRunningOperationInitialTimeout; }
            set { this._longRunningOperationInitialTimeout = value; }
        }
        
        private int _longRunningOperationRetryTimeout;
        
        /// <summary>
        /// Gets or sets the retry timeout for Long Running Operations.
        /// </summary>
        public int LongRunningOperationRetryTimeout
        {
            get { return this._longRunningOperationRetryTimeout; }
            set { this._longRunningOperationRetryTimeout = value; }
        }
        
        private IDataFactoryOperations _dataFactories;
        
        /// <summary>
        /// Operations for managing data factories.
        /// </summary>
        public virtual IDataFactoryOperations DataFactories
        {
            get { return this._dataFactories; }
        }
        
        private IDataSliceOperations _dataSlices;
        
        /// <summary>
        /// Operations for managing data slices.
        /// </summary>
        public virtual IDataSliceOperations DataSlices
        {
            get { return this._dataSlices; }
        }
        
        private IDataSliceRunOperations _dataSliceRuns;
        
        /// <summary>
        /// Operations for managing data slice runs.
        /// </summary>
        public virtual IDataSliceRunOperations DataSliceRuns
        {
            get { return this._dataSliceRuns; }
        }
        
        private IGatewayOperations _gateways;
        
        /// <summary>
        /// Operations for managing data factory gateways.
        /// </summary>
        public virtual IGatewayOperations Gateways
        {
            get { return this._gateways; }
        }
        
        private IHubOperations _hubs;
        
        /// <summary>
        /// Operations for managing hubs.
        /// </summary>
        public virtual IHubOperations Hubs
        {
            get { return this._hubs; }
        }
        
        private ILinkedServiceOperations _linkedServices;
        
        /// <summary>
        /// Operations for managing data factory internal linkedServices.
        /// </summary>
        public virtual ILinkedServiceOperations LinkedServices
        {
            get { return this._linkedServices; }
        }
        
        private IPipelineOperations _pipelines;
        
        /// <summary>
        /// Operations for managing pipelines.
        /// </summary>
        public virtual IPipelineOperations Pipelines
        {
            get { return this._pipelines; }
        }
        
        private IPipelineRunOperations _pipelineRuns;
        
        /// <summary>
        /// Operations for managing pipeline runs.
        /// </summary>
        public virtual IPipelineRunOperations PipelineRuns
        {
            get { return this._pipelineRuns; }
        }
        
        private ITableOperations _tables;
        
        /// <summary>
        /// Operations for managing tables.
        /// </summary>
        public virtual ITableOperations Tables
        {
            get { return this._tables; }
        }
        
        /// <summary>
        /// Initializes a new instance of the DataFactoryManagementClient class.
        /// </summary>
        public DataFactoryManagementClient()
            : base()
        {
            this._dataFactories = new DataFactoryOperations(this);
            this._dataSlices = new DataSliceOperations(this);
            this._dataSliceRuns = new DataSliceRunOperations(this);
            this._gateways = new GatewayOperations(this);
            this._hubs = new HubOperations(this);
            this._linkedServices = new LinkedServiceOperations(this);
            this._pipelines = new PipelineOperations(this);
            this._pipelineRuns = new PipelineRunOperations(this);
            this._tables = new TableOperations(this);
            this._longRunningOperationInitialTimeout = -1;
            this._longRunningOperationRetryTimeout = -1;
            this.HttpClient.Timeout = TimeSpan.FromSeconds(60);
        }
        
        /// <summary>
        /// Initializes a new instance of the DataFactoryManagementClient class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. When you create a Windows Azure subscription, it is
        /// uniquely identified by a subscription ID. The subscription ID
        /// forms part of the URI for every call that you make to the Service
        /// Management API. The Windows Azure Service ManagementAPI use mutual
        /// authentication of management certificates over SSL to ensure that
        /// a request made to the service is secure. No anonymous requests are
        /// allowed.
        /// </param>
        /// <param name='baseUri'>
        /// Optional. The URI used as the base for all Service Management
        /// requests.
        /// </param>
        public DataFactoryManagementClient(SubscriptionCloudCredentials credentials, Uri baseUri)
            : this()
        {
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
            if (baseUri == null)
            {
                throw new ArgumentNullException("baseUri");
            }
            this._credentials = credentials;
            this._baseUri = baseUri;
            
            this.Credentials.InitializeServiceClient(this);
        }
        
        /// <summary>
        /// Initializes a new instance of the DataFactoryManagementClient class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. When you create a Windows Azure subscription, it is
        /// uniquely identified by a subscription ID. The subscription ID
        /// forms part of the URI for every call that you make to the Service
        /// Management API. The Windows Azure Service ManagementAPI use mutual
        /// authentication of management certificates over SSL to ensure that
        /// a request made to the service is secure. No anonymous requests are
        /// allowed.
        /// </param>
        public DataFactoryManagementClient(SubscriptionCloudCredentials credentials)
            : this()
        {
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
            this._credentials = credentials;
            this._baseUri = new Uri("https://management.azure.com");
            
            this.Credentials.InitializeServiceClient(this);
        }
        
        /// <summary>
        /// Initializes a new instance of the DataFactoryManagementClient class.
        /// </summary>
        /// <param name='httpClient'>
        /// The Http client
        /// </param>
        public DataFactoryManagementClient(HttpClient httpClient)
            : base(httpClient)
        {
            this._dataFactories = new DataFactoryOperations(this);
            this._dataSlices = new DataSliceOperations(this);
            this._dataSliceRuns = new DataSliceRunOperations(this);
            this._gateways = new GatewayOperations(this);
            this._hubs = new HubOperations(this);
            this._linkedServices = new LinkedServiceOperations(this);
            this._pipelines = new PipelineOperations(this);
            this._pipelineRuns = new PipelineRunOperations(this);
            this._tables = new TableOperations(this);
            this._longRunningOperationInitialTimeout = -1;
            this._longRunningOperationRetryTimeout = -1;
            this.HttpClient.Timeout = TimeSpan.FromSeconds(60);
        }
        
        /// <summary>
        /// Initializes a new instance of the DataFactoryManagementClient class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. When you create a Windows Azure subscription, it is
        /// uniquely identified by a subscription ID. The subscription ID
        /// forms part of the URI for every call that you make to the Service
        /// Management API. The Windows Azure Service ManagementAPI use mutual
        /// authentication of management certificates over SSL to ensure that
        /// a request made to the service is secure. No anonymous requests are
        /// allowed.
        /// </param>
        /// <param name='baseUri'>
        /// Optional. The URI used as the base for all Service Management
        /// requests.
        /// </param>
        /// <param name='httpClient'>
        /// The Http client
        /// </param>
        public DataFactoryManagementClient(SubscriptionCloudCredentials credentials, Uri baseUri, HttpClient httpClient)
            : this(httpClient)
        {
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
            if (baseUri == null)
            {
                throw new ArgumentNullException("baseUri");
            }
            this._credentials = credentials;
            this._baseUri = baseUri;
            
            this.Credentials.InitializeServiceClient(this);
        }
        
        /// <summary>
        /// Initializes a new instance of the DataFactoryManagementClient class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. When you create a Windows Azure subscription, it is
        /// uniquely identified by a subscription ID. The subscription ID
        /// forms part of the URI for every call that you make to the Service
        /// Management API. The Windows Azure Service ManagementAPI use mutual
        /// authentication of management certificates over SSL to ensure that
        /// a request made to the service is secure. No anonymous requests are
        /// allowed.
        /// </param>
        /// <param name='httpClient'>
        /// The Http client
        /// </param>
        public DataFactoryManagementClient(SubscriptionCloudCredentials credentials, HttpClient httpClient)
            : this(httpClient)
        {
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
            this._credentials = credentials;
            this._baseUri = new Uri("https://management.azure.com");
            
            this.Credentials.InitializeServiceClient(this);
        }
        
        /// <summary>
        /// Clones properties from current instance to another
        /// DataFactoryManagementClient instance
        /// </summary>
        /// <param name='client'>
        /// Instance of DataFactoryManagementClient to clone to
        /// </param>
        protected override void Clone(ServiceClient<DataFactoryManagementClient> client)
        {
            base.Clone(client);
            
            if (client is DataFactoryManagementClient)
            {
                DataFactoryManagementClient clonedClient = ((DataFactoryManagementClient)client);
                
                clonedClient._credentials = this._credentials;
                clonedClient._baseUri = this._baseUri;
                clonedClient._longRunningOperationInitialTimeout = this._longRunningOperationInitialTimeout;
                clonedClient._longRunningOperationRetryTimeout = this._longRunningOperationRetryTimeout;
                
                clonedClient.Credentials.InitializeServiceClient(clonedClient);
            }
        }
        
        /// <summary>
        /// The Get Operation Status operation returns the status of the
        /// specified operation. After calling an asynchronous operation, you
        /// can call Get Operation Status to determine whether the operation
        /// has succeeded, failed, or is still in progress.
        /// </summary>
        /// <param name='operationStatusLink'>
        /// Required. Location value returned by the Begin operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response for long running operations.
        /// </returns>
        public async Task<LongRunningOperationResponse> GetLongRunningOperationStatusAsync(string operationStatusLink, CancellationToken cancellationToken)
        {
            // Validate
            if (operationStatusLink == null)
            {
                throw new ArgumentNullException("operationStatusLink");
            }
            
            // Tracing
            bool shouldTrace = TracingAdapter.IsEnabled;
            string invocationId = null;
            if (shouldTrace)
            {
                invocationId = TracingAdapter.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("operationStatusLink", operationStatusLink);
                TracingAdapter.Enter(invocationId, this, "GetLongRunningOperationStatusAsync", tracingParameters);
            }
            
            // Construct URL
            string url = "";
            url = url + operationStatusLink;
            url = url.Replace(" ", "%20");
            
            // Create HTTP transport objects
            HttpRequestMessage httpRequest = null;
            try
            {
                httpRequest = new HttpRequestMessage();
                httpRequest.Method = HttpMethod.Get;
                httpRequest.RequestUri = new Uri(url);
                
                // Set Headers
                httpRequest.Headers.Add("x-ms-version", "2015-extensibility");
                
                // Set Credentials
                cancellationToken.ThrowIfCancellationRequested();
                await this.Credentials.ProcessHttpRequestAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                
                // Send Request
                HttpResponseMessage httpResponse = null;
                try
                {
                    if (shouldTrace)
                    {
                        TracingAdapter.SendRequest(invocationId, httpRequest);
                    }
                    cancellationToken.ThrowIfCancellationRequested();
                    httpResponse = await this.HttpClient.SendAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                    if (shouldTrace)
                    {
                        TracingAdapter.ReceiveResponse(invocationId, httpResponse);
                    }
                    HttpStatusCode statusCode = httpResponse.StatusCode;
                    if (statusCode != HttpStatusCode.OK && statusCode != HttpStatusCode.Accepted && statusCode != HttpStatusCode.NoContent)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        CloudException ex = CloudException.Create(httpRequest, null, httpResponse, await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false));
                        if (shouldTrace)
                        {
                            TracingAdapter.Error(invocationId, ex);
                        }
                        throw ex;
                    }
                    
                    // Create Result
                    LongRunningOperationResponse result = null;
                    // Deserialize Response
                    result = new LongRunningOperationResponse();
                    result.StatusCode = statusCode;
                    if (httpResponse.Headers.Contains("x-ms-request-id"))
                    {
                        result.RequestId = httpResponse.Headers.GetValues("x-ms-request-id").FirstOrDefault();
                    }
                    if (statusCode == HttpStatusCode.Conflict)
                    {
                        result.Status = OperationStatus.Failed;
                    }
                    if (statusCode == HttpStatusCode.NoContent)
                    {
                        result.Status = OperationStatus.Succeeded;
                    }
                    if (statusCode == HttpStatusCode.OK)
                    {
                        result.Status = OperationStatus.Succeeded;
                    }
                    
                    if (shouldTrace)
                    {
                        TracingAdapter.Exit(invocationId, result);
                    }
                    return result;
                }
                finally
                {
                    if (httpResponse != null)
                    {
                        httpResponse.Dispose();
                    }
                }
            }
            finally
            {
                if (httpRequest != null)
                {
                    httpRequest.Dispose();
                }
            }
        }
    }
}
