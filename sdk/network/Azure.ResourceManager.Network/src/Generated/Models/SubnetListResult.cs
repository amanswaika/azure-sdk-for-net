// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Response for ListSubnets API service callRetrieves all subnet that belongs to a virtual network. </summary>
    internal partial class SubnetListResult
    {
        /// <summary> Initializes a new instance of SubnetListResult. </summary>
        internal SubnetListResult()
        {
            Value = new ChangeTrackingList<Subnet>();
        }

        /// <summary> Initializes a new instance of SubnetListResult. </summary>
        /// <param name="value"> The subnets in a virtual network. </param>
        /// <param name="nextLink"> The URL to get the next set of results. </param>
        internal SubnetListResult(IReadOnlyList<Subnet> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The subnets in a virtual network. </summary>
        public IReadOnlyList<Subnet> Value { get; }
        /// <summary> The URL to get the next set of results. </summary>
        public string NextLink { get; }
    }
}
