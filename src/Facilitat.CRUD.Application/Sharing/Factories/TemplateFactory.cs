using Facilitat.CRUD.Application.Dtos;
using Facilitat.CRUD.Domain.Aggregates.Template.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

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
                Description = templateDto.Description,
                Questions = templateDto.QuestionsDto.Select(q => new Question
                {
                    Id = q.Id,
                    QuestionText = q.QuestionText,
                    TemplateId = q.TemplateId,
                }).ToList()
            };

            return template;
        }

        public static TemplateDto TemplateToTemplateDto(Template template)
        {
            TemplateDto templateDto = new TemplateDto()
            {
                Id = template.Id,
                Name = template.Name,
                Description = template.Description,
                QuestionsDto = template.Questions.Select(q => new QuestionDto
                {
                    Id = q.Id,
                    QuestionText = q.QuestionText,
                    TemplateId = q.TemplateId,
                }).ToList()
            };

            return templateDto;
        }
    }
}

