using System;
using System.Runtime.Serialization;
using Metaplay.Core;
using Metaplay.Core.Model;
using System.Collections.Generic;
using GameLogic.Config.Types;
using GameLogic.Config;

namespace GameLogic.Player.Items.Bubble
{
    [MetaSerializable]
    public class BubbleFeatures : IBubbleFeatures
    {
        private static MetaDuration defaultBubbleDuration = MetaDuration.FromMinutes(1);
        public static BubbleFeatures Placeholder = new(MetaDuration.FromMinutes(1), Currencies.Diamonds, 1000, null, 0);
        [MetaMember(1, (MetaMemberFlags)0)]
        public MetaDuration BubbleDuration { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        public Currencies OpenCurrency { get; set; }

        [MetaMember(3, (MetaMemberFlags)0)]
        public int OpenQuantity { get; set; }

        [MetaMember(4, (MetaMemberFlags)0)]
        [MetaOnMemberDeserializationFailure("FixItemRef")]
        private ItemDef ReplacementItem { get; set; }

        [MetaMember(5, (MetaMemberFlags)0)]
        public int SpawnOdds { get; set; }

        [IgnoreDataMember]
        public ValueTuple<Currencies, int> OpenCost => (OpenCurrency, OpenQuantity);

        private BubbleFeatures()
        {
        }

        public BubbleFeatures(MetaDuration bubbleDuration, Currencies openCurrency, int openQuantity, ItemDef replacementItem, int spawnOdds)
        {
            BubbleDuration = bubbleDuration;
            OpenCurrency = openCurrency;
            OpenQuantity = openQuantity;
            ReplacementItem = replacementItem;
            SpawnOdds = spawnOdds;
        }

        private List<BubbleVariantsDefinition> bubbleVariantsDefinitions;
        [MetaMember(6, (MetaMemberFlags)0)]
        public List<BubbleVariationId> BubbleVariants { get; set; }

        public BubbleFeatures(MetaDuration bubbleDuration, Currencies openCurrency, int openQuantity, ItemDef replacementItem, int spawnOdds, List<BubbleVariationId> bubbleVariants)
        {
        }

        [IgnoreDataMember]
        public ItemDef ReplacementItemDef { get; }
    }
}