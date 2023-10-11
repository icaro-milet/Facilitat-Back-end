using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Facilitat.CRUD.Domain.Aggregates.Template.Entities;
using Facilitat.CRUD.Domain.Aggregates.Template.Interfaces.Repository;

namespace Facilitat.CRUD.Infra.Repositories
{
    public class QuestionRepository : IQuestionRepository
    {
        private readonly IDbConnection _dbConnection;

        public QuestionRepository(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public async Task<IEnumerable<Question>> GetQuestionsToFormByIdAsync(int templateId)
        {
            var question = _dbConnection.QueryAsync<Question>("SELECT * FROM Questions q \n" +
                    $"INNER JOIN Templates t \n" +
                    $"ON q.TemplateId = t.Id \n" +
                    $"WHERE q.TemplateId = {templateId}").Result.ToList();

            _dbConnection.Close();

            return  question;
        }
    }
}

