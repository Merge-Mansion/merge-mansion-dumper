using Metaplay.Core.Model;
using Metaplay.Core.League;
using System;

namespace GameLogic.Player.Leaderboard.ClassicRacesEvent
{
    [MetaSerializableDerived(4)]
    public class ClassicRacesEventDivisionClientState : DivisionClientStateBase<ClassicRacesEventDivisionHistoryEntry>
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public bool IsBannedFromParticipating { get; set; }

        public ClassicRacesEventDivisionClientState()
        {
        }
    }
}