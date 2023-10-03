using System.Collections.Generic;
using System.Threading.Tasks;

namespace Facilitat.CRUD.Domain.Aggregates.Template.Interfaces.Services
{
    public interface ITemplateService
	{
        Task<IEnumerable<Entities.Template>> GetAllTemplatesAsync();
        Task<Entities.Template> GetByIdTemplateAsync(int templateId);
        Task<Entities.Template> GetByNameTemplateAsync(string templateName);
        Task<Entities.Template> InsertTemplateAsync(Entities.Template template);
        Task<Entities.Template> UpdateTemplateAsync(int templateId, Entities.Template template);
        Task<bool> DeleteTemplateAsync(int templateId);
    }
}

