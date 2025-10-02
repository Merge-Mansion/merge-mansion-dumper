using Metaplay.Core.Model;
using Metaplay.Core.EventLog;
using System;
using System.Collections.Generic;
using Metaplay.Core.Analytics;

namespace Metaplay.Core.Guild
{
    [MetaSerializable]
    public class GuildEventLogEntry : EntityEventLogEntry<GuildEventBase, GuildEventDeserializationFailureSubstitute>
    {
        private GuildEventLogEntry()
        {
        }

        public GuildEventLogEntry(MetaEventLogEntry.BaseParams baseParams, MetaTime modelTime, int payloadSchemaVersion, GuildEventBase payload)
        {
        }

        public GuildEventLogEntry(MetaEventLogEntry.BaseParams baseParams, MetaTime modelTime, int payloadSchemaVersion, GuildEventBase payload, AnalyticsContextBase context, Dictionary<int, string> labelsAsInts)
        {
        }
    }
}