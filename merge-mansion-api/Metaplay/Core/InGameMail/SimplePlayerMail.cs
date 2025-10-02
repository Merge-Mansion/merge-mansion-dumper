using Metaplay.Core.Model;
using Metaplay.Core.Forms;
using Metaplay.Core.Localization;
using System;
using System.Collections.Generic;
using Metaplay.Core.Rewards;

namespace Metaplay.Core.InGameMail
{
    [MetaSerializableDerived(100)]
    [MetaReservedMembers(0, 100)]
    public class SimplePlayerMail : MetaInGameMail
    {
        [MetaValidateRequired]
        [MetaMember(1, (MetaMemberFlags)0)]
        public LocalizedString Title { get; set; }

        [MetaFormTextArea]
        [MetaMember(2, (MetaMemberFlags)0)]
        public LocalizedString Body { get; set; }

        [MetaFormFieldContext("AttachmentRewardList", true)]
        [MetaFormFieldCustomValidator(typeof(InGameMailRewardListValidator))]
        [MetaFormDisplayProps("Attachment")]
        [MetaMember(3, (MetaMemberFlags)0)]
        public List<MetaPlayerRewardBase> Attachments { get; set; }
        public override string Description { get; }
        public override IEnumerable<MetaPlayerRewardBase> ConsumableRewards { get; }

        public SimplePlayerMail()
        {
        }

        public SimplePlayerMail(LanguageId lang, string title, string body, List<MetaPlayerRewardBase> attachments, MetaGuid mailId)
        {
        }
    }
}