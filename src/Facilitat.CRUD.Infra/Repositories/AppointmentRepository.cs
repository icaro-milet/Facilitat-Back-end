using Dapper;
using Facilitat.CRUD.Domain.Aggregates.Appointment.Entities;
using Facilitat.CRUD.Domain.Aggregates.Appointment.Interfaces.Repository;
using System.Data;
using System.Threading.Tasks;

namespace Facilitat.CRUD.Infra.Repositories
{
    public class AppointmentRepository : IAppointmentRepository
    {
        private readonly IDbConnection _dbConnection;
        public AppointmentRepository(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public async Task<int> CreateAppointmentAsync(Appointment appointmentDto)
        {
            var sql = $@"INSERT INTO Appointments 
                         (UserId, DateStart, DateEnd, Title, Description)
                         VALUES
                         (@userId, @dateStart, @dateEnd, @title, @description)";

            return await _dbConnection.ExecuteAsync(
            sql,
                new
                {
                    userId = appointmentDto.UserId,
                    dateStart = appointmentDto.DateStart,
                    dateEnd = appointmentDto.DateEnd,
                    title = appointmentDto.Title,
                    description = appointmentDto.Description
                });
        }
    }
}
