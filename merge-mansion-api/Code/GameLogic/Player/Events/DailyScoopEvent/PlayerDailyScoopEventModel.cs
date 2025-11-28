using Metaplay.Core.Activables;
using Metaplay.Core.Model;
using Code.GameLogic.GameEvents.DailyScoop;
using Metaplay.Core;

namespace Code.GameLogic.Player.Events.DailyScoopEvent
{
    [MetaSerializable]
    [MetaActivableSet("DailyScoopEvent", false)]
    public class PlayerDailyScoopEventModel : MetaActivableSet<DailyScoopEventId, DailyScoopEventInfo, DailyScoopEventModel>
    {
        public PlayerDailyScoopEventModel()
        {
        }

        [MetaMember(1, (MetaMemberFlags)0)]
        private MetaTime _nextEventStartTime;
    }
}