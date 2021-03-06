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
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Contains the information necessary to perform import operation for new
    /// database.
    /// </summary>
    public partial class ImportNewDatabaseDefinition
    {
        /// <summary>
        /// Initializes a new instance of the ImportNewDatabaseDefinition
        /// class.
        /// </summary>
        public ImportNewDatabaseDefinition()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ImportNewDatabaseDefinition
        /// class.
        /// </summary>
        /// <param name="storageKeyType">Storage key type. Possible values
        /// include: 'SharedAccessKey', 'StorageAccessKey'</param>
        /// <param name="storageKey">Storage key.</param>
        /// <param name="storageUri">Storage Uri.</param>
        /// <param name="administratorLogin">Administrator login name.</param>
        /// <param name="administratorLoginPassword">Administrator login
        /// password.</param>
        /// <param name="databaseName">Name of the import database.</param>
        /// <param name="edition">Edition of the import database.</param>
        /// <param name="serviceObjectiveName">Service level objective name of
        /// the import database.</param>
        /// <param name="maxSizeBytes">Max size in bytes for the import
        /// database.</param>
        /// <param name="authenticationType">Authentication type.</param>
        /// <param name="networkIsolation">Optional resource information to
        /// enable network isolation for request.</param>
        public ImportNewDatabaseDefinition(string storageKeyType, string storageKey, string storageUri, string administratorLogin, string administratorLoginPassword, string databaseName = default(string), string edition = default(string), string serviceObjectiveName = default(string), string maxSizeBytes = default(string), string authenticationType = default(string), NetworkIsolationSettings networkIsolation = default(NetworkIsolationSettings))
        {
            DatabaseName = databaseName;
            Edition = edition;
            ServiceObjectiveName = serviceObjectiveName;
            MaxSizeBytes = maxSizeBytes;
            StorageKeyType = storageKeyType;
            StorageKey = storageKey;
            StorageUri = storageUri;
            AdministratorLogin = administratorLogin;
            AdministratorLoginPassword = administratorLoginPassword;
            AuthenticationType = authenticationType;
            NetworkIsolation = networkIsolation;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets name of the import database.
        /// </summary>
        [JsonProperty(PropertyName = "databaseName")]
        public string DatabaseName { get; set; }

        /// <summary>
        /// Gets or sets edition of the import database.
        /// </summary>
        [JsonProperty(PropertyName = "edition")]
        public string Edition { get; set; }

        /// <summary>
        /// Gets or sets service level objective name of the import database.
        /// </summary>
        [JsonProperty(PropertyName = "serviceObjectiveName")]
        public string ServiceObjectiveName { get; set; }

        /// <summary>
        /// Gets or sets max size in bytes for the import database.
        /// </summary>
        [JsonProperty(PropertyName = "maxSizeBytes")]
        public string MaxSizeBytes { get; set; }

        /// <summary>
        /// Gets or sets storage key type. Possible values include:
        /// 'SharedAccessKey', 'StorageAccessKey'
        /// </summary>
        [JsonProperty(PropertyName = "storageKeyType")]
        public string StorageKeyType { get; set; }

        /// <summary>
        /// Gets or sets storage key.
        /// </summary>
        [JsonProperty(PropertyName = "storageKey")]
        public string StorageKey { get; set; }

        /// <summary>
        /// Gets or sets storage Uri.
        /// </summary>
        [JsonProperty(PropertyName = "storageUri")]
        public string StorageUri { get; set; }

        /// <summary>
        /// Gets or sets administrator login name.
        /// </summary>
        [JsonProperty(PropertyName = "administratorLogin")]
        public string AdministratorLogin { get; set; }

        /// <summary>
        /// Gets or sets administrator login password.
        /// </summary>
        [JsonProperty(PropertyName = "administratorLoginPassword")]
        public string AdministratorLoginPassword { get; set; }

        /// <summary>
        /// Gets or sets authentication type.
        /// </summary>
        [JsonProperty(PropertyName = "authenticationType")]
        public string AuthenticationType { get; set; }

        /// <summary>
        /// Gets or sets optional resource information to enable network
        /// isolation for request.
        /// </summary>
        [JsonProperty(PropertyName = "networkIsolation")]
        public NetworkIsolationSettings NetworkIsolation { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (StorageKeyType == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "StorageKeyType");
            }
            if (StorageKey == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "StorageKey");
            }
            if (StorageUri == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "StorageUri");
            }
            if (AdministratorLogin == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "AdministratorLogin");
            }
            if (AdministratorLoginPassword == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "AdministratorLoginPassword");
            }
        }
    }
}
