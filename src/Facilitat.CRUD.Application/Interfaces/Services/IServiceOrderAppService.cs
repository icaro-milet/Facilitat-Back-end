using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Facilitat.CRUD.Application.Dtos;

namespace Facilitat.CRUD.Application.Interfaces.Services
{
    public interface IServiceOrderAppService
	{
        Task<IEnumerable<ServiceOrderDto>> GetAllServiceOrders();
        Task<ServiceOrderDto> CreateServiceOrder(ServiceOrderDto serviceOrderDto);
        Task<ServiceOrderDto> GetServiceOrderByCodeAsync(string serviceOrderCode);
    }
}

