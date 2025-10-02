using Code.GameLogic.Config;
using Metaplay.Core.Config;
using System.Collections.Generic;
using System;

namespace GameLogic.Area
{
    public class AreasGlobalUnlockRequirementSource : IConfigItemSource<AreasGlobalUnlockRequirementInfo, AreasGlobalUnlockRequirementId>, IGameConfigSourceItem<AreasGlobalUnlockRequirementId, AreasGlobalUnlockRequirementInfo>, IHasGameConfigKey<AreasGlobalUnlockRequirementId>
    {
        public AreasGlobalUnlockRequirementId ConfigKey { get; set; }
        public List<string> UnlockRequirementType { get; set; }
        public List<string> UnlockRequirementId { get; set; }
        public List<string> UnlockRequirementAmount { get; set; }
        public List<string> UnlockRequirementAux0 { get; set; }
        public string DescriptionLocalizationId { get; set; }
        public List<AreaId> IgnoreAreas { get; set; }

        public AreasGlobalUnlockRequirementSource()
        {
        }
    }
}