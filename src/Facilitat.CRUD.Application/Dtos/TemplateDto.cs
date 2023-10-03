using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Facilitat.CRUD.Application.Dtos
{
    public class TemplateDto
	{
        public TemplateDto() { }

        public TemplateDto(
            int id,
            string name,
            QuestionDto questionDto)
        {
            Id = id;
            Name = name;
            QuestionDto = questionDto;
        }

        [JsonIgnore]
        [JsonPropertyName("id")]
        [Column("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        [Column("name")]
        public string Name { get; set; }

        [JsonPropertyName("question_id")]
        public int question_id { get; set; }

        [JsonPropertyName("questions")]
        public QuestionDto QuestionDto { get; set; }
    }
}

