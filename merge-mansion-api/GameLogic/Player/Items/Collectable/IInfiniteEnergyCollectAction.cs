using System;

namespace GameLogic.Player.Items.Collectable
{
    public interface IInfiniteEnergyCollectAction : ICollectAction
    {
        double DurationMinutes { get; }
    }
}