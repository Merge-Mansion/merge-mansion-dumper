using Metaplay.Core.Analytics;
using System;
using Newtonsoft.Json;
using System.ComponentModel;
using Metaplay.Core.Model;
using Metaplay.Core;

namespace Analytics
{
    [AnalyticsEvent(210, "Flash Sale Impression", 1, null, false, true, false)]
    public class AnalyticEventShopOpened : AnalyticsServersideEventBase
    {
        public override AnalyticsEventType EventType { get; }
        public override string EventDescription { get; }

        [JsonProperty("impression_id")]
        [Description("Impression Id")]
        [MetaMember(1, (MetaMemberFlags)0)]
        public string ImpressionId { get; set; }

        [Description("Refresh time")]
        [JsonProperty("refresh_time")]
        [MetaMember(2, (MetaMemberFlags)0)]
        public MetaTime RefreshTime { get; set; }

        [Description("Source which the shop was opened from")]
        [JsonProperty("open_source")]
        [MetaMember(3, (MetaMemberFlags)0)]
        public string OpenSource { get; set; }

        [Description("Board Id if one was open")]
        [MetaMember(4, (MetaMemberFlags)0)]
        [JsonProperty("active_board_id")]
        public string BoardId { get; set; }

        [JsonProperty("open_menu_tag")]
        [MetaMember(5, (MetaMemberFlags)0)]
        [Description("Menu Tag if one was open")]
        public string OpenMenuTag { get; set; }

        [MetaMember(6, (MetaMemberFlags)0)]
        [JsonProperty("red_dot_status")]
        [Description("What was the status of the red dot, off, not implemented, or the reason why it was on")]
        public string RedDotStatus { get; set; }

        public AnalyticEventShopOpened()
        {
        }

        public AnalyticEventShopOpened(string impressionId, MetaTime refreshTime, string openSource, string currentBoardId, string openMenuTag, string redDotStatus)
        {
        }
    }
}