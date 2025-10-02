using Metaplay.Core.Analytics;
using System;
using Metaplay.Core.Model;
using Newtonsoft.Json;
using System.ComponentModel;

namespace Analytics
{
    [AnalyticsEvent(199, "Daily Scoop status changed", 1, null, false, true, false)]
    [AnalyticsEventKeywords(new string[] { "daily" })]
    public class AnalyticsDailyScoopStatusChanged : AnalyticsServersideEventBase
    {
        public override string EventDescription { get; }
        public override AnalyticsEventType EventType { get; }

        [JsonProperty("daily_challenge_id")]
        [MetaMember(1, (MetaMemberFlags)0)]
        [Description("Event ID")]
        public string EventId { get; set; }

        [JsonProperty("daily_challenge_week_id")]
        [MetaMember(2, (MetaMemberFlags)0)]
        [Description("week ID")]
        public string WeekId { get; set; }

        [JsonProperty("daily_challenge_day")]
        [MetaMember(3, (MetaMemberFlags)0)]
        [Description("Day ID")]
        public string DayId { get; set; }

        [JsonProperty("daily_challenge_status")]
        [MetaMember(4, (MetaMemberFlags)0)]
        [Description("Status of the task, unlocked/completed")]
        public TaskStatus Status { get; set; }

        [JsonProperty("daily_challenge_objective_category")]
        [MetaMember(5, (MetaMemberFlags)0)]
        [Description("The type of the task, Standard/Special")]
        public TaskType Type { get; set; }

        [JsonProperty("daily_challenge_token_amount")]
        [MetaMember(6, (MetaMemberFlags)0)]
        [Description("The amount of event tokens the task rewards")]
        public int TokenAmount { get; set; }

        public AnalyticsDailyScoopStatusChanged()
        {
        }

        public AnalyticsDailyScoopStatusChanged(string eventId, string weekId, string dayId, TaskStatus status, TaskType type, int tokenAmount)
        {
        }

        [JsonProperty("daily_challenge_task_id")]
        [MetaMember(7, (MetaMemberFlags)0)]
        [Description("Task ID")]
        public string TaskId { get; set; }

        public AnalyticsDailyScoopStatusChanged(string eventId, string weekId, string dayId, TaskStatus status, TaskType type, int tokenAmount, string taskId)
        {
        }
    }
}