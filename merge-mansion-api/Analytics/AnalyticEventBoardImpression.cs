using Metaplay.Core.Analytics;
using Newtonsoft.Json;
using Metaplay.Core.Model;
using System.ComponentModel;
using Merge;
using System;
using Metaplay.Core.Math;

namespace Analytics
{
    [AnalyticsEvent(166, "Board impression", 1, null, false, true, false)]
    public class AnalyticEventBoardImpression : AnalyticsServersideEventBase
    {
        public override AnalyticsEventType EventType { get; }

        [JsonProperty("board_id")]
        [MetaMember(1, (MetaMemberFlags)0)]
        [Description("Board Id")]
        public MergeBoardId BoardId { get; set; }
        public override string EventDescription { get; }

        private AnalyticEventBoardImpression()
        {
        }

        public AnalyticEventBoardImpression(MergeBoardId boardId)
        {
        }

        [JsonProperty("load_duration")]
        [MetaMember(2, (MetaMemberFlags)0)]
        [Description("Load duration")]
        public F64 LoadDuration;
    }
}