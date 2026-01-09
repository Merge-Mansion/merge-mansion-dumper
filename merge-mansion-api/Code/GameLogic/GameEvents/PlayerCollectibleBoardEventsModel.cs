using Metaplay.Core.Model;
using Metaplay.Core.Activables;
using System.Collections.Generic;
using Metaplay.Core;
using Metaplay.Core.Offers;

namespace Code.GameLogic.GameEvents
{
    [MetaSerializableDerived(8)]
    [MetaActivableSet("CollectibleBoardEvent", false)]
    public class PlayerCollectibleBoardEventsModel : ExtendableEventSet<CollectibleBoardEventId, CollectibleBoardEventInfo, CollectibleBoardEventModel>
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public List<StaleCollectibleBoardEventExtensionPurchaseInfo> StaleExtensionPurchaseInfos;
        public PlayerCollectibleBoardEventsModel()
        {
        }

        [MetaMember(2, (MetaMemberFlags)0)]
        private MetaTime _nextEventStartTime;
        private static CollectibleBoardEventId GREAT_ESCAPE_EVENT_ID;
        private static OfferPlacementId[] GREAT_ESCAPE_OFFER_IDS;
    }
}