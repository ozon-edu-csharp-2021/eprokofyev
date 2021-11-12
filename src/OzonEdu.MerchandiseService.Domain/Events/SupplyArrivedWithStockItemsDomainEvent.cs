using MediatR;
using OzonEdu.MerchandiseService.Domain.AggregationModels.MerchRequestAggregate;

namespace OzonEdu.MerchandiseService.Domain.Events
{
    /// <summary>
    ///     Пришла поставка с новыми товарами
    /// </summary>
    public class SupplyArrivedWithStockItemsDomainEvent : INotification
    {
        public SupplyArrivedWithStockItemsDomainEvent(Sku stockItemSku,
            Quantity quantity)
        {
            StockItemSku = stockItemSku;
            Qty = quantity;
        }

        public Sku StockItemSku { get; }
        public Quantity Qty { get; }
    }
}