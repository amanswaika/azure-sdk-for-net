// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Resources.Models
{
    public partial class ContainerConfiguration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ContainerGroupName))
            {
                writer.WritePropertyName("containerGroupName");
                writer.WriteStringValue(ContainerGroupName);
            }
            writer.WriteEndObject();
        }

        internal static ContainerConfiguration DeserializeContainerConfiguration(JsonElement element)
        {
            Optional<string> containerGroupName = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("containerGroupName"))
                {
                    containerGroupName = property.Value.GetString();
                    continue;
                }
            }
            return new ContainerConfiguration(containerGroupName.Value);
        }
    }
}