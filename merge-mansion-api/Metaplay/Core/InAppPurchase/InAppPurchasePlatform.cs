using Metaplay.Core.Model;
using System;

namespace Metaplay.Core.InAppPurchase
{
    [MetaSerializable]
    public class InAppPurchasePlatform : DynamicEnum<InAppPurchasePlatform>
    {
        public static int MaxNameLength;
        public static InAppPurchasePlatform Google;
        public static InAppPurchasePlatform Apple;
        public static InAppPurchasePlatform Development;
        public static InAppPurchasePlatform _ReservedDontUse3;
        public static InAppPurchasePlatform _ReservedDontUse4;
        public static InAppPurchasePlatform WebshopNeon;
        protected InAppPurchasePlatform(int id, string name, bool isReservedValueDummy) : base(id, name)
        {
            IsReservedValueDummy = isReservedValueDummy;
        }

        public bool IsReservedValueDummy { get; }
    }
}