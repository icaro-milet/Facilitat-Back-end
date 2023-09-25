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
        public int Id { get; set; }
        public string Name { get; set; }
    }
}

