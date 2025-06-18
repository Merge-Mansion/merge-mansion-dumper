using System;

namespace GameLogic.Player.Items.Collectable
{
    public interface ITimeSkipCollectAction : ICollectAction
    {
        double DurationToSkipMinutes { get; }
    }
}