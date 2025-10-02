using Code.GameLogic.Config;
using Metaplay.Core.Config;
using System.Collections.Generic;

namespace Code.GameLogic.GameEvents
{
    public class DigEventMuseumCollectionSource : IConfigItemSource<DigEventMuseumCollectionInfo, DigEventMuseumCollectionId>, IGameConfigSourceItem<DigEventMuseumCollectionId, DigEventMuseumCollectionInfo>, IHasGameConfigKey<DigEventMuseumCollectionId>
    {
        public DigEventMuseumCollectionId ConfigKey { get; set; }
        private List<DigEventMuseumShelfId> ShelfId { get; set; }

        public DigEventMuseumCollectionSource()
        {
        }
    }
}