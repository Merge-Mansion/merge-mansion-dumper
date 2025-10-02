using Metaplay.Core.Model;
using Metaplay.Core.Config;
using System.Collections.Generic;
using System;
using GameLogic.Player.Rewards;
using System.Runtime.Serialization;

namespace GameLogic.MixABooster
{
    [MetaSerializable]
    public class MixABoosterRecipe : IGameConfigData<MixABoosterRecipeId>, IGameConfigData, IHasGameConfigKey<MixABoosterRecipeId>
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public MixABoosterRecipeId ConfigKey { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        private Dictionary<MixABoosterIngredientId, int> RequiredIngredients { get; set; }

        [MetaMember(3, (MetaMemberFlags)0)]
        public PlayerReward Reward { get; set; }

        [MetaMember(4, (MetaMemberFlags)0)]
        public bool IsSecret { get; set; }

        [IgnoreDataMember]
        public IReadOnlyDictionary<MixABoosterIngredientId, int> IngredientIds { get; }
        public IEnumerable<MixABoosterIngredientId> FlattenedIngredients { get; }

        public MixABoosterRecipe()
        {
        }

        public MixABoosterRecipe(MixABoosterRecipeId configKey, Dictionary<MixABoosterIngredientId, int> requiredIngredients, PlayerReward reward, bool isSecret)
        {
        }
    }
}