using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Dapper;
using Facilitat.CRUD.API;
using Microsoft.Extensions.Configuration;

namespace Facilitat.CRUD.Infra
{
    public class TemplateContext
	{
		private readonly IConfiguration _config;
		private readonly string _connectionString;

		public TemplateContext(IConfiguration configuration)
		{
			_config = configuration;
			_connectionString = _config.GetConnectionString("DefaultConnection");
		}

		private IDbConnection dbConnection =>
			new SqlConnection(_connectionString);

		public IEnumerable<Template> GetTemplates()
		{
			using var connection = dbConnection;
			dbConnection.Open();
			return connection.Query<Template>("SELECT * FROM templates");
		}

	}
}

