using Metaplay.Core.Model;
using System;
using System.Runtime.Serialization;

namespace GameLogic.Player.Director.Config
{
    [MetaSerializableDerived(12)]
    public class ShowTutorialFinger : IDirectorAction
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public string TargetId { get; set; }

        private ShowTutorialFinger()
        {
        }

        public ShowTutorialFinger(string targetId)
        {
        }

        [IgnoreDataMember]
        public bool IsVisualAction { get; }
    }
}