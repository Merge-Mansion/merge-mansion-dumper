using Metaplay.Core.Model;
using System;

namespace Metaplay.Core.InAppPurchase
{
    [MetaSerializable]
    public class InAppProductId : StringId<InAppProductId>
    {
        public InAppProductId()
        {
        }

        public static int MaxLength;
    }
}