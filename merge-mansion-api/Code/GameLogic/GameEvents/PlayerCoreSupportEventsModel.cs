using Metaplay.Core.Model;
using Metaplay.Core.Activables;

namespace Code.GameLogic.GameEvents
{
    [MetaSerializableDerived(22)]
    [MetaActivableSet("CoreSupportEvent", false)]
    public class PlayerCoreSupportEventsModel : MetaActivableSet<CoreSupportEventId, CoreSupportEventInfo, CoreSupportEventModel>
    {
        public PlayerCoreSupportEventsModel()
        {
        }
    }
}