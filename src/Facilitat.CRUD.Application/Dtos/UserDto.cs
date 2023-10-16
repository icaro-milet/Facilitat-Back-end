using System;
using System.Text.Json.Serialization;

namespace Facilitat.CRUD.Application.Dtos
{
    public class UserDto
    {
        [JsonIgnore]
        [JsonPropertyName("Id")]
        public int Id { get; set; }

        [JsonPropertyName("FirstName")]
        public string FirstName { get; set; }

        [JsonPropertyName("LastName")]
        public string LastName { get; set; }

        [JsonPropertyName("Email")]
        public string Email { get; set; }

    }
}
