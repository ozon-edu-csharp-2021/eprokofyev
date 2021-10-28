using System.Threading.Tasks;
using Grpc.Core;
using OzonEdu.MerchandiseService.Grpc;
using OzonEdu.MerchandiseService.Models;
using OzonEdu.MerchandiseService.Services.Interfaces;

namespace OzonEdu.MerchandiseService.GrpcServices
{
    public class MerchandiseGrpcService : MerchandiseServiceGrpc.MerchandiseServiceGrpcBase
    {
        private readonly IMerchandiseService _merchandiseService;
        
        public MerchandiseGrpcService(IMerchandiseService merchandiseService)
        {
            _merchandiseService = merchandiseService;
        }

        public override async Task<RequestMerchandiseItemResponse> RequestMerchandiseItem(RequestMerchandiseItemRequest request, ServerCallContext context)
        {
            var merchItem = await _merchandiseService.RequestMerch(new MerchRequest()
                {
                    MerchName = request.ItemName
                }, context.CancellationToken);
            return new RequestMerchandiseItemResponse()
            {
                ItemName = merchItem.MerchName
            };
        }

        public override async Task<RequestMerchandiseInfo> GetRequestMerchandiseInfo(RequestMerchandiseItemRequest request, ServerCallContext context)
        {
            var merchItem = await _merchandiseService.RequestMerch(new MerchRequest()
            {
                MerchName = request.ItemName
            }, context.CancellationToken);
            return new RequestMerchandiseInfo()
            {
                ItemName = merchItem.MerchName
            };
        }
    }
}