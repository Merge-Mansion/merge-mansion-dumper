using System;

namespace GameLogic.Player.Rewards
{
    public interface IPlayerReward
    {
        CurrencySource Source { get; }

        bool ShouldShowInfoButton { get; }
    }
}