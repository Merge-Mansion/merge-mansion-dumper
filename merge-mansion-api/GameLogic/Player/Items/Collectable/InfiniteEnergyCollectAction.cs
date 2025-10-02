using Metaplay.Core;
using Metaplay.Core.Model;
using System.Runtime.Serialization;
using System;

namespace GameLogic.Player.Items.Collectable
{
    [MetaSerializableDerived(5)]
    public class InfiniteEnergyCollectAction : IInfiniteEnergyCollectAction, ICollectAction
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public MetaDuration Duration { get; set; }

        private InfiniteEnergyCollectAction()
        {
        }

        public InfiniteEnergyCollectAction(MetaDuration duration)
        {
        }

        [IgnoreDataMember]
        public double DurationMinutes { get; }
    }
}