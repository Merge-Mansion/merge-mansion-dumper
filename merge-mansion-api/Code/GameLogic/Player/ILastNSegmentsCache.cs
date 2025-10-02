using System.Collections.Generic;
using System;
using Metaplay.Core.Math;
using Metacore.MergeMansion.Common.Options;

namespace Code.GameLogic.Player
{
    public interface ILastNSegmentsCache
    {
        IReadOnlyDictionary<int, F64> ModesByLastNTransactions { get; }

        IReadOnlyDictionary<int, F64> MedianTransactionsByLastNDays { get; }

        IReadOnlyDictionary<int, int> AverageNumberOfTransactionsByLastNDays { get; }

        IReadOnlyDictionary<int, F64> AverageTransactionValueByLastNDays { get; }

        Option<F64> HighestTransactionPriceLast30DaysOption { get; }
    }
}