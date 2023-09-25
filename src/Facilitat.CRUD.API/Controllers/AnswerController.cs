using System.Collections.Generic;
using System.Threading.Tasks;
using Facilitat.CRUD.Application.Dtos;
using Facilitat.CRUD.Application.Interfaces.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Facilitat.CRUD.API.Controllers
{
    [Controller]
    [Route("[controller]/")]
    public class AnswerController : Controller
    {
        private readonly IAnswerAppService _answerAppService;

        public AnswerController(IAnswerAppService answerAppService)
        {
            _answerAppService = answerAppService;
        }

        [HttpGet("GetAllAnswers")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IEnumerable<AnswerDto>> GetAllAnswers()
        {
            return await _answerAppService.GetAllAnswers();
        }

        [HttpPost("CreateAnswer")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<AnswerDto> CreateAnswer([FromBody] AnswerDto answerDto)
        {
            return await _answerAppService.CreateAnswer(answerDto);
        }
    }
}

