using System;

namespace Facilitat.CRUD.Domain.Aggregates.Appointment.Entities
{
    public class Appointment
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
