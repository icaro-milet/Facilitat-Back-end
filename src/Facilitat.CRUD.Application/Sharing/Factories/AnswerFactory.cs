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
                template_id = answer.template_id,
                service_order_code = answer.service_order_code,
                Username = answer.Username,
                Email = answer.Email
            };
        }

        public static Answer AnswerDtoToAnswer(AnswerDto answerDto)
        {
            return new Answer()
            {
                Id = answerDto.Id,
                template_id = answerDto.template_id,
                service_order_code = answerDto.service_order_code,
                Username = answerDto.Username,
                Email = answerDto.Email
            };
        }
    }
}

