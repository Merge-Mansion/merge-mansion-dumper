using Metaplay.Core;
using Metaplay.Core.Math;
using Metaplay.Core.Model;

namespace GameLogic.Player.Board
{
    [MetaSerializable]
    public class BoardBubbleState
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public MetaTime LastBubbleAppearance { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        public MetaTime GraceChanceTimestamp { get; set; }

        [MetaMember(3, (MetaMemberFlags)0)]
        public F32 GraceChance { get; set; }

        [MetaMember(4, (MetaMemberFlags)0)]
        public MetaTime BehaviourChanceTimestamp { get; set; }

        [MetaMember(5, (MetaMemberFlags)0)]
        public F32 BehaviourChance { get; set; }

        public BoardBubbleState()
        {
        }
    }
}