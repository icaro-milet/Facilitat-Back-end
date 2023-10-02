using System.Text.Json.Serialization;

namespace Facilitat.CRUD.Domain.Aggregates.ServiceOrder.Entities
{
    public class ServiceOrder
	{
		public ServiceOrder() { }

        [JsonIgnore]
        public int id { get; set; }

        public string service_order_name { get; set; }

        public string description { get; set; }
    }
}

