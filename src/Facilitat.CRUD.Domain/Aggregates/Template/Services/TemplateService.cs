using System.Collections.Generic;
using System.Threading.Tasks;
using Facilitat.CRUD.Domain.Aggregates.Template.Interfaces.Repository;
using Facilitat.CRUD.Domain.Aggregates.Template.Interfaces.Services;

namespace Facilitat.CRUD.Domain.Aggregates.Template.Services
{
    public class TemplateService : ITemplateService
	{
        private readonly ITemplateRepository _templateRepository;

        public TemplateService(ITemplateRepository templateRepository)
        {
            _templateRepository = templateRepository;
        }

        public async Task<IEnumerable<Entities.Template>> GetAllTemplatesAsync()
        {
            return await _templateRepository.GetAllAsync();
        }

        public async Task<Entities.Template> InsertTemplateAsync(Entities.Template template)
        {
            return await _templateRepository.InsertTemplateAsync(template);
        }
    }
}

