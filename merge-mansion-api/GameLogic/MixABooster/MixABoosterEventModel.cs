using Metaplay.Core.Model;
using Metaplay.Core.Activables;
using Code.GameLogic.GameEvents;
using System;
using System.Collections.Generic;

namespace GameLogic.MixABooster
{
    [MetaSerializable]
    public class MixABoosterEventModel : MetaActivableState<MixABoosterEventId, MixABoosterEventInfo>, ICoreSupportingEventModel
    {
        private static byte InitialBoolFields;
        [MetaMember(1, (MetaMemberFlags)0)]
        public sealed override MixABoosterEventId ActivableId { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        private Dictionary<MixABoosterIngredientId, int> IngredientsInStock { get; set; }

        [MetaMember(3, (MetaMemberFlags)0)]
        private List<MixABoosterRecipeId> DiscoveredRecipes { get; set; }

        [MetaMember(4, (MetaMemberFlags)0)]
        public byte BoolFields { get; set; }
        public IReadOnlyDictionary<MixABoosterIngredientId, int> AvailableIngredients { get; }
        public bool RequiresPlayerAttention { get; }
        public bool StartNoted { get; set; }
        public bool FtueNoted { get; set; }
        public bool EndNoted { get; set; }

        public MixABoosterEventModel()
        {
        }

        public MixABoosterEventModel(MixABoosterEventInfo info)
        {
        }
    }
}