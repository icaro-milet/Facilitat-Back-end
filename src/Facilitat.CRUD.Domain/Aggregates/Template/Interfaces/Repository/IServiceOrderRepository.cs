using System.Collections.Generic;
using System.Threading.Tasks;

namespace Facilitat.CRUD.Domain.Aggregates.Template.Interfaces.Repository
{
    public interface IServiceOrderRepository
	{
        Task<IEnumerable<Entities.ServiceOrder>> GetAllServiceOrders();
    }
}

