using Metaplay.Core.Model;
using System;
using System.Collections.Generic;
using Metaplay.Core.Analytics;
using Newtonsoft.Json;

namespace Metaplay.Core.EventLog
{
    [MetaSerializable]
    public abstract class EntityEventLogEntry<TPayload, TPayloadDeserializationFailureSubstitute> : MetaEventLogEntry
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public MetaTime ModelTime { get; set; }

        [MetaMember(3, (MetaMemberFlags)0)]
        public int PayloadSchemaVersion { get; set; }

        [MetaOnMemberDeserializationFailure("CreatePayloadDeserializationFailureSubstitute")]
        [MetaMember(2, (MetaMemberFlags)0)]
        public TPayload Payload { get; set; }

        protected EntityEventLogEntry()
        {
        }

        public EntityEventLogEntry(MetaEventLogEntry.BaseParams baseParams, MetaTime modelTime, int payloadSchemaVersion, TPayload payload)
        {
        }

        [MetaOnMemberDeserializationFailure("CreateContextDeserializationFailureSubstitute")]
        [MetaMember(4, (MetaMemberFlags)0)]
        public AnalyticsContextBase Context { get; set; }

        [JsonIgnore]
        [MetaMember(5, (MetaMemberFlags)0)]
        public Dictionary<int, string> LabelsAsInts { get; set; }

        [JsonProperty("labels")]
        public Dictionary<string, string> LabelsForDashboard { get; }

        public EntityEventLogEntry(MetaEventLogEntry.BaseParams baseParams, MetaTime modelTime, int payloadSchemaVersion, TPayload payload, AnalyticsContextBase context, Dictionary<int, string> labelsAsInts)
        {
        }
    }
}