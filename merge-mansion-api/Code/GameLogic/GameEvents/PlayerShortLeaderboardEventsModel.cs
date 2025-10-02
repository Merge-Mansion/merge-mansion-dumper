using Metaplay.Core.Activables;
using Metaplay.Core.Model;

namespace Code.GameLogic.GameEvents
{
    [MetaSerializableDerived(19)]
    [MetaActivableSet("ShortLeaderboardEvent", false)]
    public class PlayerShortLeaderboardEventsModel : MetaActivableSet<ShortLeaderboardEventId, ShortLeaderboardEventInfo, ShortLeaderboardEventModel>
    {
        public PlayerShortLeaderboardEventsModel()
        {
        }
    }
}