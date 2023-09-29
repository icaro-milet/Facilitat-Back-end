using System.Threading.Tasks;

namespace Facilitat.CRUD.Domain.Aggregates.Template.Interfaces.Repository
{
    public interface IQuestionRepository
	{
        Task<Entities.Question> GetQuestionsToFormByIdAsync(int templateId);
    }
}

