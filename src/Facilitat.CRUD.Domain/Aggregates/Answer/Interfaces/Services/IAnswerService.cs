﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace Facilitat.CRUD.Domain.Aggregates.Answer.Interfaces.Services
{
    public interface IAnswerService
	{
        Task<IEnumerable<Entities.Answer>> GetAllAnswersByTemplateId(int templateId);
        Task<Entities.Answer> CreateAnswer(Entities.Answer answer);
    }
}

