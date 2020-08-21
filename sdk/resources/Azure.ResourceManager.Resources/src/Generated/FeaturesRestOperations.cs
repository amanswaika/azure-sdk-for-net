// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Resources
{
    internal partial class FeaturesRestOperations
    {
        private string subscriptionId;
        private Uri endpoint;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;

        /// <summary> Initializes a new instance of FeaturesRestOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> is null. </exception>
        public FeaturesRestOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            endpoint ??= new Uri("https://management.azure.com");

            this.subscriptionId = subscriptionId;
            this.endpoint = endpoint;
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        internal Core.HttpMessage CreateListAllRequest()
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/Microsoft.Features/features", false);
            uri.AppendQuery("api-version", "2015-12-01", true);
            request.Uri = uri;
            return message;
        }

        /// <summary> Gets all the preview features that are available through AFEC for the subscription. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<FeatureOperationsListResult>> ListAllAsync(CancellationToken cancellationToken = default)
        {
            using var message = CreateListAllRequest();
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        FeatureOperationsListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = FeatureOperationsListResult.DeserializeFeatureOperationsListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets all the preview features that are available through AFEC for the subscription. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<FeatureOperationsListResult> ListAll(CancellationToken cancellationToken = default)
        {
            using var message = CreateListAllRequest();
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        FeatureOperationsListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = FeatureOperationsListResult.DeserializeFeatureOperationsListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal Core.HttpMessage CreateListRequest(string resourceProviderNamespace)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/Microsoft.Features/providers/", false);
            uri.AppendPath(resourceProviderNamespace, true);
            uri.AppendPath("/features", false);
            uri.AppendQuery("api-version", "2015-12-01", true);
            request.Uri = uri;
            return message;
        }

        /// <summary> Gets all the preview features in a provider namespace that are available through AFEC for the subscription. </summary>
        /// <param name="resourceProviderNamespace"> The namespace of the resource provider for getting features. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceProviderNamespace"/> is null. </exception>
        public async Task<Response<FeatureOperationsListResult>> ListAsync(string resourceProviderNamespace, CancellationToken cancellationToken = default)
        {
            if (resourceProviderNamespace == null)
            {
                throw new ArgumentNullException(nameof(resourceProviderNamespace));
            }

            using var message = CreateListRequest(resourceProviderNamespace);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        FeatureOperationsListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = FeatureOperationsListResult.DeserializeFeatureOperationsListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets all the preview features in a provider namespace that are available through AFEC for the subscription. </summary>
        /// <param name="resourceProviderNamespace"> The namespace of the resource provider for getting features. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceProviderNamespace"/> is null. </exception>
        public Response<FeatureOperationsListResult> List(string resourceProviderNamespace, CancellationToken cancellationToken = default)
        {
            if (resourceProviderNamespace == null)
            {
                throw new ArgumentNullException(nameof(resourceProviderNamespace));
            }

            using var message = CreateListRequest(resourceProviderNamespace);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        FeatureOperationsListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = FeatureOperationsListResult.DeserializeFeatureOperationsListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal Core.HttpMessage CreateGetRequest(string resourceProviderNamespace, string featureName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/Microsoft.Features/providers/", false);
            uri.AppendPath(resourceProviderNamespace, true);
            uri.AppendPath("/features/", false);
            uri.AppendPath(featureName, true);
            uri.AppendQuery("api-version", "2015-12-01", true);
            request.Uri = uri;
            return message;
        }

        /// <summary> Gets the preview feature with the specified name. </summary>
        /// <param name="resourceProviderNamespace"> The resource provider namespace for the feature. </param>
        /// <param name="featureName"> The name of the feature to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceProviderNamespace"/> or <paramref name="featureName"/> is null. </exception>
        public async Task<Response<FeatureResult>> GetAsync(string resourceProviderNamespace, string featureName, CancellationToken cancellationToken = default)
        {
            if (resourceProviderNamespace == null)
            {
                throw new ArgumentNullException(nameof(resourceProviderNamespace));
            }
            if (featureName == null)
            {
                throw new ArgumentNullException(nameof(featureName));
            }

            using var message = CreateGetRequest(resourceProviderNamespace, featureName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        FeatureResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = FeatureResult.DeserializeFeatureResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets the preview feature with the specified name. </summary>
        /// <param name="resourceProviderNamespace"> The resource provider namespace for the feature. </param>
        /// <param name="featureName"> The name of the feature to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceProviderNamespace"/> or <paramref name="featureName"/> is null. </exception>
        public Response<FeatureResult> Get(string resourceProviderNamespace, string featureName, CancellationToken cancellationToken = default)
        {
            if (resourceProviderNamespace == null)
            {
                throw new ArgumentNullException(nameof(resourceProviderNamespace));
            }
            if (featureName == null)
            {
                throw new ArgumentNullException(nameof(featureName));
            }

            using var message = CreateGetRequest(resourceProviderNamespace, featureName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        FeatureResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = FeatureResult.DeserializeFeatureResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal Core.HttpMessage CreateRegisterRequest(string resourceProviderNamespace, string featureName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/Microsoft.Features/providers/", false);
            uri.AppendPath(resourceProviderNamespace, true);
            uri.AppendPath("/features/", false);
            uri.AppendPath(featureName, true);
            uri.AppendPath("/register", false);
            uri.AppendQuery("api-version", "2015-12-01", true);
            request.Uri = uri;
            return message;
        }

        /// <summary> Registers the preview feature for the subscription. </summary>
        /// <param name="resourceProviderNamespace"> The namespace of the resource provider. </param>
        /// <param name="featureName"> The name of the feature to register. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceProviderNamespace"/> or <paramref name="featureName"/> is null. </exception>
        public async Task<Response<FeatureResult>> RegisterAsync(string resourceProviderNamespace, string featureName, CancellationToken cancellationToken = default)
        {
            if (resourceProviderNamespace == null)
            {
                throw new ArgumentNullException(nameof(resourceProviderNamespace));
            }
            if (featureName == null)
            {
                throw new ArgumentNullException(nameof(featureName));
            }

            using var message = CreateRegisterRequest(resourceProviderNamespace, featureName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        FeatureResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = FeatureResult.DeserializeFeatureResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Registers the preview feature for the subscription. </summary>
        /// <param name="resourceProviderNamespace"> The namespace of the resource provider. </param>
        /// <param name="featureName"> The name of the feature to register. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceProviderNamespace"/> or <paramref name="featureName"/> is null. </exception>
        public Response<FeatureResult> Register(string resourceProviderNamespace, string featureName, CancellationToken cancellationToken = default)
        {
            if (resourceProviderNamespace == null)
            {
                throw new ArgumentNullException(nameof(resourceProviderNamespace));
            }
            if (featureName == null)
            {
                throw new ArgumentNullException(nameof(featureName));
            }

            using var message = CreateRegisterRequest(resourceProviderNamespace, featureName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        FeatureResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = FeatureResult.DeserializeFeatureResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal Core.HttpMessage CreateUnregisterRequest(string resourceProviderNamespace, string featureName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/Microsoft.Features/providers/", false);
            uri.AppendPath(resourceProviderNamespace, true);
            uri.AppendPath("/features/", false);
            uri.AppendPath(featureName, true);
            uri.AppendPath("/unregister", false);
            uri.AppendQuery("api-version", "2015-12-01", true);
            request.Uri = uri;
            return message;
        }

        /// <summary> Unregisters the preview feature for the subscription. </summary>
        /// <param name="resourceProviderNamespace"> The namespace of the resource provider. </param>
        /// <param name="featureName"> The name of the feature to unregister. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceProviderNamespace"/> or <paramref name="featureName"/> is null. </exception>
        public async Task<Response<FeatureResult>> UnregisterAsync(string resourceProviderNamespace, string featureName, CancellationToken cancellationToken = default)
        {
            if (resourceProviderNamespace == null)
            {
                throw new ArgumentNullException(nameof(resourceProviderNamespace));
            }
            if (featureName == null)
            {
                throw new ArgumentNullException(nameof(featureName));
            }

            using var message = CreateUnregisterRequest(resourceProviderNamespace, featureName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        FeatureResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = FeatureResult.DeserializeFeatureResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Unregisters the preview feature for the subscription. </summary>
        /// <param name="resourceProviderNamespace"> The namespace of the resource provider. </param>
        /// <param name="featureName"> The name of the feature to unregister. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceProviderNamespace"/> or <paramref name="featureName"/> is null. </exception>
        public Response<FeatureResult> Unregister(string resourceProviderNamespace, string featureName, CancellationToken cancellationToken = default)
        {
            if (resourceProviderNamespace == null)
            {
                throw new ArgumentNullException(nameof(resourceProviderNamespace));
            }
            if (featureName == null)
            {
                throw new ArgumentNullException(nameof(featureName));
            }

            using var message = CreateUnregisterRequest(resourceProviderNamespace, featureName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        FeatureResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = FeatureResult.DeserializeFeatureResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal Core.HttpMessage CreateListAllNextPageRequest(string nextLink)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            return message;
        }

        /// <summary> Gets all the preview features that are available through AFEC for the subscription. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> is null. </exception>
        public async Task<Response<FeatureOperationsListResult>> ListAllNextPageAsync(string nextLink, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }

            using var message = CreateListAllNextPageRequest(nextLink);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        FeatureOperationsListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = FeatureOperationsListResult.DeserializeFeatureOperationsListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets all the preview features that are available through AFEC for the subscription. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> is null. </exception>
        public Response<FeatureOperationsListResult> ListAllNextPage(string nextLink, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }

            using var message = CreateListAllNextPageRequest(nextLink);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        FeatureOperationsListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = FeatureOperationsListResult.DeserializeFeatureOperationsListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal Core.HttpMessage CreateListNextPageRequest(string nextLink, string resourceProviderNamespace)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            return message;
        }

        /// <summary> Gets all the preview features in a provider namespace that are available through AFEC for the subscription. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="resourceProviderNamespace"> The namespace of the resource provider for getting features. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> or <paramref name="resourceProviderNamespace"/> is null. </exception>
        public async Task<Response<FeatureOperationsListResult>> ListNextPageAsync(string nextLink, string resourceProviderNamespace, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (resourceProviderNamespace == null)
            {
                throw new ArgumentNullException(nameof(resourceProviderNamespace));
            }

            using var message = CreateListNextPageRequest(nextLink, resourceProviderNamespace);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        FeatureOperationsListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = FeatureOperationsListResult.DeserializeFeatureOperationsListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets all the preview features in a provider namespace that are available through AFEC for the subscription. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="resourceProviderNamespace"> The namespace of the resource provider for getting features. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> or <paramref name="resourceProviderNamespace"/> is null. </exception>
        public Response<FeatureOperationsListResult> ListNextPage(string nextLink, string resourceProviderNamespace, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (resourceProviderNamespace == null)
            {
                throw new ArgumentNullException(nameof(resourceProviderNamespace));
            }

            using var message = CreateListNextPageRequest(nextLink, resourceProviderNamespace);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        FeatureOperationsListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = FeatureOperationsListResult.DeserializeFeatureOperationsListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}