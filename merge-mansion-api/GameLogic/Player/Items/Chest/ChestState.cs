using Metaplay.Core.Model;
using Metaplay.Core.Math;
using Metaplay.Core;
using System.Collections.Generic;
using System;
using System.Runtime.Serialization;
using GameLogic.Config.Types;

namespace GameLogic.Player.Items.Chest
{
    [MetaSerializable]
    public class ChestState : IChestState
    {
        private static F64 oneMinuteGemCost;
        private static F64 timeDiscountMin;
        private static F64 timeDiscountMax;
        private static F64 discountCurve;
        private static F64 upperRangeOfTimeInSeconds;
        [MetaMember(1, (MetaMemberFlags)0)]
        private MetaTime openStartTime;
        [MetaMember(2, (MetaMemberFlags)0)]
        private MetaTime estimatedEndTime;
        [MetaMember(3, (MetaMemberFlags)0)]
        private MetaDuration relativeTimeSpendOnOpen;
        [MetaMember(4, (MetaMemberFlags)0)]
        [MetaOnMemberDeserializationFailure("FixItemListRef")]
        private List<MetaRef<ItemDefinition>> remainingLoot;
        [MetaMember(5, (MetaMemberFlags)0)]
        private bool hasBeenFilled;
        [MetaMember(6, (MetaMemberFlags)0)]
        private MetaTime lastAbsoluteUpdateTime;
        public ChestState()
        {
        }

        [MetaMember(7, (MetaMemberFlags)0)]
        public ulong ActivationCount { get; set; }

        [MetaMember(8, (MetaMemberFlags)0)]
        public ChestContext ChestContext { get; set; }

        [IgnoreDataMember]
        public MetaTime OpenStartTime { get; }

        [IgnoreDataMember]
        public MetaTime EstimatedEndTime { get; }
    }
}