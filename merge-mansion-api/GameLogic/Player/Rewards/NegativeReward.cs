using Code.GameLogic.GameEvents;
using Metaplay.Core.Model;
using System;
using Metaplay.Core.Forms;

namespace GameLogic.Player.Rewards
{
    [MetaSerializableDerived(8)]
    [MetaFormHidden]
    [Obsolete("Old way of removing currency from players. To be removed after all current mails with NegativeRewards are consumed.")]
    public class NegativeReward : PlayerReward
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public Currencies Currency { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        public long RemoveAmount { get; set; }

        [MetaMember(3, (MetaMemberFlags)0)]
        public EventCurrencyId EventCurrencyId { get; set; }

        public NegativeReward()
        {
        }

        public NegativeReward(Currencies currency, long maxRemoveAmount)
        {
        }

        public NegativeReward(EventCurrencyId eventCurrencyId, long maxRemoveAmount)
        {
        }
    }
}