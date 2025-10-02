using Code.GameLogic.Config;
using Metaplay.Core.Config;
using System;

namespace GameLogic.MixABooster
{
    public class MixABoosterRecipeSource : IConfigItemSource<MixABoosterRecipe, MixABoosterRecipeId>, IGameConfigSourceItem<MixABoosterRecipeId, MixABoosterRecipe>, IHasGameConfigKey<MixABoosterRecipeId>
    {
        public MixABoosterRecipeId ConfigKey { get; set; }
        private string RequiredIngredients { get; set; }
        private string RewardType { get; set; }
        private string RewardId { get; set; }
        private string RewardAux0 { get; set; }
        private string RewardAux1 { get; set; }
        private int RewardAmount { get; set; }
        public bool IsSecret { get; set; }

        public MixABoosterRecipeSource()
        {
        }
    }
}