using Code.GameLogic.Config;
using Metaplay.Core.Config;
using System;

namespace Code.GameLogic.Player.Requirements
{
    public class RequirementSource : IConfigItemSource<RequirementInfo, RequirementId>, IGameConfigSourceItem<RequirementId, RequirementInfo>, IHasGameConfigKey<RequirementId>
    {
        public RequirementId ConfigKey { get; set; }
        private string RequirementType { get; set; }
        private string RequirementId { get; set; }
        private string RequirementAmount { get; set; }
        private string RequirementAux0 { get; set; }
    }
}