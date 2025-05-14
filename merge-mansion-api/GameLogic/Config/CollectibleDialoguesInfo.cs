using Metaplay.Core.Model;
using Metaplay.Core.Config;
using Code.GameLogic.Config;
using System.Collections.Generic;
using System;

namespace GameLogic.Config
{
    [MetaSerializable]
    [MetaBlockedMembers(new int[] { 4, 5 })]
    public class CollectibleDialoguesInfo : IGameConfigData<CollectibleDialoguesInfoId>, IGameConfigData, IHasGameConfigKey<CollectibleDialoguesInfoId>, IValidatable
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public CollectibleDialoguesInfoId ConfigKey { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        private List<ItemDialogueEntry> ItemDialogues { get; set; }

        [MetaMember(3, (MetaMemberFlags)0)]
        private List<DecorationDialogueEntry> DecorationsDialogues { get; set; }

        public CollectibleDialoguesInfo()
        {
        }

        public CollectibleDialoguesInfo(CollectibleDialoguesInfoId configKey, string requiredBoardEventId, string itemDialogues, string decorationsDialogues)
        {
        }

        [MetaMember(6, (MetaMemberFlags)0)]
        public List<string> RequiredBoardEventIds { get; set; }

        public CollectibleDialoguesInfo(CollectibleDialoguesInfoId configKey, List<string> requiredBoardEventId, string itemDialogues, string decorationsDialogues)
        {
        }
    }
}