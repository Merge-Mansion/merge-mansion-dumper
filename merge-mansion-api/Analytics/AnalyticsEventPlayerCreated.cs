using Metaplay.Core.Analytics;
using Newtonsoft.Json;
using Metaplay.Core.Model;
using System.ComponentModel;
using System;
using Metaplay.Core;

namespace Analytics
{
    [AnalyticsEvent(171, "Player created", 1, null, false, true, false)]
    public class AnalyticsEventPlayerCreated : AnalyticsServersideEventBase
    {
        public sealed override AnalyticsEventType EventType { get; }

        [JsonProperty("device")]
        [MetaMember(1, (MetaMemberFlags)0)]
        [Description("Device used on first login")]
        public string Device { get; set; }

        [JsonProperty("platform")]
        [MetaMember(2, (MetaMemberFlags)0)]
        [Description("Platform used on first login")]
        public ClientPlatform Platform { get; set; }

        [JsonProperty("location")]
        [MetaMember(3, (MetaMemberFlags)0)]
        [Description("Country ISO code on first login")]
        public string Location { get; set; }
        public override string EventDescription { get; }
    }
}