using Metaplay.Core.Model;
using System;
using Metaplay.Core.Player;
using System.Collections.Generic;

namespace GameLogic.Player.Rewards
{
    [MetaSerializable]
    [MetaBlockedMembers(new int[] { 1, 8 })]
    public class RewardContainerItem
    {
        [MetaMember(9, (MetaMemberFlags)0)]
        public PlayerRewardType Type { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        public string Item { get; set; }

        [MetaMember(3, (MetaMemberFlags)0)]
        public string ItemAux0 { get; set; }

        [MetaMember(4, (MetaMemberFlags)0)]
        public string ItemAux1 { get; set; }

        [MetaMember(5, (MetaMemberFlags)0)]
        public int MinAmount { get; set; }

        [MetaMember(6, (MetaMemberFlags)0)]
        public int MaxAmount { get; set; }

        [MetaMember(7, (MetaMemberFlags)0)]
        public int BatchAmount { get; set; }

        public RewardContainerItem()
        {
        }

        public RewardContainerItem(RewardContainerItemType type, string item, string itemAux0, string itemAux1, int minAmount, int maxAmount, int? batchAmount, int weight)
        {
        }

        [MetaMember(10, (MetaMemberFlags)0)]
        private Dictionary<PlayerSegmentId, int> SegmentedWeights { get; set; }

        [MetaMember(11, (MetaMemberFlags)0)]
        public int ShowMinAmount { get; set; }

        [MetaMember(12, (MetaMemberFlags)0)]
        public int ShowMaxAmount { get; set; }
    }
}