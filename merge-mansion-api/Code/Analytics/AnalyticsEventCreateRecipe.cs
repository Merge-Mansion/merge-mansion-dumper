using Metaplay.Core.Analytics;
using Analytics;
using Newtonsoft.Json;
using Metaplay.Core.Model;
using System.ComponentModel;
using GameLogic;
using System;
using System.Collections.Generic;
using GameLogic.MixABooster;
using GameLogic.Config.Costs;
using GameLogic.Player.Rewards;

namespace Code.Analytics
{
    [AnalyticsEvent(217, "Create Recipe", 1, null, true, true, false)]
    public class AnalyticsEventCreateRecipe : AnalyticsServersideEventBase
    {
        public sealed override AnalyticsEventType EventType { get; }

        [JsonProperty("sink_type")]
        [MetaMember(1, (MetaMemberFlags)0)]
        [Description("Type of currency sink")]
        public CurrencySink CurrencySinkTag { get; set; }

        [JsonProperty("recipe_id")]
        [MetaMember(2, (MetaMemberFlags)0)]
        [Description("Created Recipe Id")]
        public string RecipeId { get; set; }

        [JsonProperty("recipe_items")]
        [MetaMember(3, (MetaMemberFlags)0)]
        [Description("Needed items to create recipe")]
        public string ItemIds { get; set; }

        [JsonProperty("recipe_value")]
        [MetaMember(4, (MetaMemberFlags)0)]
        [Description("Total value of each currency in the recipe")]
        public string RecipeValue { get; set; }

        [JsonProperty("recipe_reward")]
        [MetaMember(5, (MetaMemberFlags)0)]
        [Description("Gained reward and number of items")]
        public string RecipeRewards { get; set; }

        [MetaMember(6, (MetaMemberFlags)0)]
        private Currencies[] UsedCurrencies { get; set; }
        public override string EventDescription { get; }
        public override IEnumerable<string> KeywordsForEventInstance { get; }

        public AnalyticsEventCreateRecipe()
        {
        }

        public AnalyticsEventCreateRecipe(CurrencySink currencySink, MixABoosterRecipeId recipeId, IEnumerable<MixABoosterIngredientId> itemIds, IEnumerable<CurrencyCost> combinedCurrencyCost, PlayerReward reward)
        {
        }
    }
}