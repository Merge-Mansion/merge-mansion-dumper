using Metaplay.Core.Model;
using GameLogic;

namespace Code.GameLogic.IAP
{
    [MetaSerializable]
    [ForceExplicitEnumValues]
    public enum OfferType
    {
        Undefined = 0,
        Generic = 1,
        BigBundle = 2,
        MakeYourOwn = 3
    }
}