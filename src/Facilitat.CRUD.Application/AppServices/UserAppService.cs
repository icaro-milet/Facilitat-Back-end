using Facilitat.CRUD.Application.Dtos;
using Facilitat.CRUD.Application.Interfaces.Services;
using Facilitat.CRUD.Application.Sharing.Factories;
using Facilitat.CRUD.Domain.Aggregates.User.Interfaces.Services;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Facilitat.CRUD.Application.AppServices
{
    public class UserAppService : IUserAppService
    {
        private readonly IUserService _userService;

        public UserAppService(IUserService userService)
        {
            _userService = userService;
        }

        public async Task<UserDto> CreateUser(UserDto userDto)
        {
            var user = UserFactory.UserDtoToUser(userDto);

            await _userService.CreateUser(user);

            userDto = UserFactory.UserToUserDto(user);

            return userDto;
        }

        public async Task<IEnumerable<UserDto>> GetAllUsersAsync()
        {
            var user = await _userService.GetAllUsersAsync();

            var usersDto = user
                .Select(user => new UserDto()
                {
                    Id = user.Id,
                    Email = user.Email,
                    FirstName = user.FirstName,
                    LastName = user.LastName
                });

            return usersDto;
        }
    }
}
