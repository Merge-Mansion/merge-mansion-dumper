using System.Collections.Generic;
using Metaplay.Core.Model;
using System;
using System.Runtime.Serialization;

namespace GameLogic.Player.Director.Config
{
    [MetaSerializableDerived(9)]
    [MetaBlockedMembers(new int[] { 2 })]
    public class TriggerPopup : IDirectorAction
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        private string PopupId { get; set; }

        [MetaMember(3, (MetaMemberFlags)0)]
        private List<ISerializableArg> Args { get; set; }

        private TriggerPopup()
        {
        }

        public TriggerPopup(string popupId, List<string> args)
        {
        }

        public TriggerPopup(string popupId, List<ISerializableArg> args)
        {
        }

        public TriggerPopup(string popupId, IEnumerable<string> args)
        {
        }

        [IgnoreDataMember]
        public bool IsVisualAction { get; }

        [MetaMember(4, (MetaMemberFlags)0)]
        public bool AllowBoard { get; set; }

        public TriggerPopup(string popupId, List<ISerializableArg> args, bool allowBoard)
        {
        }

        public TriggerPopup(string popupId, IEnumerable<string> args, bool allowBoard)
        {
        }
    }
}