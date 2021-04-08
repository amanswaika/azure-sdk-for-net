// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.Backup.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// AzureWorkload workload-specific backup request.
    /// </summary>
    public partial class AzureWorkloadBackupRequest : BackupRequest
    {
        /// <summary>
        /// Initializes a new instance of the AzureWorkloadBackupRequest class.
        /// </summary>
        public AzureWorkloadBackupRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AzureWorkloadBackupRequest class.
        /// </summary>
        /// <param name="backupType">Type of backup, viz. Full, Differential,
        /// Log or CopyOnlyFull. Possible values include: 'Invalid', 'Full',
        /// 'Differential', 'Log', 'CopyOnlyFull', 'Incremental'</param>
        /// <param name="enableCompression">Bool for Compression
        /// setting</param>
        /// <param name="recoveryPointExpiryTimeInUTC">Backup copy will expire
        /// after the time specified (UTC).</param>
        public AzureWorkloadBackupRequest(string backupType = default(string), bool? enableCompression = default(bool?), System.DateTime? recoveryPointExpiryTimeInUTC = default(System.DateTime?))
        {
            BackupType = backupType;
            EnableCompression = enableCompression;
            RecoveryPointExpiryTimeInUTC = recoveryPointExpiryTimeInUTC;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets type of backup, viz. Full, Differential, Log or
        /// CopyOnlyFull. Possible values include: 'Invalid', 'Full',
        /// 'Differential', 'Log', 'CopyOnlyFull', 'Incremental'
        /// </summary>
        [JsonProperty(PropertyName = "backupType")]
        public string BackupType { get; set; }

        /// <summary>
        /// Gets or sets bool for Compression setting
        /// </summary>
        [JsonProperty(PropertyName = "enableCompression")]
        public bool? EnableCompression { get; set; }

        /// <summary>
        /// Gets or sets backup copy will expire after the time specified
        /// (UTC).
        /// </summary>
        [JsonProperty(PropertyName = "recoveryPointExpiryTimeInUTC")]
        public System.DateTime? RecoveryPointExpiryTimeInUTC { get; set; }

    }
}
