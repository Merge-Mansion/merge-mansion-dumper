using Metaplay.Core.Activables;
using Metaplay.Core.Model;
using Metaplay.Core;

namespace Code.GameLogic.GameEvents
{
    [MetaSerializableDerived(19)]
    [MetaActivableSet("ShortLeaderboardEvent", false)]
    public class PlayerShortLeaderboardEventsModel : MetaActivableSet<ShortLeaderboardEventId, ShortLeaderboardEventInfo, ShortLeaderboardEventModel>
    {
        public PlayerShortLeaderboardEventsModel()
        {
        }

        [MetaMember(1, (MetaMemberFlags)0)]
        private MetaTime _nextEventStartTime;
    }
}