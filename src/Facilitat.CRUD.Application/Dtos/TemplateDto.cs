using System;
using Facilitat.CRUD.Domain.Aggregates.Template.Entities;

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

        public static Template ToTemplate (TemplateDto templateDto)
        {
            return new Template()
            {
                Id = templateDto.Id,
                Username = templateDto.Username,
                Email = templateDto.Email
            };
        }

        public static TemplateDto ToTemplateDto(Template template)
        {
            return new TemplateDto
            {
                Id = template.Id,
                Username = template.Username,
                Email = template.Email
            };
        }
    }
}

