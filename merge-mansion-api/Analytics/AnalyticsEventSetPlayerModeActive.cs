using Metaplay.Core.Analytics;
using Newtonsoft.Json;
using System.ComponentModel;
using Metaplay.Core.Model;
using System;
using GameLogic.Player.Modes;
using Merge;

namespace Analytics
{
    [AnalyticsEvent(182, "Set player mode active/inactive", 1, null, false, true, false)]
    public class AnalyticsEventSetPlayerModeActive : AnalyticsServersideEventBase
    {
        public sealed override AnalyticsEventType EventType { get; }

        [Description("Id of the activated/deactivated mode")]
        [MetaMember(1, (MetaMemberFlags)0)]
        [JsonProperty("player_mode_id")]
        public string PlayerModeId { get; set; }

        [JsonProperty("active")]
        [Description("True if mode was activated, false if deactivated")]
        [MetaMember(2, (MetaMemberFlags)0)]
        public bool Active { get; set; }
        public override string EventDescription { get; }

        private AnalyticsEventSetPlayerModeActive()
        {
        }

        public AnalyticsEventSetPlayerModeActive(PlayerModeId playerModeId, bool active)
        {
        }

        [JsonProperty("board_id", NullValueHandling = (NullValueHandling)1)]
        [MetaMember(3, (MetaMemberFlags)0)]
        [Description("Board where the mode was activated/deactivated")]
        public MergeBoardId BoardId { get; set; }

        public AnalyticsEventSetPlayerModeActive(PlayerModeId playerModeId, bool active, MergeBoardId boardId)
        {
        }
    }
}