using System.Threading.Tasks;

namespace Facilitat.CRUD.Domain.Aggregates.Appointment.Interfaces.Services
{
    public interface IAppointmentService
    {
        Task<int> CreateAppointmentAsync(Entities.Appointment appointmentDto);
    }
}
