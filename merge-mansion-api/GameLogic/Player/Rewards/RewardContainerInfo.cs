using Metaplay.Core.Model;
using Metaplay.Core.Config;
using System;
using System.Collections.Generic;
using GameLogic.ConfigPrefabs;
using Code.GameLogic.Config;

namespace GameLogic.Player.Rewards
{
    [MetaSerializable]
    [MetaBlockedMembers(new int[] { 7 })]
    public class RewardContainerInfo : IGameConfigData<RewardContainerId>, IGameConfigData, IHasGameConfigKey<RewardContainerId>, IValidatable
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public RewardContainerId ConfigKey { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        public string PoolTag { get; set; }

        [MetaMember(3, (MetaMemberFlags)0)]
        public string SkinName { get; set; }

        [MetaMember(4, (MetaMemberFlags)0)]
        private string OverrideLocalizationRewardContainerId { get; set; }

        [MetaMember(5, (MetaMemberFlags)0)]
        public int MinAmount { get; set; }

        [MetaMember(6, (MetaMemberFlags)0)]
        public int MaxAmount { get; set; }

        public RewardContainerInfo()
        {
        }

        public RewardContainerInfo(RewardContainerId configKey, string poolTag, string skinName, string overrideLocalizationRewardContainerId, int minAmount, int maxAmount, List<RewardContainerItem> items)
        {
        }

        [MetaMember(8, (MetaMemberFlags)0)]
        public ConfigAssetPackId ModelId { get; set; }

        [MetaMember(9, (MetaMemberFlags)0)]
        public bool UseIconLibrary { get; set; }

        [MetaMember(10, (MetaMemberFlags)0)]
        public string SfxClose { get; set; }

        [MetaMember(11, (MetaMemberFlags)0)]
        public string SfxOpen { get; set; }

        public RewardContainerInfo(RewardContainerId configKey, string poolTag, string skinName, string overrideLocalizationRewardContainerId, int minAmount, int maxAmount, List<RewardContainerItem> items, ConfigAssetPackId modelId, bool useIconLibrary, string sfxClose, string sfxOpen)
        {
        }

        [MetaMember(12, (MetaMemberFlags)0)]
        public List<RewardContainerItemGroup> ItemGroups { get; set; }

        [MetaMember(13, (MetaMemberFlags)0)]
        public bool ShowChances { get; set; }
    }
}