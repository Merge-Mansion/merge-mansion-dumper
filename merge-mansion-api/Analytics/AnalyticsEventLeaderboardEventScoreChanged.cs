using Metaplay.Core.Analytics;
using Metaplay.Core.Model;
using Newtonsoft.Json;
using System.ComponentModel;
using Code.GameLogic.GameEvents;
using System;
using Metaplay.Core;

namespace Analytics
{
    [AnalyticsEvent(164, "Leaderboard event score changed", 1, null, true, true, false)]
    [MetaBlockedMembers(new int[] { 1 })]
    [AnalyticsEventKeywords(new string[] { "event" })]
    public class AnalyticsEventLeaderboardEventScoreChanged : AnalyticsServersideEventBase
    {
        public sealed override AnalyticsEventType EventType { get; }

        [JsonProperty("event_id")]
        [MetaMember(2, (MetaMemberFlags)0)]
        [Description("Leaderboard event where score changed")]
        public LeaderboardEventId EventId { get; set; }

        [JsonProperty("source_action")]
        [MetaMember(3, (MetaMemberFlags)0)]
        [Description("Action that caused score change")]
        public LeaderboardEventScoreChangeSourceAction SourceAction { get; set; }

        [JsonProperty("score_change")]
        [MetaMember(4, (MetaMemberFlags)0)]
        [Description("How much score changed")]
        public int ScoreChange { get; set; }

        [JsonProperty("total_score")]
        [MetaMember(5, (MetaMemberFlags)0)]
        [Description("Total score after change")]
        public int TotalScore { get; set; }

        [JsonProperty("leaderboard_id")]
        [MetaMember(6, (MetaMemberFlags)0)]
        [Description("Leaderboard division id")]
        public EntityId DivisionId { get; set; }
        public override string EventDescription { get; }

        private AnalyticsEventLeaderboardEventScoreChanged()
        {
        }

        public AnalyticsEventLeaderboardEventScoreChanged(LeaderboardEventId eventId, LeaderboardEventScoreChangeSourceAction sourceAction, int scoreChange, int totalScore, EntityId divisionId)
        {
        }

        [JsonProperty("stage_number", NullValueHandling = (NullValueHandling)1)]
        [MetaMember(7, (MetaMemberFlags)0)]
        [Description("Stage number in case event contains multiple stages")]
        public int? StageNumber { get; set; }

        public AnalyticsEventLeaderboardEventScoreChanged(LeaderboardEventId eventId, LeaderboardEventScoreChangeSourceAction sourceAction, int scoreChange, int totalScore, EntityId divisionId, int? stageNumber)
        {
        }
    }
}