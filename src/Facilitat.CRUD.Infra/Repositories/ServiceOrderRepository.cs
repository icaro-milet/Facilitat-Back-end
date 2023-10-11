using Dapper;
using Facilitat.CRUD.Domain.Aggregates.ServiceOrder.Entities;
using Facilitat.CRUD.Domain.Aggregates.ServiceOrder.Interfaces.Repository;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;

namespace Facilitat.CRUD.Infra.Repositories
{
    public class ServiceOrderRepository : IServiceOrderRepository
	{
        private readonly IDbConnection _dbConnection;

        public ServiceOrderRepository(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public async Task<ServiceOrder> CreateServiceOrder(ServiceOrder serviceOrder)
        {
                var query = await _dbConnection.ExecuteAsync("INSERT INTO ServiceOrders\n" +
                    $"(ServiceOrderCode, DateCreated, Status)\n" +
                    $"VALUES \n" +
                    $"('{serviceOrder.ServiceOrderCode}', '{serviceOrder.DateCreated}', '{serviceOrder.Status}')");

                 _dbConnection.Close();

                return serviceOrder;
            }
        }

        public async Task<IEnumerable<ServiceOrder>> GetAllServiceOrders()
        {
            List<ServiceOrder> serviceOrders = new List<ServiceOrder>();


            //serviceOrders = await _dbConnection.Query<SeviceOrder>("SELECT * FROM service_orders").ToList();
        

            //_dbConnection.Close();

            return serviceOrders;
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

