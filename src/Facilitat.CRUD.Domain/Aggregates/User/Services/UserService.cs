using Facilitat.CRUD.Domain.Aggregates.User.Interfaces.Repository;
using Facilitat.CRUD.Domain.Aggregates.User.Interfaces.Services;
using System.Threading.Tasks;

namespace Facilitat.CRUD.Domain.Aggregates.User.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<Entities.User> CreateUser(Entities.User user)
        {
            return await _userRepository.CreateUser(user);
        }
    }
}
