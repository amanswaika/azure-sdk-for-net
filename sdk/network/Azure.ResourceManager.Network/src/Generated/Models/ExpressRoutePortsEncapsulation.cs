// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Encapsulation method on physical ports. </summary>
    public readonly partial struct ExpressRoutePortsEncapsulation : IEquatable<ExpressRoutePortsEncapsulation>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="ExpressRoutePortsEncapsulation"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ExpressRoutePortsEncapsulation(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string Dot1QValue = "Dot1Q";
        private const string QinQValue = "QinQ";

        /// <summary> Dot1Q. </summary>
        public static ExpressRoutePortsEncapsulation Dot1Q { get; } = new ExpressRoutePortsEncapsulation(Dot1QValue);
        /// <summary> QinQ. </summary>
        public static ExpressRoutePortsEncapsulation QinQ { get; } = new ExpressRoutePortsEncapsulation(QinQValue);
        /// <summary> Determines if two <see cref="ExpressRoutePortsEncapsulation"/> values are the same. </summary>
        public static bool operator ==(ExpressRoutePortsEncapsulation left, ExpressRoutePortsEncapsulation right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ExpressRoutePortsEncapsulation"/> values are not the same. </summary>
        public static bool operator !=(ExpressRoutePortsEncapsulation left, ExpressRoutePortsEncapsulation right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ExpressRoutePortsEncapsulation"/>. </summary>
        public static implicit operator ExpressRoutePortsEncapsulation(string value) => new ExpressRoutePortsEncapsulation(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ExpressRoutePortsEncapsulation other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ExpressRoutePortsEncapsulation other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}