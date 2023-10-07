using System.Collections.Generic;
using System.Threading.Tasks;

namespace Facilitat.CRUD.Domain.Aggregates.Template.Interfaces.Services
{
	public interface IQuestionService
	{
        Task<IEnumerable<Entities.Question>> GetQuestionsToFormByIdAsync(int templateId);
    }
}

