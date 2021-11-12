using System;
using OzonEdu.MerchandiseService.Domain.Models;

namespace OzonEdu.MerchandiseService.Domain.AggregationModels.EmployeeAggregate
{
    public class Employee : Entity
    {
        /// <summary>
        ///     Уникальный идентификатор сотрудника
        /// </summary>
        public Guid Id { get; }
    }
}