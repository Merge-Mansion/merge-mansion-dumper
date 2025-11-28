using Metaplay.Core.Model;
using GameLogic.Player.Items;
using Metaplay.Core;
using System;
using Metaplay.Core.Forms;
using Code.GameLogic.GameEvents;
using System.Runtime.Serialization;
using Metacore.MergeMansion.Common.Options;
using System.Collections.Generic;
using GameLogic.Config;

namespace GameLogic.Player.Rewards
{
    [MetaSerializableDerived(42)]
    public class RewardItemForCollectibleBoardEvent : PlayerReward
    {
        [MetaMember(2, (MetaMemberFlags)0)]
        public int Amount { get; set; }

        [MetaFormNotEditable]
        [MetaMember(3, (MetaMemberFlags)0)]
        public bool FromSupport { get; set; }

        [MetaFormNotEditable]
        [MetaMember(5, (MetaMemberFlags)0)]
        public OverrideItemFeatures OverrideItemFeatures { get; set; }

        [MetaMember(6, (MetaMemberFlags)0)]
        public bool ForceOnTopOfPocket { get; set; }

        [MetaMember(7, (MetaMemberFlags)0)]
        private string OverridePoolTag { get; set; }

        [IgnoreDataMember]
        public override bool ShouldShowInfoButton { get; }

        public RewardItemForCollectibleBoardEvent()
        {
        }

        public RewardItemForCollectibleBoardEvent(CollectibleBoardEventId eventId, ItemDefinition itemDefinition, int amount, bool fromSupport, CurrencySource currencySource, OverrideItemFeatures overrideItemFeatures, bool forceOnTopOfPocket, string overridePoolTag)
        {
        }

        public RewardItemForCollectibleBoardEvent(CollectibleBoardEventId eventId, MetaRef<ItemDefinition> itemRef, int amount, bool fromSupport, CurrencySource currencySource, OverrideItemFeatures overrideItemFeatures, bool forceOnTopOfPocket, string overridePoolTag)
        {
        }

        [MetaMember(4, (MetaMemberFlags)0)]
        public CollectibleBoardEventId EventId_DEPRECATED { get; set; }

        [IgnoreDataMember]
        public Option<CollectibleBoardEventId> EventIdOption_DEPRECATED { get; }

        [MetaMember(8, (MetaMemberFlags)0)]
        public List<CollectibleBoardEventId> EventIds { get; set; }

        [IgnoreDataMember]
        private Option<List<CollectibleBoardEventId>> EventIdsOption { get; }

        public RewardItemForCollectibleBoardEvent(List<CollectibleBoardEventId> eventIds, ItemDefinition itemDefinition, int amount, bool fromSupport, CurrencySource currencySource, OverrideItemFeatures overrideItemFeatures, bool forceOnTopOfPocket, string overridePoolTag)
        {
        }

        public RewardItemForCollectibleBoardEvent(List<CollectibleBoardEventId> eventIds, MetaRef<ItemDefinition> itemRef, int amount, bool fromSupport, CurrencySource currencySource, OverrideItemFeatures overrideItemFeatures, bool forceOnTopOfPocket, string overridePoolTag)
        {
        }

        [ValidateItemDefMetaMember]
        [MetaMember(1, (MetaMemberFlags)0)]
        [MetaOnMemberDeserializationFailure("FixItemRef")]
        public ItemDef ItemDef { get; set; }
    }
}