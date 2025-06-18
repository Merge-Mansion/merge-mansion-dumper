using Metaplay.Core.Model;
using System;

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
    }
}