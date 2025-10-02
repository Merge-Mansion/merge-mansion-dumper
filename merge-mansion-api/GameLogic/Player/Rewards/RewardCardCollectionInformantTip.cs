using Metaplay.Core.Model;
using GameLogic.CardCollection;
using GameLogic.Fallbacks;
using System;
using System.Runtime.Serialization;

namespace GameLogic.Player.Rewards
{
    [MetaSerializableDerived(40)]
    public class RewardCardCollectionInformantTip : PlayerReward
    {
        [MetaMember(101, (MetaMemberFlags)0)]
        public CardCollectionCardId CardId { get; set; }

        [MetaMember(102, (MetaMemberFlags)0)]
        public FallbackPlayerRewardId FallbackPlayerRewardId { get; set; }

        public RewardCardCollectionInformantTip()
        {
        }

        public RewardCardCollectionInformantTip(CardCollectionCardId cardId, FallbackPlayerRewardId fallbackPlayerRewardId, CurrencySource currencySource)
        {
        }

        public override bool ShouldShowInfoButton { get; }

        [IgnoreDataMember]
        public int Amount { get; }
    }
}