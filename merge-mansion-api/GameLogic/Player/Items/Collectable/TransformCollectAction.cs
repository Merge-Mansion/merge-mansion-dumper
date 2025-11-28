using Metaplay.Core;
using Metaplay.Core.Model;
using System;
using System.Runtime.Serialization;
using GameLogic.Config;

namespace GameLogic.Player.Items.Collectable
{
    [MetaSerializableDerived(3)]
    public class TransformCollectAction : ITransformCollectAction, ICollectAction
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        [MetaOnMemberDeserializationFailure("FixItemRef")]
        public ItemDef TransformsInto { get; set; }

        private TransformCollectAction()
        {
        }

        public TransformCollectAction(MetaRef<ItemDefinition> transformsInto)
        {
        }

        public TransformCollectAction(int itemId)
        {
        }
    }
}