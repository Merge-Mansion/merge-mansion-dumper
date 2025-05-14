using Metacore.MergeMansion.Common.Options;
using System;
using GameLogic.Player.Items;

namespace Code.GameLogic.GameEvents
{
    public interface ICoreSupportEventInfo : IEventSharedInfo, ILevelEventInfo
    {
        CoreSupportEventId ConfigKey { get; }

        CoreSupportEventType EventType { get; }

        Option<CoreSupportEventMinigameId> MinigameIdOption { get; }

        string AssetId { get; }

        string LocIdPrefix { get; }

        Option<ItemDefinition> PortalItemOption { get; }

        CoreSupportEventTokenId TokenId { get; }

        Option<CoreSupportEventCollectionId> CollectionIdOption { get; }

        string NameLocId { get; }
    }
}