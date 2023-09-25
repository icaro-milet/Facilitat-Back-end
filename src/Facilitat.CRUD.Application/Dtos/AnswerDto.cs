using System;
using System.Text.Json.Serialization;

namespace Facilitat.CRUD.Application.Dtos
{
	public class AnswerDto
	{

		public AnswerDto() { }

        public AnswerDto(int id, int template_id, int service_order_code, string username, string email)
        {
            Id = id;
            this.template_id = template_id;
            this.service_order_code = service_order_code;
            Username = username;
            Email = email;
        }

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

