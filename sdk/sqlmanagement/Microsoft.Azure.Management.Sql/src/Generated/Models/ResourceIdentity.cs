// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Sql.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Azure Active Directory identity configuration for a resource.
    /// </summary>
    public partial class ResourceIdentity
    {
        /// <summary>
        /// Initializes a new instance of the ResourceIdentity class.
        /// </summary>
        public ResourceIdentity()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ResourceIdentity class.
        /// </summary>
        /// <param name="principalId">The Azure Active Directory principal
        /// id.</param>
        /// <param name="type">The identity type. Set this to 'SystemAssigned'
        /// in order to automatically create and assign an Azure Active
        /// Directory principal for the resource. Possible values include:
        /// 'None', 'SystemAssigned', 'UserAssigned'</param>
        /// <param name="tenantId">The Azure Active Directory tenant
        /// id.</param>
        public ResourceIdentity(System.Guid? principalId = default(System.Guid?), string type = default(string), System.Guid? tenantId = default(System.Guid?))
        {
            PrincipalId = principalId;
            Type = type;
            TenantId = tenantId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the Azure Active Directory principal id.
        /// </summary>
        [JsonProperty(PropertyName = "principalId")]
        public System.Guid? PrincipalId { get; private set; }

        /// <summary>
        /// Gets or sets the identity type. Set this to 'SystemAssigned' in
        /// order to automatically create and assign an Azure Active Directory
        /// principal for the resource. Possible values include: 'None',
        /// 'SystemAssigned', 'UserAssigned'
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets the Azure Active Directory tenant id.
        /// </summary>
        [JsonProperty(PropertyName = "tenantId")]
        public System.Guid? TenantId { get; private set; }

    }
}
