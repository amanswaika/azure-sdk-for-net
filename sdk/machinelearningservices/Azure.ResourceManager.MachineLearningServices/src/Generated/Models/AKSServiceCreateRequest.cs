// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    /// <summary> The request to create an AKS service. </summary>
    public partial class AKSServiceCreateRequest : CreateEndpointVariantRequest
    {
        /// <summary> Initializes a new instance of AKSServiceCreateRequest. </summary>
        public AKSServiceCreateRequest()
        {
            ComputeType = ComputeEnvironmentType.AKS;
        }

        /// <summary> The number of replicas on the cluster. </summary>
        public int? NumReplicas { get; set; }
        /// <summary> Details of the data collection options specified. </summary>
        public AKSServiceCreateRequestDataCollection DataCollection { get; set; }
        /// <summary> The name of the compute resource. </summary>
        public string ComputeName { get; set; }
        /// <summary> Whether or not Application Insights is enabled. </summary>
        public bool? AppInsightsEnabled { get; set; }
        /// <summary> The auto scaler properties. </summary>
        public AKSServiceCreateRequestAutoScaler AutoScaler { get; set; }
        /// <summary> The container resource requirements. </summary>
        public ContainerResourceRequirements ContainerResourceRequirements { get; set; }
        /// <summary> The maximum number of concurrent requests per container. </summary>
        public int? MaxConcurrentRequestsPerContainer { get; set; }
        /// <summary> Maximum time a request will wait in the queue (in milliseconds). After this time, the service will return 503 (Service Unavailable). </summary>
        public int? MaxQueueWaitMs { get; set; }
        /// <summary> Kubernetes namespace for the service. </summary>
        public string Namespace { get; set; }
        /// <summary> The scoring timeout in milliseconds. </summary>
        public int? ScoringTimeoutMs { get; set; }
        /// <summary> Whether or not authentication is enabled. </summary>
        public bool? AuthEnabled { get; set; }
        /// <summary> The liveness probe requirements. </summary>
        public AKSServiceCreateRequestLivenessProbeRequirements LivenessProbeRequirements { get; set; }
        /// <summary> Whether or not AAD authentication is enabled. </summary>
        public bool? AadAuthEnabled { get; set; }
    }
}
