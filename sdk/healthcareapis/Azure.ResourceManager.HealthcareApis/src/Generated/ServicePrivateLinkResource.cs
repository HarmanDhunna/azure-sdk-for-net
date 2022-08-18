// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.HealthcareApis
{
    /// <summary>
    /// A Class representing a ServicePrivateLinkResource along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="ServicePrivateLinkResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetServicePrivateLinkResource method.
    /// Otherwise you can get one from its parent resource <see cref="ServicesDescriptionResource" /> using the GetServicePrivateLinkResource method.
    /// </summary>
    public partial class ServicePrivateLinkResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ServicePrivateLinkResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string resourceName, string groupName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HealthcareApis/services/{resourceName}/privateLinkResources/{groupName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _servicePrivateLinkResourcePrivateLinkResourcesClientDiagnostics;
        private readonly PrivateLinkResourcesRestOperations _servicePrivateLinkResourcePrivateLinkResourcesRestClient;
        private readonly PrivateLinkResourceDescriptionData _data;

        /// <summary> Initializes a new instance of the <see cref="ServicePrivateLinkResource"/> class for mocking. </summary>
        protected ServicePrivateLinkResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "ServicePrivateLinkResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ServicePrivateLinkResource(ArmClient client, PrivateLinkResourceDescriptionData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="ServicePrivateLinkResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ServicePrivateLinkResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _servicePrivateLinkResourcePrivateLinkResourcesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.HealthcareApis", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string servicePrivateLinkResourcePrivateLinkResourcesApiVersion);
            _servicePrivateLinkResourcePrivateLinkResourcesRestClient = new PrivateLinkResourcesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, servicePrivateLinkResourcePrivateLinkResourcesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.HealthcareApis/services/privateLinkResources";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual PrivateLinkResourceDescriptionData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets a private link resource that need to be created for a service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HealthcareApis/services/{resourceName}/privateLinkResources/{groupName}
        /// Operation Id: PrivateLinkResources_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ServicePrivateLinkResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _servicePrivateLinkResourcePrivateLinkResourcesClientDiagnostics.CreateScope("ServicePrivateLinkResource.Get");
            scope.Start();
            try
            {
                var response = await _servicePrivateLinkResourcePrivateLinkResourcesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServicePrivateLinkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a private link resource that need to be created for a service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HealthcareApis/services/{resourceName}/privateLinkResources/{groupName}
        /// Operation Id: PrivateLinkResources_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ServicePrivateLinkResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _servicePrivateLinkResourcePrivateLinkResourcesClientDiagnostics.CreateScope("ServicePrivateLinkResource.Get");
            scope.Start();
            try
            {
                var response = _servicePrivateLinkResourcePrivateLinkResourcesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServicePrivateLinkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
