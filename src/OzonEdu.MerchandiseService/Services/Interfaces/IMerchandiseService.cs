using System;
using System.Threading;
using System.Threading.Tasks;
using OzonEdu.MerchandiseService.Models;

namespace OzonEdu.MerchandiseService.Services.Interfaces
{
    public interface IMerchandiseService
    {
        Task<MerchItem> RequestMerch(MerchRequest merchItem, CancellationToken token);

        Task<MerchResponse> ResponseMerch(Guid itemId, CancellationToken token);
    }
}