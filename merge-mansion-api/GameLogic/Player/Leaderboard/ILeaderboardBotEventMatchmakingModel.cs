using Metaplay.Core;
using Metaplay.Core.League;

namespace GameLogic.Player.Leaderboard
{
    public interface ILeaderboardBotEventMatchmakingModel
    {
        MetaTime CurrentTime { get; }

        MetaTime? MatchMakingEnded { get; set; }

        MetaTime EndsAt { get; set; }

        IDivisionModelClientListenerCore ClientListenerCore { get; }
    }
}