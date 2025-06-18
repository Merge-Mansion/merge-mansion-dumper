using Metaplay.Core.Math;
using GameLogic.Player.Rewards;

namespace GameLogic.Player.Items.Fishing
{
    public interface IWeightStarRewardData
    {
        F32 Weight { get; }

        PlayerReward Reward { get; }
    }
}