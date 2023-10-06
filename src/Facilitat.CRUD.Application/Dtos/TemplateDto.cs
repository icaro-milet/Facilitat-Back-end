using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Facilitat.CRUD.Application.Dtos
{
    public class TemplateDto
    {
        [JsonIgnore]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        [JsonPropertyName("Questions")]
        public List<QuestionDto> QuestionsDto { get; set; }
    }
}

