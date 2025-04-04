using Metaplay.Core.Model;
using System.ComponentModel;
using Newtonsoft.Json;
using System;

namespace Analytics
{
    [MetaSerializable]
    public class AnalyticsPlayerBonusReward
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        [JsonProperty("reward_type")]
        [Description("Type of the reward")]
        public string Type { get; set; }

        [JsonProperty("reward_id")]
        [MetaMember(2, (MetaMemberFlags)0)]
        [Description("Id/Name of the reward")]
        public string Id { get; set; }

        [JsonProperty("reward_amount")]
        [Description("Reward amount")]
        [MetaMember(3, (MetaMemberFlags)0)]
        public long Amount { get; set; }

        public AnalyticsPlayerBonusReward()
        {
        }

        public AnalyticsPlayerBonusReward(string type, string id, long amount)
        {
        }
    }
}