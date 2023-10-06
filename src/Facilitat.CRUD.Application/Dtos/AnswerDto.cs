namespace Facilitat.CRUD.Application.Dtos
{
    public class AnswerDto
	{
        public int Id { get; set; }

        public int QuestionId { get; set; }

        public int ServiceOrderId { get; set; }

		public string AnswerText { get; set; }
	}
}

