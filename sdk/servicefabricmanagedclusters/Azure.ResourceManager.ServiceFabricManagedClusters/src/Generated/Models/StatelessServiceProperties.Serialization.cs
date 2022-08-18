// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    public partial class StatelessServiceProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("instanceCount");
            writer.WriteNumberValue(InstanceCount);
            if (Optional.IsDefined(MinInstanceCount))
            {
                writer.WritePropertyName("minInstanceCount");
                writer.WriteNumberValue(MinInstanceCount.Value);
            }
            if (Optional.IsDefined(MinInstancePercentage))
            {
                writer.WritePropertyName("minInstancePercentage");
                writer.WriteNumberValue(MinInstancePercentage.Value);
            }
            writer.WritePropertyName("serviceKind");
            writer.WriteStringValue(ServiceKind.ToString());
            writer.WritePropertyName("serviceTypeName");
            writer.WriteStringValue(ServiceTypeName);
            writer.WritePropertyName("partitionDescription");
            writer.WriteObjectValue(PartitionDescription);
            if (Optional.IsDefined(ServicePackageActivationMode))
            {
                writer.WritePropertyName("servicePackageActivationMode");
                writer.WriteStringValue(ServicePackageActivationMode.Value.ToString());
            }
            if (Optional.IsDefined(PlacementConstraints))
            {
                writer.WritePropertyName("placementConstraints");
                writer.WriteStringValue(PlacementConstraints);
            }
            if (Optional.IsCollectionDefined(CorrelationScheme))
            {
                writer.WritePropertyName("correlationScheme");
                writer.WriteStartArray();
                foreach (var item in CorrelationScheme)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ServiceLoadMetrics))
            {
                writer.WritePropertyName("serviceLoadMetrics");
                writer.WriteStartArray();
                foreach (var item in ServiceLoadMetrics)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ServicePlacementPolicies))
            {
                writer.WritePropertyName("servicePlacementPolicies");
                writer.WriteStartArray();
                foreach (var item in ServicePlacementPolicies)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(DefaultMoveCost))
            {
                writer.WritePropertyName("defaultMoveCost");
                writer.WriteStringValue(DefaultMoveCost.Value.ToString());
            }
            if (Optional.IsCollectionDefined(ScalingPolicies))
            {
                writer.WritePropertyName("scalingPolicies");
                writer.WriteStartArray();
                foreach (var item in ScalingPolicies)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static StatelessServiceProperties DeserializeStatelessServiceProperties(JsonElement element)
        {
            int instanceCount = default;
            Optional<int> minInstanceCount = default;
            Optional<int> minInstancePercentage = default;
            Optional<string> provisioningState = default;
            ServiceKind serviceKind = default;
            string serviceTypeName = default;
            Partition partitionDescription = default;
            Optional<ServicePackageActivationMode> servicePackageActivationMode = default;
            Optional<string> placementConstraints = default;
            Optional<IList<ServiceCorrelation>> correlationScheme = default;
            Optional<IList<ServiceLoadMetric>> serviceLoadMetrics = default;
            Optional<IList<ServicePlacementPolicy>> servicePlacementPolicies = default;
            Optional<MoveCost> defaultMoveCost = default;
            Optional<IList<ScalingPolicy>> scalingPolicies = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("instanceCount"))
                {
                    instanceCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("minInstanceCount"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    minInstanceCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("minInstancePercentage"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    minInstancePercentage = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("provisioningState"))
                {
                    provisioningState = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("serviceKind"))
                {
                    serviceKind = new ServiceKind(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("serviceTypeName"))
                {
                    serviceTypeName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("partitionDescription"))
                {
                    partitionDescription = Partition.DeserializePartition(property.Value);
                    continue;
                }
                if (property.NameEquals("servicePackageActivationMode"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    servicePackageActivationMode = new ServicePackageActivationMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("placementConstraints"))
                {
                    placementConstraints = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("correlationScheme"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ServiceCorrelation> array = new List<ServiceCorrelation>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ServiceCorrelation.DeserializeServiceCorrelation(item));
                    }
                    correlationScheme = array;
                    continue;
                }
                if (property.NameEquals("serviceLoadMetrics"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ServiceLoadMetric> array = new List<ServiceLoadMetric>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ServiceLoadMetric.DeserializeServiceLoadMetric(item));
                    }
                    serviceLoadMetrics = array;
                    continue;
                }
                if (property.NameEquals("servicePlacementPolicies"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ServicePlacementPolicy> array = new List<ServicePlacementPolicy>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ServicePlacementPolicy.DeserializeServicePlacementPolicy(item));
                    }
                    servicePlacementPolicies = array;
                    continue;
                }
                if (property.NameEquals("defaultMoveCost"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    defaultMoveCost = new MoveCost(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("scalingPolicies"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ScalingPolicy> array = new List<ScalingPolicy>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ScalingPolicy.DeserializeScalingPolicy(item));
                    }
                    scalingPolicies = array;
                    continue;
                }
            }
            return new StatelessServiceProperties(placementConstraints.Value, Optional.ToList(correlationScheme), Optional.ToList(serviceLoadMetrics), Optional.ToList(servicePlacementPolicies), Optional.ToNullable(defaultMoveCost), Optional.ToList(scalingPolicies), provisioningState.Value, serviceKind, serviceTypeName, partitionDescription, Optional.ToNullable(servicePackageActivationMode), instanceCount, Optional.ToNullable(minInstanceCount), Optional.ToNullable(minInstancePercentage));
        }
    }
}
