using Metaplay.Core.Analytics;
using Newtonsoft.Json;
using System;
using Metaplay.Core.Model;
using System.ComponentModel;

namespace Analytics
{
    [AnalyticsEvent(167, "Daily task first impression", 1, null, false, true, false)]
    public class AnalyticsEventDailyTaskFirstImpression : AnalyticsServersideEventBase
    {
        public sealed override AnalyticsEventType EventType { get; }

        [JsonProperty(PropertyName = "state", DefaultValueHandling = (DefaultValueHandling)0)]
        public string State { get; }

        [JsonProperty("task_index")]
        [MetaMember(1, (MetaMemberFlags)0)]
        [Description("Index of the task")]
        public int TaskIndex { get; set; }

        [JsonProperty("required_item")]
        [MetaMember(2, (MetaMemberFlags)0)]
        [Description("Id of the required item")]
        public string RequiredItem { get; set; }

        [JsonProperty("required_item_count")]
        [MetaMember(3, (MetaMemberFlags)0)]
        [Description("How many items were required")]
        public int RequiredItemCount { get; set; }

        [JsonProperty("reward_item")]
        [MetaMember(4, (MetaMemberFlags)0)]
        [Description("The received reward item id")]
        public string RewardItem { get; set; }

        [JsonProperty("reward_item_count")]
        [MetaMember(5, (MetaMemberFlags)0)]
        [Description("How many reward items were received")]
        public int RewardItemCount { get; set; }

        [JsonProperty("local_datetime")]
        [MetaMember(6, (MetaMemberFlags)0)]
        [Description("Player's local date and time")]
        public string LocalDateTime { get; set; }

        [JsonProperty("task_id")]
        [MetaMember(7, (MetaMemberFlags)0)]
        [Description("Task ConfigKey")]
        public string TaskId { get; set; }

        [JsonProperty("daily_tasks_set_id")]
        [MetaMember(8, (MetaMemberFlags)0)]
        [Description("Daily Tasks Set Id")]
        public string DailyTasksSetId { get; set; }

        [JsonProperty("daily_tasks_final_rewards_id")]
        [MetaMember(9, (MetaMemberFlags)0)]
        [Description("Daily Tasks Final Rewards Id")]
        public string DailyTasksFinalRewardsId { get; set; }
        public override string EventDescription { get; }

        public AnalyticsEventDailyTaskFirstImpression()
        {
        }

        public AnalyticsEventDailyTaskFirstImpression(string taskId, int taskIndex, string requiredItem, int requiredItemCount, string rewardItem, int rewardItemCount, string localDateTime, string dailyTasksSetId, string dailyTasksFinalRewardsId)
        {
        }

        [JsonProperty("is_purchased_task")]
        [MetaMember(10, (MetaMemberFlags)0)]
        [Description("Is Purchased Task")]
        public bool IsPurchasedTask { get; set; }

        public AnalyticsEventDailyTaskFirstImpression(string taskId, int taskIndex, string requiredItem, int requiredItemCount, string rewardItem, int rewardItemCount, string localDateTime, string dailyTasksSetId, string dailyTasksFinalRewardsId, bool isPurchasedTask)
        {
        }

        [JsonProperty("required_item_level")]
        [MetaMember(11, (MetaMemberFlags)0)]
        [Description("Required item level")]
        public int RequiredItemLevel { get; set; }

        [JsonProperty("required_item_mergechain_total_length")]
        [MetaMember(12, (MetaMemberFlags)0)]
        [Description("Merge chain total length of the required item")]
        public int RequiredItemMergeChainTotalLength { get; set; }

        [JsonProperty("required_item_mergechain_unlocked_length")]
        [MetaMember(13, (MetaMemberFlags)0)]
        [Description("Merge chain unlocked length of the required item")]
        public int RequiredItemMergeChainUnlockedLength { get; set; }

        [JsonProperty("reward_item_level")]
        [MetaMember(14, (MetaMemberFlags)0)]
        [Description("Reward item level")]
        public int RewardItemLevel { get; set; }

        [JsonProperty("reward_item_mergechain_total_length")]
        [MetaMember(15, (MetaMemberFlags)0)]
        [Description("Merge chain total length of the reward item")]
        public int RewardItemMergeChainTotalLength { get; set; }

        [JsonProperty("reward_item_mergechain_unlocked_length")]
        [MetaMember(16, (MetaMemberFlags)0)]
        [Description("Merge chain unlocked length of the reward item")]
        public int RewardItemMergeChainUnlockedLength { get; set; }

        public AnalyticsEventDailyTaskFirstImpression(string taskId, int taskIndex, string requiredItem, int requiredItemCount, string rewardItem, int rewardItemCount, string localDateTime, string dailyTasksSetId, string dailyTasksFinalRewardsId, bool isPurchasedTask, int requiredItemLevel, int requiredItemMergeChainTotalLength, int requiredItemMergeChainUnlockedLength, int rewardItemLevel, int rewardItemMergeChainTotalLength, int rewardItemMergeChainUnlockedLength)
        {
        }
    }
}