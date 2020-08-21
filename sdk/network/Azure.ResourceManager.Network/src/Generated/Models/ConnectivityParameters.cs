// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Parameters that determine how the connectivity check will be performed. </summary>
    public partial class ConnectivityParameters
    {
        /// <summary> Initializes a new instance of ConnectivityParameters. </summary>
        /// <param name="source"> The source of the connection. </param>
        /// <param name="destination"> The destination of connection. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="source"/> or <paramref name="destination"/> is null. </exception>
        public ConnectivityParameters(ConnectivitySource source, ConnectivityDestination destination)
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }
            if (destination == null)
            {
                throw new ArgumentNullException(nameof(destination));
            }

            Source = source;
            Destination = destination;
        }

        /// <summary> The source of the connection. </summary>
        public ConnectivitySource Source { get; }
        /// <summary> The destination of connection. </summary>
        public ConnectivityDestination Destination { get; }
        /// <summary> Network protocol. </summary>
        public Protocol? Protocol { get; set; }
        /// <summary> Configuration of the protocol. </summary>
        public ProtocolConfiguration ProtocolConfiguration { get; set; }
        /// <summary> Preferred IP version of the connection. </summary>
        public IPVersion? PreferredIPVersion { get; set; }
    }
}