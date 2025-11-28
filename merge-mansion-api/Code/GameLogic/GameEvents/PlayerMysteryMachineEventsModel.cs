using Metaplay.Core.Model;
using Metaplay.Core.Activables;
using Metaplay.Core;

namespace Code.GameLogic.GameEvents
{
    [MetaSerializableDerived(11)]
    [MetaActivableSet("MysteryMachineEvent", false)]
    public class PlayerMysteryMachineEventsModel : MetaActivableSet<MysteryMachineEventId, MysteryMachineEventInfo, MysteryMachineEventModel>
    {
        public PlayerMysteryMachineEventsModel()
        {
        }

        [MetaMember(1, (MetaMemberFlags)0)]
        private MetaTime _nextEventStartTime;
    }
}