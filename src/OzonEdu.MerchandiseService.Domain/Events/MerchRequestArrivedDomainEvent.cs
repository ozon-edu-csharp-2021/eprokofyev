using MediatR;
using OzonEdu.MerchandiseService.Domain.AggregationModels.EmployeeAggregate;
using OzonEdu.MerchandiseService.Domain.AggregationModels.MerchItemAggregate;
using OzonEdu.MerchandiseService.Domain.AggregationModels.MerchRequestAggregate;

namespace OzonEdu.MerchandiseService.Domain.Events
{
    public class MerchRequestArrivedDomainEvent
    {
        public MerchPackItem MerchPackItem { get; }
        public Employee Employee { get; }
        public MerchSizes Sizes { get; }

        public MerchRequestArrivedDomainEvent(MerchPackItem merchPackItem, Employee employee, MerchSizes sizes)
        {
            MerchPackItem = merchPackItem;
            Employee = employee;
            Sizes = sizes;
        }
    }
}