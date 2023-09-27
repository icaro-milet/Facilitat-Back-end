using System.Text.Json.Serialization;

namespace Facilitat.CRUD.Domain.Aggregates.Template.Entities
{
    public class Template
    {
        [JsonIgnore]
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("questions")]
        public Question Questions { get; set; }
    }
}

