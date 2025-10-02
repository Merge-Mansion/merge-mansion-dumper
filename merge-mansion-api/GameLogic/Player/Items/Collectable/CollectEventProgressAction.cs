using Metaplay.Core.Model;
using System;

namespace GameLogic.Player.Items.Collectable
{
    [MetaSerializableDerived(4)]
    public class CollectEventProgressAction : ICollectEventProgressAction, ICollectAction
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public int ProgressGiven { get; set; }

        private CollectEventProgressAction()
        {
        }

        public CollectEventProgressAction(int progressGiven)
        {
        }
    }
}