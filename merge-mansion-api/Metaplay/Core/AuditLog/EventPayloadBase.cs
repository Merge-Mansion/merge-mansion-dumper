using Metaplay.Core.Model;
using System.Collections.Generic;
using System;
using Newtonsoft.Json;

namespace Metaplay.Core.AuditLog
{
    [MetaSerializable]
    [MetaReservedMembers(100, 200)]
    public abstract class EventPayloadBase
    {
        [MetaMember(100, (MetaMemberFlags)0)]
        public List<string> RelatedEventIds { get; set; }
        public abstract string EventTitle { get; }

        [JsonIgnore]
        public abstract string EventDescription { get; }

        [JsonProperty("eventDescription")]
        public string EventDescriptionErrorWrapper { get; }
    }
}