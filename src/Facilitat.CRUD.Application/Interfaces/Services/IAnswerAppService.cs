using System.Collections.Generic;
using System.Threading.Tasks;
using Facilitat.CRUD.Application.Dtos;

namespace Facilitat.CRUD.Application.Interfaces.Services
{
    public interface IAnswerAppService
	{
        Task<IEnumerable<AnswerDto>> GetAllAnswers();
        Task<AnswerDto> CreateAnswer(AnswerDto answerDto);
    }
}

