using Metaplay.Core;
using System;
using System.Collections.Generic;
using GameLogic.Config.Types;

namespace GameLogic.Player.Items.Bubble
{
    public interface IBubbleFeatures
    {
        MetaDuration BubbleDuration { get; }

        Currencies OpenCurrency { get; }

        int OpenQuantity { get; }

        int SpawnOdds { get; }

        ValueTuple<Currencies, int> OpenCost { get; }

        List<BubbleVariationId> BubbleVariants { get; }
    }
}