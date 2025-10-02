using Metaplay.Core.Model;
using Metaplay.Core.Activables;
using Metaplay.Core.Offers;
using Code.GameLogic.Config;
using System;
using System.Collections.Generic;
using Metaplay.Core;

namespace Code.GameLogic.IAP
{
    [MetaSerializableDerived(1)]
    [MetaActivableConfigData("OfferGroup", false, true)]
    [MetaBlockedMembers(new int[] { 10 })]
    public class MergeMansionOfferGroupInfo : MetaOfferGroupInfoBase, IOfferGroupVisuals, IValidatable
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        private string OfferTitlePrefabId { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        private string BackgroundPrefabId { get; set; }

        [MetaMember(3, (MetaMemberFlags)0)]
        private string TitleLocId { get; set; }

        [MetaMember(4, (MetaMemberFlags)0)]
        private string OfferButtonPrefabId { get; set; }

        [MetaMember(5, (MetaMemberFlags)0)]
        private string OfferContainerPrefabId { get; set; }

        [MetaMember(6, (MetaMemberFlags)0)]
        private int FlashSaleWeight { get; set; }

        [MetaMember(7, (MetaMemberFlags)0)]
        private bool DynamicContent { get; set; }

        [MetaMember(8, (MetaMemberFlags)0)]
        private OfferPlacementId[] AdditionalPlacements { get; set; }

        [MetaMember(9, (MetaMemberFlags)0)]
        public bool IsUnderMore { get; set; }

        [MetaMember(11, (MetaMemberFlags)0)]
        public List<MetaRef<OfferPopupTrigger>> OfferPopupTriggers { get; set; }

        [MetaMember(12, (MetaMemberFlags)0)]
        private string DescriptionLocId { get; set; }

        [MetaMember(13, (MetaMemberFlags)0)]
        public int? MaxPurchasesPerActivation { get; set; }

        [MetaMember(14, (MetaMemberFlags)0)]
        public MetaDuration? OfferPopupTriggerCooldown { get; set; }

        [MetaMember(15, (MetaMemberFlags)0)]
        private string[] Tags { get; set; }
        public string OfferTitleId { get; }
        public string BackgroundId { get; }
        public string GroupTitleLocId { get; }
        public string GroupDescriptionLocId { get; }
        public string ButtonId { get; }
        public string ContainerId { get; }
        public int FlashSaleWeightAmount { get; }
        public bool IsDynamicContent { get; }
        public bool CanEndBeforeExpiration { get; }
        public bool ActivatesOnTrigger { get; }
        public IEnumerable<OfferPlacementId> AdditionalPlacementsForOffer { get; }

        public MergeMansionOfferGroupInfo()
        {
        }

        public MergeMansionOfferGroupInfo(MetaOfferGroupSourceConfigItemBase source, string titleLocId, string descriptionLocId, string offerTitlePrefabId, string backgroundPrefabId, string offerButtonPrefabId, string offerContainerPrefabId, int flashSaleWeight, bool dynamicContent, OfferPlacementId[] additionalPlacements, bool isUnderMore, List<MetaRef<OfferPopupTrigger>> offerPopupTriggers, int? maxPurchasesPerActivation, MetaDuration? offerPopupTriggerCooldown, string[] tags)
        {
        }
    }
}