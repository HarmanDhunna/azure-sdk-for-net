// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.FrontDoor.Models
{
    public partial class LoadBalancingSettingsModel : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id");
                writer.WriteStringValue(Id);
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(SampleSize))
            {
                writer.WritePropertyName("sampleSize");
                writer.WriteNumberValue(SampleSize.Value);
            }
            if (Optional.IsDefined(SuccessfulSamplesRequired))
            {
                writer.WritePropertyName("successfulSamplesRequired");
                writer.WriteNumberValue(SuccessfulSamplesRequired.Value);
            }
            if (Optional.IsDefined(AdditionalLatencyMilliseconds))
            {
                writer.WritePropertyName("additionalLatencyMilliseconds");
                writer.WriteNumberValue(AdditionalLatencyMilliseconds.Value);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static LoadBalancingSettingsModel DeserializeLoadBalancingSettingsModel(JsonElement element)
        {
            Optional<string> name = default;
            Optional<string> type = default;
            Optional<string> id = default;
            Optional<int> sampleSize = default;
            Optional<int> successfulSamplesRequired = default;
            Optional<int> additionalLatencyMilliseconds = default;
            Optional<FrontDoorResourceState> resourceState = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("sampleSize"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            sampleSize = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("successfulSamplesRequired"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            successfulSamplesRequired = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("additionalLatencyMilliseconds"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            additionalLatencyMilliseconds = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("resourceState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            resourceState = new FrontDoorResourceState(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new LoadBalancingSettingsModel(id.Value, name.Value, type.Value, Optional.ToNullable(sampleSize), Optional.ToNullable(successfulSamplesRequired), Optional.ToNullable(additionalLatencyMilliseconds), Optional.ToNullable(resourceState));
        }
    }
}
