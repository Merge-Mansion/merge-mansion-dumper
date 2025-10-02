using Metaplay.Core.Model;
using GameLogic.Player.Items.Production;
using System;
using System.Runtime.Serialization;

namespace GameLogic.Player.Items
{
    [MetaSerializable]
    [MetaBlockedMembers(new int[] { 7 })]
    public class OnFireFeatures : IOnFireFeatures
    {
        public static OnFireFeatures NoOnFire;
        [MetaMember(1, (MetaMemberFlags)0)]
        private IItemSpawner OnFireSpawn { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        private bool UseMaxLevel { get; set; }

        [IgnoreDataMember]
        public bool SupportsOnFire { get; }
    }
}