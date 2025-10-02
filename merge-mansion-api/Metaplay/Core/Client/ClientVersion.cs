using Metaplay.Core.Model;
using System;

namespace Metaplay.Core.Client
{
    [MetaSerializable]
    public readonly struct ClientVersion
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public readonly int LogicVersion;
        [MetaMember(2, (MetaMemberFlags)0)]
        public readonly int Patch;
    }
}