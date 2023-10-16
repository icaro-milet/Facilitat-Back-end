using Facilitat.CRUD.Domain.Aggregates.Appointment.Interfaces.Repository;
using Facilitat.CRUD.Domain.Aggregates.Appointment.Interfaces.Services;
using System.Threading.Tasks;

namespace Facilitat.CRUD.Domain.Aggregates.Appointment.Services
{
    public class AppointmentService : IAppointmentService
    {
        private readonly IAppointmentRepository _appointmentRepository;

        public AppointmentService(IAppointmentRepository appointmentRepository)
        {
            _appointmentRepository = appointmentRepository;
        }

        public Task<int> CreateAppointmentAsync(Entities.Appointment appointmentDto)
        {
            return _appointmentRepository.CreateAppointmentAsync(appointmentDto);   
        }
    }
}
