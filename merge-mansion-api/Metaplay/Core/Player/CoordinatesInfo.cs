using Metaplay.Core.Model;
using Metaplay.Core.Math;
using System;

namespace Metaplay.Core.Player
{
    [MetaSerializable]
    public class CoordinatesInfo
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public F32 Latitude { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        public F32 Longitude { get; set; }

        [MetaMember(3, (MetaMemberFlags)0)]
        public int? AccuracyRadiusKilometers { get; set; }

        private CoordinatesInfo()
        {
        }

        public CoordinatesInfo(F32 latitude, F32 longitude, int? accuracyRadiusKilometers)
        {
        }
    }
}