using System.Collections.Generic;
using System;

namespace Metaplay.Core.League
{
    public interface IDivisionClientState
    {
        EntityId CurrentDivision { get; set; }

        IEnumerable<IDivisionHistoryEntry> HistoricalDivisions { get; }

        int CurrentDivisionParticipantIdx { get; set; }
    }
}