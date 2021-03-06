// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> The unique key on that enforces uniqueness constraint on documents in the collection in the Azure Cosmos DB service. </summary>
    public partial class UniqueKey
    {
        /// <summary> Initializes a new instance of UniqueKey. </summary>
        public UniqueKey()
        {
            Paths = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of UniqueKey. </summary>
        /// <param name="paths"> List of paths must be unique for each document in the Azure Cosmos DB service. </param>
        internal UniqueKey(IList<string> paths)
        {
            Paths = paths;
        }

        /// <summary> List of paths must be unique for each document in the Azure Cosmos DB service. </summary>
        public IList<string> Paths { get; }
    }
}
