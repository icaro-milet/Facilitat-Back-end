using System;
using System.Text.Json.Serialization;

namespace Facilitat.CRUD.Application.Dtos
{
    public class ServiceOrderDto
    {
        public int Id { get; set; }
        public string ServiceOrderCode { get; set; }
        public DateTime DateCreated { get; set; }
        public string Status { get; set; }
    }
}

