using Metaplay.Core.Analytics;
using Newtonsoft.Json;
using Metaplay.Core.Model;
using System.ComponentModel;
using Metaplay.Core;
using System.Collections.Generic;
using System;
using Code.GameLogic.GameEvents;

namespace Analytics
{
    [AnalyticsEvent(165, "Leaderboard snapshot", 1, null, false, true, false)]
    [MetaBlockedMembers(new int[] { 6 })]
    public class AnalyticEventLeaderboardSnapshot : AnalyticsServersideDivisionEventBase
    {
        public override AnalyticsEventType EventType { get; }

        [JsonProperty("leaderboard_id")]
        [MetaMember(1, (MetaMemberFlags)0)]
        [Description("Leaderboard division id")]
        public EntityId DivisionId { get; set; }

        [JsonProperty("players")]
        [MetaMember(2, (MetaMemberFlags)0)]
        [Description("Participants")]
        public List<LeaderboardSnapshotPlayerEntry> Players { get; set; }

        [JsonProperty("gathered_from")]
        [MetaMember(3, (MetaMemberFlags)0)]
        [Description("Snapshot taken at")]
        public AnalyticsLeaderboardSnapshotType SnapshotType { get; set; }

        [JsonProperty("new_player_id", NullValueHandling = (NullValueHandling)1)]
        [MetaMember(4, (MetaMemberFlags)0)]
        [Description("New player id if added")]
        public string NewPlayerId { get; set; }
        public override string EventDescription { get; }

        private AnalyticEventLeaderboardSnapshot()
        {
        }

        public AnalyticEventLeaderboardSnapshot(EntityId divisionId, List<LeaderboardSnapshotPlayerEntry> players, AnalyticsLeaderboardSnapshotType snapshotType, string newPlayerId)
        {
        }

        [MetaMember(5, (MetaMemberFlags)0)]
        [Description("Division rank")]
        public int Rank { get; set; }

        [JsonProperty("event_id")]
        [MetaMember(7, (MetaMemberFlags)0)]
        [Description("Event Id")]
        public string EventId { get; set; }

        public AnalyticEventLeaderboardSnapshot(EntityId divisionId, List<LeaderboardSnapshotPlayerEntry> players, AnalyticsLeaderboardSnapshotType snapshotType, int rank, LeaderboardEventId eventId, string newPlayerId)
        {
        }

        public AnalyticEventLeaderboardSnapshot(EntityId divisionId, List<LeaderboardSnapshotPlayerEntry> players, AnalyticsLeaderboardSnapshotType snapshotType, int rank, string eventId, string newPlayerId)
        {
        }

        [JsonProperty("stage_number", NullValueHandling = (NullValueHandling)1)]
        [MetaMember(8, (MetaMemberFlags)0)]
        [Description("Stage number in case event contains multiple stages")]
        public int? StageNumber { get; set; }

        public AnalyticEventLeaderboardSnapshot(EntityId divisionId, List<LeaderboardSnapshotPlayerEntry> players, AnalyticsLeaderboardSnapshotType snapshotType, int rank, string eventId, string newPlayerId, int? stageNumber)
        {
        }
    }
}