// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Resources.Models
{
    public partial class DeploymentProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(TemplateJson))
            {
                writer.WritePropertyName("template");
                TemplateJson.WriteTo(writer);
            }
            if (Optional.IsDefined(TemplateLink))
            {
                writer.WritePropertyName("templateLink");
                writer.WriteObjectValue(TemplateLink);
            }
            if (Optional.IsDefined(ParametersJson))
            {
                writer.WritePropertyName("parameters");
                ParametersJson.WriteTo(writer);
            }
            if (Optional.IsDefined(ParametersLink))
            {
                writer.WritePropertyName("parametersLink");
                writer.WriteObjectValue(ParametersLink);
            }
            writer.WritePropertyName("mode");
            writer.WriteStringValue(Mode.ToSerialString());
            if (Optional.IsDefined(DebugSetting))
            {
                writer.WritePropertyName("debugSetting");
                writer.WriteObjectValue(DebugSetting);
            }
            if (Optional.IsDefined(OnErrorDeployment))
            {
                writer.WritePropertyName("onErrorDeployment");
                writer.WriteObjectValue(OnErrorDeployment);
            }
            writer.WriteEndObject();
        }
    }
}