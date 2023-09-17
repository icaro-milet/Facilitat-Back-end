using System.Collections.Generic;
using System.Threading.Tasks;

namespace Facilitat.CRUD.Domain.Aggregates.Template.Interfaces.Repository
{
    public interface ITemplateRepository
	{
        Task<IEnumerable<Entities.Template>> GetAllAsync();
    }
}

