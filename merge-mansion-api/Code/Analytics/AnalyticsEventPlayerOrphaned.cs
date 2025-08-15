using Metaplay.Core.Analytics;
using Analytics;
using Newtonsoft.Json;
using Metaplay.Core.Model;
using System.ComponentModel;
using System;

namespace Code.Analytics
{
    [AnalyticsEvent(218, "Player orphaned", 1, null, true, true, false)]
    public class AnalyticsEventPlayerOrphaned : AnalyticsServersideEventBase
    {
        public sealed override AnalyticsEventType EventType { get; }

        [JsonProperty("player_id")]
        [MetaMember(1, (MetaMemberFlags)0)]
        [Description("orphaned player")]
        public string PlayerId { get; set; }
        public override string EventDescription { get; }
    }
}