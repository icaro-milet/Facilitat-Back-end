using System.Threading.Tasks;
using Facilitat.CRUD.Application.Dtos;
using Facilitat.CRUD.Application.Interfaces.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Facilitat.CRUD.API.Controllers
{
    [Controller]
    [Route("[controller]/")]
    public class QuestionController : Controller
    {
        private readonly IQuestionAppService _questionAppService;

        public QuestionController(IQuestionAppService questionAppService)
        {
            _questionAppService = questionAppService;
        }

        [HttpGet("GetQuestionsToFormById")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<QuestionDto> GetQuestionsToFormByIdAsync(int templateId)
        {
            return await _questionAppService.GetQuestionsToFormByIdAsync(templateId);
        }
	}
}

