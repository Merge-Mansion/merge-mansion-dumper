using System;

namespace GameLogic.Player.Items.GemMining
{
    public interface IRockChunkFeatures
    {
        bool IsRockChunk { get; }

        int SpawnItemWeight { get; }

        int NoItemWeight { get; }
    }
}