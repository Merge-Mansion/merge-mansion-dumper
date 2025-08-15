using Metaplay.Core.Model;

namespace Metaplay.Core.Player
{
    [MetaSerializable]
    public interface IPlatformSpecificData
    {
        MetaTime LastUpdated { get; }
    }
}