using System.Text.Json.Serialization;

namespace Facilitat.CRUD.Application.Dtos
{
    public class QuestionDto
	{
        public int Id { get; set; }
        [JsonIgnore]
        public int TemplateId { get; set; }
        public string QuestionText { get; set; }

    }
}

