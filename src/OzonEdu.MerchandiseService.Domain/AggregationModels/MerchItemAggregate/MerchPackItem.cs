using System.Collections.Generic;

namespace OzonEdu.MerchandiseService.Domain.AggregationModels.MerchItemAggregate
{
    public class MerchPackItem
    {
        public MerchPackItem(
            Name name,
            MerchPackItem merchPackItemType,
            List<long> itemIdCollection)
        {
            MerchName = name;
            MerchPackItemType = merchPackItemType;
            ItemIdCollection = itemIdCollection;
        }

        public Name MerchName { get; }

        public MerchPackItem MerchPackItemType { get; }
        public List<long> ItemIdCollection { get; }
    }
}