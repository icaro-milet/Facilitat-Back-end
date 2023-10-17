﻿using Facilitat.CRUD.Application.Dtos;
using System.Threading.Tasks;

namespace Facilitat.CRUD.Application.Interfaces.Services
{
    public interface IAppointmentAppService
    {
        Task<int> CreateAppointmentAsync(AppointmentDto appointmentDto);
    }
}