using Metaplay.Core.Model;
using Metaplay.Core.Config;
using Metaplay.Core;
using System;
using System.Collections.Generic;
using Metaplay.Core.Player;
using GameLogic.Player.Requirements;

namespace GameLogic.Player.Items.Bubble
{
    [MetaSerializable]
    public class BubbleVariantsDefinition : IGameConfigData<BubbleVariationId>, IGameConfigData, IHasGameConfigKey<BubbleVariationId>
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public BubbleVariationId ConfigKey { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        public MetaDuration BubbleDuration { get; set; }

        [MetaMember(3, (MetaMemberFlags)0)]
        public Currencies OpenCurrency { get; set; }

        [MetaMember(4, (MetaMemberFlags)0)]
        public int OpenCost { get; set; }

        [MetaMember(5, (MetaMemberFlags)0)]
        public MetaRef<ItemDefinition> ReplacementItem { get; set; }

        [MetaMember(6, (MetaMemberFlags)0)]
        public int SpawnOdds { get; set; }

        [MetaMember(7, (MetaMemberFlags)0)]
        public List<PlayerSegmentId> Segments { get; set; }

        [MetaMember(8, (MetaMemberFlags)0)]
        public int Priority { get; set; }

        [MetaMember(9, (MetaMemberFlags)0)]
        public List<PlayerRequirement> PlayerRequirements { get; set; }

        public BubbleVariantsDefinition()
        {
        }

        public BubbleVariantsDefinition(BubbleVariationId configKey, MetaDuration bubbleDuration, Currencies openCurrency, int openCost, MetaRef<ItemDefinition> replacementItem, int spawnOdds, int priority, List<PlayerSegmentId> segments, List<PlayerRequirement> playerRequirements)
        {
        }
    }
}