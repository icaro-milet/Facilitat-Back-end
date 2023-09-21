using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Facilitat.CRUD.Application.Dtos
{
    public class ServiceOrderDto
	{
        public ServiceOrderDto(int id, int templateId, int code, string description)
        {
            Id = id;
            template_id = templateId;
            Code = code;
            Description = description;
        }

        public ServiceOrderDto() { }

        [JsonIgnore]
        public int Id { get; set; }

        public int template_id { get; set; }

        public int Code { get; set; }

        public string Description { get; set; }
    }
}

