using Facilitat.CRUD.Application.Dtos;
using Facilitat.CRUD.Domain.Aggregates.Template.Entities;

namespace Facilitat.CRUD.Application.Sharing.Factories
{
    public static class TemplateFactory
	{
        public static Template TemplateDtoToTemplate(TemplateDto templateDto)
        {
            Template template = new Template()
            {
                Id = templateDto.Id,
                Name = templateDto.Name,
                Question = new Question()
                {
                    template_id = templateDto.Id,
                    question_one = templateDto.QuestionDto.question_one,
                    question_two = templateDto.QuestionDto.question_two
                },
                question_id = templateDto.question_id
            };

            return template;
        }

        public static TemplateDto TemplateToTemplateDto(Template template)
        {
            TemplateDto templateDto = new TemplateDto()
            {
                Id = template.Id,
                Name = template.Name,
                QuestionDto = new QuestionDto()
                {
                    template_id = template.Id,
                    question_one = template.Question.question_one,
                    question_two = template.Question.question_two
                },
                question_id = template.question_id
            };

            return templateDto;
        }
    }
}

