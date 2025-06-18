using Code.GameLogic.Config;
using Metaplay.Core.Config;
using System;
using System.Collections.Generic;
using Metaplay.Core;
using GameLogic.Config;
using Metaplay.Core.Schedule;
using Metaplay.Core.Player;

namespace Code.GameLogic.GameEvents
{
    public class CoreSupportEventSource : IConfigItemSource<CoreSupportEventInfo, CoreSupportEventId>, IGameConfigSourceItem<CoreSupportEventId, CoreSupportEventInfo>, IHasGameConfigKey<CoreSupportEventId>
    {
        public CoreSupportEventId ConfigKey { get; set; }
        private string DisplayName { get; set; }
        private string Description { get; set; }
        private List<MetaRef<PlayerSegmentInfo>> Segments { get; set; }
        private bool IsEnabled { get; set; }
        private MetaScheduleBase Schedule { get; set; }
        private EventGroupId GroupId { get; set; }
        private int Priority { get; set; }
        private CoreSupportEventType EventType { get; set; }
        private CoreSupportEventMinigameId MinigameId { get; set; }
        private string AssetOverride { get; set; }
        private string LocOverride { get; set; }
        private string PortalItem { get; set; }
        private CoreSupportEventTokenId Token { get; set; }
        private string TokenAsset { get; set; }
        private string TokenLoc { get; set; }
        private long TokensAtStart { get; set; }
        private List<MetaRef<EventLevelInfo>> Levels { get; set; }
        private List<MetaRef<EventLevelInfo>> RecurringLevels { get; set; }
        private string FallbackLevels { get; set; }
        private string UnlockRequirementType { get; set; }
        private string UnlockRequirementId { get; set; }
        private string UnlockRequirementAmount { get; set; }
        private string UnlockRequirementAux0 { get; set; }
        private string PreviewRequirementType { get; set; }
        private string PreviewRequirementId { get; set; }
        private string PreviewRequirementAmount { get; set; }
        private string PreviewRequirementAux0 { get; set; }
        private List<MetaRef<CoreSupportEventModeInfo>> Modes { get; set; }
        private string ContextCategory { get; set; }
        private string ContextSubCategory { get; set; }
        private PlayerSegmentId Segment { get; set; }
        private int SegmentPriority { get; set; }
        private CoreSupportEventCollectionId CollectionId { get; set; }

        public CoreSupportEventSource()
        {
        }

        private CoreSupportEventStartPopupAction StartPopupAction { get; set; }
        private CoreSupportEventTokenTarget FallbackTokenTarget { get; set; }
        private CoreSupportEventTokenType TokenType { get; set; }
    }
}