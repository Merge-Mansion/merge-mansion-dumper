using System.Collections.Generic;
using System;
using Metaplay.Core.Math;
using Metacore.MergeMansion.Common.Options;

namespace Code.GameLogic.Player
{
    public interface ILastNSegmentsCache
    {
        Dictionary<int, F64> ModesByLastNTransactions { get; }

        Dictionary<int, F64> MedianTransactionsByLastNDays { get; }

        Dictionary<int, int> AverageNumberOfTransactionsByLastNDays { get; }

        Dictionary<int, F64> AverageTransactionValueByLastNDays { get; }

        F64? HighestTransactionPriceLast30Days { get; }
    }
}