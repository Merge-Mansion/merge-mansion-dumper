using Metaplay.Core.Model;
using Newtonsoft.Json;
using System.ComponentModel;
using System;

namespace Metacore.MergeMansion.Analytics
{
    [MetaSerializable]
    public class AnalyticsRollTheDiceIngredientData
    {
        [JsonProperty("ingredient_type")]
        [MetaMember(1, (MetaMemberFlags)0)]
        [Description("Type of the ingredient")]
        public string Type { get; set; }

        [JsonProperty("ingredient_amount")]
        [MetaMember(2, (MetaMemberFlags)0)]
        [Description("Ingredient amount")]
        public long Amount { get; set; }
    }
}