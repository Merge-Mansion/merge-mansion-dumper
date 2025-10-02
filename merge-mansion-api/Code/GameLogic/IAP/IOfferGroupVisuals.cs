using System;

namespace Code.GameLogic.IAP
{
    public interface IOfferGroupVisuals
    {
        string OfferTitleId { get; }

        string BackgroundId { get; }

        string GroupTitleLocId { get; }

        string GroupDescriptionLocId { get; }

        string ButtonId { get; }

        string ContainerId { get; }
    }
}