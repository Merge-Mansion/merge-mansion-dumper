using Metaplay.Core.Model;
using System.Collections.Generic;
using System;

namespace GameLogic.Player.Rewards
{
    [MetaSerializable]
    public class RewardContainerItemGroup
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public List<RewardContainerItem> GroupItems { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        public int GroupMin { get; set; }

        [MetaMember(3, (MetaMemberFlags)0)]
        public int GroupMax { get; set; }
    }
}