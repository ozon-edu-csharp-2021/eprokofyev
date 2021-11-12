using OzonEdu.MerchandiseService.Domain.Models;

namespace OzonEdu.MerchandiseService.Domain.AggregationModels.MerchRequestAggregate
{
    public sealed class MerchRequestStatus : Enumeration
    {
        public static MerchRequestStatus Draft = new(1, nameof(Draft));
        public static MerchRequestStatus Created = new(2, nameof(Created));
        public static MerchRequestStatus InProgress = new(3, nameof(InProgress));
        public static MerchRequestStatus WaitingForStock = new(4, nameof(WaitingForStock));
        public static MerchRequestStatus Done = new(5, nameof(Done));

        public MerchRequestStatus(int id, string name) : base(id, name)
        {
        }
    }
}