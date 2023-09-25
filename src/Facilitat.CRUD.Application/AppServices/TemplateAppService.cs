using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Facilitat.CRUD.Application.Dtos;
using Facilitat.CRUD.Application.Interfaces.Services;
using Facilitat.CRUD.Application.Sharing.Factories;
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
					Name = template.Name
				});
			
            return templateDto;
        }

        public async Task<TemplateDto> GetByIdTemplateAsync(int templateDtoId)
        {
			Template template = await _templateService.GetByIdTemplateAsync(templateDtoId);

			TemplateDto templateDto = TemplateFactory.MakeTemplateToTemplateDto(template);

            return templateDto;
        }

        public async Task<TemplateDto> InsertTemplateAsync(TemplateDto templateDto)
        {
			var template = TemplateFactory.MakeTemplateDtoToTemplate(templateDto);

            await _templateService.InsertTemplateAsync(template);

			templateDto = TemplateFactory.MakeTemplateToTemplateDto(template);

            return templateDto;
        }

        public async Task<TemplateDto> UpdateTemplateAsync(int templateId, TemplateDto templateDto)
        {
			var template = TemplateFactory.MakeTemplateDtoToTemplate(templateDto);

			await _templateService.UpdateTemplateAsync(templateId, template);

            templateDto = TemplateFactory.MakeTemplateToTemplateDto(template);

			return templateDto;
        }


        public async Task<bool> DeleteTemplateAsync(int templateDtoId)
        {
            return await _templateService.DeleteTemplateAsync(templateDtoId);
        }
    }
}

