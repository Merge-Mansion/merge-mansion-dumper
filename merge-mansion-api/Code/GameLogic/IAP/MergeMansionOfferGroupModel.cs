using Metaplay.Core.Model;
using Metaplay.Core.Offers;
using System;
using Metaplay.Core;

namespace Code.GameLogic.IAP
{
    [MetaSerializableDerived(14)]
    public class MergeMansionOfferGroupModel : MetaOfferGroupModelBase
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public bool PendingActivationTrigger { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        public bool MailTriggered { get; set; }

        [MetaMember(3, (MetaMemberFlags)0)]
        private MetaTime? ExtensionStartedAt { get; set; }

        [MetaMember(4, (MetaMemberFlags)0)]
        private MetaDuration? ExtensionDuration { get; set; }

        [MetaMember(5, (MetaMemberFlags)0)]
        public bool PopupNoted { get; set; }

        public MergeMansionOfferGroupModel()
        {
        }

        public MergeMansionOfferGroupModel(MergeMansionOfferGroupInfo groupInfo)
        {
        }
    }
}