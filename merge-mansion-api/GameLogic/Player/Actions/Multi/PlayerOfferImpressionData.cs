using Metaplay.Core.Model;
using Metaplay.Core.Offers;
using System;
using Metaplay.Core;
using Metaplay.Core.Math;
using Metaplay.Core.Player;

namespace GameLogic.Player.Actions.Multi
{
    [MetaSerializable]
    [MetaBlockedMembers(new int[] { 9, 11 })]
    public struct PlayerOfferImpressionData
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public MetaOfferId OfferId { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        public MetaOfferGroupId OfferGroupId { get; set; }

        [MetaMember(3, (MetaMemberFlags)0)]
        public string PlatformId { get; set; }

        [MetaMember(4, (MetaMemberFlags)0)]
        public OfferPlacementId PlacementId { get; set; }

        [MetaMember(5, (MetaMemberFlags)0)]
        public string PopupTrigger { get; set; }

        [MetaMember(6, (MetaMemberFlags)0)]
        public MetaTime? StartDate { get; set; }

        [MetaMember(7, (MetaMemberFlags)0)]
        public MetaTime? EndDate { get; set; }

        [MetaMember(8, (MetaMemberFlags)0)]
        public long? Duration { get; set; }

        [MetaMember(13, (MetaMemberFlags)0)]
        public F64 ReferencePrice { get; set; }

        [MetaMember(10, (MetaMemberFlags)0)]
        public string OfferItems { get; set; }

        [MetaMember(14, (MetaMemberFlags)0)]
        public PlayerSegmentId Segment { get; set; }

        [MetaMember(12, (MetaMemberFlags)0)]
        public int OfferGlobalCounter { get; set; }

        [MetaMember(15, (MetaMemberFlags)0)]
        public int? Step { get; set; }
    }
}