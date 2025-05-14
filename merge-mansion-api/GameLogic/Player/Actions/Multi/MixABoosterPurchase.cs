using Metaplay.Core.Model;
using GameLogic.MixABooster;

namespace GameLogic.Player.Actions.Multi
{
    [ModelAction(30101)]
    public class MixABoosterPurchase : PlayerAction
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        private MixABoosterRecipeId RecipeId { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        private MixABoosterEventId EventId { get; set; }

        public MixABoosterPurchase()
        {
        }

        public MixABoosterPurchase(MixABoosterRecipeId recipeId, MixABoosterEventId eventId)
        {
        }
    }
}