using System;

namespace GameLogic.Player.Items.Collectable
{
    public interface IShortLeaderboardEventCollectAction : IProgressCollectAction, ICollectAction
    {
        bool LevelUpMergeChain { get; }
    }
}