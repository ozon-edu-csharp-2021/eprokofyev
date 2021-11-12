using System.Collections.Generic;
using OzonEdu.MerchandiseService.Domain.Models;

namespace OzonEdu.MerchandiseService.Domain.AggregationModels.MerchRequestAggregate
{
    public sealed class PhoneNumber : ValueObject
    {
        public PhoneNumber(string value)
        {
            Value = value;
        }

        public string Value { get; }

        public static PhoneNumber Parse(string number)
        {
            // TODO validation
            return new PhoneNumber(number);
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }
    }
}