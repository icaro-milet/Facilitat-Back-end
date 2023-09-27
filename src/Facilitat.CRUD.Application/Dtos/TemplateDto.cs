using System.Text.Json.Serialization;

namespace Facilitat.CRUD.Application.Dtos
{
    public class TemplateDto
	{
        public TemplateDto(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public TemplateDto() { }

        [JsonIgnore]
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("questions")]
        public QuestionDto Questions { get; set; }
    }
}

