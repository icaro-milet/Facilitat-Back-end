using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Facilitat.CRUD.Domain.Aggregates.Template.Entities;
using Facilitat.CRUD.Domain.Aggregates.Template.Interfaces.Repository;
using Npgsql;

namespace Facilitat.CRUD.Infra.Repositories
{
    public class QuestionRepository : IQuestionRepository
    {
        public QuestionRepository() { }

        public async Task<Question> GetQuestionsToFormByIdAsync(int templateId)
        {
            using (var connection =
                    new NpgsqlConnection("User ID=user;Password=pass;Host=localhost;Port=5432;Database=poc-crud;"))
            {
                var question = connection.QueryAsync<Question>("SELECT * FROM questions q \n" +
                    "INNER JOIN templates t \n" +
                    $"ON q.template_id = t.id \n" +
                    $"WHERE q.template_id = {templateId}").Result.FirstOrDefault();

                await connection.CloseAsync();

                return  question;
            }
        }
    }
}

