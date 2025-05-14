using Metaplay.Core.Model;

namespace GameLogic.Player.Rewards
{
    [MetaSerializable]
    [ForceExplicitEnumValues]
    public enum RewardContainerItemType
    {
        None = 0,
        Item = 1,
        Currency = 2,
        Energy = 3,
        ItemForCollectibleBoardEvent = 4,
        CardCollectionPack = 5,
        CooldownRemover = 6,
        SkipTime = 7,
        ActivateInfiniteEnergy = 8
    }
}