using Code.GameLogic.Config;
using Metaplay.Core.Config;
using System;
using System.Collections.Generic;

namespace GameLogic.Config
{
    public class CollectibleDialoguesSource : IConfigItemSource<CollectibleDialoguesInfo, CollectibleDialoguesInfoId>, IGameConfigSourceItem<CollectibleDialoguesInfoId, CollectibleDialoguesInfo>, IHasGameConfigKey<CollectibleDialoguesInfoId>
    {
        public CollectibleDialoguesInfoId ConfigKey { get; set; }
        private List<string> RequiredBoardEventId { get; set; }
        private string ItemDialogues { get; set; }
        private string DecorationDialogues { get; set; }

        public CollectibleDialoguesSource()
        {
        }
    }
}