using Metaplay.Core.Model;
using Metaplay.Core.Guild;

namespace Metaplay.Core.Rewards
{
    [GuildsEnabledCondition]
    [MetaSerializable]
    [UseCustomParserFromDerived]
    public abstract class MetaGuildRewardBase : MetaReward
    {
        protected MetaGuildRewardBase()
        {
        }
    }
}