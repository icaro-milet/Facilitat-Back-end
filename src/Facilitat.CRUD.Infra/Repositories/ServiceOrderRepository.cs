using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Facilitat.CRUD.Domain.Aggregates.ServiceOrder.Entities;
using Facilitat.CRUD.Domain.Aggregates.ServiceOrder.Interfaces.Repository;
using Npgsql;

namespace Facilitat.CRUD.Infra.Repositories
{
    public class ServiceOrderRepository : IServiceOrderRepository
	{
		public ServiceOrderRepository() { }

        public async Task<ServiceOrder> CreateServiceOrder(ServiceOrder serviceOrder)
        {
            using (var connection =
                    new NpgsqlConnection("User ID=user;Password=pass;Host=localhost;Port=5432;Database=poc-crud;"))
            {
                var query = await connection.ExecuteAsync("INSERT INTO service_orders\n" +
                    $"(service_order_name, description)\n" +
                    $"VALUES \n" +
                    $"('{serviceOrder.service_order_name}','{serviceOrder.description}')");

                await connection.CloseAsync();

                return serviceOrder;
            }
        }

        public async Task<IEnumerable<ServiceOrder>> GetAllServiceOrders()
        {
            using (var connection =
                    new NpgsqlConnection("User ID=user;Password=pass;Host=localhost;Port=5432;Database=poc-crud;"))
            {
                List<ServiceOrder> serviceOrders = new List<ServiceOrder>();
                serviceOrders = connection.Query<ServiceOrder>("SELECT * FROM service_orders").ToList();

                await connection.CloseAsync();

                return serviceOrders;
            }

        }
    }
}

