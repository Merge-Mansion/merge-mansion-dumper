using Metaplay.Core.Analytics;
using Newtonsoft.Json;
using Metaplay.Core.Model;
using System.ComponentModel;
using System;

namespace Analytics
{
    [AnalyticsEvent(224, "Config status", 1, null, false, true, false)]
    public class AnalyticsEventSessionStartConfigStatus : AnalyticsServersideEventBase
    {
        public sealed override AnalyticsEventType EventType { get; }

        [JsonProperty("status")]
        [MetaMember(1, (MetaMemberFlags)0)]
        [Description("Current status of the config in sessions flow")]
        public string Status { get; set; }
        public override string EventDescription { get; }

        [JsonProperty("app_launch_id")]
        [MetaMember(2, (MetaMemberFlags)0)]
        [Description("Session's latest app launch identifier")]
        public uint AppLaunchId { get; set; }
    }
}