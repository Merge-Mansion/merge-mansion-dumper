using Metaplay.Core;
using Metaplay.Core.Model;
using System.Runtime.Serialization;
using System;

namespace GameLogic.Player.Items.Collectable
{
    [MetaSerializableDerived(2)]
    public class TimeSkipCollectAction : ITimeSkipCollectAction, ICollectAction
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public MetaDuration DurationToSkip { get; set; }

        private TimeSkipCollectAction()
        {
        }

        public TimeSkipCollectAction(MetaDuration durationToSkip)
        {
        }

        [IgnoreDataMember]
        public double DurationToSkipMinutes { get; }
    }
}