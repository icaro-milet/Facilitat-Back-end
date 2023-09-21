using System.Collections.Generic;
using System.Threading.Tasks;
using Facilitat.CRUD.Application.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Facilitat.CRUD.Application.Interfaces.Services;

namespace Facilitat.CRUD.API.Controllers
{
    [Controller]
    [Route("[controller]/")]
    public class ServiceOrderController : Controller
    {
        private readonly IServiceOrderAppService _serviceOrderAppService;

		public ServiceOrderController(IServiceOrderAppService serviceOrderAppService)
        {
            _serviceOrderAppService = serviceOrderAppService;
        }

        [HttpGet("GetAllServiceOrders")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IEnumerable<ServiceOrderDto>> GetAllServiceOrders()
        {
            return await _serviceOrderAppService.GetAllServiceOrders();
        }
	}
}

