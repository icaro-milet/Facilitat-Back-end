using System;
using System.Text.Json.Serialization;

namespace Facilitat.CRUD.Application.Dtos
{
    public class UserDto
    {
        [JsonIgnore]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime Birthday { get; set; }

    }
}
