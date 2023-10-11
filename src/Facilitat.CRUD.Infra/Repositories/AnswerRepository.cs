using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Facilitat.CRUD.Domain.Aggregates.Answer.Entities;
using Facilitat.CRUD.Domain.Aggregates.Answer.Interfaces.Repository;
using Facilitat.CRUD.Domain.Aggregates.Template.Entities;

namespace Facilitat.CRUD.Infra.Repositories
{
    public class AnswerRepository : IAnswerRepository
    {
        private readonly IDbConnection _dbConnection;
        public AnswerRepository(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public async Task<Answer> CreateAnswer(Answer answer)
        {
            var result = _dbConnection.Query<Template>("INSERT INTO Answers  (QuestionId, ServiceOrderId, AnswerText) \n" +
                    $"VALUES ({answer.QuestionId}, {answer.ServiceOrderId}, '{answer.AnswerText}')");

            _dbConnection.Close();
            return answer;
        }

        public async Task<IEnumerable<Answer>> GetAllAnswersByTemplateId(int templateId)
        {
                var answers = _dbConnection.QueryAsync<Answer>("SELECT a.AnswerText, q.Id " +
                    "FROM Answers a " +
                    $"INNER JOIN Questions q " +
                    $"ON q.Id = a.QuestionId " +
                    $"INNER JOIN Templates t " +
                    $"ON q.TemplateId = t.Id " +
                    $"WHERE t.Id = {templateId} " +
                    $"ORDER BY q.Id ASC").Result.ToList();

                _dbConnection.Close();

                return answers;
        }
    }
}

