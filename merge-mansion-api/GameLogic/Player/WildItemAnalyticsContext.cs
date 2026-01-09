using Metaplay.Core.Model;
using System;

namespace GameLogic.Player
{
    [MetaSerializableDerived(8)]
    public class WildItemAnalyticsContext : AnalyticsContext
    {
        [MetaMember(10, (MetaMemberFlags)0)]
        public string Goal_Id { get; set; }
    }
}