// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.HDInsight.Job.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class SparkStatementRequest
    {
        /// <summary>
        /// Initializes a new instance of the SparkStatementRequest class.
        /// </summary>
        public SparkStatementRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SparkStatementRequest class.
        /// </summary>
        /// <param name="kind">Possible values include: 'spark', 'pyspark',
        /// 'sparkr', 'sql'</param>
        public SparkStatementRequest(string code = default(string), string kind = default(string))
        {
            Code = code;
            Kind = kind;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "code")]
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'spark', 'pyspark', 'sparkr',
        /// 'sql'
        /// </summary>
        [JsonProperty(PropertyName = "kind")]
        public string Kind { get; set; }

    }
}