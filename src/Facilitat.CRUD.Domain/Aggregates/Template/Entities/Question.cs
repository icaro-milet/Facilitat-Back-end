using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Facilitat.CRUD.Domain.Aggregates.Template.Entities
{
    public class Question
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Templates")]
        public int TemplateId { get; set; }
        public string QuestionText { get; set; }
    }
}

