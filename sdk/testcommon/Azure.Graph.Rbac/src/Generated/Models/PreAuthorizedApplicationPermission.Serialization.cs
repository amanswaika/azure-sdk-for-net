// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Graph.Rbac.Models
{
    public partial class PreAuthorizedApplicationPermission : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(DirectAccessGrant))
            {
                writer.WritePropertyName("directAccessGrant");
                writer.WriteBooleanValue(DirectAccessGrant.Value);
            }
            if (Optional.IsCollectionDefined(AccessGrants))
            {
                writer.WritePropertyName("accessGrants");
                writer.WriteStartArray();
                foreach (var item in AccessGrants)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static PreAuthorizedApplicationPermission DeserializePreAuthorizedApplicationPermission(JsonElement element)
        {
            Optional<bool> directAccessGrant = default;
            Optional<IList<string>> accessGrants = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("directAccessGrant"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    directAccessGrant = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("accessGrants"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    accessGrants = array;
                    continue;
                }
            }
            return new PreAuthorizedApplicationPermission(Optional.ToNullable(directAccessGrant), Optional.ToList(accessGrants));
        }
    }
}
