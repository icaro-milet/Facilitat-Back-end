using Dapper;
using Facilitat.CRUD.Domain.Aggregates.User.Entities;
using Facilitat.CRUD.Domain.Aggregates.User.Interfaces.Repository;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Facilitat.CRUD.Infra.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly IDbConnection _dbConnection;
        public UserRepository(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }
        public async Task<User> CreateUser(User user)
        {
            return _dbConnection.Query<User>("INSERT INTO Users (FirstName, LastName, Email, Document) \n" +
                $"VALUES ('{user.FirstName}', '{user.LastName}', '{user.Email}', '{user.Document}')").AsList<User>().FirstOrDefault();
        }

        public async Task<IEnumerable<User>> GetAllUsersAsync()
        {
            var users = _dbConnection.QueryAsync<User>("SELECT * FROM Users").Result.ToList();

            _dbConnection.Close();

            return users;
        }
    }
}
