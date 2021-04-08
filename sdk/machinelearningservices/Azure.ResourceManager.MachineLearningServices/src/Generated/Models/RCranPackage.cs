// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    /// <summary> The RCranPackage. </summary>
    public partial class RCranPackage
    {
        /// <summary> Initializes a new instance of RCranPackage. </summary>
        public RCranPackage()
        {
        }

        /// <summary> Initializes a new instance of RCranPackage. </summary>
        /// <param name="name"> The package name. </param>
        /// <param name="repository"> The repository name. </param>
        internal RCranPackage(string name, string repository)
        {
            Name = name;
            Repository = repository;
        }

        /// <summary> The package name. </summary>
        public string Name { get; set; }
        /// <summary> The repository name. </summary>
        public string Repository { get; set; }
    }
}
