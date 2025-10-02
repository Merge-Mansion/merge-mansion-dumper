using Metaplay.Core.Analytics;
using Metaplay.Core.Model;
using System;
using Metaplay.Core.Message;

namespace Metaplay.Core.Player
{
    [AnalyticsEvent(1026, "Client App-launch Performance Sample", 1, "Client reports application launch performance statistics", true, true, false)]
    public class PlayerEventAppStartPerformance : PlayerEventBase
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public ClientPlatform Platform { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        public string DeviceModel { get; set; }

        [MetaMember(3, (MetaMemberFlags)0)]
        public string ClientVersion { get; set; }

        [MetaMember(4, (MetaMemberFlags)0)]
        public ClientLaunchStatistics Statistics { get; set; }
        public override string EventDescription { get; }
    }
}