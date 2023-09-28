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
                Name = templateDto.Name,
                Question = new Question()
                {
                    TemplateId = templateDto.Id,
                    QuestionOne = templateDto.QuestionDto.QuestionOne,
                    QuestionTwo = templateDto.QuestionDto.QuestionTwo
                }
            };

            return template;
        }

        public static TemplateDto MakeTemplateToTemplateDto(Template template)
        {
            TemplateDto templateDto = new TemplateDto()
            {
                Id = template.Id,
                Name = template.Name,
                QuestionDto = new QuestionDto()
                {
                    TemplateId = template.Id,
                    QuestionOne = template.Question.QuestionOne,
                    QuestionTwo = template.Question.QuestionTwo
                }
            };

            return templateDto;
        }
    }
}

