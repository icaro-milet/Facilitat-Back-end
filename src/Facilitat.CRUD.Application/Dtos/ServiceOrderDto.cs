using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Facilitat.CRUD.Application.Dtos
{
    public class ServiceOrderDto
	{
        

        public ServiceOrderDto() { }

        public ServiceOrderDto(
            int id,
            string service_order_name,
            string description)
        {
            this.id = id;
            this.service_order_name = service_order_name;
            this.description = description;
        }

        [JsonIgnore]
        public int id { get; set; }

        public string service_order_name { get; set; }

        public string description { get; set; }
    }
}

