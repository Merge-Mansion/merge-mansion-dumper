using Metaplay.Core.Activables;
using Metaplay.Core.Model;
using Code.GameLogic.GameEvents.CardCollectionSupportingEvent;

namespace GameLogic.Player.Events
{
    [MetaSerializableDerived(21)]
    [MetaActivableSet("CardCollectionSupportingEvent", false)]
    public class PlayerCardCollectionSupportingEventsModel : MetaActivableSet<CardCollectionSupportingEventId, CardCollectionSupportingEventInfo, CardCollectionSupportingEventModel>
    {
        public PlayerCardCollectionSupportingEventsModel()
        {
        }
    }
}