using System;
using System.Text.Json.Serialization;

namespace Facilitat.CRUD.Application.Dtos
{
    public class AppointmentDto
    {
        [JsonIgnore]
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public string Title { get; set; }
    }
}
