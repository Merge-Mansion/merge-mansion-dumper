using Metaplay.Core.Model;
using Metaplay.Core.Offers;
using System;
using GameLogic.Config.Costs;
using System.Collections.Generic;
using GameLogic.Player.Requirements;
using GameLogic.Player.Director.Config;
using Metaplay.Core;
using Metaplay.Core.InAppPurchase;
using System.Runtime.Serialization;
using GameLogic.Player.Rewards;

namespace Code.GameLogic.IAP
{
    [MetaSerializableDerived(1)]
    public class MergeMansionOfferInfo : MetaOfferInfoBase, IOfferVisuals
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        private string TitleLocId { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        private string SaleBadgeLocId { get; set; }

        [MetaMember(3, (MetaMemberFlags)0)]
        private string OfferPanePrefabId { get; set; }

        [MetaMember(4, (MetaMemberFlags)0)]
        private string BackgroundSpriteId { get; set; }

        [MetaMember(5, (MetaMemberFlags)0)]
        public ICost OfferCost { get; set; }

        [MetaMember(6, (MetaMemberFlags)0)]
        public int FlashSalePriceModifier { get; set; }

        [MetaMember(7, (MetaMemberFlags)0)]
        public int Weight { get; set; }

        [MetaMember(8, (MetaMemberFlags)0)]
        public List<PlayerRequirement> Requirements { get; set; }

        [MetaMember(9, (MetaMemberFlags)0)]
        public string TitleColorHex { get; set; }

        [MetaMember(10, (MetaMemberFlags)0)]
        public string BackgroundColorHex { get; set; }

        [MetaMember(11, (MetaMemberFlags)0)]
        public string BackgroundGradientHex { get; set; }

        [MetaMember(12, (MetaMemberFlags)0)]
        public string LeftCharacterId { get; set; }

        [MetaMember(13, (MetaMemberFlags)0)]
        public string RightCharacterId { get; set; }

        [MetaMember(14, (MetaMemberFlags)0)]
        public string BackgroundAnimationId { get; set; }

        [MetaMember(15, (MetaMemberFlags)0)]
        public string ForegroundEffectId { get; set; }

        [MetaMember(16, (MetaMemberFlags)0)]
        private List<IDirectorAction> FirstTimePurchaseActions { get; set; }

        [MetaMember(17, (MetaMemberFlags)0)]
        public List<int> CostAmounts { get; set; }

        [MetaMember(18, (MetaMemberFlags)0)]
        public MetaRef<InAppProductInfoBase> PreviousInAppProduct { get; set; }

        [MetaMember(19, (MetaMemberFlags)0)]
        public int MaxPurchasesGlobally { get; set; }

        [MetaMember(20, (MetaMemberFlags)0)]
        public int SaleAmount { get; set; }

        [MetaMember(21, (MetaMemberFlags)0)]
        private OfferType OfferType { get; set; }

        [IgnoreDataMember]
        public CurrencyCost Cost { get; }
        public string TitleLocalizationId { get; }
        public string SaleBadgeLocalizationId { get; }
        public string OfferPaneId { get; }
        public string BackgroundId { get; }
        public IEnumerable<PlayerReward> OfferRewards { get; }
        public override bool RequireInAppProduct { get; }
        public override string CustomReferencePriceForDashboard { get; }

        public MergeMansionOfferInfo()
        {
        }

        public MergeMansionOfferInfo(MetaOfferSourceConfigItemBase metaOfferInfo, string titleLocId, string saleBadgeLocId, string offerPanePrefabId, string backgroundAnimationId, string foregroundEffectId, string backgroundSpriteId, string titleColorHex, string backgroundColorHex, string backgroundGradientHex, string leftCharacterId, string rightCharacterId, ICost cost, List<int> costAmounts, int flashSalePriceModifier, int weight, List<PlayerRequirement> requirements, List<IDirectorAction> firstTimePurchaseActions, MetaRef<InAppProductInfoBase> previousInAppProduct, int maxPurchasesGlobally, int saleAmount, OfferType offerType)
        {
        }
    }
}