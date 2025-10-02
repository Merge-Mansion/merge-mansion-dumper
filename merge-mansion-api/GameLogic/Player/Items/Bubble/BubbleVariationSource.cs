using Code.GameLogic.Config;
using Metaplay.Core.Config;
using Metaplay.Core;
using System;
using System.Collections.Generic;
using Metaplay.Core.Player;

namespace GameLogic.Player.Items.Bubble
{
    public class BubbleVariationSource : IConfigItemSource<BubbleVariantsDefinition, BubbleVariationId>, IGameConfigSourceItem<BubbleVariationId, BubbleVariantsDefinition>, IHasGameConfigKey<BubbleVariationId>
    {
        public BubbleVariationId ConfigKey { get; set; }
        public MetaDuration BubbleDuration { get; set; }
        public Currencies OpenCurrency { get; set; }
        public int OpenCost { get; set; }
        public int SpawnOdds { get; set; }
        public string ReplacementItem { get; set; }
        public List<PlayerSegmentId> Segments { get; set; }
        public int Priority { get; set; }
        private List<string> RequirementType { get; set; }
        private List<string> RequirementId { get; set; }
        private List<string> RequirementAmount { get; set; }
        private List<string> RequirementAux0 { get; set; }

        public BubbleVariationSource()
        {
        }
    }
}