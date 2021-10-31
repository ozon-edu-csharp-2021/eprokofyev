using System.Threading;
using System.Threading.Tasks;
using OzonEdu.MerchandiseService.HttpModels;

namespace OzonEdu.MerchandiseService.HttpClient
{
    public interface IMerchandiseHttpClient
    {
        Task<MerchItemRequest> RequestMerch(MerchItemRequest itemRequest, CancellationToken token);
        Task<MerchItemResponse> GetRequestedMerchInfo(long id, CancellationToken token);
    }
}