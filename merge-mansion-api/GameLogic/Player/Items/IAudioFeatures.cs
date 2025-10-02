using System;

namespace GameLogic.Player.Items
{
    public interface IAudioFeatures
    {
        string ActivationAutoSfx { get; }

        string ActivationManualSfx { get; }

        string CollectableSfx { get; }

        string SinkProgressSfx { get; }

        string SinkCompletedSfx { get; }

        string SelectSfx { get; }

        string SpawnSfx { get; }

        string MergeSfx { get; }

        string DecaySfx { get; }

        string FishingSfx { get; }
    }
}