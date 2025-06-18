using Metaplay.Core;

namespace GameLogic.Player.Items.Collectable
{
    public interface ITransformCollectAction : ICollectAction
    {
        MetaRef<ItemDefinition> TransformsInto { get; }
    }
}