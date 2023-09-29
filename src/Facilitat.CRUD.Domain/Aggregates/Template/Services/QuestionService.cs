using System.Threading.Tasks;
using Facilitat.CRUD.Domain.Aggregates.Template.Entities;
using Facilitat.CRUD.Domain.Aggregates.Template.Interfaces.Repository;
using Facilitat.CRUD.Domain.Aggregates.Template.Interfaces.Services;

namespace Facilitat.CRUD.Domain.Aggregates.Template.Services
{
    public class QuestionService : IQuestionService
	{
		private readonly IQuestionRepository _questionRepository;

        public QuestionService(IQuestionRepository questionRepository)
        {
            _questionRepository = questionRepository;
        }

        public async Task<Question> GetQuestionsToFormByIdAsync(int templateId)
        {
            return await _questionRepository.GetQuestionsToFormByIdAsync(templateId);
        }
    }
}

