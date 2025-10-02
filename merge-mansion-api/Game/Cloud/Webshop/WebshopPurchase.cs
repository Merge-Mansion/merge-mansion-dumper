using Metaplay.Core.Model;
using System;
using Metaplay.Core;
using System.Collections.Generic;

namespace Game.Cloud.Webshop
{
    [MetaSerializable]
    public class WebshopPurchase
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public string PurchaseId;
        [MetaMember(2, (MetaMemberFlags)0)]
        [ServerOnly]
        public string OrderNumber;
        [MetaMember(3, (MetaMemberFlags)0)]
        [ServerOnly]
        public MetaTime PurchaseTime;
        [MetaMember(4, (MetaMemberFlags)0)]
        [ServerOnly]
        public WebshopType Type;
        [MetaMember(5, (MetaMemberFlags)0)]
        public List<WebshopItem> Items;
        [MetaMember(6, (MetaMemberFlags)0)]
        [ServerOnly]
        public string RefundId;
        [MetaMember(7, (MetaMemberFlags)0)]
        [ServerOnly]
        public bool RefundProcessed;
        [MetaMember(8, (MetaMemberFlags)0)]
        [ServerOnly]
        public string Currency;
        public WebshopPurchase()
        {
        }
    }
}