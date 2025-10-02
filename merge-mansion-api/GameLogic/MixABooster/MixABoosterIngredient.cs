using Metaplay.Core.Model;
using Metaplay.Core.Config;
using GameLogic.Config.Costs;

namespace GameLogic.MixABooster
{
    [MetaSerializable]
    public class MixABoosterIngredient : IGameConfigData<MixABoosterIngredientId>, IGameConfigData, IHasGameConfigKey<MixABoosterIngredientId>
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public MixABoosterIngredientId ConfigKey { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        public CurrencyCost Cost { get; set; }

        public MixABoosterIngredient()
        {
        }

        public MixABoosterIngredient(MixABoosterIngredientId configKey, CurrencyCost cost)
        {
        }
    }
}