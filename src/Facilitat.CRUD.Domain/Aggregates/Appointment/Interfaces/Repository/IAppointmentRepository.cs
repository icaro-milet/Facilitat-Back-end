using System.Threading.Tasks;

namespace Facilitat.CRUD.Domain.Aggregates.Appointment.Interfaces.Repository
{
    public interface IAppointmentRepository
    {
        Task<int> CreateAppointmentAsync(Entities.Appointment appointmentDto);
    }
}
