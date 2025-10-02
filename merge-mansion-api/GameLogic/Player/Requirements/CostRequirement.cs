using GameLogic.Config.Costs;
using Metaplay.Core.Model;

namespace GameLogic.Player.Requirements
{
    [MetaSerializableDerived(6)]
    public class CostRequirement : PlayerRequirement
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public ICost RequiredCost { get; set; }

        public CostRequirement()
        {
        }

        public CostRequirement(ICost cost)
        {
        }
    }
}