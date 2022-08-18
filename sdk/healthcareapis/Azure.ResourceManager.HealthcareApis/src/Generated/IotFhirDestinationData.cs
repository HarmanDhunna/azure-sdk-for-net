// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure;
using Azure.Core;
using Azure.ResourceManager.HealthcareApis.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.HealthcareApis
{
    /// <summary> A class representing the IotFhirDestination data model. </summary>
    public partial class IotFhirDestinationData : ResourceData
    {
        /// <summary> Initializes a new instance of IotFhirDestinationData. </summary>
        /// <param name="resourceIdentityResolutionType"> Determines how resource identity is resolved on the destination. </param>
        /// <param name="fhirServiceResourceId"> Fully qualified resource id of the FHIR service to connect to. </param>
        /// <param name="fhirMapping"> FHIR Mappings. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="fhirServiceResourceId"/> or <paramref name="fhirMapping"/> is null. </exception>
        public IotFhirDestinationData(IotIdentityResolutionType resourceIdentityResolutionType, string fhirServiceResourceId, IotMappingProperties fhirMapping)
        {
            if (fhirServiceResourceId == null)
            {
                throw new ArgumentNullException(nameof(fhirServiceResourceId));
            }
            if (fhirMapping == null)
            {
                throw new ArgumentNullException(nameof(fhirMapping));
            }

            ResourceIdentityResolutionType = resourceIdentityResolutionType;
            FhirServiceResourceId = fhirServiceResourceId;
            FhirMapping = fhirMapping;
        }

        /// <summary> Initializes a new instance of IotFhirDestinationData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="provisioningState"> The provisioning state. </param>
        /// <param name="resourceIdentityResolutionType"> Determines how resource identity is resolved on the destination. </param>
        /// <param name="fhirServiceResourceId"> Fully qualified resource id of the FHIR service to connect to. </param>
        /// <param name="fhirMapping"> FHIR Mappings. </param>
        /// <param name="location"> The resource location. </param>
        /// <param name="etag"> An etag associated with the resource, used for optimistic concurrency when editing it. </param>
        internal IotFhirDestinationData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, ProvisioningState? provisioningState, IotIdentityResolutionType resourceIdentityResolutionType, string fhirServiceResourceId, IotMappingProperties fhirMapping, AzureLocation? location, ETag? etag) : base(id, name, resourceType, systemData)
        {
            ProvisioningState = provisioningState;
            ResourceIdentityResolutionType = resourceIdentityResolutionType;
            FhirServiceResourceId = fhirServiceResourceId;
            FhirMapping = fhirMapping;
            Location = location;
            ETag = etag;
        }

        /// <summary> The provisioning state. </summary>
        public ProvisioningState? ProvisioningState { get; }
        /// <summary> Determines how resource identity is resolved on the destination. </summary>
        public IotIdentityResolutionType ResourceIdentityResolutionType { get; set; }
        /// <summary> Fully qualified resource id of the FHIR service to connect to. </summary>
        public string FhirServiceResourceId { get; set; }
        /// <summary> FHIR Mappings. </summary>
        internal IotMappingProperties FhirMapping { get; set; }
        /// <summary> The mapping. </summary>
        public BinaryData FhirMappingContent
        {
            get => FhirMapping is null ? default : FhirMapping.Content;
            set
            {
                if (FhirMapping is null)
                    FhirMapping = new IotMappingProperties();
                FhirMapping.Content = value;
            }
        }

        /// <summary> The resource location. </summary>
        public AzureLocation? Location { get; set; }
        /// <summary> An etag associated with the resource, used for optimistic concurrency when editing it. </summary>
        public ETag? ETag { get; set; }
    }
}
