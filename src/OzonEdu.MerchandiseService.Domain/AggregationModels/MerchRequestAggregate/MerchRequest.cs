using System;
using OzonEdu.MerchandiseService.Domain.AggregationModels.MerchItemAggregate;
using OzonEdu.MerchandiseService.Domain.Models;

namespace OzonEdu.MerchandiseService.Domain.AggregationModels.MerchRequestAggregate
{
    public sealed class MerchRequest : Entity
    {
        /// <summary>
        ///     Уникальный идентификатор запроса
        /// </summary>
        public Guid Id { get; }

        /// <summary>
        ///     Статус запроса
        /// </summary>
        public MerchRequestStatus Status { get; private set; }

        /// <summary>
        ///     Идентификатор сотрудника которому запрашивается мерч
        /// </summary>
        public long EmployeeId { get; private set; }

        /// <summary>
        ///     Телефон для связи с сотрудником
        /// </summary>
        public PhoneNumber ContactPhone { get; private set; }

        /// <summary>
        ///     ID мерч пака для выдачи
        /// </summary>
        public long MerchPackId { get; private set; }
        
        /// <summary>
        ///     Набор размеров одежды
        /// </summary>
        public MerchSizes Sizes { get; private set; }
    }
}