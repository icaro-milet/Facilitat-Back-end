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
				TemplateId = question.TemplateId,
				QuestionOneId = question.QuestionOneId,
				QuestionOne = question.QuestionOne,
				QuestionTwoId = question.QuestionTwoId,
				QuestionTwo = question.QuestionTwo
			};

			return questionDto;
        }

        public static Question QuestionDtoToQuestion(QuestionDto questionDto)
        {
            var question = new Question()
            {
                Id = questionDto.Id,
                TemplateId = questionDto.TemplateId,
                QuestionOneId = questionDto.QuestionOneId,
                QuestionOne = questionDto.QuestionOne,
                QuestionTwoId = questionDto.QuestionTwoId,
                QuestionTwo = questionDto.QuestionTwo
            };

            return question;
        }
    }
}

