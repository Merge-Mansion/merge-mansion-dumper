using Metaplay.Core.Model;
using GameLogic.Player;

namespace GameLogic.Config.Shop.PurchaseLimiters
{
    [MetaSerializableDerived(10)]
    public class DailyEnergyEventNoLimitPurchaseLimiter : IPurchaseLimiter
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        private EnergyType EnergyType { get; set; }

        public DailyEnergyEventNoLimitPurchaseLimiter()
        {
        }

        public DailyEnergyEventNoLimitPurchaseLimiter(EnergyType energyType)
        {
        }
    }
}