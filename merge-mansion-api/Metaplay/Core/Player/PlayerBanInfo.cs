using Metaplay.Core.Model;
using System;

namespace Metaplay.Core.Player
{
    [MetaSerializable]
    public class PlayerBanInfo
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public MetaTime? EndTimeOrNull { get; }

        [MetaMember(2, (MetaMemberFlags)0)]
        public string PlayerMessage { get; }
    }
}