using Facilitat.CRUD.Application.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Facilitat.CRUD.Application.Interfaces.Services
{
    public interface IQuestionAppService
	{
        Task<IEnumerable<QuestionDto>> GetQuestionsToFormByIdAsync(int templateId);
    }
}

