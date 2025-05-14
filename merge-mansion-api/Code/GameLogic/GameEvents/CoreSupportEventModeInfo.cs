using Metaplay.Core.Model;
using Metaplay.Core.Config;
using GameLogic.Player.Requirements;

namespace Code.GameLogic.GameEvents
{
    [MetaSerializable]
    [MetaReservedMembers(1, 100)]
    public abstract class CoreSupportEventModeInfo : IGameConfigData<CoreSupportEventModeId>, IGameConfigData, IHasGameConfigKey<CoreSupportEventModeId>
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public CoreSupportEventModeId ConfigKey { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        private PlayerRequirement EnableRequirement { get; set; }

        [MetaMember(3, (MetaMemberFlags)0)]
        private PlayerRequirement DisableRequirement { get; set; }

        protected CoreSupportEventModeInfo()
        {
        }

        protected CoreSupportEventModeInfo(CoreSupportEventModeId configKey, PlayerRequirement enableRequirement, PlayerRequirement disableRequirement)
        {
        }
    }
}