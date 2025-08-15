using System;
using GameLogic.Advertisement;
using GameLogic;
using Merge;
using GameLogic.Player.Board;
using GameLogic.Player;
using Metaplay.Core.Offers;
using GameLogic.Player.Rewards;
using System.Collections.Generic;
using GameLogic.Merge;

namespace Code.GameLogic.Ads
{
    public interface IAdsRewardData
    {
        string AdPlacement { get; }

        AdvertisementPlacementId AdPlacementId { get; }

        string ItemName { get; }

        string AuctionId { get; }

        ShopItemId ShopItemId { get; }

        int ItemDiamondValue { get; }

        AdsRewardType AdsRewardType { get; }

        int ItemCostValue { get; }

        Currencies ItemCostValueType { get; }

        string AdvertiserId { get; }

        string NetworkId { get; }

        MergeBoardId MergeBoardId { get; }

        Coordinate BubbleCoordinates { get; }

        AnalyticsContext AnalyticsContext { get; }

        OfferPlacementId OfferPlacementId { get; }

        PlayerReward DailyAdReward { get; }

        string RequiredTaskItems { get; }

        string RequiredMergeChains { get; }

        ICollection<MergeBoardAct> ProductActs { get; }
    }
}