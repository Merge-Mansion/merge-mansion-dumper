using Metaplay.Core.Model;
using Metaplay.Core.Activables;
using Code.GameLogic.GameEvents;

namespace GameLogic.Player.Events.AdStampCardEvent
{
    [MetaSerializableDerived(24)]
    [MetaActivableSet("AdStampCardEvent", false)]
    public class PlayerAdStampCardEventModel : MetaActivableSet<AdStampCardEventId, AdStampCardEventInfo, AdStampCardEventModel>
    {
        public PlayerAdStampCardEventModel()
        {
        }
    }
}