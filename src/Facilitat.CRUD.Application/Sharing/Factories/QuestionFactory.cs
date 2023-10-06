using Facilitat.CRUD.Application.Dtos;
using Facilitat.CRUD.Domain.Aggregates.Template.Entities;

namespace Facilitat.CRUD.Application.Sharing.Factories
{
    public static class QuestionFactory
	{
		public static QuestionDto QuestionToQuestionDto(Question question)
		{
			var questionDto = new QuestionDto()
			{
				Id = question.Id,
                QuestionText = question.QuestionText,   
                TemplateId = question.TemplateId,
            };

			return questionDto;
        }

        public static Question QuestionDtoToQuestion(QuestionDto questionDto)
        {
            var question = new Question()
            {
                Id = questionDto.Id,
                QuestionText = questionDto.QuestionText,
                TemplateId = questionDto.TemplateId,
            };

            return question;
        }
    }
}

