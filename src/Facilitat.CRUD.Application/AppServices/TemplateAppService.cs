using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Facilitat.CRUD.Application.Dtos;
using Facilitat.CRUD.Application.Interfaces.Services;
using Facilitat.CRUD.Domain.Aggregates.Template.Entities;
using Facilitat.CRUD.Domain.Aggregates.Template.Interfaces.Services;

namespace Facilitat.CRUD.Application.AppServices
{
    public class TemplateAppService : ITemplateAppService
	{
		private readonly ITemplateService _templateService;

		public TemplateAppService(ITemplateService templateService)
		{
			_templateService = templateService;
        }

		public async Task<IEnumerable<TemplateDto>> GetAllTemplatesAsync()
		{
			var template = await _templateService.GetAllTemplatesAsync();

			var templateDto = template
				.Select(template => new TemplateDto()
				{
					Id = template.Id,
					Email = template.Email,
					Username = template.Username
				});
			
            return templateDto;
        }

        public async Task<TemplateDto> InsertTemplateAsync(TemplateDto templateDto)
        {
            Template template = new Template()
			{
				Id = templateDto.Id,
				Username = templateDto.Username,
				Email = templateDto.Email
			};

			var teste = await _templateService.InsertTemplateAsync(template);

			{
				templateDto.Id = teste.Id;
				templateDto.Username = teste.Username;
				templateDto.Email = teste.Email;
			}

			return templateDto;
        }
    }
}

