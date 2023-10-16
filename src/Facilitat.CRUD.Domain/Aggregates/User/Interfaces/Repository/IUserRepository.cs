using System.Collections.Generic;
using System.Threading.Tasks;

namespace Facilitat.CRUD.Domain.Aggregates.User.Interfaces.Repository
{
    public interface IUserRepository
    {
        Task<Entities.User> CreateUser(Entities.User user);
        Task<IEnumerable<Entities.User>> GetAllUsersAsync();
    }
}
