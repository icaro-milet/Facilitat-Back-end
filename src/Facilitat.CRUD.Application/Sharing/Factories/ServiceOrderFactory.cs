using Facilitat.CRUD.Application.Dtos;
using Facilitat.CRUD.Domain.Aggregates.ServiceOrder.Entities;

namespace Facilitat.CRUD.Application.Sharing.Factories
{
    public static class ServiceOrderFactory
	{
		public static ServiceOrderDto ServiceOrderToServiceOrderDto(ServiceOrder serviceOrder)
		{
			return new ServiceOrderDto()
			{
				id = serviceOrder.id,
                service_order_name = serviceOrder.service_order_name,
                description = serviceOrder.description
			};
        }

        public static ServiceOrder ServiceOrderDtoToServiceOrder(ServiceOrderDto serviceOrderDto)
        {
            return new ServiceOrder()
            {
                id = serviceOrderDto.id,
                service_order_name = serviceOrderDto.service_order_name,
                description = serviceOrderDto.description
            };
        }
    }
}

