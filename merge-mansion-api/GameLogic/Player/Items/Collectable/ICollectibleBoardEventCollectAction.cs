using System;

namespace GameLogic.Player.Items.Collectable
{
    public interface ICollectibleBoardEventCollectAction : IProgressCollectAction, ICollectAction
    {
        bool LevelUpMergeChain { get; }
    }
}