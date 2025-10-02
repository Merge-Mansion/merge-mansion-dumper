using Metaplay.Core.Model;
using Metaplay.Core.Config;
using Metaplay.Core;
using GameLogic.Cutscenes;
using GameLogic.ConfigPrefabs;
using System;
using GameLogic.Decorations;
using System.Collections.Generic;
using GameLogic.Area;
using System.Runtime.Serialization;
using GameLogic.Config;
using GameLogic.Config.Map.Characters;

namespace GameLogic.Player.Rewards
{
    [MetaSerializable]
    [MetaBlockedMembers(new int[] { 9 })]
    public class PetInfo : IGameConfigData<PetId>, IGameConfigData, IHasGameConfigKey<PetId>
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public PetId ConfigKey { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        public MetaRef<CutsceneInfo> OnDiscoveredCutscene { get; set; }

        [MetaMember(3, (MetaMemberFlags)0)]
        public ConfigAssetPackId AssetPackId { get; set; }

        [MetaMember(4, (MetaMemberFlags)0)]
        public string UnlockHeaderLocId { get; set; }

        [MetaMember(5, (MetaMemberFlags)0)]
        public string UnlockDescLocId { get; set; }

        [MetaMember(6, (MetaMemberFlags)0)]
        public string InfoHeaderLocId { get; set; }

        [MetaMember(7, (MetaMemberFlags)0)]
        public string InfoDescLocId { get; set; }

        [MetaMember(8, (MetaMemberFlags)0)]
        public DecorationId Decoration { get; set; }

        [IgnoreDataMember]
        public DirectorGroupId OnDiscoveredDirectorGroupId { get; }

        public PetInfo()
        {
        }

        public PetInfo(PetId petId, CutsceneId onDiscoveredCutscene, ConfigAssetPackId configAssetPackId, string unlockHeaderLocId, string unlockDescLocId, string infoHeaderLocId, string infoDescLocId, DecorationId decorationId, Dictionary<AreaId, string> areaAnimationOverrides)
        {
        }

        public PetInfo(PetId petId, CutsceneId onDiscoveredCutscene, ConfigAssetPackId configAssetPackId, string unlockHeaderLocId, string unlockDescLocId, string infoHeaderLocId, string infoDescLocId, DecorationId decorationId)
        {
        }

        [MetaMember(10, (MetaMemberFlags)0)]
        public string SelectionHeaderLocId { get; set; }

        [MetaMember(11, (MetaMemberFlags)0)]
        public string SelectionDescriptionLocId { get; set; }

        [MetaMember(12, (MetaMemberFlags)0)]
        public MapCharacterPositionId PetHomeCharacterPositionId { get; set; }

        public PetInfo(PetId petId, CutsceneId onDiscoveredCutscene, ConfigAssetPackId configAssetPackId, string unlockHeaderLocId, string unlockDescLocId, string infoHeaderLocId, string infoDescLocId, DecorationId decorationId, string selectionHeaderLocId, string selectionDescriptionLocId, MapCharacterPositionId petHomeCharacterPositionId)
        {
        }
    }
}