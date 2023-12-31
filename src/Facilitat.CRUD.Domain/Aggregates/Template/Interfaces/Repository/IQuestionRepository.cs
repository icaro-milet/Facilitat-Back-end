﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace Facilitat.CRUD.Domain.Aggregates.Template.Interfaces.Repository
{
    public interface IQuestionRepository
	{
        Task<IEnumerable<Entities.Question>> GetQuestionsToFormByIdAsync(int templateId);
    }
}

