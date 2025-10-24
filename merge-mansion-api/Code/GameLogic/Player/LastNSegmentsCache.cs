using Metaplay.Core.Model;
using System;
using Metaplay.Core.Math;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Metacore.MergeMansion.Common.Options;

namespace Code.GameLogic.Player
{
    [MetaSerializable]
    public class LastNSegmentsCache : ILastNSegmentsCache, IWritableLastNSegmentsCache
    {
        [IgnoreDataMember]
        public Dictionary<int, F64> ModesByLastNTransactions { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        public int? LastNDaysDay { get; set; }

        [IgnoreDataMember]
        public Dictionary<int, F64> MedianTransactionsByLastNDays { get; set; }

        [IgnoreDataMember]
        public Dictionary<int, int> AverageNumberOfTransactionsByLastNDays { get; set; }

        [IgnoreDataMember]
        public Dictionary<int, F64> AverageTransactionValueByLastNDays { get; set; }

        [MetaMember(6, (MetaMemberFlags)0)]
        public F64? HighestTransactionPriceLast30Days { get; set; }
    }
}