using System.Collections.Generic;
using System.Threading.Tasks;

namespace Facilitat.CRUD.Domain.Aggregates.Template.Interfaces.Repository
{
    public interface ITemplateRepository
	{
        Task<IEnumerable<Entities.Template>> GetAllAsync();
        Task<Entities.Template> GetByIdTemplateAsync(int templateId);
        Task<Entities.Template> InsertTemplateAsync(Entities.Template template);
        Task<Entities.Template> UpdateTemplateAsync(int templateId, Entities.Template template);
        Task<bool> DeleteTemplateAsync(int templateId);
    }
}

