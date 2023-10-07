using Facilitat.CRUD.Application.Dtos;
using Facilitat.CRUD.Domain.Aggregates.Template.Entities;
using System.Collections.Generic;

namespace Facilitat.CRUD.Application.Sharing.Factories
{
    public static class QuestionFactory
    {
        public static List<QuestionDto> QuestionToQuestionDto(List<Question> questions)
        {
            var questionsDto = new List<QuestionDto>();

            foreach (var questionsItem in questions)
            {
                questionsDto.Add(new QuestionDto()
                {
                        Id = questionsItem.Id,
                        QuestionText = questionsItem.QuestionText,
                        TemplateId = questionsItem.TemplateId,
                    
                });
            }

            return questionsDto;
        }

        public static List<Question> QuestionDtoToQuestion(List<QuestionDto> questionsDto)
        {
            var questions = new List<Question>();

            foreach (var questionsItem in questionsDto)
            {
                questions.Add(new Question()
                {
                        Id = questionsItem.Id,
                        QuestionText = questionsItem.QuestionText,
                      
                });
            }

            return questions;
        }
    }
}

