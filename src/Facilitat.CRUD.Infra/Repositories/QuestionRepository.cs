using System.Collections.Generic;
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

        public async Task<IEnumerable<Question>> GetQuestionsToFormByIdAsync(int templateId)
        {
            using (var connection =
                    new NpgsqlConnection("User ID=user;Password=pass;Host=localhost;Port=5432;Database=poc-crud;"))
            {
                var question = connection.QueryAsync<Question>("SELECT * FROM Questions q \n" +
                    "INNER JOIN Templates t \n" +
                    $"ON q.TemplateId = t.Id \n" +
                    $"WHERE q.TemplateId = {templateId}").Result.ToList();

                await connection.CloseAsync();

                return  question;
            }
        }
    }
}

