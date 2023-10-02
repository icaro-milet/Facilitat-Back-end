using System.Collections.Generic;
using System.Threading.Tasks;

namespace Facilitat.CRUD.Domain.Aggregates.ServiceOrder.Interfaces.Services
{
    public interface IServiceOrderService
	{
        Task<IEnumerable<Entities.ServiceOrder>> GetAllServiceOrders();
        Task<Entities.ServiceOrder> CreateServiceOrder(Entities.ServiceOrder serviceOrder);
    }
}

