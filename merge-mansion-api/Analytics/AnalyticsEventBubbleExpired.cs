using Metaplay.Core.Analytics;
using Metaplay.Core.Model;
using Newtonsoft.Json;
using System.ComponentModel;
using System;
using Merge;
using System.Collections.Generic;
using GameLogic;

namespace Analytics
{
    [AnalyticsEvent(102, "Bubble expired", 1, null, false, true, false)]
    [MetaBlockedMembers(new int[] { 2, 6, 7, 9, 10 })]
    public class AnalyticsEventBubbleExpired : AnalyticsServersideEventBase
    {
        public sealed override AnalyticsEventType EventType { get; }

        [JsonProperty("item_name")]
        [MetaMember(1, (MetaMemberFlags)0)]
        [Description("Item that was in the expired bubble")]
        public string ItemInBubble { get; set; }

        [JsonProperty("dismissed")]
        [MetaMember(4, (MetaMemberFlags)0)]
        [Description("Was the bubble dismissed")]
        public bool Dismissed { get; set; }

        [JsonProperty("board_id")]
        [MetaMember(5, (MetaMemberFlags)0)]
        [Description("Merge Board Id")]
        public MergeBoardId BoardId { get; set; }
        public override string EventDescription { get; }

        public AnalyticsEventBubbleExpired()
        {
        }

        public AnalyticsEventBubbleExpired(string itemInBubble, int bubbleCostInDiamonds, MergeBoardId boardId, bool dismissed)
        {
        }

        [MetaMember(11, (MetaMemberFlags)0)]
        [JsonProperty("attachments")]
        [Description("Attachments to the bubble")]
        [BigQueryAnalyticsFormat((BigQueryAnalyticsFormatMode)0)]
        [MetaAllowNondeterministicCollection]
        public Dictionary<string, int> Attachment { get; set; }

        public AnalyticsEventBubbleExpired(string itemInBubble, int bubbleCostInDiamonds, MergeBoardId boardId, string attachment, int attachmentAmount, bool dismissed)
        {
        }

        [JsonProperty("active_ads")]
        [MetaMember(8, (MetaMemberFlags)0)]
        [Description("Is there and Active ads on the bubble")]
        public bool IsActiveAds { get; set; }

        public AnalyticsEventBubbleExpired(string itemInBubble, int bubbleCostInDiamonds, MergeBoardId boardId, string attachment, int attachmentAmount, bool isActiveAds, bool dismissed)
        {
        }

        public AnalyticsEventBubbleExpired(string itemInBubble, int bubbleCostInDiamonds, MergeBoardId boardId, Dictionary<string, int> attachment, bool isActiveAds, bool dismissed)
        {
        }

        [JsonProperty("bubble_cost")]
        [MetaMember(3, (MetaMemberFlags)0)]
        [Description("How much the bubble popping cost in diamonds")]
        public int BubbleCostAmount { get; set; }

        [JsonProperty("bubble_currency")]
        [MetaMember(12, (MetaMemberFlags)0)]
        [Description("Which currency it cost to pop the bubble")]
        public Currencies Currency { get; set; }
    }
}