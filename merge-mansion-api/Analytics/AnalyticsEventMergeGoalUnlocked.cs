using Metaplay.Core.Analytics;
using Newtonsoft.Json;
using Metaplay.Core.Model;
using System.ComponentModel;
using System;
using GameLogic;
using GameLogic.Player;
using GameLogic.Hotspots;

namespace Analytics
{
    [AnalyticsEvent(101, "Merge goal unlocked", 1, null, false, true, false)]
    [MetaBlockedMembers(new int[] { 6 })]
    public class AnalyticsEventMergeGoalUnlocked : AnalyticsServersideEventBase
    {
        public sealed override AnalyticsEventType EventType { get; }

        [Description("ID of the opened hotspot")]
        [MetaMember(1, (MetaMemberFlags)0)]
        [JsonProperty("goal_id")]
        public HotspotId HotspotId { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        [JsonProperty("area_name")]
        [Description("Area that was unlocked")]
        public string AreaName { get; set; }

        [MetaMember(3, (MetaMemberFlags)0)]
        [Description("How many merge goals open")]
        [JsonProperty("merge_goals_open")]
        public int MergeGoalsOpen { get; set; }
        public override string EventDescription { get; }

        public AnalyticsEventMergeGoalUnlocked()
        {
        }

        public AnalyticsEventMergeGoalUnlocked(PlayerModel player, HotspotDefinition hotspotDefinition)
        {
        }

        [MetaMember(4, (MetaMemberFlags)0)]
        [Description("MapSpot where the hotspot is located")]
        [JsonProperty("map_spot_id")]
        public string MapSpot { get; set; }

        [Description("Multistep Group Id of the hotspot task (may be empty)")]
        [MetaMember(5, (MetaMemberFlags)0)]
        [JsonProperty("task_group_id")]
        public string TaskGroup { get; set; }

        [Description("How much time is left for bonus")]
        [MetaMember(7, (MetaMemberFlags)0)]
        [JsonProperty("bonus_time_left")]
        public double? BonusTimeLeft { get; set; }

        [Description("Possible bonus rewards")]
        [MetaMember(9, (MetaMemberFlags)0)]
        [JsonProperty("bonus_rewards")]
        public AnalyticsPlayerBonusReward[] BonusRewards { get; set; }

        [Description("Character id of the hotspot task (may be empty)")]
        [MetaMember(8, (MetaMemberFlags)0)]
        [JsonProperty("character_id")]
        public string Character { get; set; }
    }
}