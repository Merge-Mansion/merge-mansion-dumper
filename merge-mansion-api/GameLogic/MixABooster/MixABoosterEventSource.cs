using Code.GameLogic.Config;
using Metaplay.Core.Config;
using System;
using Metaplay.Core.Schedule;
using System.Collections.Generic;
using Metaplay.Core;
using GameLogic.Config;
using Metaplay.Core.Offers;

namespace GameLogic.MixABooster
{
    public class MixABoosterEventSource : IConfigItemSource<MixABoosterEventInfo, MixABoosterEventId>, IGameConfigSourceItem<MixABoosterEventId, MixABoosterEventInfo>, IHasGameConfigKey<MixABoosterEventId>
    {
        public MixABoosterEventId ConfigKey { get; set; }
        private bool IsEnabled { get; set; }
        private MetaScheduleBase Schedule { get; set; }
        private List<MetaRef<PlayerSegmentInfo>> Segments { get; set; }
        private string DisplayName { get; set; }
        private string Description { get; set; }
        private string UnlockRequirementType { get; set; }
        private string UnlockRequirementId { get; set; }
        private string UnlockRequirementAmount { get; set; }
        private string UnlockRequirementAux0 { get; set; }
        private OfferPlacementId PlacementId { get; set; }
        public List<MetaRef<MixABoosterRecipe>> Recipes { get; set; }
        public string InitialIngredients { get; set; }

        public MixABoosterEventSource()
        {
        }

        private string ContextCategory { get; set; }
        private string ContextSubCategory { get; set; }
    }
}