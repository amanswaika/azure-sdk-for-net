// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Graph.Rbac.Models
{
    /// <summary> Active Directory Domain information. </summary>
    public partial class Domain : IReadOnlyDictionary<string, object>
    {
        /// <summary> Initializes a new instance of Domain. </summary>
        /// <param name="name"> the domain name. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        internal Domain(string name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            Name = name;
            AdditionalProperties = new ChangeTrackingDictionary<string, object>();
        }

        /// <summary> Initializes a new instance of Domain. </summary>
        /// <param name="authenticationType"> the type of the authentication into the domain. </param>
        /// <param name="isDefault"> if this is the default domain in the tenant. </param>
        /// <param name="isVerified"> if this domain&apos;s ownership is verified. </param>
        /// <param name="name"> the domain name. </param>
        /// <param name="additionalProperties"> . </param>
        internal Domain(string authenticationType, bool? isDefault, bool? isVerified, string name, IReadOnlyDictionary<string, object> additionalProperties)
        {
            AuthenticationType = authenticationType;
            IsDefault = isDefault;
            IsVerified = isVerified;
            Name = name;
            AdditionalProperties = additionalProperties;
        }

        /// <summary> the type of the authentication into the domain. </summary>
        public string AuthenticationType { get; }
        /// <summary> if this is the default domain in the tenant. </summary>
        public bool? IsDefault { get; }
        /// <summary> if this domain&apos;s ownership is verified. </summary>
        public bool? IsVerified { get; }
        /// <summary> the domain name. </summary>
        public string Name { get; }
        internal IReadOnlyDictionary<string, object> AdditionalProperties { get; }
        /// <inheritdoc />
        public IEnumerator<KeyValuePair<string, object>> GetEnumerator() => AdditionalProperties.GetEnumerator();
        /// <inheritdoc />
        IEnumerator IEnumerable.GetEnumerator() => AdditionalProperties.GetEnumerator();
        /// <inheritdoc />
        public bool TryGetValue(string key, out object value) => AdditionalProperties.TryGetValue(key, out value);
        /// <inheritdoc />
        public bool ContainsKey(string key) => AdditionalProperties.ContainsKey(key);
        /// <inheritdoc />
        public IEnumerable<string> Keys => AdditionalProperties.Keys;
        /// <inheritdoc />
        public IEnumerable<object> Values => AdditionalProperties.Values;
        /// <inheritdoc />
        int IReadOnlyCollection<KeyValuePair<string, object>>.Count => AdditionalProperties.Count;
        /// <inheritdoc />
        public object this[string key]
        {
            get => AdditionalProperties[key];
        }
    }
}