using System.Collections.Generic;
using Facilitat.CRUD.Infra;
using Microsoft.AspNetCore.Mvc;

namespace Facilitat.CRUD.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TemplateController : ControllerBase
    {
        private readonly TemplateContext _templateContext;

        public TemplateController(TemplateContext templateContext)
        {
            _templateContext = templateContext;
        }

        [HttpGet]
        public IEnumerable<Template> GetTemplates()
        {
            return new List<Template>()
            {
                
            };
        }
    }
}

