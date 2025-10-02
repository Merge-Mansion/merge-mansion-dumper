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
        public IDictionary<int, F64> ModesByLastNTransactions { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        public int? LastNDaysDay { get; set; }

        [IgnoreDataMember]
        public IDictionary<int, F64> MedianTransactionsByLastNDays { get; set; }

        [IgnoreDataMember]
        public IDictionary<int, int> AverageNumberOfTransactionsByLastNDays { get; set; }

        [IgnoreDataMember]
        public IDictionary<int, F64> AverageTransactionValueByLastNDays { get; set; }

        [MetaMember(6, (MetaMemberFlags)0)]
        public F64? HighestTransactionPriceLast30Days { get; set; }

        [IgnoreDataMember]
        IReadOnlyDictionary<int, F64> Code.GameLogic.Player.ILastNSegmentsCache.ModesByLastNTransactions { get; }

        [IgnoreDataMember]
        IReadOnlyDictionary<int, F64> Code.GameLogic.Player.ILastNSegmentsCache.MedianTransactionsByLastNDays { get; }

        [IgnoreDataMember]
        IReadOnlyDictionary<int, int> Code.GameLogic.Player.ILastNSegmentsCache.AverageNumberOfTransactionsByLastNDays { get; }

        [IgnoreDataMember]
        IReadOnlyDictionary<int, F64> Code.GameLogic.Player.ILastNSegmentsCache.AverageTransactionValueByLastNDays { get; }

        [IgnoreDataMember]
        Option<F64> Code.GameLogic.Player.ILastNSegmentsCache.HighestTransactionPriceLast30DaysOption { get; }

        [IgnoreDataMember]
        IDictionary<int, F64> Code.GameLogic.Player.IWritableLastNSegmentsCache.ModesByLastNTransactions { get; }

        [IgnoreDataMember]
        IDictionary<int, F64> Code.GameLogic.Player.IWritableLastNSegmentsCache.MedianTransactionsByLastNDays { get; }

        [IgnoreDataMember]
        IDictionary<int, int> Code.GameLogic.Player.IWritableLastNSegmentsCache.AverageNumberOfTransactionsByLastNDays { get; }

        [IgnoreDataMember]
        IDictionary<int, F64> Code.GameLogic.Player.IWritableLastNSegmentsCache.AverageTransactionValueByLastNDays { get; }
    }
}