using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Facilitat.CRUD.Domain.Aggregates.Template.Entities
{
    public class Template
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public List<Question> Questions { get; set; }
    }
}

