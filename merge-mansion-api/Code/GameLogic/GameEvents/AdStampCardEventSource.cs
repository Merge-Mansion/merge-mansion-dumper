using Code.GameLogic.Config;
using Metaplay.Core.Config;
using System;
using System.Collections.Generic;
using Metaplay.Core;
using GameLogic.Config;
using Metaplay.Core.Schedule;
using GameLogic.Story;
using Metaplay.Core.Offers;

namespace Code.GameLogic.GameEvents
{
    public class AdStampCardEventSource : IConfigItemSource<AdStampCardEventInfo, AdStampCardEventId>, IGameConfigSourceItem<AdStampCardEventId, AdStampCardEventInfo>, IHasGameConfigKey<AdStampCardEventId>
    {
        public AdStampCardEventId ConfigKey { get; set; }
        private string DisplayName { get; set; }
        private string Description { get; set; }
        private List<MetaRef<PlayerSegmentInfo>> Segments { get; set; }
        private bool IsEnabled { get; set; }
        private MetaScheduleBase Schedule { get; set; }
        private string UnlockRequirementType { get; set; }
        private string UnlockRequirementId { get; set; }
        private string UnlockRequirementAmount { get; set; }
        private string UnlockRequirementAux0 { get; set; }
        public string DailyRewards { get; set; }
        public string FinalReward { get; set; }
        private int Priority { get; set; }
        public string RequiredAdWatchedPerDay { get; set; }
        public string UnlockPeriods { get; set; }
        public StoryDefinitionId StoryDefinition { get; set; }
        public int FreeInitialStamps { get; set; }
        public OfferPlacementId PlacementId { get; set; }
        private string ContextCategory { get; set; }
        private string ContextSubCategory { get; set; }

        public AdStampCardEventSource()
        {
        }
    }
}