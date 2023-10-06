using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Facilitat.CRUD.Domain.Aggregates.ServiceOrder.Interfaces.Repository
{
    public interface IServiceOrderRepository
	{
        Task<IEnumerable<Entities.ServiceOrder>> GetAllServiceOrders();
        Task<Entities.ServiceOrder> CreateServiceOrder(Entities.ServiceOrder serviceOrder);
        Task<Entities.ServiceOrder> GetServiceOrderByCodeAsync(string serviceOrderCode);
    }
}

