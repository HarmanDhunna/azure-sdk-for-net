// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    internal partial class DataResidency : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ResidencyType))
            {
                writer.WritePropertyName("type");
                writer.WriteStringValue(ResidencyType.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static DataResidency DeserializeDataResidency(JsonElement element)
        {
            Optional<DataResidencyType> type = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    type = new DataResidencyType(property.Value.GetString());
                    continue;
                }
            }
            return new DataResidency(Optional.ToNullable(type));
        }
    }
}
