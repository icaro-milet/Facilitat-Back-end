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

        public async Task<IEnumerable<Answer>> GetAllAnswersByTemplate(string template)
        {
            using (var connection =
                    new NpgsqlConnection("User ID=user;Password=pass;Host=localhost;Port=5432;Database=poc-crud;"))
            {
                List<Answer> answers = new List<Answer>();
                answers = connection.Query<Answer>("select s.serviceordercode, q.questiontext, a.answertext " +
                    "from answers a " +
                    "inner join questions q on q.id = a.questionid " +
                    "inner join serviceorders s on s.id = a.serviceorderid ").ToList();

                await connection.CloseAsync();

                return answers;
            }
        }
    }
}

