using GameLogic.Merge;
using Metaplay.Core.Model;
using Merge;
using System;
using Metacore.MergeMansion.Common.Options;

namespace GameLogic.Player.Items
{
    [MetaSerializable]
    public class PortalFeatures : IPortalFeatures
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public bool IsPortal { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        public MergeBoardId TargetBoardId { get; set; }

        public static PortalFeatures NoPortal;
        public PortalFeatures(MergeBoardId id)
        {
        }

        private PortalFeatures()
        {
        }

        [MetaMember(3, (MetaMemberFlags)0)]
        public PortalType Type { get; set; }
        public Option<MergeBoardId> TargetBoardIdOption { get; }

        public PortalFeatures(PortalType type, MergeBoardId targetBoardId)
        {
        }
    }
}