using Metaplay.Core.Model;
using Metaplay.Core.Config;
using GameLogic.Player.Rewards;
using Code.GameLogic.Config;

namespace GameLogic.Fallbacks
{
    [MetaSerializable]
    public class FallbackPlayerRewardInfo : IGameConfigData<FallbackPlayerRewardId>, IGameConfigData, IHasGameConfigKey<FallbackPlayerRewardId>, IValidatable
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public FallbackPlayerRewardId ConfigKey { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        public PlayerReward Reward { get; set; }

        public FallbackPlayerRewardInfo()
        {
        }

        public FallbackPlayerRewardInfo(FallbackPlayerRewardId fallbackPlayerRewardId, PlayerReward reward)
        {
        }
    }
}