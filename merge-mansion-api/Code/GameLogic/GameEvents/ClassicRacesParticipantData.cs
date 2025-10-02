using Metaplay.Core.Model;
using System;

namespace Code.GameLogic.GameEvents
{
    [MetaSerializable]
    public struct ClassicRacesParticipantData
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public int Index { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        public string DisplayName { get; set; }

        [MetaMember(3, (MetaMemberFlags)0)]
        public int Points { get; set; }

        [MetaMember(4, (MetaMemberFlags)0)]
        public bool IsLocalPlayer { get; set; }

        [MetaMember(5, (MetaMemberFlags)0)]
        public int Placement { get; set; }
    }
}