using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Facilitat.CRUD.Domain.Aggregates.Answer.Entities;
using Facilitat.CRUD.Domain.Aggregates.Answer.Interfaces.Repository;
using Facilitat.CRUD.Domain.Aggregates.Template.Entities;
using Npgsql;

namespace Facilitat.CRUD.Infra.Repositories
{
    public class AnswerRepository : IAnswerRepository
    {
		public AnswerRepository() { }

        public async Task<Answer> CreateAnswer(Answer answer)
        {
            using (var connection =
                    new NpgsqlConnection("User ID=user;Password=pass;Host=localhost;Port=5432;Database=poc-crud;"))
            {
                var query = connection.Query<Template>("INSERT INTO Answers  (QuestionId, ServiceOrderId, AnswerText) \n" +
                    $"VALUES ({answer.QuestionId}, {answer.ServiceOrderId}, '{answer.AnswerText}')");

                await connection.CloseAsync();
                return answer;
            }
        }

        public async Task<IEnumerable<Answer>> GetAllAnswersByTemplateId(int templateId)
        {
            using (var connection =
                    new NpgsqlConnection("User ID=user;Password=pass;Host=localhost;Port=5432;Database=poc-crud;"))
            {
                var answers = connection.QueryAsync<Answer>("SELECT a.AnswerText, q.Id " +
                    "FROM Answers a " +
                    $"INNER JOIN Questions q " +
                    $"ON q.Id = a.QuestionId " +
                    $"INNER JOIN Templates t " +
                    $"ON q.TemplateId = t.Id " +
                    $"WHERE t.Id = {templateId} " +
                    $"ORDER BY q.Id ASC").Result.ToList();

                await connection.CloseAsync();

                return answers;
            }
        }
    }
}

