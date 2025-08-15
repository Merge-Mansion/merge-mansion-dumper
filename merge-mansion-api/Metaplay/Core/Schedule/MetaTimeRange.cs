using Metaplay.Core.Model;

namespace Metaplay.Core.Schedule
{
    [MetaSerializable]
    public readonly struct MetaTimeRange
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public readonly MetaTime Start;
        [MetaMember(2, (MetaMemberFlags)0)]
        public readonly MetaTime End;
    }
}