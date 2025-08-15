using Metaplay.Core.Model;
using System;
using System.Runtime.Serialization;

namespace Code.GameLogic.ExtraSpawns
{
    [MetaSerializableDerived(3)]
    public class ProduceItemTrigger : IExtraSpawnTrigger
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        private int EnergyConsumptionMultiplier { get; set; }

        public ProduceItemTrigger()
        {
        }

        public ProduceItemTrigger(int energyConsumptionMultiplier)
        {
        }

        [IgnoreDataMember]
        public ExtraSpawnTriggerType Type { get; }
    }
}