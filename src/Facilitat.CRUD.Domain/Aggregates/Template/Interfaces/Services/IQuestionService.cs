using System.Threading.Tasks;

namespace Facilitat.CRUD.Domain.Aggregates.Template.Interfaces.Services
{
	public interface IQuestionService
	{
        Task<Entities.Question> GetQuestionsToFormByIdAsync(int templateId);
    }
}

