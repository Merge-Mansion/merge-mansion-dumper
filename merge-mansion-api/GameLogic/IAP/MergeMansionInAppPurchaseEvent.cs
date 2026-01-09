using Metaplay.Core.Model;
using Metaplay.Core.InAppPurchase;
using System;
using Metaplay.Core.Player;

namespace GameLogic.IAP
{
    [MetaSerializableDerived(1)]
    [IgnoreDefValidation]
    public class MergeMansionInAppPurchaseEvent : InAppPurchaseEvent
    {
        [MetaMember(17, (MetaMemberFlags)0)]
        public string OfferId { get; set; }

        public MergeMansionInAppPurchaseEvent()
        {
        }
    }
}