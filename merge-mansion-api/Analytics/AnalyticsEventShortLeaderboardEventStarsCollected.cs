using Metaplay.Core.Analytics;
using Newtonsoft.Json;
using Metaplay.Core.Model;
using System.ComponentModel;
using Code.GameLogic.GameEvents;
using System;

namespace Analytics
{
    [AnalyticsEvent(211, "Short Leaderboard Event Stars Collected", 1, null, true, true, false)]
    public class AnalyticsEventShortLeaderboardEventStarsCollected : AnalyticsServersideEventBase
    {
        public sealed override AnalyticsEventType EventType { get; }

        [JsonProperty("event_id")]
        [MetaMember(1, (MetaMemberFlags)0)]
        [Description("Event id where stars were collected.")]
        public ShortLeaderboardEventId EventId { get; set; }

        [JsonProperty("stage_number")]
        [MetaMember(2, (MetaMemberFlags)0)]
        [Description("Stage number (1-based) where stars were collected.")]
        public int StageNumber { get; set; }

        [JsonProperty("rank")]
        [MetaMember(3, (MetaMemberFlags)0)]
        [Description("Rank (1-based) that player had at end of stage.")]
        public int Rank { get; set; }

        [JsonProperty("leaderboard_stars")]
        [MetaMember(4, (MetaMemberFlags)0)]
        [Description("Number of stars collected.")]
        public int LeaderboardStars { get; set; }

        [JsonProperty("leaderboard_stars_saldo")]
        [MetaMember(5, (MetaMemberFlags)0)]
        [Description("Total number of stars after stars for this stage were collected.")]
        public int LeaderboardStarsSaldo { get; set; }

        [JsonProperty("stage_cost")]
        [MetaMember(6, (MetaMemberFlags)0)]
        [Description("Number of gems spent to enter the stage. 0 if free.")]
        public long StageCost { get; set; }

        [JsonProperty("stage_replay")]
        [MetaMember(7, (MetaMemberFlags)0)]
        [Description("How many times the stage has been replayed. 0 if this is the first time.")]
        public int StageReplay { get; set; }

        [JsonProperty("score")]
        [MetaMember(8, (MetaMemberFlags)0)]
        [Description("Score player had during this stage.")]
        public long Score { get; set; }
        public override string EventDescription { get; }

        public AnalyticsEventShortLeaderboardEventStarsCollected()
        {
        }

        public AnalyticsEventShortLeaderboardEventStarsCollected(ShortLeaderboardEventId eventId, int stageNumber, int rank, int leaderboardStars, int leaderboardStarsSaldo, long stageCost, int stageReplay, int score)
        {
        }
    }
}