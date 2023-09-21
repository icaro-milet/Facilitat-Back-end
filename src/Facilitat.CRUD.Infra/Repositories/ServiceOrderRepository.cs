using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Facilitat.CRUD.Domain.Aggregates.Template.Entities;
using Facilitat.CRUD.Domain.Aggregates.Template.Interfaces.Repository;
using Npgsql;

namespace Facilitat.CRUD.Infra.Repositories
{
    public class ServiceOrderRepository : IServiceOrderRepository
	{
		public ServiceOrderRepository() { }

        public async Task<IEnumerable<ServiceOrder>> GetAllServiceOrders()
        {
            using (var connection =
                    new NpgsqlConnection("User ID=user;Password=pass;Host=localhost;Port=5432;Database=poc-crud;"))
            {
                List<ServiceOrder> serviceOrders = new List<ServiceOrder>();
                serviceOrders = connection.Query<ServiceOrder>("SELECT so.*\n" +
                    "FROM service_orders so\n" +
                    "INNER JOIN templates tem\n" +
                    "ON so.template_id = tem.id").ToList();

                await connection.CloseAsync();

                return serviceOrders;
            }

        }
    }
}

