using Metaplay.Core.Model;
using System.Collections.Generic;
using System;

namespace GameLogic
{
    [MetaSerializable]
    public class ServerDiceRollResult
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public List<DiceFaceRollResult> RolledFaces;
        [MetaMember(2, (MetaMemberFlags)0)]
        public int Multiplier;
        [MetaMember(3, (MetaMemberFlags)0)]
        public bool LevelCompleted;
    }
}