using GameLogic;
using Metaplay.Core.Model;

namespace Code.GameLogic.GameEvents
{
    [MetaSerializable]
    [ForceExplicitEnumValues]
    public enum MuseumShelfRewardState
    {
        NoneClaimed = 0,
        NormalClaimed = 1,
        AllClaimed = 2
    }
}