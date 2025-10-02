using GameLogic.Config;
using System;
using Code.GameLogic.IAP;

namespace GameLogic.Offers
{
    public interface IActiveOffer
    {
        IActiveOfferGroup ParentGroup { get; }

        IOfferVisuals Visuals { get; }

        MergeMansionOfferInfo Info { get; }

        int AvailablePurchases { get; }

        bool CanBePurchased { get; }
    }
}