// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> RerunTrigger resource type. </summary>
    public partial class RerunTriggerResource : SubResource
    {
        /// <summary> Initializes a new instance of RerunTriggerResource. </summary>
        /// <param name="properties"> Properties of the rerun trigger. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="properties"/> is null. </exception>
        public RerunTriggerResource(RerunTumblingWindowTrigger properties)
        {
            if (properties == null)
            {
                throw new ArgumentNullException(nameof(properties));
            }

            Properties = properties;
        }

        /// <summary> Initializes a new instance of RerunTriggerResource. </summary>
        /// <param name="id"> The resource identifier. </param>
        /// <param name="name"> The resource name. </param>
        /// <param name="type"> The resource type. </param>
        /// <param name="etag"> Etag identifies change in the resource. </param>
        /// <param name="properties"> Properties of the rerun trigger. </param>
        internal RerunTriggerResource(string id, string name, string type, string etag, RerunTumblingWindowTrigger properties) : base(id, name, type, etag)
        {
            Properties = properties;
        }

        /// <summary> Properties of the rerun trigger. </summary>
        public RerunTumblingWindowTrigger Properties { get; set; }
    }
}