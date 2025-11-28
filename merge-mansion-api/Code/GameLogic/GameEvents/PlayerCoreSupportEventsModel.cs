using Metaplay.Core.Model;
using Metaplay.Core.Activables;
using Metaplay.Core;

namespace Code.GameLogic.GameEvents
{
    [MetaSerializableDerived(22)]
    [MetaActivableSet("CoreSupportEvent", false)]
    public class PlayerCoreSupportEventsModel : MetaActivableSet<CoreSupportEventId, CoreSupportEventInfo, CoreSupportEventModel>
    {
        public PlayerCoreSupportEventsModel()
        {
        }

        [MetaMember(1, (MetaMemberFlags)0)]
        private MetaTime _nextEventStartTime;
    }
}