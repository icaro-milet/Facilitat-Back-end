using System.Text.Json.Serialization;

namespace Facilitat.CRUD.Application.Dtos
{
    public class TemplateDto
	{
        public TemplateDto(int id, string username, string email)
        {
            Id = id;
            Username = username;
            Email = email;
        }

        public TemplateDto() { }

        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
    }
}

