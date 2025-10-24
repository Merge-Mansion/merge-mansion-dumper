using GameLogic.MergeChains;
using Metaplay.Core;
using Metaplay.Core.Model;
using System.Runtime.Serialization;
using Metaplay.Core.Forms;
using GameLogic.Config;

namespace GameLogic.Player.Rewards
{
    [MetaFormDeprecated]
    [MetaSerializableDerived(20)]
    public class RewardLevelUpMergeChain : PlayerReward
    {
        public RewardLevelUpMergeChain()
        {
        }

        public RewardLevelUpMergeChain(MergeChainId mergeChainId)
        {
        }

        [MetaMember(1, (MetaMemberFlags)0)]
        [MetaOnMemberDeserializationFailure("FixMergeChainRef")]
        private MergeChainDef MergeChainDef { get; set; }
    }
}