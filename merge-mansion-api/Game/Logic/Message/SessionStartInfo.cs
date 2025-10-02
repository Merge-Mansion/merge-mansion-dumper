using Metaplay.Core.Message;
using Metaplay.Core.Model;
using System;

namespace Game.Logic.Message
{
    [MetaSerializableDerived(1)]
    public class SessionStartInfo : ISessionStartSuccessGamePayload
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        [Obsolete("Was used by SCID SDK")]
        public string SCIDGameAccountToken; // 0x10
        public SessionStartInfo()
        {
        }
    }
}