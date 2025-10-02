using Metaplay.Core.Model;
using Metaplay.Core;
using GameLogic.Hotspots;

namespace GameLogic.Player.Requirements
{
    [MetaSerializableDerived(24)]
    public class HotspotNotCompletedRequirement : PlayerRequirement
    {
        [MetaOnMemberDeserializationFailure("FixRef")]
        [MetaMember(1, (MetaMemberFlags)0)]
        private MetaRef<HotspotDefinition> hotspot;
        public HotspotNotCompletedRequirement()
        {
        }

        public HotspotNotCompletedRequirement(HotspotId hotspot)
        {
        }
    }
}