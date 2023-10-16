using System.Collections.Generic;
using System.Threading.Tasks;

namespace Facilitat.CRUD.Domain.Aggregates.User.Interfaces.Services
{
    public interface IUserService
    {
        Task<Entities.User> CreateUser(Entities.User user);
        Task<IEnumerable<Entities.User>> GetAllUsersAsync();
    }
}
