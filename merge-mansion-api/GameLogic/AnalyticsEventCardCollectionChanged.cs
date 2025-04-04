using Metaplay.Core.Analytics;
using Analytics;
using System.ComponentModel;
using Metaplay.Core.Model;
using Newtonsoft.Json;
using GameLogic.CardCollection;
using System;

namespace GameLogic
{
    [AnalyticsEvent(205, "Card Collection Changed", 1, null, true, true, false)]
    [AnalyticsEventKeywords(new string[] { "event", "discovery" })]
    public class AnalyticsEventCardCollectionChanged : AnalyticsServersideEventBase
    {
        public sealed override AnalyticsEventType EventType { get; }

        [MetaMember(1, (MetaMemberFlags)0)]
        [JsonProperty("collection_id")]
        [Description("Unique ID for each collection")]
        public CardCollectionCardId CollectionId { get; set; }

        [JsonProperty("card_id")]
        [MetaMember(2, (MetaMemberFlags)0)]
        [Description("Unique ID for each card")]
        public CardCollectionCardId CardId { get; set; }

        [JsonProperty("card_stars")]
        [MetaMember(3, (MetaMemberFlags)0)]
        [Description("The number of stars for each card")]
        public CardStars CardStars { get; set; }

        [JsonProperty("set_id")]
        [Description("The set ID for each card")]
        [MetaMember(4, (MetaMemberFlags)0)]
        public CardCollectionCardSetId SetId { get; set; }

        [JsonProperty("pack_id")]
        [MetaMember(5, (MetaMemberFlags)0)]
        [Description("The unique ID of the pack the card is coming from")]
        public CardCollectionPackId PackId { get; set; }

        [MetaMember(6, (MetaMemberFlags)0)]
        [Description("Where the card pack is coming from")]
        [JsonProperty("pack_source")]
        public CurrencySource PackSource { get; set; }

        [MetaMember(7, (MetaMemberFlags)0)]
        [Description("Based on config")]
        [JsonProperty("balance_id")]
        public CardCollectionBalanceId BalanceId { get; set; }

        [JsonProperty("hidden_rarity")]
        [MetaMember(8, (MetaMemberFlags)0)]
        [Description("The rarity of the card")]
        public CardHiddenRarity HiddenRarity { get; set; }

        [Description("Indicates if the card is special (yes/no)")]
        [MetaMember(9, (MetaMemberFlags)0)]
        [JsonProperty("is_special")]
        public bool IsSpecial { get; set; }

        [JsonProperty("is_wild")]
        [MetaMember(10, (MetaMemberFlags)0)]
        [Description("Indicates if the card was generated from a wild card (yes/no)")]
        public bool IsWild { get; set; }

        [MetaMember(11, (MetaMemberFlags)0)]
        [JsonProperty("collection_completed")]
        [Description("Collection completion status (0-not completed, 1-completed for the first time, etc.)")]
        public int CollectionCompleted { get; set; }

        [MetaMember(12, (MetaMemberFlags)0)]
        [Description("Set completion status (0-not completed, 1-completed for the first time, etc.)")]
        [JsonProperty("set_completed")]
        public int SetCompleted { get; set; }

        [JsonProperty("duplicate")]
        [MetaMember(13, (MetaMemberFlags)0)]
        [Description("Number of times the card has been received as a duplicate (0 if not duplicate)")]
        public int Duplicate { get; set; }

        [Description("0 Player has not prestiged, 1 Player has prestiged")]
        [JsonProperty("prestige_level")]
        [MetaMember(14, (MetaMemberFlags)0)]
        public int PrestigeLevel { get; set; }
        public override string EventDescription { get; }

        public AnalyticsEventCardCollectionChanged()
        {
        }

        public AnalyticsEventCardCollectionChanged(CardCollectionCardId collectionId, CardCollectionCardId cardId, CardStars cardStars, CardCollectionCardSetId setId, CardCollectionPackId packId, CurrencySource packSource, CardCollectionBalanceId balanceId, CardHiddenRarity hiddenRarity, bool isSpecial, bool isWild, int collectionCompleted, int setCompleted, int duplicate, int prestigeLevel)
        {
        }
    }
}