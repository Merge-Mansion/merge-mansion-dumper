using System;

namespace Code.GameLogic.IAP
{
    public interface IOfferVisuals
    {
        string TitleLocalizationId { get; }

        string SaleBadgeLocalizationId { get; }

        string OfferPaneId { get; }

        string BackgroundAnimationId { get; }

        string ForegroundEffectId { get; }

        string BackgroundId { get; }

        string TitleColorHex { get; }

        string BackgroundColorHex { get; }

        string BackgroundGradientHex { get; }

        string LeftCharacterId { get; }

        string RightCharacterId { get; }
    }
}