using Facilitat.CRUD.Application.Dtos;
using Facilitat.CRUD.Domain.Aggregates.Template.Entities;

namespace Facilitat.CRUD.Application.Sharing.Factories
{
    public static class TemplateFactory
	{
		public static Template MakeTemplateDtoToTemplate(TemplateDto templateDto)
		{
            Template template = new Template()
            {
                Id = templateDto.Id,
                Username = templateDto.Username,
                Email = templateDto.Email
            };

            return template;
        }

        public static TemplateDto MakeTemplateToTemplateDto(Template template)
        {
            TemplateDto templateDto = new TemplateDto()
            {
                Id = template.Id,
                Username = template.Username,
                Email = template.Email
            };

            return templateDto;
        }
    }
}

