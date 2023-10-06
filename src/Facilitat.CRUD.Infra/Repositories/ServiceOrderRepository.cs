using System;
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
                var query = await connection.ExecuteAsync("INSERT INTO ServiceOrders\n" +
                    $"(ServiceOrderCode, DateCreated, Status)\n" +
                    $"VALUES \n" +
                    $"('{serviceOrder.ServiceOrderCode}', '{serviceOrder.DateCreated}', '{serviceOrder.Status}')");

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

        public async Task<ServiceOrder> GetServiceOrderByCodeAsync(string serviceOrderCode)
        {
            using (var connection =
                    new NpgsqlConnection("User ID=user;Password=pass;Host=localhost;Port=5432;Database=poc-crud;"))
            {
                var serviceOrders = connection.Query<ServiceOrder>("SELECT * FROM ServiceOrders\n" +
                    $"WHERE ServiceOrderCode = '{serviceOrderCode}'").FirstOrDefault();

                await connection.CloseAsync();

                return serviceOrders;
            }
        }
    }
}

