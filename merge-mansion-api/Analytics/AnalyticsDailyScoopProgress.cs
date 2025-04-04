using Metaplay.Core.Analytics;
using System;
using Newtonsoft.Json;
using System.ComponentModel;
using Metaplay.Core.Model;
using GameLogic.StatsTracking;
using System.Collections.Generic;

namespace Analytics
{
    [AnalyticsEvent(198, "Daily Scoop Task Progress", 1, null, true, true, false)]
    [AnalyticsEventKeywords(new string[] { "daily" })]
    [MetaBlockedMembers(new int[] { 5, 6, 8, 10, 11, 14, 15, 19 })]
    public class AnalyticsDailyScoopProgress : AnalyticsServersideEventBase
    {
        public override AnalyticsEventType EventType { get; }
        public override string EventDescription { get; }

        [JsonProperty("daily_challenge_id")]
        [MetaMember(1, (MetaMemberFlags)0)]
        [Description("Event ID")]
        public string EventId { get; set; }

        [JsonProperty("daily_challenge_week_id")]
        [MetaMember(2, (MetaMemberFlags)0)]
        [Description("week instance")]
        public string WeekId { get; set; }

        [JsonProperty("daily_challenge_day")]
        [MetaMember(3, (MetaMemberFlags)0)]
        [Description("Day instance")]
        public string DayId { get; set; }

        [Description("Task objective type")]
        [JsonProperty("daily_challenge_objective_type")]
        [MetaMember(4, (MetaMemberFlags)0)]
        public StatsObjectiveType ObjectiveType { get; set; }

        [JsonProperty("daily_challenge_objective_order")]
        [BigQueryAnalyticsFormat((BigQueryAnalyticsFormatMode)0)]
        [MetaMember(21, (MetaMemberFlags)0)]
        public Dictionary<string, int> ObjectiveOrder { get; set; }

        [JsonProperty("daily_challenge_objective_category")]
        [MetaMember(22, (MetaMemberFlags)0)]
        [BigQueryAnalyticsFormat((BigQueryAnalyticsFormatMode)0)]
        public Dictionary<string, string> ObjectiveCategory { get; set; }

        [JsonProperty("daily_challenge_objective_name")]
        [MetaMember(7, (MetaMemberFlags)0)]
        [Description("Task objective parameter/name")]
        public string ObjectiveParameter { get; set; }

        [MetaMember(23, (MetaMemberFlags)0)]
        [JsonProperty("daily_challenge_objective_requirement")]
        [BigQueryAnalyticsFormat((BigQueryAnalyticsFormatMode)0)]
        public Dictionary<string, int> ObjectiveRequirement { get; set; }

        [MetaMember(9, (MetaMemberFlags)0)]
        [JsonProperty("daily_challenge_objective_requirement_amount")]
        [Description("Task progress amount")]
        public int ObjectiveProgressAmount { get; set; }

        [JsonProperty("daily_challenge_objective_requirement_saldo")]
        [BigQueryAnalyticsFormat((BigQueryAnalyticsFormatMode)0)]
        [MetaMember(24, (MetaMemberFlags)0)]
        public Dictionary<string, int> ObjectiveProgressSaldo { get; set; }

        [BigQueryAnalyticsFormat((BigQueryAnalyticsFormatMode)0)]
        [MetaMember(25, (MetaMemberFlags)0)]
        [JsonProperty("daily_challenge_token_amount")]
        public Dictionary<string, int> EventPointReceived { get; set; }

        [MetaMember(12, (MetaMemberFlags)0)]
        [JsonProperty("daily_challenge_token_saldo")]
        [Description("Total amount of event points after receiving reward")]
        public int EventPointSaldo { get; set; }

        [Description("The ID of the previous milestone")]
        [JsonProperty("previous_daily_challenge_weekly_milestone")]
        [MetaMember(13, (MetaMemberFlags)0)]
        public string PreviousMileStoneId { get; set; }

        [MetaMember(16, (MetaMemberFlags)0)]
        [Description("The ID of the daily reward")]
        [JsonProperty("daily_challenge_total_reward")]
        public string DailyRewardId { get; set; }

        public AnalyticsDailyScoopProgress()
        {
        }

        public AnalyticsDailyScoopProgress(string eventId, string weekId, string dayId, StatsObjectiveType objectiveType, int objectiveOrder, string objectiveCategory, string objectiveParameter, int objectiveRequirement, int objectiveProgressAmount, int objectiveProgressSaldo, int eventPointReceived, int eventPointSaldo, string previousMileStoneId, string nextMileStoneId, string lastMileStoneId, string dailyRewardId)
        {
        }

        [JsonProperty("current_daily_challenge_weekly_milestone")]
        [MetaMember(17, (MetaMemberFlags)0)]
        [Description("The ID of the next milestone")]
        public int NextMileStoneIndex { get; set; }

        [MetaMember(18, (MetaMemberFlags)0)]
        [Description("The ID of the last milestone")]
        [JsonProperty("max_daily_challenge_weekly_milestone")]
        public int LastMileStoneIndex { get; set; }

        [MetaMember(26, (MetaMemberFlags)0)]
        [JsonProperty("secondary_reward_recieved")]
        [BigQueryAnalyticsFormat((BigQueryAnalyticsFormatMode)0)]
        public Dictionary<string, string> SecondaryReward { get; set; }

        public AnalyticsDailyScoopProgress(string eventId, string weekId, string dayId, StatsObjectiveType objectiveType, int objectiveOrder, string objectiveCategory, string objectiveParameter, int objectiveRequirement, int objectiveProgressAmount, int objectiveProgressSaldo, int eventPointReceived, int eventPointSaldo, string previousMileStoneId, int nextMileStoneIndex, int lastMileStoneIndex, string dailyRewardId, string secondaryReward)
        {
        }

        private static string Locked;
        private static string Unlocked;
        [JsonProperty("daily_challenge_event_state")]
        [Description("The state of the daily challenge event")]
        [MetaMember(20, (MetaMemberFlags)0)]
        public string EventState { get; set; }

        public AnalyticsDailyScoopProgress(string eventId, string weekId, string dayId, StatsObjectiveType objectiveType, int objectiveProgressAmount, int eventPointSaldo, string previousMileStoneId, int nextMileStoneIndex, int lastMileStoneIndex, string dailyRewardId, bool eventState, List<DailyScoopProgressAnalyticsData> objectivesData)
        {
        }
    }
}