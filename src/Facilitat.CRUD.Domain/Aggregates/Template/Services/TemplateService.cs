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

        public async Task<Entities.Template> GetByIdTemplateAsync(int templateId)
        {
            return await _templateRepository.GetByIdTemplateAsync(templateId);
        }

        public async Task<Entities.Template> InsertTemplateAsync(Entities.Template template)
        {
            return await _templateRepository.InsertTemplateAsync(template);
        }

        public async Task<Entities.Template> UpdateTemplateAsync(int templateId, Entities.Template template)
        {
            var item = _templateRepository.GetByIdTemplateAsync(templateId);

            if (item != null)
            {
                var updatedTemplate = new Entities.Template()
                {
                    Username = template.Username,
                    Email = template.Email
                };

                return await _templateRepository.UpdateTemplateAsync(templateId, updatedTemplate);
            }

            return await item;
        }

        public async Task<bool> DeleteTemplateAsync(int templateId)
        {
            var entity = await _templateRepository.GetByIdTemplateAsync(templateId);

            if (entity == null)
                return false;

            await _templateRepository.DeleteTemplateAsync(templateId);
            return true;

        }
    }
}

