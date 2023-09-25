using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Facilitat.CRUD.Application.Dtos;
using Facilitat.CRUD.Application.Interfaces.Services;
using Facilitat.CRUD.Domain.Aggregates.ServiceOrder.Interfaces.Services;

namespace Facilitat.CRUD.Application.AppServices
{
    public class ServiceOrderAppService : IServiceOrderAppService
    {
        private readonly IServiceOrderService _serviceOrderService;

		public ServiceOrderAppService(IServiceOrderService serviceOrderService)
		{
            _serviceOrderService = serviceOrderService;
		}

        public async Task<IEnumerable<ServiceOrderDto>> GetAllServiceOrders()
        {
            var serviceOrder = await _serviceOrderService.GetAllServiceOrders();

            var serviceOrdersDto = serviceOrder
                .Select(serviceOrder => new ServiceOrderDto()
                {
                    Id = serviceOrder.Id,
                    template_id = serviceOrder.template_id,
                    Code = serviceOrder.Code,
                    Description = serviceOrder.Description
                });

            return serviceOrdersDto;
        }
    }
}

