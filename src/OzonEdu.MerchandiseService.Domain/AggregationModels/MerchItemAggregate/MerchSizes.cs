using System.Collections.Generic;
using OzonEdu.MerchandiseService.Domain.Models;

namespace OzonEdu.MerchandiseService.Domain.AggregationModels.MerchItemAggregate
{
    public class MerchSizes : ValueObject
    {
        public MerchSizes(int tshrtSize, int pantsSize, int shoesSize)
        {
            TshrtSize = tshrtSize;
            PantsSize = pantsSize;
            ShoesSize = shoesSize;
        }

        public int TshrtSize { get; }
        public int PantsSize { get; }
        public int ShoesSize { get; }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return TshrtSize;
            yield return PantsSize;
            yield return ShoesSize;
        }
    }
}