using Metaplay.Core.Model;
using Metaplay.Core.Authentication;

namespace Metaplay.Core.Player
{
    [MetaSerializable]
    [MetaReservedMembers(100, 200)]
    public abstract class PlayerAuthEntryBase
    {
        [MetaMember(100, (MetaMemberFlags)0)]
        public MetaTime AttachedAt { get; set; }

        protected PlayerAuthEntryBase()
        {
        }

        protected PlayerAuthEntryBase(MetaTime attachedAt)
        {
        }

        [MetaSerializableDerived(100)]
        public class Default : PlayerAuthEntryBase
        {
            private Default()
            {
            }

            public Default(MetaTime attachedAt)
            {
            }
        }

        [MetaMember(101, (MetaMemberFlags)0)]
        public IAuthenticationPlatformUserInfo User { get; set; }
    }
}