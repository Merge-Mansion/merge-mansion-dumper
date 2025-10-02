using Metaplay.Core.Model;
using System.Collections.Generic;
using GameLogic.Player.Rewards;
using System;
using Metaplay.Core;
using Metaplay.Core.InAppPurchase;

namespace Game.Cloud.Webshop
{
    [MetaReservedMembers(100, 110)]
    [MetaSerializable]
    public abstract class WebshopItem
    {
        [MetaMember(100, (MetaMemberFlags)0)]
        public List<PlayerReward> Rewards { get; set; }

        [MetaMember(101, (MetaMemberFlags)0)]
        public bool IsConsumed { get; set; }

        [MetaMember(102, (MetaMemberFlags)0)]
        [ServerOnly]
        public int ReferencePrice { get; set; }

        [MetaMember(103, (MetaMemberFlags)0)]
        [ServerOnly]
        public string ReferenceCurrency { get; set; }

        [MetaMember(104, (MetaMemberFlags)0)]
        [ServerOnly]
        public MetaTime? ConsumeTime { get; set; }

        [MetaMember(105, (MetaMemberFlags)0)]
        [ServerOnly]
        public int Price { get; set; }

        [MetaMember(106, (MetaMemberFlags)0)]
        [ServerOnly]
        public string Sku { get; set; }
        public virtual bool ShouldEarlyConsume { get; }
        public abstract InAppProductId ProductId { get; }

        protected WebshopItem()
        {
        }
    }
}