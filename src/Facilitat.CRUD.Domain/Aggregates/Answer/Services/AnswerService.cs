using System.Collections.Generic;
using System.Threading.Tasks;
using Facilitat.CRUD.Domain.Aggregates.Answer.Interfaces.Repository;
using Facilitat.CRUD.Domain.Aggregates.Answer.Interfaces.Services;

namespace Facilitat.CRUD.Domain.Aggregates.Answer.Services
{
    public class AnswerService : IAnswerService
	{
        private readonly IAnswerRepository _answerRepository;

		public AnswerService(IAnswerRepository answerRepository)
		{
            _answerRepository = answerRepository;
		}

        public async Task<Entities.Answer> CreateAnswer(Entities.Answer answer)
        {
            return await _answerRepository.CreateAnswer(answer);
        }

        public async Task<IEnumerable<Entities.Answer>> GetAllAnswers()
        {
            return await _answerRepository.GetAllAnswers();
        }
    }
}

