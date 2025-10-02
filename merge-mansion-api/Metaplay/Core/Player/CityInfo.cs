using Metaplay.Core.Model;
using System;

namespace Metaplay.Core.Player
{
    [MetaSerializable]
    public class CityInfo
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public long GeoNameId { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        public string Name { get; set; }

        private CityInfo()
        {
        }

        public CityInfo(long geoNameId, string name)
        {
        }
    }
}