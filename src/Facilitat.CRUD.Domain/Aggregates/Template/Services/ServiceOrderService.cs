using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Facilitat.CRUD.Domain.Aggregates.Template.Entities;
using Facilitat.CRUD.Domain.Aggregates.Template.Interfaces.Repository;
using Facilitat.CRUD.Domain.Aggregates.Template.Interfaces.Services;

namespace Facilitat.CRUD.Domain.Aggregates.Template.Services
{
	public class ServiceOrderService : IServiceOrderService
	{
        private readonly IServiceOrderRepository _serviceOrderRepository;

		public ServiceOrderService(IServiceOrderRepository serviceOrderRepository)
		{
            _serviceOrderRepository = serviceOrderRepository;
        }

        public async Task<IEnumerable<ServiceOrder>> GetAllServiceOrders()
        {
            return await _serviceOrderRepository.GetAllServiceOrders();
        }
    }
}

