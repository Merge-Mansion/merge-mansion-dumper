using Metaplay.Core.Analytics;
using Newtonsoft.Json;
using Metaplay.Core.Model;
using System.ComponentModel;
using System;
using GameLogic;
using Code.GameLogic.GameEvents;
using GameLogic.Player;

namespace Analytics
{
    [AnalyticsEvent(178, "Player received a pet reward", 1, null, true, true, false)]
    [AnalyticsEventKeywords(new string[] { "event" })]
    public class AnalyticsPlayerPetRewardGained : AnalyticsPlayerRewardGained
    {
        [JsonProperty("pet_id")]
        [MetaMember(1, (MetaMemberFlags)0)]
        [Description("ID of the pet received")]
        public string PetId;
        [JsonProperty("amount")]
        [MetaMember(2, (MetaMemberFlags)0)]
        [Description("Number of pets received")]
        public int Amount;
        [JsonProperty("reward_type")]
        [Description("Type of the reward received")]
        public sealed override string RewardType { get; }
        public override string EventDescription { get; }

        public AnalyticsPlayerPetRewardGained(CurrencySource rewardSource, string context, string eventOfferSetId, EventLevelId eventLevelId)
        {
        }

        public AnalyticsPlayerPetRewardGained()
        {
        }

        public AnalyticsPlayerPetRewardGained(CurrencySource rewardSource, string context, string eventOfferSetId, EventLevelId eventLevelId, AnalyticsContext analyticsContext)
        {
        }
    }
}