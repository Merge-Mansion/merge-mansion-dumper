using Metaplay.Core.Model;
using Game.Cloud.Config;
using GameLogic.MergeChains;

namespace GameLogic.Config
{
    [MetaSerializableDerived(3)]
    public class MergeChainDef : ConfigDefinition<MergeChainId, MergeChainDefinition>
    {
    }
}