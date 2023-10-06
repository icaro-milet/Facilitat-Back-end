using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Facilitat.CRUD.Application.Dtos;
using Facilitat.CRUD.Application.Interfaces.Services;
using Facilitat.CRUD.Application.Sharing.Factories;
using Facilitat.CRUD.Domain.Aggregates.Answer.Interfaces.Services;

namespace Facilitat.CRUD.Application.AppServices
{
    public class AnswerAppService : IAnswerAppService
	{
        private readonly IAnswerService _answerService;

		public AnswerAppService(IAnswerService answerService)
        {
            _answerService = answerService;
        }

        public async Task<AnswerDto> CreateAnswer(AnswerDto answerDto)
        {
            var answer = AnswerFactory.AnswerDtoToAnswer(answerDto);

            var result = await _answerService.CreateAnswer(answer);

            answerDto = AnswerFactory.AnswerToAnswerDto(result);

            return answerDto;
        }

        public async Task<IEnumerable<AnswerDto>> GetAllAnswers()
        {
            var answers = await _answerService.GetAllAnswers();

            var answersDto = answers
                .Select(answers => new AnswerDto()
                {
                    Id = answers.Id,
                    AnswerText = answers.AnswerText,    
                    QuestionId = answers.QuestionId,
                    ServiceOrderId = answers.ServiceOrderId
                });

            return answersDto;
        }
    }
}

