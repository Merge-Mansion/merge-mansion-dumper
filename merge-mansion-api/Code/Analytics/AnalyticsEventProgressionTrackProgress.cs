using Metaplay.Core.Analytics;
using Analytics;
using System;
using Newtonsoft.Json;
using Metaplay.Core.Model;
using System.ComponentModel;

namespace Code.Analytics
{
    [AnalyticsEvent(222, "ProgressTrack progress made", 1, null, true, true, false)]
    [AnalyticsEventKeywords(new string[] { "event", "task" })]
    public class AnalyticsEventProgressionTrackProgress : AnalyticsServersideEventBase
    {
        public override string EventDescription { get; }
        public override AnalyticsEventType EventType { get; }

        [JsonProperty("track_id")]
        [MetaMember(1, (MetaMemberFlags)0)]
        [Description("Track identifier")]
        public string TrackId { get; set; }

        [JsonProperty("progress_amount")]
        [MetaMember(2, (MetaMemberFlags)0)]
        [Description("Amount of progress that was made")]
        public int ProgressAmount { get; set; }

        [JsonProperty("current_progress")]
        [MetaMember(3, (MetaMemberFlags)0)]
        [Description("New current progress of the track  after progress was added")]
        public int CurrentProgress { get; set; }

        [JsonProperty("max_level_progress")]
        [MetaMember(4, (MetaMemberFlags)0)]
        [Description("Max progress of the current level")]
        public int MaxLevelProgress { get; set; }

        [JsonProperty("current_milestone")]
        [MetaMember(5, (MetaMemberFlags)0)]
        [Description("New current milestone of the track after progress was added")]
        public int CurrentMilestone { get; set; }

        [JsonProperty("max_milestones")]
        [MetaMember(6, (MetaMemberFlags)0)]
        [Description("Max number of milestones in the track")]
        public int MaxMilestones { get; set; }

        [JsonProperty("milestone_completed")]
        [MetaMember(7, (MetaMemberFlags)0)]
        [Description("Was milestone completed with the progress that was made")]
        public bool MilestoneCompleted { get; set; }
    }
}