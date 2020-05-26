// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Management.Network.Models
{
    /// <summary> BGP peer status details. </summary>
    public partial class BgpPeerStatus
    {
        /// <summary> Initializes a new instance of BgpPeerStatus. </summary>
        internal BgpPeerStatus()
        {
        }

        /// <summary> Initializes a new instance of BgpPeerStatus. </summary>
        /// <param name="localAddress"> The virtual network gateway&apos;s local address. </param>
        /// <param name="neighbor"> The remote BGP peer. </param>
        /// <param name="asn"> The autonomous system number of the remote BGP peer. </param>
        /// <param name="state"> The BGP peer state. </param>
        /// <param name="connectedDuration"> For how long the peering has been up. </param>
        /// <param name="routesReceived"> The number of routes learned from this peer. </param>
        /// <param name="messagesSent"> The number of BGP messages sent. </param>
        /// <param name="messagesReceived"> The number of BGP messages received. </param>
        internal BgpPeerStatus(string localAddress, string neighbor, long? asn, BgpPeerState? state, string connectedDuration, long? routesReceived, long? messagesSent, long? messagesReceived)
        {
            LocalAddress = localAddress;
            Neighbor = neighbor;
            Asn = asn;
            State = state;
            ConnectedDuration = connectedDuration;
            RoutesReceived = routesReceived;
            MessagesSent = messagesSent;
            MessagesReceived = messagesReceived;
        }

        /// <summary> The virtual network gateway&apos;s local address. </summary>
        public string LocalAddress { get; }
        /// <summary> The remote BGP peer. </summary>
        public string Neighbor { get; }
        /// <summary> The autonomous system number of the remote BGP peer. </summary>
        public long? Asn { get; }
        /// <summary> The BGP peer state. </summary>
        public BgpPeerState? State { get; }
        /// <summary> For how long the peering has been up. </summary>
        public string ConnectedDuration { get; }
        /// <summary> The number of routes learned from this peer. </summary>
        public long? RoutesReceived { get; }
        /// <summary> The number of BGP messages sent. </summary>
        public long? MessagesSent { get; }
        /// <summary> The number of BGP messages received. </summary>
        public long? MessagesReceived { get; }
    }
}
