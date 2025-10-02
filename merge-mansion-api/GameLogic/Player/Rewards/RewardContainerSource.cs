using Code.GameLogic.Config;
using Metaplay.Core.Config;
using System;
using System.Collections.Generic;
using GameLogic.ConfigPrefabs;

namespace GameLogic.Player.Rewards
{
    public class RewardContainerSource : IConfigItemSource<RewardContainerInfo, RewardContainerId>, IGameConfigSourceItem<RewardContainerId, RewardContainerInfo>, IHasGameConfigKey<RewardContainerId>
    {
        public RewardContainerId ConfigKey { get; set; }
        public string PoolTag { get; set; }
        public string SkinName { get; set; }
        private string OverrideLocalizationRewardContainerId { get; set; }
        private int MinAmount { get; set; }
        private int MaxAmount { get; set; }
        private List<PlayerRewardType> ItemType { get; set; }
        private List<string> Item { get; set; }
        private List<string> ItemAux0 { get; set; }
        private List<string> ItemAux1 { get; set; }
        private List<int> ItemMinAmount { get; set; }
        private List<int> ItemMaxAmount { get; set; }
        private List<int?> ItemBatchAmount { get; set; }
        private List<int> ItemWeight { get; set; }

        public RewardContainerSource()
        {
        }

        private ConfigAssetPackId ModelId { get; set; }
        private bool UseIconLibrary { get; set; }
        private string SfxClose { get; set; }
        private string SfxOpen { get; set; }
        private List<string> SegmentItemWeight { get; set; }
        private List<int?> ShowMinAmount { get; set; }
        private List<int?> ShowMaxAmount { get; set; }
        private List<string> GroupItems { get; set; }
        private List<int> GroupMinAmount { get; set; }
        private List<int> GroupMaxAmount { get; set; }
        private bool ShowChances { get; set; }
    }
}