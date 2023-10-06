using Facilitat.CRUD.Application.Dtos;
using Facilitat.CRUD.Application.Interfaces.Services;
using Facilitat.CRUD.Application.Sharing.Factories;
using Facilitat.CRUD.Domain.Aggregates.ServiceOrder.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Facilitat.CRUD.Application.AppServices
{
    public class ServiceOrderAppService : IServiceOrderAppService
    {
        private readonly IServiceOrderService _serviceOrderService;

		public ServiceOrderAppService(IServiceOrderService serviceOrderService)
		{
            _serviceOrderService = serviceOrderService;
		}

        public async Task<ServiceOrderDto> CreateServiceOrder(ServiceOrderDto serviceOrderDto)
        {
            var serviceOrder = ServiceOrderFactory.ServiceOrderDtoToServiceOrder(serviceOrderDto);

            serviceOrder = await _serviceOrderService.CreateServiceOrder(serviceOrder);

            serviceOrderDto = ServiceOrderFactory.ServiceOrderToServiceOrderDto(serviceOrder);

            return serviceOrderDto;
        }

        public async Task<IEnumerable<ServiceOrderDto>> GetAllServiceOrders()
        {
            var serviceOrder = await _serviceOrderService.GetAllServiceOrders();

            var serviceOrdersDto = serviceOrder
                .Select(serviceOrder => new ServiceOrderDto()
                {
                    Id = serviceOrder.Id,
                    DateCreated = serviceOrder.DateCreated, 
                    ServiceOrderCode = serviceOrder.ServiceOrderCode,
                    Status = serviceOrder.Status
                });

            return serviceOrdersDto;
        }

        public async Task<ServiceOrderDto> GetServiceOrderByCodeAsync(string serviceOrderCode)
        {
            var serviceOrder = await _serviceOrderService.GetServiceOrderByCodeAsync(serviceOrderCode);

            var serviceOrderDto = ServiceOrderFactory.ServiceOrderToServiceOrderDto(serviceOrder);

            return serviceOrderDto;
        }
    }
}

