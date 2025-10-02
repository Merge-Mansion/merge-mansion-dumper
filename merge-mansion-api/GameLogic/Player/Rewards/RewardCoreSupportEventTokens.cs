using Metaplay.Core.Model;
using Code.GameLogic.GameEvents;
using System;

namespace GameLogic.Player.Rewards
{
    [MetaSerializableDerived(46)]
    public class RewardCoreSupportEventTokens : PlayerReward
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public CoreSupportEventTokenId TokenId { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        public long Amount { get; set; }

        public RewardCoreSupportEventTokens()
        {
        }

        public RewardCoreSupportEventTokens(CoreSupportEventTokenId tokenId, long amount)
        {
        }
    }
}