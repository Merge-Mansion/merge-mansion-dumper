using Metaplay.Core.Model;
using System;

namespace GameLogic.Player.Items
{
    [MetaSerializable]
    public class ItemEffectFeatures : IItemEffectFeatures
    {
        public static ItemEffectFeatures NoItemEffectFeatures;
        [MetaMember(1, (MetaMemberFlags)0)]
        public string ActivationVfxPoolTag { get; set; }
        public bool HasActivationVfx { get; }

        private ItemEffectFeatures()
        {
        }

        public ItemEffectFeatures(string activationVfxPoolTag)
        {
        }
    }
}