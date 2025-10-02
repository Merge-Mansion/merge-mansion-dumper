using Metaplay.Core.Analytics;
using System.ComponentModel;
using Metaplay.Core.Model;
using Newtonsoft.Json;
using System;
using GameLogic;
using GameLogic.Player;
using Code.GameLogic.GameEvents;

namespace Analytics
{
    [AnalyticsEvent(216, "Player received reward container", 1, null, false, true, false)]
    public class AnalyticsPlayerRewardContainerGained : AnalyticsPlayerRewardGained
    {
        [JsonProperty("item_name")]
        [MetaMember(1, (MetaMemberFlags)0)]
        [Description("ID of the received item")]
        public string ItemName;
        [JsonProperty("reward_type")]
        [Description("Type of the reward received")]
        public sealed override string RewardType { get; }
        public override string EventDescription { get; }

        public AnalyticsPlayerRewardContainerGained(string itemName, CurrencySource rewardSource, string context, AnalyticsContext analyticsContext, string eventOfferSetId, EventLevelId eventLeveLId)
        {
        }

        public AnalyticsPlayerRewardContainerGained()
        {
        }
    }
}