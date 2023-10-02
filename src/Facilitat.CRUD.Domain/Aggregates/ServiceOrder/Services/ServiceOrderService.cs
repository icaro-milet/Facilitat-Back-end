using System.Collections.Generic;
using System.Threading.Tasks;
using Facilitat.CRUD.Domain.Aggregates.ServiceOrder.Interfaces.Repository;
using Facilitat.CRUD.Domain.Aggregates.ServiceOrder.Interfaces.Services;

namespace Facilitat.CRUD.Domain.Aggregates.ServiceOrder.Services
{
    public class ServiceOrderService : IServiceOrderService
    {
        private readonly IServiceOrderRepository _serviceOrderRepository;

        public ServiceOrderService(IServiceOrderRepository serviceOrderRepository)
        {
            _serviceOrderRepository = serviceOrderRepository;
        }

        public async Task<Entities.ServiceOrder> CreateServiceOrder(Entities.ServiceOrder serviceOrder)
        {
            return await _serviceOrderRepository.CreateServiceOrder(serviceOrder);
        }

        public async Task<IEnumerable<Entities.ServiceOrder>> GetAllServiceOrders()
        {
            return await _serviceOrderRepository.GetAllServiceOrders();
        }
    }
}

