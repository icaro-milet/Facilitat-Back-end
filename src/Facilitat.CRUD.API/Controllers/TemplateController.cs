using System.Collections.Generic;
using System.Threading.Tasks;
using Facilitat.CRUD.Application.Dtos;
using Facilitat.CRUD.Application.Interfaces.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Facilitat.CRUD.API.Controllers
{
    [Controller]
    [Route("[controller]/")]
    public class TemplateController : Controller
    {
        private readonly ITemplateAppService _templateAppService;

        public TemplateController(ITemplateAppService templateAppService)
        {
            _templateAppService = templateAppService;
        }

        [HttpGet("GetAllTemplatesAsync")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IEnumerable<TemplateDto>> GetAllTemplatesAsync()
        {
            return await _templateAppService.GetAllTemplatesAsync();
        }

        [HttpPost("CreateTemplate")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> CreateTemplate([FromBody] TemplateDto templateDto)
        {
            var item = await _templateAppService.InsertTemplateAsync(templateDto);
            return Ok();
        }
    }
}

