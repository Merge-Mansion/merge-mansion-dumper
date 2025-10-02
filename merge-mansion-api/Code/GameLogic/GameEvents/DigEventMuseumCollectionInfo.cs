using Metaplay.Core.Model;
using Metaplay.Core.Config;
using System.Collections.Generic;

namespace Code.GameLogic.GameEvents
{
    [MetaSerializable]
    public class DigEventMuseumCollectionInfo : IGameConfigData<DigEventMuseumCollectionId>, IGameConfigData, IHasGameConfigKey<DigEventMuseumCollectionId>
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public DigEventMuseumCollectionId CollectionId { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        public List<DigEventMuseumShelfId> Shelfs { get; set; }
        public DigEventMuseumCollectionId ConfigKey => CollectionId;

        public DigEventMuseumCollectionInfo()
        {
        }

        public DigEventMuseumCollectionInfo(DigEventMuseumCollectionId configKey, List<DigEventMuseumShelfId> shelfs)
        {
        }
    }
}