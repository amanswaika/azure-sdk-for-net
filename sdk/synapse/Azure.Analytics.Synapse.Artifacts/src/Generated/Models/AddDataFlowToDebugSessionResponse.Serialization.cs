// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    public partial class AddDataFlowToDebugSessionResponse
    {
        internal static AddDataFlowToDebugSessionResponse DeserializeAddDataFlowToDebugSessionResponse(JsonElement element)
        {
            Optional<string> jobVersion = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("jobVersion"))
                {
                    jobVersion = property.Value.GetString();
                    continue;
                }
            }
            return new AddDataFlowToDebugSessionResponse(jobVersion.Value);
        }
    }
}