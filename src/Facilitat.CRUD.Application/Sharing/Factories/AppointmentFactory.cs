using Facilitat.CRUD.Application.Dtos;
using Facilitat.CRUD.Domain.Aggregates.Appointment.Entities;

namespace Facilitat.CRUD.Application.Sharing.Factories
{
    public static class AppointmentFactory
    {
        public static Appointment AppointmentDtoToAppointment(AppointmentDto appointmentDto)
        {
            var appointment = new Appointment()
            {
                Id = appointmentDto.Id,
                UserId = appointmentDto.UserId,
                DateStart = appointmentDto.DateStart,
                DateEnd = appointmentDto.DateEnd,
                Description = appointmentDto.Description,
                Title = appointmentDto.Title
            };

            return appointment;
        }

        public static AppointmentDto AppointmentToAppointmentDto(Appointment appointment)
        {
            var appointmentDto = new AppointmentDto()
            {
                Id = appointment.Id,
                UserId = appointment.UserId,
                DateStart = appointment.DateStart,
                DateEnd = appointment.DateEnd,
                Description = appointment.Description,
                Title = appointment.Title
            };

            return appointmentDto;
        }
    }
}
