using Metaplay.Core.Model;
using System.Collections.Generic;

namespace Metaplay.Core.LiveOpsEvent
{
    [MetaSerializable]
    [MetaBlockedMembers(new int[] { 2 })]
    public class PlayerLiveOpsEventsModel
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public Dictionary<MetaGuid, PlayerLiveOpsEventModel> EventModels { get; set; }

        [MetaMember(3, (MetaMemberFlags)0)]
        [ServerOnly]
        public PlayerLiveOpsEventsServerOnlyModel ServerOnly { get; set; }

        public PlayerLiveOpsEventsModel()
        {
        }
    }
}