using Metaplay.Core.Analytics;
using Newtonsoft.Json;
using System.ComponentModel;
using Metaplay.Core.Model;
using Merge;
using System;
using GameLogic.Player.Items.Fishing;
using GameLogic.Player;
using Code.GameLogic.GameEvents;

namespace Analytics
{
    [AnalyticsEvent(172, "Fish caught", 1, null, false, true, false)]
    public class AnalyticsEventFishCaught : AnalyticsServersideEventBase
    {
        public sealed override AnalyticsEventType EventType { get; }

        [Description("Id of the board where the fish was caught")]
        [MetaMember(1, (MetaMemberFlags)0)]
        [JsonProperty("board_id")]
        public MergeBoardId MergeBoardId { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        [Description("Name of the item that was caught")]
        [JsonProperty("item_name")]
        public string ItemName { get; set; }

        [Description("Weight category of the fish that was caught")]
        [JsonProperty("weight_category")]
        [MetaMember(3, (MetaMemberFlags)0)]
        public WeightCategory WeightCategory { get; set; }

        [JsonProperty("weight")]
        [Description("Weight of the fish that was caught")]
        [MetaMember(4, (MetaMemberFlags)0)]
        public double Weight { get; set; }

        [Description("True if this fish was a personal weight high score for the player, false otherwise")]
        [MetaMember(5, (MetaMemberFlags)0)]
        [JsonProperty("personal_high_score")]
        public bool PersonalHighScore { get; set; }

        [Description("True if this fish beat the previous \"world record\" (configured limit, or personal high score if that's higher), false otherwise")]
        [MetaMember(6, (MetaMemberFlags)0)]
        [JsonProperty("world_high_score")]
        public bool WorldHighScore { get; set; }

        [MetaMember(7, (MetaMemberFlags)0)]
        [JsonProperty("event_id")]
        public string Context { get; set; }
        public override string EventDescription { get; }

        public AnalyticsEventFishCaught()
        {
        }

        public AnalyticsEventFishCaught(MergeBoardId mergeBoardId, string itemName, WeightCategory weightCategory, double weight, bool personalHighScore, bool worldHighScore, AnalyticsContext context)
        {
        }

        [JsonProperty("rarity")]
        [MetaMember(8, (MetaMemberFlags)0)]
        public string Rarity { get; set; }

        [MetaMember(9, (MetaMemberFlags)0)]
        [JsonProperty("lucky_event_type")]
        public string LuckyEventType { get; set; }

        [MetaMember(10, (MetaMemberFlags)0)]
        [JsonProperty("merge_parts_weights")]
        public double[] MergePartsWeight { get; set; }

        public AnalyticsEventFishCaught(MergeBoardId mergeBoardId, string itemName, WeightCategory weightCategory, double weight, bool personalHighScore, bool worldHighScore, AnalyticsContext context, LuckyType luckyType, FishRarity rarity, double[] mergePartsWeight)
        {
        }

        [JsonProperty("is_codex_reward_unlocked")]
        [MetaMember(11, (MetaMemberFlags)0)]
        public bool IsCodexRewardUnlocked { get; set; }

        public AnalyticsEventFishCaught(MergeBoardId mergeBoardId, string itemName, WeightCategory weightCategory, double weight, bool personalHighScore, bool worldHighScore, AnalyticsContext context, bool isCodexRewardUnlocked, LuckyType luckyType, FishRarity rarity, double[] mergePartsWeight)
        {
        }
    }
}