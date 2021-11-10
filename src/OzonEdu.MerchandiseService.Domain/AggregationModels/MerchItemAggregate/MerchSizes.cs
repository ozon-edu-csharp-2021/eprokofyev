using System;
using System.Collections.Generic;
using OzonEdu.MerchandiseService.Domain.Models;

namespace OzonEdu.MerchandiseService.Domain.AggregationModels.MerchItemAggregate
{
    public class MerchSizes : ValueObject
    {
        public int TshrtSize { get; private set; }
        public int PantsSize { get; private set; }
        public int ShoesSize { get; private set; }
        
        public MerchSizes(int tshrtSize, int pantsSize, int shoesSize)
        {
            TshrtSize = tshrtSize;
            PantsSize = pantsSize;
            ShoesSize = shoesSize;
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return TshrtSize;
            yield return PantsSize;
            yield return ShoesSize;
        }
    }
}