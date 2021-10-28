using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using OzonEdu.MerchandiseService.Models;

namespace OzonEdu.MerchandiseService.Services.Interfaces
{
    public interface IMerchandiseService
    {
        Task<MerchItem> RequestMerch(MerchRequest merchItem, CancellationToken _);
        
        Task<MerchResponse> ResponseMerch(long itemId, CancellationToken _);
    }
}