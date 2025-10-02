using Metaplay.Core.Model;
using System;

namespace GameLogic.Player.Items.Collectable
{
    [MetaSerializable]
    [MetaBlockedMembers(new int[] { 3 })]
    public class CollectableFeatures : ICollectableFeatures
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public bool Collectable { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        public ICollectAction CollectAction { get; set; }

        [MetaMember(4, (MetaMemberFlags)0)]
        public bool ConfirmCollectBelowMergeChainLevel { get; set; }

        public static CollectableFeatures NoCollectable;
        private CollectableFeatures()
        {
        }

        public CollectableFeatures(ICollectAction collectAction, string overrideSfx, bool confirmCollectBelowMergeChainLevel)
        {
        }

        public CollectableFeatures(ICollectAction collectAction, bool confirmCollectBelowMergeChainLevel)
        {
        }

        public CollectableFeatures(bool collectable, ICollectAction collectAction, bool confirmCollectBelowMergeChainLevel)
        {
        }

        [MetaMember(5, (MetaMemberFlags)0)]
        public bool CollectOnSpawn { get; set; }

        public CollectableFeatures(ICollectAction collectAction, bool confirmCollectBelowMergeChainLevel, bool collectOnSpawn)
        {
        }

        public CollectableFeatures(bool collectable, ICollectAction collectAction, bool confirmCollectBelowMergeChainLevel, bool collectOnSpawn)
        {
        }
    }
}