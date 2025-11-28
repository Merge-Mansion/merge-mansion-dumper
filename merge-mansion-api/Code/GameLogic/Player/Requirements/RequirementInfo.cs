using Metaplay.Core.Model;
using Metaplay.Core.Config;
using GameLogic.Player.Requirements;

namespace Code.GameLogic.Player.Requirements
{
    [MetaSerializable]
    public class RequirementInfo : IGameConfigData<RequirementId>, IGameConfigData, IHasGameConfigKey<RequirementId>
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public RequirementId ConfigKey { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        public PlayerRequirement Requirement { get; set; }
    }
}