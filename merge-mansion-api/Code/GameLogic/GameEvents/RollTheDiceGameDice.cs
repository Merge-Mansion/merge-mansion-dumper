using Metaplay.Core.Model;
using Metaplay.Core.Config;
using System;
using System.Collections.Generic;

namespace Code.GameLogic.GameEvents
{
    [MetaSerializable]
    [MetaBlockedMembers(new int[] { 4 })]
    public class RollTheDiceGameDice : IGameConfigData<RollTheDiceGameDiceId>, IGameConfigData, IHasGameConfigKey<RollTheDiceGameDiceId>
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public RollTheDiceGameDiceId ConfigKey { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        public int Sides { get; set; }

        [MetaMember(3, (MetaMemberFlags)0)]
        public List<RollTheDiceFace> Faces { get; set; }
    }
}