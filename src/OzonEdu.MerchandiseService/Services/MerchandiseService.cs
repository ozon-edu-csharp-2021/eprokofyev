using System;
using System.Threading;
using System.Threading.Tasks;
using OzonEdu.MerchandiseService.Models;
using OzonEdu.MerchandiseService.Services.Interfaces;

namespace OzonEdu.MerchandiseService.Services
{
    public class MerchandiseService : IMerchandiseService
    {
        public Task<MerchItem> RequestMerch(MerchRequest merchItem, CancellationToken _)
        {
            var newMerchItem = new MerchItem
            {
                MerchName = merchItem.MerchName
            };
            return Task.FromResult(newMerchItem);
        }

        public Task<MerchResponse> ResponseMerch(Guid itemId, CancellationToken _)
        {
            return Task.FromResult(new MerchResponse("T-Shirt"));
        }
    }
}