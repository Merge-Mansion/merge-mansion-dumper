using Metaplay.Core.Model;
using System;
using System.Runtime.Serialization;

namespace GameLogic.Player.Director.Config
{
    [MetaSerializableDerived(11)]
    public class TriggerSong : IDirectorAction
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        private string SongAlias { get; set; }

        private TriggerSong()
        {
        }

        public TriggerSong(string songAlias)
        {
        }

        [IgnoreDataMember]
        public bool IsVisualAction { get; }
    }
}