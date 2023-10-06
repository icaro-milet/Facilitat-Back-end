using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Facilitat.CRUD.Domain.Aggregates.Answer.Entities
{
    public class Answer
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Questions")]
        public int QuestionId { get; set; }

        [ForeignKey("ServiceOrders")]
        public int ServiceOrderId { get; set; }

        public string AnswerText { get; set; }
    }
}

