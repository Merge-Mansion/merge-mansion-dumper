using Metaplay.Core.Model;
using Metaplay.Core.Activables;
using Metaplay.Core;

namespace Code.GameLogic.GameEvents
{
    [MetaSerializableDerived(17)]
    [MetaActivableSet("BoultonLeagueEvent", false)]
    public class PlayerBoultonLeagueEventsModel : MetaActivableSet<BoultonLeagueEventId, BoultonLeagueEventInfo, BoultonLeagueEventModel>
    {
        public PlayerBoultonLeagueEventsModel()
        {
        }

        [MetaMember(1, (MetaMemberFlags)0)]
        private MetaTime _nextEventStartTime;
    }
}