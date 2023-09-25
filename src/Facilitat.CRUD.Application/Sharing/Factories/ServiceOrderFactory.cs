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
                template_id = serviceOrder.template_id,
				Code = serviceOrder.Code,
				Description = serviceOrder.Description
			};
        }

        public static ServiceOrder ServiceOrderDtoToServiceOrder(ServiceOrderDto serviceOrderDto)
        {
            return new ServiceOrder()
            {
                Id = serviceOrderDto.Id,
                template_id = serviceOrderDto.template_id,
                Code = serviceOrderDto.Code,
                Description = serviceOrderDto.Description
            };
        }
    }
}

