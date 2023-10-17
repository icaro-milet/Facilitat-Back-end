using Facilitat.CRUD.Application.Dtos;
using Facilitat.CRUD.Domain.Aggregates.User.Entities;

namespace Facilitat.CRUD.Application.Sharing.Factories
{
    public static class UserFactory
    {
        public static User UserDtoToUser(UserDto userDto)
        {
            return new User()
            {
                Id = userDto.Id,
                FirstName = userDto.FirstName,
                LastName = userDto.LastName,
                Email = userDto.Email,
                Document = userDto.Document
            };
        }

        public static UserDto UserToUserDto(User user)
        {
            return new UserDto()
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                Document = user.Document
            };
        }
    }
}
