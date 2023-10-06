using Facilitat.CRUD.Application.Dtos;
using Facilitat.CRUD.Domain.Aggregates.Answer.Entities;

namespace Facilitat.CRUD.Application.Sharing.Factories
{
    public static class AnswerFactory
	{
		public static AnswerDto AnswerToAnswerDto(Answer answer)
        {
            return new AnswerDto()
            {
                Id = answer.Id,
                AnswerText = answer.AnswerText, 
                QuestionId = answer.QuestionId,
                ServiceOrderId = answer.ServiceOrderId,
            };
        }

        public static Answer AnswerDtoToAnswer(AnswerDto answerDto)
        {
            return new Answer()
            {
                Id = answerDto.Id,
                AnswerText = answerDto.AnswerText,
                QuestionId = answerDto.QuestionId,
                ServiceOrderId = answerDto.ServiceOrderId,  
            };
        }
    }
}

