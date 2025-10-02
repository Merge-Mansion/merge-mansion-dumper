using Metaplay.Core.Model;
using Metaplay.Core.EventLog;
using System;
using System.Collections.Generic;
using Metaplay.Core.Analytics;

namespace Metaplay.Core.Player
{
    [MetaSerializable]
    public class PlayerEventLogEntry : EntityEventLogEntry<PlayerEventBase, PlayerEventDeserializationFailureSubstitute>
    {
        private PlayerEventLogEntry()
        {
        }

        public PlayerEventLogEntry(MetaEventLogEntry.BaseParams baseParams, MetaTime modelTime, int payloadSchemaVersion, PlayerEventBase payload)
        {
        }

        public PlayerEventLogEntry(MetaEventLogEntry.BaseParams baseParams, MetaTime modelTime, int payloadSchemaVersion, PlayerEventBase payload, AnalyticsContextBase context, Dictionary<int, string> labelsAsInts)
        {
        }
    }
}