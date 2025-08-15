using Metaplay.Core.Model;
using Metaplay.Core.Analytics;
using Newtonsoft.Json;
using System.ComponentModel;
using System;
using Merge;
using System.Collections.Generic;
using GameLogic;

namespace Analytics
{
    [AnalyticsEvent(107, "Bubble purchased", 1, null, false, true, false)]
    [MetaBlockedMembers(new int[] { 3, 5, 6, 9, 10 })]
    public class AnalyticsEventBubblePurchased : AnalyticsServersideEventBase
    {
        public sealed override AnalyticsEventType EventType { get; }

        [JsonProperty("item_name")]
        [MetaMember(1, (MetaMemberFlags)0)]
        [Description("Item inside the bubble that was bought")]
        public string ItemInBubble { get; set; }

        [JsonProperty("board_id")]
        [MetaMember(4, (MetaMemberFlags)0)]
        [Description("Merge Board Id")]
        public MergeBoardId BoardId { get; set; }
        public override string EventDescription { get; }

        public AnalyticsEventBubblePurchased()
        {
        }

        public AnalyticsEventBubblePurchased(string itemInBubble, int bubbleCostInDiamonds, MergeBoardId boardId)
        {
        }

        [MetaMember(11, (MetaMemberFlags)0)]
        [JsonProperty("attachments")]
        [Description("Attachments to the bubble")]
        [BigQueryAnalyticsFormat((BigQueryAnalyticsFormatMode)0)]
        [MetaAllowNondeterministicCollection]
        public Dictionary<string, int> Attachment { get; set; }

        public AnalyticsEventBubblePurchased(string itemInBubble, int bubbleCostInDiamonds, MergeBoardId boardId, string attachment, int attachmentAmount)
        {
        }

        [JsonProperty("active_ads")]
        [MetaMember(7, (MetaMemberFlags)0)]
        [Description("Is there and Active ads on the bubble")]
        public bool IsActiveAds { get; set; }

        [JsonProperty("purchased_with_ads")]
        [MetaMember(8, (MetaMemberFlags)0)]
        [Description("Was the bubble purchased with an ad")]
        public bool PurchasedWithAds { get; set; }

        public AnalyticsEventBubblePurchased(string itemInBubble, int bubbleCostInDiamonds, MergeBoardId boardId, string attachment, int attachmentAmount, bool isActiveAds, bool purchasedWithAds)
        {
        }

        public AnalyticsEventBubblePurchased(string itemInBubble, int bubbleCostInDiamonds, MergeBoardId boardId, Dictionary<string, int> attachment, bool isActiveAds, bool purchasedWithAds)
        {
        }

        [JsonProperty("bubble_cost")]
        [MetaMember(2, (MetaMemberFlags)0)]
        [Description("How many diamonds the bubble costs")]
        public int BubbleCostAmount { get; set; }

        [JsonProperty("bubble_currency")]
        [MetaMember(12, (MetaMemberFlags)0)]
        [Description("Which currency it cost to pop the bubble")]
        public Currencies Currency { get; set; }
    }
}