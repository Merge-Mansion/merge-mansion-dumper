using Code.GameLogic.Config;
using Metaplay.Core.Config;
using System;

namespace GameLogic.MixABooster
{
    public class MixABoosterIngredientSource : IConfigItemSource<MixABoosterIngredient, MixABoosterIngredientId>, IGameConfigSourceItem<MixABoosterIngredientId, MixABoosterIngredient>, IHasGameConfigKey<MixABoosterIngredientId>
    {
        public MixABoosterIngredientId ConfigKey { get; set; }
        private string CostType { get; set; }
        private string CostId { get; set; }
        private int CostAmount { get; set; }

        public MixABoosterIngredientSource()
        {
        }
    }
}