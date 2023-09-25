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
    }
}

