using Metaplay.Core.Model;
using System;
using System.Runtime.Serialization;

namespace Code.GameLogic.ExtraSpawns
{
    [MetaSerializableDerived(5)]
    public class CompleteDailyTaskV2Trigger : IExtraSpawnTrigger
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public int? Item { get; set; }

        public CompleteDailyTaskV2Trigger()
        {
        }

        public CompleteDailyTaskV2Trigger(int? item)
        {
        }

        [IgnoreDataMember]
        public ExtraSpawnTriggerType Type { get; }
    }
}