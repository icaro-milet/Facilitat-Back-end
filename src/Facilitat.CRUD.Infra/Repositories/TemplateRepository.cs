using Dapper;
using Facilitat.CRUD.Domain.Aggregates.Template.Entities;
using Facilitat.CRUD.Domain.Aggregates.Template.Interfaces.Repository;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Facilitat.CRUD.Infra.Repositories
{
    public class TemplateRepository : ITemplateRepository
    {
        private readonly IDbConnection _dbConnection;

        public TemplateRepository(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public async Task<IEnumerable<Template>> GetAllAsync()
        {
            List<Template> templates = new List<Template>();
            templates = _dbConnection.Query<Template>("SELECT * FROM Templates").ToList();

            _dbConnection.Close();

            return templates;
        }

        public async Task<Template> GetByIdTemplateAsync(int templateId)
        {
            var template = _dbConnection.Query<Template>(
                $"SELECT * FROM templates WHERE id = {templateId}").FirstOrDefault();

            var questions = _dbConnection.QueryAsync<Question>(
                $"SELECT * \n" +
                $"FROM Questions \n" +
                $"WHERE TemplateId = {template.Id}").Result.AsList();

            template.Questions = questions;

            _dbConnection.Close();
            return template;
        }

        public async Task<Template> InsertTemplateAsync(Template template)
        {
            var query = _dbConnection.Query<Template>("INSERT INTO templates (Name, Description) " +
                $"VALUES ('{template.Name}', '{template.Description}')");

            var templateId = _dbConnection.Query<int>(
                $"SELECT id FROM templates ORDER BY id DESC").FirstOrDefault();

            foreach (var question in template.Questions)
            {
                _dbConnection.Query<Question>("INSERT INTO Questions \n" +
                    "(TemplateId, QuestionText) \n" +
                    $"VALUES \n" +
                    $"({templateId}, '{question.QuestionText}')");
            }

            _dbConnection.Close();

            return template;
        }

        public async Task<Template> UpdateTemplateAsync(int templateId, Template template)
        {
            var query = _dbConnection.Execute("UPDATE templates " +
                $"SET name = '{template.Name}' WHERE id = {templateId}");

            _dbConnection.Close();
            return template;
        }

        public async Task<bool> DeleteTemplateAsync(int templateId)
        {
            var query = _dbConnection.Execute("DELETE FROM templates " +
                $"WHERE id = {templateId}");

            _dbConnection.Close();
            return true;
        }

        public async Task<Template> GetByNameTemplateAsync(string templateName)
        {
            var template = _dbConnection.QueryAsync<Template>(
                    $"SELECT * \n" +
                    $"FROM Templates \n" +
                    $"WHERE Name = '{templateName}'").Result.FirstOrDefault();

            var questions = _dbConnection.QueryAsync<Question>(
                    $"SELECT * \n" +
                    $"FROM Questions \n" +
                    $"WHERE TemplateId = {template.Id}").Result.AsList();

            template.Questions = questions;

            _dbConnection.Close();
            return template;
        }
    }
}

