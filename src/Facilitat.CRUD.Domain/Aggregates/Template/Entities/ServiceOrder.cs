using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Facilitat.CRUD.Domain.Aggregates.Template.Entities
{
    public class ServiceOrder
	{
        [JsonIgnore]
        public int Id { get; set; }

        public int template_id { get; set; }

        public int Code { get; set; }

        public string Description { get; set; }
    }
}

