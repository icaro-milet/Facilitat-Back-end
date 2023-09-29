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
                var query = connection.Query<Template>("INSERT INTO answers  (template_id, service_order_code , username, email) \n" +
                    $"VALUES (1, 5432, '{answer.Username}', '{answer.Email}')");

                await connection.CloseAsync();
                return answer;
            }
        }

        public async Task<IEnumerable<Answer>> GetAllAnswers()
        {
            using (var connection =
                    new NpgsqlConnection("User ID=user;Password=pass;Host=localhost;Port=5432;Database=poc-crud;"))
            {
                List<Answer> answers = new List<Answer>();
                answers = connection.Query<Answer>("SELECT * \n" +
                    "FROM answers").ToList();

                await connection.CloseAsync();

                return answers;
            }
        }
    }
}

