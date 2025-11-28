using Metaplay.Core.Offers;

namespace Code.GameLogic.GameEvents
{
    public interface IOfferPlacementSupporting
    {
        OfferPlacementId OfferPlacementId { get; }
    }
}