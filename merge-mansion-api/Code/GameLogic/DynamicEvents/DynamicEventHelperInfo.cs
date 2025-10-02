using Metaplay.Core.Model;
using Metaplay.Core.Config;
using Code.GameLogic.Config;
using Metaplay.Core;
using GameLogic.MergeChains;
using Metaplay.Core.Math;
using GameLogic.Config;

namespace Code.GameLogic.DynamicEvents
{
    [MetaSerializable]
    public class DynamicEventHelperInfo : IGameConfigData<DynamicEventHelperId>, IGameConfigData, IHasGameConfigKey<DynamicEventHelperId>, IValidatable
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public DynamicEventHelperId ConfigKey { get; set; }

        [MetaMember(4, (MetaMemberFlags)0)]
        public F32 AmountLvl1 { get; set; }

        public DynamicEventHelperInfo()
        {
        }

        public DynamicEventHelperInfo(DynamicEventHelperId configKey, MergeChainId mergeChain, MergeChainId mergeChainB, F32 amountLvl1)
        {
        }

        [MetaMember(2, (MetaMemberFlags)0)]
        [MetaOnMemberDeserializationFailure("FixRef")]
        public MergeChainDef MergeChainDef { get; set; }

        [MetaMember(3, (MetaMemberFlags)0)]
        [MetaOnMemberDeserializationFailure("FixRef")]
        public MergeChainDef MergeChainBDef { get; set; }
    }
}