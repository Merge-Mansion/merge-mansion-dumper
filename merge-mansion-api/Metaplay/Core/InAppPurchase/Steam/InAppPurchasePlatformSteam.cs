using Metaplay.Core.Model;
using System;

namespace Metaplay.Core.InAppPurchase.Steam
{
    [MetaSerializable]
    public class InAppPurchasePlatformSteam : InAppPurchasePlatform
    {
        public static int TagId;
        public static InAppPurchasePlatform Steam;
        protected InAppPurchasePlatformSteam(int id, string name, bool isValid, bool isReservedValueDummy) : base(id, name, isValid, isReservedValueDummy)
        {
        }
    }
}