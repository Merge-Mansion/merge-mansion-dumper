using Metaplay.Core.Model;
using System;
using GameLogic.Player.Requirements;

namespace Code.GameLogic.GameEvents
{
    [MetaSerializable]
    public class TestCoreSupportEventModeInfo : CoreSupportEventModeInfo
    {
        [MetaMember(101, (MetaMemberFlags)0)]
        public string TestCode { get; set; }

        public TestCoreSupportEventModeInfo()
        {
        }

        public TestCoreSupportEventModeInfo(CoreSupportEventModeId configKey, PlayerRequirement enableRequirement, PlayerRequirement disableRequirement, string testCode)
        {
        }
    }
}