using System.Collections.Generic;
using System.Threading.Tasks;

namespace Facilitat.CRUD.Domain.Aggregates.Answer.Interfaces.Repository
{
    public interface IAnswerRepository
	{
        Task<IEnumerable<Entities.Answer>> GetAllAnswers();
        Task<Entities.Answer> CreateAnswer(Entities.Answer answer);
    }
}

