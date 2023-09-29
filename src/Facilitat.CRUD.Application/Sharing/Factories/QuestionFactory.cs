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
				id = question.id,
                template_id = question.template_id,
                question_one_id = question.question_one_id,
                question_one = question.question_one,
                question_two_id = question.question_two_id,
                question_two = question.question_two
            };

			return questionDto;
        }

        public static Question QuestionDtoToQuestion(QuestionDto questionDto)
        {
            var question = new Question()
            {
                id = questionDto.id,
                template_id = questionDto.template_id,
                question_one_id = questionDto.question_one_id,
                question_one = questionDto.question_one,
                question_two_id = questionDto.question_two_id,
                question_two = questionDto.question_two
            };

            return question;
        }
    }
}

