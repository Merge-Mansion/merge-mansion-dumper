using Metaplay.Core.Model;
using Metaplay.Core.Config;
using GameLogic.Player.Requirements;
using Metaplay.Core.Player;

namespace Code.GameLogic.GameEvents
{
    [MetaSerializable]
    [MetaBlockedMembers(new int[] { 2, 3 })]
    public class CoreSupportEventModeInfo : IGameConfigData<CoreSupportEventModeId>, IGameConfigData, IHasGameConfigKey<CoreSupportEventModeId>
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public CoreSupportEventModeId ConfigKey { get; set; }

        [MetaMember(4, (MetaMemberFlags)0)]
        private PlayerSegmentId EnableRequirement { get; set; }

        [MetaMember(5, (MetaMemberFlags)0)]
        private PlayerSegmentId DisableRequirement { get; set; }

        protected CoreSupportEventModeInfo()
        {
        }

        protected CoreSupportEventModeInfo(CoreSupportEventModeId configKey, PlayerRequirement enableRequirement, PlayerRequirement disableRequirement)
        {
        }

        public CoreSupportEventModeInfo(CoreSupportEventModeId configKey, PlayerSegmentId enableRequirement, PlayerSegmentId disableRequirement)
        {
        }
    }
}