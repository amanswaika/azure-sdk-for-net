// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class DedicatedHostListResult
    {
        internal static DedicatedHostListResult DeserializeDedicatedHostListResult(JsonElement element)
        {
            IReadOnlyList<DedicatedHost> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    List<DedicatedHost> array = new List<DedicatedHost>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DedicatedHost.DeserializeDedicatedHost(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new DedicatedHostListResult(value, nextLink.Value);
        }
    }
}