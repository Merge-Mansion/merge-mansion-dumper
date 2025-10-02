using System.Collections.Generic;
using System;

namespace Code.GameLogic.Config
{
    public interface ILastNSegmentsConfig
    {
        IReadOnlyList<int> ModeLastNTransactionsSegments { get; }

        IReadOnlyList<int> MedianTransactionLastNDaysSegments { get; }

        IReadOnlyList<int> AverageNumberOfTransactionsInNDaysSegments { get; }

        IReadOnlyList<int> AverageTransactionValueInNDaysSegments { get; }
    }
}