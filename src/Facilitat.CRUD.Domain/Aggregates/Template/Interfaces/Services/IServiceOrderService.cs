using System.Collections.Generic;
using System.Threading.Tasks;

namespace Facilitat.CRUD.Domain.Aggregates.Template.Interfaces.Services
{
    public interface IServiceOrderService
	{
        Task<IEnumerable<Entities.ServiceOrder>> GetAllServiceOrders();
    }
}

