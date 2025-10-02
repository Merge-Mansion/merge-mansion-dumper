using Metaplay.Core.Model;
using Metaplay.Core.Config;
using System.Collections.Generic;
using GameLogic.Player.Rewards;
using Metaplay.Core;
using GameLogic.Player.Items;
using GameLogic.Config;

namespace Code.GameLogic.GameEvents
{
    [MetaSerializable]
    public class GarageCleanupRewardInfo : IGameConfigData<GarageCleanupRewardId>, IGameConfigData, IHasGameConfigKey<GarageCleanupRewardId>
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public GarageCleanupRewardId ConfigKey { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        public List<PlayerReward> Rewards { get; set; }

        [MetaMember(3, (MetaMemberFlags)0)]
        [MetaOnMemberDeserializationFailure("FixRef")]
        public ItemDef VisualItem { get; set; }

        public GarageCleanupRewardInfo()
        {
        }

        public GarageCleanupRewardInfo(GarageCleanupRewardId rewardId, List<PlayerReward> rewards, MetaRef<ItemDefinition> visualItem)
        {
        }
    }
}