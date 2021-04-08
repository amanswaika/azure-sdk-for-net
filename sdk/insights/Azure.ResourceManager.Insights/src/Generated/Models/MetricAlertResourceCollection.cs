// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Insights.Models
{
    /// <summary> Represents a collection of alert rule resources. </summary>
    internal partial class MetricAlertResourceCollection
    {
        /// <summary> Initializes a new instance of MetricAlertResourceCollection. </summary>
        internal MetricAlertResourceCollection()
        {
            Value = new ChangeTrackingList<MetricAlertResource>();
        }

        /// <summary> Initializes a new instance of MetricAlertResourceCollection. </summary>
        /// <param name="value"> the values for the alert rule resources. </param>
        internal MetricAlertResourceCollection(IReadOnlyList<MetricAlertResource> value)
        {
            Value = value;
        }

        /// <summary> the values for the alert rule resources. </summary>
        public IReadOnlyList<MetricAlertResource> Value { get; }
    }
}
