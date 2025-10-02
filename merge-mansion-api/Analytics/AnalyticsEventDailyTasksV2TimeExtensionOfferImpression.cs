using Metaplay.Core.Analytics;
using System;
using System.ComponentModel;
using Newtonsoft.Json;
using Metaplay.Core.Model;

namespace Analytics
{
    [AnalyticsEvent(195, "Daily Tasks V2 time extension offer impression", 1, null, false, true, false)]
    public class AnalyticsEventDailyTasksV2TimeExtensionOfferImpression : AnalyticEventGeneralImpression
    {
        private static string TypeId;
        public override AnalyticsEventType EventType { get; }

        [MetaMember(1, (MetaMemberFlags)0)]
        [JsonProperty("type")]
        [Description("")]
        public string Type { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        [JsonProperty("daily_tasks_set_id")]
        [Description("Unique daily cycle task set id")]
        public string TasksSetId { get; set; }
        public override string EventDescription { get; }

        private AnalyticsEventDailyTasksV2TimeExtensionOfferImpression()
        {
        }

        public AnalyticsEventDailyTasksV2TimeExtensionOfferImpression(string tasksSetId, string placementId, Guid impressionId)
        {
        }

        [MetaMember(3, (MetaMemberFlags)0)]
        [JsonProperty("trigger_type")]
        [Description("Event Offer Trigger Type")]
        public string TriggerType { get; set; }

        public AnalyticsEventDailyTasksV2TimeExtensionOfferImpression(string tasksSetId, string placementId, Guid impressionId, string triggerType)
        {
        }
    }
}