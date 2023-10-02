using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Facilitat.CRUD.Application.Dtos
{
    public class ServiceOrderDto
	{
        public ServiceOrderDto(int id, string name, string description)
        {
            this.id = id;
            this.name = name;
            this.description = description;
        }

        public ServiceOrderDto() { }

        [JsonIgnore]
        public int id { get; set; }

        public string name { get; set; }

        public string description { get; set; }
    }
}

