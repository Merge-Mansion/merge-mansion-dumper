using Metaplay.Core.Model;
using Metaplay.Core.Activables;

namespace Metaplay.Core.Offers
{
    [MetaSerializableDerived(100)]
    [MetaActivableConfigData("OfferGroup", true, false)]
    public class DefaultMetaOfferGroupInfo : MetaOfferGroupInfoBase
    {
        public DefaultMetaOfferGroupInfo()
        {
        }

        public DefaultMetaOfferGroupInfo(MetaOfferGroupSourceConfigItemBase source)
        {
        }
    }
}