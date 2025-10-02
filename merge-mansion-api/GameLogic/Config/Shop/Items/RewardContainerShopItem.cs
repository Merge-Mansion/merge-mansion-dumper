using Metaplay.Core.Model;
using Metaplay.Core;
using GameLogic.Player.Rewards;
using GameLogic.Config.Shop.PriceCurves;
using GameLogic.Config.Shop.PurchaseLimiters;

namespace GameLogic.Config.Shop.Items
{
    [MetaSerializableDerived(9)]
    public class RewardContainerShopItem : IShopItem
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        private ShopItemId ShopItemId { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        private MetaRef<RewardContainerInfo> RewardContainerRef { get; set; }

        [MetaMember(3, (MetaMemberFlags)0)]
        private IPriceCurve PriceCurve { get; set; }

        [MetaMember(4, (MetaMemberFlags)0)]
        private IPurchaseLimiter PurchaseLimiter { get; set; }
        public RewardContainer RewardContainer { get; }
    }
}