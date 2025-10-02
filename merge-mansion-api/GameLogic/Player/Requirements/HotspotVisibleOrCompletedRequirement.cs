using GameLogic.Hotspots;
using Metaplay.Core;
using Metaplay.Core.Model;

namespace GameLogic.Player.Requirements
{
    [MetaSerializableDerived(4)]
    public class HotspotVisibleOrCompletedRequirement : PlayerRequirement
    {
        [MetaOnMemberDeserializationFailure("FixRef")]
        [MetaMember(1, (MetaMemberFlags)0)]
        private MetaRef<HotspotDefinition> hotspot;
        public HotspotVisibleOrCompletedRequirement()
        {
        }

        public HotspotVisibleOrCompletedRequirement(HotspotDefinition hotspot)
        {
        }

        // CUSTOM: Copied from HotspotCompletedRequirement
        public MetaRef<HotspotDefinition> GetRequiredHotspot()
        {
            return hotspot;
        }

        public HotspotVisibleOrCompletedRequirement(HotspotId hotspot)
        {
        }
    }
}