using Metaplay.Core.Model;
using Code.GameLogic.GameEvents;
using System;

namespace GameLogic
{
    [MetaSerializable]
    public class DiceFaceRollResult
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public RollTheDiceGameDiceId DiceId;
        [MetaMember(2, (MetaMemberFlags)0)]
        public int FaceIndex;
    }
}