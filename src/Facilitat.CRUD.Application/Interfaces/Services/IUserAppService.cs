﻿using Facilitat.CRUD.Application.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Facilitat.CRUD.Application.Interfaces.Services
{
    public interface IUserAppService
    {
        Task<UserDto> CreateUser(UserDto userDto);
        Task<IEnumerable<UserDto>> GetAllUsersAsync();
    }
}