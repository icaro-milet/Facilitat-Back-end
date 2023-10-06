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
				Id = serviceOrder.Id,
                DateCreated = serviceOrder.DateCreated,
                Status = serviceOrder.Status,
                ServiceOrderCode = serviceOrder.ServiceOrderCode
			};
        }

        public static ServiceOrder ServiceOrderDtoToServiceOrder(ServiceOrderDto serviceOrderDto)
        {
            return new ServiceOrder()
            {
                Id = serviceOrderDto.Id,
                DateCreated = serviceOrderDto.DateCreated,
                Status = serviceOrderDto.Status,
                ServiceOrderCode = serviceOrderDto.ServiceOrderCode
            };
        }
    }
}

