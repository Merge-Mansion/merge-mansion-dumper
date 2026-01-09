using Metaplay.Core.Model;
using System;
using System.Collections.Generic;

namespace Metaplay.Core.Config
{
    [MetaSerializable]
    public class GameConfigStructurePatch<TStructure> : GameConfigEntryPatch<TStructure>, IGameConfigStructurePatch
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        private TStructure _replacementValues;
        [MetaMember(2, (MetaMemberFlags)0)]
        private HashSet<int> _replacedMemberTagIds;
        private GameConfigStructurePatch()
        {
        }

        public GameConfigStructurePatch(TStructure replacementValues, HashSet<int> replacedMemberTagIds)
        {
        }

        public GameConfigStructurePatch(Dictionary<string, object> replacedMembersByName)
        {
        }

        public GameConfigStructurePatch(Dictionary<int, object> replacedMembersByTagId)
        {
        }

        internal override void PatchContentDangerouslyInPlace(object entryContent)
        {
            return;
        }
    }
}