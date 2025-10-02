using Metaplay.Core.Model;
using System;

namespace Metaplay.Core.Player
{
    [MetaSerializableDerived(101)]
    [MetaReservedMembers(200, 300)]
    public class PlayerDeviceIdAuthEntry : PlayerAuthEntryBase
    {
        [MetaMember(201, (MetaMemberFlags)0)]
        public string DeviceModel { get; set; }

        private PlayerDeviceIdAuthEntry()
        {
        }

        public PlayerDeviceIdAuthEntry(MetaTime attachedAt, string deviceModel)
        {
        }
    }
}