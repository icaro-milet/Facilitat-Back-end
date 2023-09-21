using System.Text.Json.Serialization;

namespace Facilitat.CRUD.Domain.Aggregates.Template.Entities
{
    public class Template
    {
        [JsonIgnore]
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
    }
}

