using Metaplay.Core.Model;
using Metaplay.Core.Config;
using System.Collections.Generic;
using GameLogic.Player.Requirements;
using System;

namespace GameLogic.Area
{
    [MetaSerializable]
    public class AreasGlobalUnlockRequirementInfo : IGameConfigData<AreasGlobalUnlockRequirementId>, IGameConfigData, IHasGameConfigKey<AreasGlobalUnlockRequirementId>
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public AreasGlobalUnlockRequirementId ConfigKey { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        public List<PlayerRequirement> UnlockRequirements { get; set; }

        [MetaMember(3, (MetaMemberFlags)0)]
        public string DescriptionLocalizationId { get; set; }

        [MetaMember(4, (MetaMemberFlags)0)]
        public List<AreaId> IgnoreAreas { get; set; }

        public AreasGlobalUnlockRequirementInfo()
        {
        }

        public AreasGlobalUnlockRequirementInfo(AreasGlobalUnlockRequirementId configKey, List<PlayerRequirement> unlockRequirements, string descriptionLocalizationId, List<AreaId> ignoreAreas)
        {
        }
    }
}