// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary> The JobExecutions service client. </summary>
    public partial class JobExecutionsOperations
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal JobExecutionsRestOperations RestClient { get; }

        /// <summary> Initializes a new instance of JobExecutionsOperations for mocking. </summary>
        protected JobExecutionsOperations()
        {
        }

        /// <summary> Initializes a new instance of JobExecutionsOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="subscriptionId"> The subscription ID that identifies an Azure subscription. </param>
        /// <param name="endpoint"> server parameter. </param>
        internal JobExecutionsOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null)
        {
            RestClient = new JobExecutionsRestOperations(clientDiagnostics, pipeline, subscriptionId, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Requests cancellation of a job execution. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="jobAgentName"> The name of the job agent. </param>
        /// <param name="jobName"> The name of the job. </param>
        /// <param name="jobExecutionId"> The id of the job execution to cancel. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> CancelAsync(string resourceGroupName, string serverName, string jobAgentName, string jobName, Guid jobExecutionId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("JobExecutionsOperations.Cancel");
            scope.Start();
            try
            {
                return await RestClient.CancelAsync(resourceGroupName, serverName, jobAgentName, jobName, jobExecutionId, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Requests cancellation of a job execution. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="jobAgentName"> The name of the job agent. </param>
        /// <param name="jobName"> The name of the job. </param>
        /// <param name="jobExecutionId"> The id of the job execution to cancel. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Cancel(string resourceGroupName, string serverName, string jobAgentName, string jobName, Guid jobExecutionId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("JobExecutionsOperations.Cancel");
            scope.Start();
            try
            {
                return RestClient.Cancel(resourceGroupName, serverName, jobAgentName, jobName, jobExecutionId, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a job execution. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="jobAgentName"> The name of the job agent. </param>
        /// <param name="jobName"> The name of the job. </param>
        /// <param name="jobExecutionId"> The id of the job execution. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<JobExecution>> GetAsync(string resourceGroupName, string serverName, string jobAgentName, string jobName, Guid jobExecutionId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("JobExecutionsOperations.Get");
            scope.Start();
            try
            {
                return await RestClient.GetAsync(resourceGroupName, serverName, jobAgentName, jobName, jobExecutionId, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a job execution. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="jobAgentName"> The name of the job agent. </param>
        /// <param name="jobName"> The name of the job. </param>
        /// <param name="jobExecutionId"> The id of the job execution. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<JobExecution> Get(string resourceGroupName, string serverName, string jobAgentName, string jobName, Guid jobExecutionId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("JobExecutionsOperations.Get");
            scope.Start();
            try
            {
                return RestClient.Get(resourceGroupName, serverName, jobAgentName, jobName, jobExecutionId, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all executions in a job agent. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="jobAgentName"> The name of the job agent. </param>
        /// <param name="createTimeMin"> If specified, only job executions created at or after the specified time are included. </param>
        /// <param name="createTimeMax"> If specified, only job executions created before the specified time are included. </param>
        /// <param name="endTimeMin"> If specified, only job executions completed at or after the specified time are included. </param>
        /// <param name="endTimeMax"> If specified, only job executions completed before the specified time are included. </param>
        /// <param name="isActive"> If specified, only active or only completed job executions are included. </param>
        /// <param name="skip"> The number of elements in the collection to skip. </param>
        /// <param name="top"> The number of elements to return from the collection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="serverName"/>, or <paramref name="jobAgentName"/> is null. </exception>
        public virtual AsyncPageable<JobExecution> ListByAgentAsync(string resourceGroupName, string serverName, string jobAgentName, DateTimeOffset? createTimeMin = null, DateTimeOffset? createTimeMax = null, DateTimeOffset? endTimeMin = null, DateTimeOffset? endTimeMax = null, bool? isActive = null, int? skip = null, int? top = null, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (serverName == null)
            {
                throw new ArgumentNullException(nameof(serverName));
            }
            if (jobAgentName == null)
            {
                throw new ArgumentNullException(nameof(jobAgentName));
            }

            async Task<Page<JobExecution>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("JobExecutionsOperations.ListByAgent");
                scope.Start();
                try
                {
                    var response = await RestClient.ListByAgentAsync(resourceGroupName, serverName, jobAgentName, createTimeMin, createTimeMax, endTimeMin, endTimeMax, isActive, skip, top, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<JobExecution>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("JobExecutionsOperations.ListByAgent");
                scope.Start();
                try
                {
                    var response = await RestClient.ListByAgentNextPageAsync(nextLink, resourceGroupName, serverName, jobAgentName, createTimeMin, createTimeMax, endTimeMin, endTimeMax, isActive, skip, top, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Lists all executions in a job agent. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="jobAgentName"> The name of the job agent. </param>
        /// <param name="createTimeMin"> If specified, only job executions created at or after the specified time are included. </param>
        /// <param name="createTimeMax"> If specified, only job executions created before the specified time are included. </param>
        /// <param name="endTimeMin"> If specified, only job executions completed at or after the specified time are included. </param>
        /// <param name="endTimeMax"> If specified, only job executions completed before the specified time are included. </param>
        /// <param name="isActive"> If specified, only active or only completed job executions are included. </param>
        /// <param name="skip"> The number of elements in the collection to skip. </param>
        /// <param name="top"> The number of elements to return from the collection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="serverName"/>, or <paramref name="jobAgentName"/> is null. </exception>
        public virtual Pageable<JobExecution> ListByAgent(string resourceGroupName, string serverName, string jobAgentName, DateTimeOffset? createTimeMin = null, DateTimeOffset? createTimeMax = null, DateTimeOffset? endTimeMin = null, DateTimeOffset? endTimeMax = null, bool? isActive = null, int? skip = null, int? top = null, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (serverName == null)
            {
                throw new ArgumentNullException(nameof(serverName));
            }
            if (jobAgentName == null)
            {
                throw new ArgumentNullException(nameof(jobAgentName));
            }

            Page<JobExecution> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("JobExecutionsOperations.ListByAgent");
                scope.Start();
                try
                {
                    var response = RestClient.ListByAgent(resourceGroupName, serverName, jobAgentName, createTimeMin, createTimeMax, endTimeMin, endTimeMax, isActive, skip, top, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<JobExecution> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("JobExecutionsOperations.ListByAgent");
                scope.Start();
                try
                {
                    var response = RestClient.ListByAgentNextPage(nextLink, resourceGroupName, serverName, jobAgentName, createTimeMin, createTimeMax, endTimeMin, endTimeMax, isActive, skip, top, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Lists a job&apos;s executions. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="jobAgentName"> The name of the job agent. </param>
        /// <param name="jobName"> The name of the job to get. </param>
        /// <param name="createTimeMin"> If specified, only job executions created at or after the specified time are included. </param>
        /// <param name="createTimeMax"> If specified, only job executions created before the specified time are included. </param>
        /// <param name="endTimeMin"> If specified, only job executions completed at or after the specified time are included. </param>
        /// <param name="endTimeMax"> If specified, only job executions completed before the specified time are included. </param>
        /// <param name="isActive"> If specified, only active or only completed job executions are included. </param>
        /// <param name="skip"> The number of elements in the collection to skip. </param>
        /// <param name="top"> The number of elements to return from the collection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="serverName"/>, <paramref name="jobAgentName"/>, or <paramref name="jobName"/> is null. </exception>
        public virtual AsyncPageable<JobExecution> ListByJobAsync(string resourceGroupName, string serverName, string jobAgentName, string jobName, DateTimeOffset? createTimeMin = null, DateTimeOffset? createTimeMax = null, DateTimeOffset? endTimeMin = null, DateTimeOffset? endTimeMax = null, bool? isActive = null, int? skip = null, int? top = null, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (serverName == null)
            {
                throw new ArgumentNullException(nameof(serverName));
            }
            if (jobAgentName == null)
            {
                throw new ArgumentNullException(nameof(jobAgentName));
            }
            if (jobName == null)
            {
                throw new ArgumentNullException(nameof(jobName));
            }

            async Task<Page<JobExecution>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("JobExecutionsOperations.ListByJob");
                scope.Start();
                try
                {
                    var response = await RestClient.ListByJobAsync(resourceGroupName, serverName, jobAgentName, jobName, createTimeMin, createTimeMax, endTimeMin, endTimeMax, isActive, skip, top, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<JobExecution>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("JobExecutionsOperations.ListByJob");
                scope.Start();
                try
                {
                    var response = await RestClient.ListByJobNextPageAsync(nextLink, resourceGroupName, serverName, jobAgentName, jobName, createTimeMin, createTimeMax, endTimeMin, endTimeMax, isActive, skip, top, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Lists a job&apos;s executions. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="jobAgentName"> The name of the job agent. </param>
        /// <param name="jobName"> The name of the job to get. </param>
        /// <param name="createTimeMin"> If specified, only job executions created at or after the specified time are included. </param>
        /// <param name="createTimeMax"> If specified, only job executions created before the specified time are included. </param>
        /// <param name="endTimeMin"> If specified, only job executions completed at or after the specified time are included. </param>
        /// <param name="endTimeMax"> If specified, only job executions completed before the specified time are included. </param>
        /// <param name="isActive"> If specified, only active or only completed job executions are included. </param>
        /// <param name="skip"> The number of elements in the collection to skip. </param>
        /// <param name="top"> The number of elements to return from the collection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="serverName"/>, <paramref name="jobAgentName"/>, or <paramref name="jobName"/> is null. </exception>
        public virtual Pageable<JobExecution> ListByJob(string resourceGroupName, string serverName, string jobAgentName, string jobName, DateTimeOffset? createTimeMin = null, DateTimeOffset? createTimeMax = null, DateTimeOffset? endTimeMin = null, DateTimeOffset? endTimeMax = null, bool? isActive = null, int? skip = null, int? top = null, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (serverName == null)
            {
                throw new ArgumentNullException(nameof(serverName));
            }
            if (jobAgentName == null)
            {
                throw new ArgumentNullException(nameof(jobAgentName));
            }
            if (jobName == null)
            {
                throw new ArgumentNullException(nameof(jobName));
            }

            Page<JobExecution> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("JobExecutionsOperations.ListByJob");
                scope.Start();
                try
                {
                    var response = RestClient.ListByJob(resourceGroupName, serverName, jobAgentName, jobName, createTimeMin, createTimeMax, endTimeMin, endTimeMax, isActive, skip, top, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<JobExecution> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("JobExecutionsOperations.ListByJob");
                scope.Start();
                try
                {
                    var response = RestClient.ListByJobNextPage(nextLink, resourceGroupName, serverName, jobAgentName, jobName, createTimeMin, createTimeMax, endTimeMin, endTimeMax, isActive, skip, top, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Starts an elastic job execution. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="jobAgentName"> The name of the job agent. </param>
        /// <param name="jobName"> The name of the job to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="serverName"/>, <paramref name="jobAgentName"/>, or <paramref name="jobName"/> is null. </exception>
        public virtual async Task<JobExecutionsCreateOperation> StartCreateAsync(string resourceGroupName, string serverName, string jobAgentName, string jobName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (serverName == null)
            {
                throw new ArgumentNullException(nameof(serverName));
            }
            if (jobAgentName == null)
            {
                throw new ArgumentNullException(nameof(jobAgentName));
            }
            if (jobName == null)
            {
                throw new ArgumentNullException(nameof(jobName));
            }

            using var scope = _clientDiagnostics.CreateScope("JobExecutionsOperations.StartCreate");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.CreateAsync(resourceGroupName, serverName, jobAgentName, jobName, cancellationToken).ConfigureAwait(false);
                return new JobExecutionsCreateOperation(_clientDiagnostics, _pipeline, RestClient.CreateCreateRequest(resourceGroupName, serverName, jobAgentName, jobName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Starts an elastic job execution. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="jobAgentName"> The name of the job agent. </param>
        /// <param name="jobName"> The name of the job to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="serverName"/>, <paramref name="jobAgentName"/>, or <paramref name="jobName"/> is null. </exception>
        public virtual JobExecutionsCreateOperation StartCreate(string resourceGroupName, string serverName, string jobAgentName, string jobName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (serverName == null)
            {
                throw new ArgumentNullException(nameof(serverName));
            }
            if (jobAgentName == null)
            {
                throw new ArgumentNullException(nameof(jobAgentName));
            }
            if (jobName == null)
            {
                throw new ArgumentNullException(nameof(jobName));
            }

            using var scope = _clientDiagnostics.CreateScope("JobExecutionsOperations.StartCreate");
            scope.Start();
            try
            {
                var originalResponse = RestClient.Create(resourceGroupName, serverName, jobAgentName, jobName, cancellationToken);
                return new JobExecutionsCreateOperation(_clientDiagnostics, _pipeline, RestClient.CreateCreateRequest(resourceGroupName, serverName, jobAgentName, jobName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates a job execution. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="jobAgentName"> The name of the job agent. </param>
        /// <param name="jobName"> The name of the job to get. </param>
        /// <param name="jobExecutionId"> The job execution id to create the job execution under. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="serverName"/>, <paramref name="jobAgentName"/>, or <paramref name="jobName"/> is null. </exception>
        public virtual async Task<JobExecutionsCreateOrUpdateOperation> StartCreateOrUpdateAsync(string resourceGroupName, string serverName, string jobAgentName, string jobName, Guid jobExecutionId, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (serverName == null)
            {
                throw new ArgumentNullException(nameof(serverName));
            }
            if (jobAgentName == null)
            {
                throw new ArgumentNullException(nameof(jobAgentName));
            }
            if (jobName == null)
            {
                throw new ArgumentNullException(nameof(jobName));
            }

            using var scope = _clientDiagnostics.CreateScope("JobExecutionsOperations.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.CreateOrUpdateAsync(resourceGroupName, serverName, jobAgentName, jobName, jobExecutionId, cancellationToken).ConfigureAwait(false);
                return new JobExecutionsCreateOrUpdateOperation(_clientDiagnostics, _pipeline, RestClient.CreateCreateOrUpdateRequest(resourceGroupName, serverName, jobAgentName, jobName, jobExecutionId).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates a job execution. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="jobAgentName"> The name of the job agent. </param>
        /// <param name="jobName"> The name of the job to get. </param>
        /// <param name="jobExecutionId"> The job execution id to create the job execution under. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="serverName"/>, <paramref name="jobAgentName"/>, or <paramref name="jobName"/> is null. </exception>
        public virtual JobExecutionsCreateOrUpdateOperation StartCreateOrUpdate(string resourceGroupName, string serverName, string jobAgentName, string jobName, Guid jobExecutionId, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (serverName == null)
            {
                throw new ArgumentNullException(nameof(serverName));
            }
            if (jobAgentName == null)
            {
                throw new ArgumentNullException(nameof(jobAgentName));
            }
            if (jobName == null)
            {
                throw new ArgumentNullException(nameof(jobName));
            }

            using var scope = _clientDiagnostics.CreateScope("JobExecutionsOperations.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var originalResponse = RestClient.CreateOrUpdate(resourceGroupName, serverName, jobAgentName, jobName, jobExecutionId, cancellationToken);
                return new JobExecutionsCreateOrUpdateOperation(_clientDiagnostics, _pipeline, RestClient.CreateCreateOrUpdateRequest(resourceGroupName, serverName, jobAgentName, jobName, jobExecutionId).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
