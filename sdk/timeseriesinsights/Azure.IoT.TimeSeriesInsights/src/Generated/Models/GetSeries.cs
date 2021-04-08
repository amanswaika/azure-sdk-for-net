// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.IoT.TimeSeriesInsights
{
    /// <summary> Get Series query. Allows to retrieve time series of calculated variable values from events for a given Time Series ID and search span. </summary>
    public partial class GetSeries
    {
        /// <summary> The range of time on which the query is executed. Cannot be null. </summary>
        public DateTimeRange SearchSpan { get; }
        /// <summary> Top-level filter over the events that restricts the number of events being considered for computation. This filter is AND&apos;ed with filter in each variable. Example: &quot;$event.Status.String=&apos;Good&apos;&quot;. Optional. </summary>
        public TimeSeriesExpression Filter { get; set; }
        /// <summary> Selected variables that needs to be projected in the query result. When it is null or not set, all the variables from inlineVariables and time series type in the model are returned. Can be null. </summary>
        public IList<string> ProjectedVariables { get; }
        /// <summary> Optional inline variables apart from the ones already defined in the time series type in the model. When the inline variable name is the same name as in the model, the inline variable definition takes precedence. Can be null. </summary>
        public IDictionary<string, TimeSeriesVariable> InlineVariables { get; }
        /// <summary> Maximum number of property values in the whole response set, not the maximum number of property values per page. Defaults to 10,000 when not set. Maximum value of take can be 250,000. </summary>
        public int? Take { get; set; }
    }
}
