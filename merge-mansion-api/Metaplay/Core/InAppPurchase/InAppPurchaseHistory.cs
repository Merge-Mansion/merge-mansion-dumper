using Metaplay.Core.Model;
using System;
using Metaplay.Core.Math;
using System.Collections.Generic;

namespace Metaplay.Core.InAppPurchase
{
    [MetaSerializable]
    [MetaReservedMembers(100, 200)]
    public abstract class InAppPurchaseHistory
    {
        protected virtual int MinRecentPurchases { get; }
        protected virtual int RecentPurchasesMaxDays { get; }

        [MetaMember(100, (MetaMemberFlags)0)]
        public int TotalInAppPurchaseCount { get; set; }

        [MetaMember(101, (MetaMemberFlags)0)]
        public F64 TotalInAppPurchaseSpend { get; set; }

        [MetaMember(102, (MetaMemberFlags)0)]
        public F64 MaxInAppPurchasePrice { get; set; }

        [MetaMember(103, (MetaMemberFlags)0)]
        public int SubscriptionPurchaseCount { get; set; }

        [MetaMember(104, (MetaMemberFlags)0)]
        public F64 TotalSubscriptionSpend { get; set; }

        [MetaMember(105, (MetaMemberFlags)0)]
        public List<InAppPurchaseHistory.RecentPurchaseEvent> RecentPurchaseData { get; set; }

        [MetaMember(106, (MetaMemberFlags)0)]
        public Dictionary<InAppProductId, int> PurchaseCountByProduct { get; set; }
        public virtual F64 TotalSpend { get; }
        public virtual int TotalNumPurchases { get; }

        [MetaSerializable]
        public readonly struct RecentPurchaseEvent
        {
            [MetaMember(1, (MetaMemberFlags)0)]
            public readonly MetaTime PurchaseTime;
            [MetaMember(2, (MetaMemberFlags)0)]
            public readonly InAppProductId ProductId;
            [MetaMember(3, (MetaMemberFlags)0)]
            public readonly F64 ReferencePrice;
        }
    }
}