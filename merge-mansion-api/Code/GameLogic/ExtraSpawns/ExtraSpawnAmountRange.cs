using Metaplay.Core.Model;
using Metaplay.Core.Math;

namespace Code.GameLogic.ExtraSpawns
{
    [MetaSerializable]
    public struct ExtraSpawnAmountRange
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public F32 Min { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        public F32 Max { get; set; }
    }
}