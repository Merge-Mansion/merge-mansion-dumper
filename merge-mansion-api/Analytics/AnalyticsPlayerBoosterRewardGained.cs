using Metaplay.Core.Analytics;
using Newtonsoft.Json;
using Metaplay.Core.Model;
using System.ComponentModel;
using System;

namespace Analytics
{
    [AnalyticsEvent(221, "Player received a booster reward", 1, null, true, true, false)]
    [AnalyticsEventKeywords(new string[] { "booster" })]
    public class AnalyticsPlayerBoosterRewardGained : AnalyticsPlayerRewardGained
    {
        [JsonProperty("item_name")]
        [MetaMember(1, (MetaMemberFlags)0)]
        [Description("ID of the booster received")]
        public string Name;
        [JsonProperty("duration_in_minutes")]
        [MetaMember(2, (MetaMemberFlags)0)]
        [Description("Duration received in minutes")]
        public int Duration;
        public override string EventDescription { get; }
        public override string RewardType { get; }
    }
}