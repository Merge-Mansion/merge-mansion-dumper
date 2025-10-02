using Metaplay.Core.Model;
using System;
using GameLogic.Advertisement;
using Merge;
using Metaplay.Core.Offers;
using GameLogic.Player.Board;
using System.Runtime.Serialization;
using System.Collections.Generic;
using GameLogic.Merge;
using GameLogic.Player.Rewards;
using Code.GameLogic.Player.Board;

namespace GameLogic
{
    [MetaSerializable]
    [MetaBlockedMembers(new int[] { 4 })]
    public class AdsData
    {
        public AdsData()
        {
        }

        [MetaMember(1, (MetaMemberFlags)0)]
        [ExcludeFromGdprExport]
        public string adsProviderIds { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        [ExcludeFromGdprExport]
        public bool canBeClaimed { get; set; }

        [MetaMember(3, (MetaMemberFlags)0)]
        [ExcludeFromGdprExport]
        public AdsRewardType rewardType { get; set; }

        [MetaMember(5, (MetaMemberFlags)0)]
        [ExcludeFromGdprExport]
        public ShopItemId shopItemId { get; set; }

        [MetaMember(6, (MetaMemberFlags)0)]
        [ExcludeFromGdprExport]
        public MergeBoardId mergeBoardId { get; set; }

        [MetaMember(7, (MetaMemberFlags)0)]
        [ExcludeFromGdprExport]
        public OfferPlacementId offerPlacementId { get; set; }

        [MetaMember(8, (MetaMemberFlags)0)]
        [ExcludeFromGdprExport]
        public Coordinate itemCoordinates { get; set; }

        [MetaMember(9, (MetaMemberFlags)0)]
        [ExcludeFromGdprExport]
        public AdvertisementPlacementId adPlacementId { get; set; }

        [IgnoreDataMember]
        public ICollection<MergeBoardAct> productActs { get; set; }

        public AdsData(string adsProviderIds, bool canBeClaimed, AdsRewardType rewardType, ShopItemId shopItemId, MergeBoardId mergeBoardId, OfferPlacementId offerPlacementId, Coordinate itemCoordinates, AdvertisementPlacementId adPlacementId, ICollection<MergeBoardAct> productActs)
        {
        }

        [MetaMember(10, (MetaMemberFlags)0)]
        [ExcludeFromGdprExport]
        public PlayerReward dailyAdReward { get; set; }

        public AdsData(string adsProviderIds, bool canBeClaimed, AdsRewardType rewardType, ShopItemId shopItemId, MergeBoardId mergeBoardId, OfferPlacementId offerPlacementId, Coordinate itemCoordinates, AdvertisementPlacementId adPlacementId, ICollection<MergeBoardAct> productActs, PlayerReward dailyAdReward)
        {
        }

        public AdsData(string adsProviderIds, bool canBeClaimed, AdsRewardType rewardType, ShopItemId shopItemId, MergeBoardId mergeBoardId, OfferPlacementId offerPlacementId, ICoordinate itemCoordinates, AdvertisementPlacementId adPlacementId, ICollection<MergeBoardAct> productActs, PlayerReward dailyAdReward)
        {
        }
    }
}