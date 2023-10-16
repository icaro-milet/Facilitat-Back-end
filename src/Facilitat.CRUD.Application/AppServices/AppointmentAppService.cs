using Facilitat.CRUD.Application.Dtos;
using Facilitat.CRUD.Application.Interfaces.Services;
using Facilitat.CRUD.Application.Sharing.Factories;
using Facilitat.CRUD.Domain.Aggregates.Appointment.Interfaces.Services;
using System.Threading.Tasks;

namespace Facilitat.CRUD.Application.AppServices
{
    public class AppointmentAppService : IAppointmentAppService
    {
        private readonly IAppointmentService _appointmentService;
        public AppointmentAppService(IAppointmentService appointmentService)
        {
            _appointmentService = appointmentService;
        }

        public async Task<int> CreateAppointmentAsync(AppointmentDto appointmentDto)
        {
            var appointment = AppointmentFactory.AppointmentDtoToAppointment(appointmentDto);

            return await _appointmentService.CreateAppointmentAsync(appointment);
        }
    }
}
