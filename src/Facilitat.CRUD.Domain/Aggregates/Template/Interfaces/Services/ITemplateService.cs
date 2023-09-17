using System.Collections.Generic;
using System.Threading.Tasks;

namespace Facilitat.CRUD.Domain.Aggregates.Template.Interfaces.Services
{
    public interface ITemplateService
	{
        Task<IEnumerable<Entities.Template>> GetAllTemplatesAsync();
    }
}

