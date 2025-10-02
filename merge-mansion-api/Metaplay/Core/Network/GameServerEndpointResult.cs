using Metaplay.Core.Model;
using System;
using System.Collections.Generic;

namespace Metaplay.Core.Network
{
    [MetaSerializable]
    public class GameServerEndpointResult
    {
        public GameServerEndpointResult()
        {
        }

        public GameServerEndpointResult(string hostname, List<int> ports)
        {
        }

        [MetaMember(1, (MetaMemberFlags)0)]
        public string LegacyHostname;
        [MetaMember(3, (MetaMemberFlags)0)]
        public Dictionary<int, SocketProbeResult> LegacyGatewaysByPort;
        [MetaMember(4, (MetaMemberFlags)0)]
        public Dictionary<string, SocketProbeResult> GatewaysByHost;
    }
}