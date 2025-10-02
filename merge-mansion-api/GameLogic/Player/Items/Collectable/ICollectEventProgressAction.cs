using System;

namespace GameLogic.Player.Items.Collectable
{
    public interface ICollectEventProgressAction : ICollectAction
    {
        int ProgressGiven { get; }
    }
}