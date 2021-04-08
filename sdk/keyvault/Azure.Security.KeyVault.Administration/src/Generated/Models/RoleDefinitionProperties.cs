// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.Security.KeyVault.Administration;

namespace Azure.Security.KeyVault.Administration.Models
{
    /// <summary> Role definition properties. </summary>
    internal partial class RoleDefinitionProperties
    {
        /// <summary> Initializes a new instance of RoleDefinitionProperties. </summary>
        public RoleDefinitionProperties()
        {
            Permissions = new ChangeTrackingList<KeyVaultPermission>();
            AssignableScopes = new ChangeTrackingList<KeyVaultRoleScope>();
        }

        /// <summary> The role name. </summary>
        public string RoleName { get; set; }
        /// <summary> The role definition description. </summary>
        public string Description { get; set; }
        /// <summary> The role type. </summary>
        public KeyVaultRoleType? RoleType { get; set; }
        /// <summary> Role definition permissions. </summary>
        public IList<KeyVaultPermission> Permissions { get; }
        /// <summary> Role definition assignable scopes. </summary>
        public IList<KeyVaultRoleScope> AssignableScopes { get; }
    }
}
