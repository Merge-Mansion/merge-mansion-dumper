using Metaplay.Core.Model;
using Metaplay.Core.Analytics;
using Newtonsoft.Json;
using System.ComponentModel;
using System.Collections.Generic;
using Merge;
using System;
using Code.GameLogic.GameEvents;
using GameLogic;
using GameLogic.Player;

namespace Analytics
{
    [MetaBlockedMembers(new int[] { 1, 2, 3, 8, 9, 10 })]
    [AnalyticsEvent(138, "Board state snapshot", 1, null, false, true, false)]
    public class AnalyticEventBoardState : AnalyticsServersideEventBase
    {
        public override AnalyticsEventType EventType { get; }

        [MetaMember(15, (MetaMemberFlags)0)]
        [JsonProperty("partially_visible_board_items")]
        [Description("Partially visible Board items of all on-going boards")]
        [BigQueryAnalyticsFormat((BigQueryAnalyticsFormatMode)0)]
        public Dictionary<MergeBoardId, Dictionary<string, int>> PartiallyVisibleBoardItems { get; set; }

        [JsonProperty("merge_goals")]
        [Description("Merge goals")]
        [MetaMember(4, (MetaMemberFlags)0)]
        [BigQueryAnalyticsFormat((BigQueryAnalyticsFormatMode)0)]
        public List<HotspotId> MergeGoals { get; set; }

        [Description("Event goals")]
        [JsonProperty("event_goals")]
        [BigQueryAnalyticsFormat((BigQueryAnalyticsFormatMode)0)]
        [MetaMember(5, (MetaMemberFlags)0)]
        public Dictionary<EventId, List<EventTaskId>> EventGoals { get; set; }

        [MetaMember(6, (MetaMemberFlags)0)]
        [JsonProperty("board_items")]
        [BigQueryAnalyticsFormat((BigQueryAnalyticsFormatMode)0)]
        [Description("Board items of all on-going boards")]
        public Dictionary<MergeBoardId, List<AnalyticsBoardStateMetaData>> BoardItems { get; set; }

        [BigQueryAnalyticsFormat((BigQueryAnalyticsFormatMode)0)]
        [Description("Inventory items")]
        [JsonProperty("inventory_items")]
        [MetaMember(7, (MetaMemberFlags)0)]
        public Dictionary<MergeBoardId, List<AnalyticsBoardStateMetaData>> InventoryItems { get; set; }

        [Description("Pocket items")]
        [BigQueryAnalyticsFormat((BigQueryAnalyticsFormatMode)0)]
        [JsonProperty("pocket_items")]
        [MetaMember(16, (MetaMemberFlags)0)]
        public Dictionary<MergeBoardId, Dictionary<string, int>> PocketItems { get; set; }

        [JsonProperty("decorations")]
        [Description("Decorations")]
        [MetaMember(11, (MetaMemberFlags)0)]
        [BigQueryAnalyticsFormat((BigQueryAnalyticsFormatMode)0)]
        public List<AnalyticsBoardStateDecorationMetaData> Decorations { get; set; }

        [MetaMember(12, (MetaMemberFlags)0)]
        [BigQueryAnalyticsFormat((BigQueryAnalyticsFormatMode)0)]
        [Description("Inventory items from extra perk")]
        [JsonProperty("inventory_items_extra")]
        public Dictionary<MergeBoardId, List<AnalyticsBoardStateMetaData>> InventoryExtraItems { get; set; }

        [JsonProperty("hidden_item_count")]
        [MetaMember(13, (MetaMemberFlags)0)]
        [Description("Hidden items count")]
        [BigQueryAnalyticsFormat((BigQueryAnalyticsFormatMode)0)]
        public Dictionary<MergeBoardId, int> HiddenItemCount { get; set; }

        [JsonProperty("gathered_from")]
        [Description("Snapshot taken at session start or session end")]
        [MetaMember(14, (MetaMemberFlags)0)]
        public AnalyticsSnapshotType SnapshotType { get; set; }
        public override string EventDescription { get; }

        public AnalyticEventBoardState()
        {
        }

        public AnalyticEventBoardState(PlayerModel player, AnalyticsSnapshotType snapshotType)
        {
        }

        [BigQueryAnalyticsFormat((BigQueryAnalyticsFormatMode)0)]
        [Description("Producer inventory items")]
        [JsonProperty("producer_inventory_items")]
        [MetaMember(17, (MetaMemberFlags)0)]
        public Dictionary<MergeBoardId, List<AnalyticsBoardStateMetaData>> ProducerInventoryItems { get; set; }

        [BigQueryAnalyticsFormat((BigQueryAnalyticsFormatMode)0)]
        [Description("Rentable inventory items")]
        [JsonProperty("rentable_inventory_items")]
        [MetaMember(18, (MetaMemberFlags)0)]
        public Dictionary<MergeBoardId, List<AnalyticsBoardStateMetaData>> RentableInventoryItems { get; set; }

        [BigQueryAnalyticsFormat((BigQueryAnalyticsFormatMode)0)]
        [MetaMember(19, (MetaMemberFlags)0)]
        [JsonProperty("pets")]
        [Description("Pets")]
        public List<AnalyticsBoardStateDecorationMetaData> Pets { get; set; }
    }
}