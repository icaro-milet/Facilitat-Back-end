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
                name = serviceOrder.name,
                description = serviceOrder.description
			};
        }

        public static ServiceOrder ServiceOrderDtoToServiceOrder(ServiceOrderDto serviceOrderDto)
        {
            return new ServiceOrder()
            {
                id = serviceOrderDto.id,
                name = serviceOrderDto.name,
                description = serviceOrderDto.description
            };
        }
    }
}

