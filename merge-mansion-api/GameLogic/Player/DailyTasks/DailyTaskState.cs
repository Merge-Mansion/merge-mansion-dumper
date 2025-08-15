using Metaplay.Core.Model;
using Metaplay.Core;
using GameLogic.Player.Items;
using System;
using GameLogic.DailyTasks;
using GameLogic.Config;

namespace GameLogic.Player.DailyTasks
{
    [MetaSerializable]
    public class DailyTaskState
    {
        [MetaMember(2, (MetaMemberFlags)0)]
        public int RequiredQuantity { get; set; }

        [MetaMember(4, (MetaMemberFlags)0)]
        public int ResultingQuantity { get; set; }

        [MetaMember(5, (MetaMemberFlags)0)]
        public OverrideItemFeatures ResultingItemOverrideFeatures { get; set; }

        [MetaMember(6, (MetaMemberFlags)0)]
        public MetaTime? TimeTaskCompleted { get; set; }

        [MetaMember(7, (MetaMemberFlags)0)]
        public DailyTaskId DailyTaskId { get; set; }
        public bool IsComplete { get; }

        private DailyTaskState()
        {
        }

        public DailyTaskState(int requiredItem, int requiredQuantity, int resultingItem, int resultingQuantity)
        {
        }

        public DailyTaskState(DailyTaskDefinition definition)
        {
        }

        [MetaMember(8, (MetaMemberFlags)0)]
        public MetaTime? TimeTaskWasPurchased { get; set; }
        public bool IsPurchasedTask { get; }

        public DailyTaskState(DailyTaskDefinition definition, MetaTime timeTaskWasPurchased)
        {
        }

        [MetaMember(1, (MetaMemberFlags)0)]
        [MetaOnMemberDeserializationFailure("FixRef")]
        private ItemDef RequiredItemDef { get; set; }

        [MetaMember(3, (MetaMemberFlags)0)]
        [MetaOnMemberDeserializationFailure("FixRef")]
        private ItemDef ResultingItemDef { get; set; }
    }
}