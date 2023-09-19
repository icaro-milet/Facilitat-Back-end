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

        [HttpGet("GetAllTemplates")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IEnumerable<TemplateDto>> GetAllTemplatesAsync()
        {
            return await _templateAppService.GetAllTemplatesAsync();
        }

        [HttpGet("GetByIdTemplate/{templateId}")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(IEnumerable<TemplateDto>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<TemplateDto> GetByIdTemplateAsync(int templateId)
        {
            return await _templateAppService.GetByIdTemplateAsync(templateId);
        }

        [HttpPost("CreateTemplate")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<TemplateDto> CreateTemplate([FromBody] TemplateDto templateDto)
        {
            return await _templateAppService.InsertTemplateAsync(templateDto);
        }

        [HttpPut("UpdateTemplate/{templateId}")]
        [Produces("application/json")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<TemplateDto> UpdateTemplateAsync(int templateId, [FromBody] TemplateDto templateDto)
        {
            return await _templateAppService.UpdateTemplateAsync(templateId, templateDto);
        }
    }
}

