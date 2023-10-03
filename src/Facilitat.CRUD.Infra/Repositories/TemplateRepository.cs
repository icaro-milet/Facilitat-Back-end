using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Facilitat.CRUD.Domain.Aggregates.Template.Entities;
using Facilitat.CRUD.Domain.Aggregates.Template.Interfaces.Repository;
using Microsoft.Extensions.Configuration;
using Npgsql;

namespace Facilitat.CRUD.Infra.Repositories
{
    public class TemplateRepository : ITemplateRepository
    {
        private readonly string _connectionString;
        private readonly IConfiguration _config;

        public TemplateRepository(IConfiguration configuration)
        {
            _config = configuration;
            _connectionString = _config.GetConnectionString("DefaultConnection");
        }

        public async Task<IEnumerable<Template>> GetAllAsync()
        {
            using (var connection =
                    new NpgsqlConnection("User ID=user;Password=pass;Host=localhost;Port=5432;Database=poc-crud;"))
            {
                List<Template> templates = new List<Template>();
                templates = connection.Query<Template>("SELECT * FROM templates").ToList();

                await connection.CloseAsync();

                return templates;
            }

        }

        public async Task<Template> GetByIdTemplateAsync(int templateId)
        {
            using (var connection =
                    new NpgsqlConnection("User ID=user;Password=pass;Host=localhost;Port=5432;Database=poc-crud;"))
            {
                var template = connection.Query<Template>(
                    $"SELECT * FROM templates WHERE id = {templateId}").FirstOrDefault();

                await connection.CloseAsync();
                return template;
            }
        }

        public async Task<Template> InsertTemplateAsync(Template template)
        {
            using (var connection =
                    new NpgsqlConnection("User ID=user;Password=pass;Host=localhost;Port=5432;Database=poc-crud;"))
            {
                var query = connection.Query<Template>("INSERT INTO templates (name) " +
                    $"VALUES ('{template.Name}')");

                var templateId = connection.Query<int>(
                    $"SELECT id FROM templates ORDER BY id DESC").FirstOrDefault();

                var questionsQuery = connection.Query<Question>("INSERT INTO questions \n" +
                    "(template_id, question_one, question_two) \n" +
                    $"VALUES " +
                    $"({templateId}, '{template.Question.question_one}', " +
                    $"'{template.Question.question_two}')");

                var questionId = connection.Query<int>(
                    $"SELECT id FROM questions ORDER BY id DESC").FirstOrDefault();

                var  questionIdInsert = connection.Query<Template>("UPDATE templates \n" +
                    $"SET question_id = {questionId}\n" +
                    $"WHERE id = {templateId}");

                var questionNameInsert = connection.Query<Template>("UPDATE templates \n" +
                    $"SET name = '{template.Name}'\n" +
                    $"WHERE id = {templateId}");

                await connection.CloseAsync();
                return template;
            }
        }

        public async Task<Template> UpdateTemplateAsync(int templateId, Template template)
        {
            using (var connection =
                    new NpgsqlConnection("User ID=user;Password=pass;Host=localhost;Port=5432;Database=poc-crud;"))
            {

                var query = connection.Execute("UPDATE templates " +
                    $"SET name = '{template.Name}' WHERE id = {templateId}");

                await connection.CloseAsync();
                return template;
            }
        }

        public async Task<bool> DeleteTemplateAsync(int templateId)
        {
            using (var connection =
                    new NpgsqlConnection("User ID=user;Password=pass;Host=localhost;Port=5432;Database=poc-crud;"))
            {

                var query = connection.Execute("DELETE FROM templates " +
                    $"WHERE id = {templateId}");

                await connection.CloseAsync();
                return true;
            }
        }

        public async Task<Template> GetByNameTemplateAsync(string templateName)
        {
            using (var connection =
                    new NpgsqlConnection("User ID=user;Password=pass;Host=localhost;Port=5432;Database=poc-crud;"))
            {
                var template = connection.QueryAsync<Template>(
                    $"SELECT * \n" +
                    $"FROM templates \n" +
                    $"WHERE name = '{templateName}'").Result.FirstOrDefault();

                var questions = connection.QueryAsync<Question>(
                    $"SELECT * \n" +
                    $"FROM questions \n" +
                    $"WHERE template_id = {template.Id}").Result.FirstOrDefault();

                template.Question = questions;

                await connection.CloseAsync();
                return template;
            }
        }
    }
}

