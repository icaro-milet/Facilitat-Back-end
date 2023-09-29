using System.Threading.Tasks;
using Facilitat.CRUD.Application.Dtos;
using Facilitat.CRUD.Application.Interfaces.Services;
using Facilitat.CRUD.Application.Sharing.Factories;
using Facilitat.CRUD.Domain.Aggregates.Template.Interfaces.Services;

namespace Facilitat.CRUD.Application.AppServices
{
    public class QuestionAppService : IQuestionAppService
	{
		private readonly IQuestionService _questionService;

        public QuestionAppService(IQuestionService questionService)
        {
            _questionService = questionService;
        }

        public async Task<QuestionDto> GetQuestionsToFormByIdAsync(int templateId)
        {
            var question = await _questionService.GetQuestionsToFormByIdAsync(templateId);

            var questionDto = QuestionFactory.QuestionToQuestionDto(question);

            return questionDto;

        }
    }
}

