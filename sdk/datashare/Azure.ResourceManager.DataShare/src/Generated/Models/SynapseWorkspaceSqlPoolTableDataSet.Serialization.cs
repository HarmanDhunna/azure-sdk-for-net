// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataShare.Models
{
    public partial class SynapseWorkspaceSqlPoolTableDataSet : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("kind");
            writer.WriteStringValue(Kind.ToString());
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            writer.WritePropertyName("synapseWorkspaceSqlPoolTableResourceId");
            writer.WriteStringValue(SynapseWorkspaceSqlPoolTableResourceId);
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static SynapseWorkspaceSqlPoolTableDataSet DeserializeSynapseWorkspaceSqlPoolTableDataSet(JsonElement element)
        {
            DataSetKind kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> dataSetId = default;
            string synapseWorkspaceSqlPoolTableResourceId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"))
                {
                    kind = new DataSetKind(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.ToString());
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
                        if (property0.NameEquals("dataSetId"))
                        {
                            dataSetId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("synapseWorkspaceSqlPoolTableResourceId"))
                        {
                            synapseWorkspaceSqlPoolTableResourceId = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new SynapseWorkspaceSqlPoolTableDataSet(id, name, type, systemData.Value, kind, dataSetId.Value, synapseWorkspaceSqlPoolTableResourceId);
        }
    }
}
