using Metaplay.Core.Activables;
using Metaplay.Core.Model;
using Metaplay.Core;

namespace GameLogic.Config.EnergyModeEvent
{
    [MetaSerializableDerived(12)]
    [MetaActivableSet("EnergyModeEvent", false)]
    public class PlayerEnergyModeEventsModel : MetaActivableSet<EnergyModeEventId, EnergyModeEventInfo, EnergyModeEventModel>
    {
        public PlayerEnergyModeEventsModel()
        {
        }

        [MetaMember(1, (MetaMemberFlags)0)]
        private MetaTime _nextEventStartTime;
    }
}