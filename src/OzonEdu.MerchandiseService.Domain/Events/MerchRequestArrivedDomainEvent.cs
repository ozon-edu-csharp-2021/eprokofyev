using OzonEdu.MerchandiseService.Domain.AggregationModels.EmployeeAggregate;
using OzonEdu.MerchandiseService.Domain.AggregationModels.MerchItemAggregate;

namespace OzonEdu.MerchandiseService.Domain.Events
{
    public class MerchRequestArrivedDomainEvent
    {
        public MerchRequestArrivedDomainEvent(MerchPackItem merchPackItem, Employee employee, MerchSizes sizes)
        {
            MerchPackItem = merchPackItem;
            Employee = employee;
            Sizes = sizes;
        }

        public MerchPackItem MerchPackItem { get; }
        public Employee Employee { get; }
        public MerchSizes Sizes { get; }
    }
}