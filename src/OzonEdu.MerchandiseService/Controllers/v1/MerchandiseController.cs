using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OzonEdu.MerchandiseService.HttpModels;
using OzonEdu.MerchandiseService.Models;
using OzonEdu.MerchandiseService.Services.Interfaces;

namespace OzonEdu.MerchandiseService.Controllers.v1
{
    [ApiController]
    [Route("v1/api/merch")]
    [Produces("application/json")]
    public class MerchandiseController : ControllerBase
    {
        private readonly IMerchandiseService _merchandiseService;

        public MerchandiseController(IMerchandiseService merchandiseService)
        {
            _merchandiseService = merchandiseService;
        }


        [HttpPost]
        public async Task<ActionResult<MerchItemRequest>> Add(MerchItemRequest merchItemRequestModel,
            CancellationToken token)
        {
            var createdStockItem = await _merchandiseService.RequestMerch(new MerchRequest
            {
                MerchName = merchItemRequestModel.ItemName
            }, token);

            return Ok(createdStockItem);
        }

        [HttpGet("{id:long}")]
        public async Task<ActionResult<MerchResponse>> GetById(long id, CancellationToken token)
        {
            var merchItem = await _merchandiseService.ResponseMerch(id, token);
            if (merchItem is null)
            {
                return NotFound();
            }

            return merchItem;
        }
    }
}