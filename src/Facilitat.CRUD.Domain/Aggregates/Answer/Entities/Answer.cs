using System.Text.Json.Serialization;

namespace Facilitat.CRUD.Domain.Aggregates.Answer.Entities
{
    public class Answer
	{
		public Answer() { }

        [JsonIgnore]
        public int Id { get; set; }

        [JsonIgnore]
        public int template_id { get; set; }

        [JsonIgnore]
        public int service_order_code { get; set; }

        public string Username { get; set; }

        public string Email { get; set; }
    }
}

