// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    public partial class ApplicationUserAssignedIdentity : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            writer.WritePropertyName("principalId");
            writer.WriteStringValue(PrincipalId);
            writer.WriteEndObject();
        }

        internal static ApplicationUserAssignedIdentity DeserializeApplicationUserAssignedIdentity(JsonElement element)
        {
            string name = default;
            string principalId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("principalId"))
                {
                    principalId = property.Value.GetString();
                    continue;
                }
            }
            return new ApplicationUserAssignedIdentity(name, principalId);
        }
    }
}
