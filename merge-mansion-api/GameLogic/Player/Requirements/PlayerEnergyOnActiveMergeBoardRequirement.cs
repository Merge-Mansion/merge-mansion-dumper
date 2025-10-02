using Metaplay.Core.Model;
using System;

namespace GameLogic.Player.Requirements
{
    [MetaSerializableDerived(59)]
    public class PlayerEnergyOnActiveMergeBoardRequirement : PlayerRequirement
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        private long MinAmount { get; set; }

        public PlayerEnergyOnActiveMergeBoardRequirement()
        {
        }

        public PlayerEnergyOnActiveMergeBoardRequirement(long minAmount)
        {
        }
    }
}