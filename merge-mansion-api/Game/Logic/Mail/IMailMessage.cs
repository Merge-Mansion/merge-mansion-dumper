using Metaplay.Core;
using System;
using System.Collections.Generic;
using GameLogic;
using GameLogic.Player.Rewards;

namespace Game.Logic.Mail
{
    public interface IMailMessage
    {
        MetaGuid Id { get; }

        InboxItemStatus Status { get; }

        string TitleExcerpt { get; }

        string BodyExcerpt { get; }

        IEnumerable<IPlayerReward> Rewards { get; }

        MergeMansionMailContents Contents { get; }

        MetaTime SentAt { get; }
    }
}