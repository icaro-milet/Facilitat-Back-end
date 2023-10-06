using System;
using System.ComponentModel.DataAnnotations;

namespace Facilitat.CRUD.Domain.Aggregates.ServiceOrder.Entities
{
    public class ServiceOrder
	{
        [Key]
        public int Id { get; set; }

        public string ServiceOrderCode { get; set; }

        public DateTime DateCreated { get; set; }

        public string Status { get; set; }
    }
}

