using System.Text.Json.Serialization;

namespace Facilitat.CRUD.Domain.Aggregates.Template.Entities
{
    public class Template
    {
        [JsonIgnore]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}

