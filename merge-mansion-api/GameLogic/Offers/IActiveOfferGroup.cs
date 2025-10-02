using Metaplay.Core.Offers;
using System.Collections.Generic;
using GameLogic.Config;
using Metaplay.Core.Activables;
using System;
using Code.GameLogic.IAP;

namespace GameLogic.Offers
{
    public interface IActiveOfferGroup
    {
        OfferPlacementId Placement { get; }

        IEnumerable<IActiveOffer> Offers { get; }

        IOfferGroupVisuals Visuals { get; }

        MergeMansionOfferGroupInfo Group { get; }

        MetaActivableState.Activation? Activation { get; }

        IEnumerable<OfferPlacementId> AdditionalPlacementsForOffer { get; }

        bool IsUnderMore { get; }
    }
}