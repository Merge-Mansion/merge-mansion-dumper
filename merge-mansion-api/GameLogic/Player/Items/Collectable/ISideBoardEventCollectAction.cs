using Code.GameLogic.GameEvents;
using System;

namespace GameLogic.Player.Items.Collectable
{
    public interface ISideBoardEventCollectAction : IProgressCollectAction, ICollectAction
    {
        SideBoardEventId SideBoardEventId { get; }

        bool LevelUpMergeChain { get; }
    }
}