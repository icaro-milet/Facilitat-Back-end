using System.Text.Json.Serialization;

namespace Facilitat.CRUD.Domain.Aggregates.Template.Entities
{
    public class Question
	{
        public Question() { }

        public Question(
            int id,
            int template_id,
            int question_one_id,
            string question_one,
            int question_two_id,
            string question_two)
        {
            this.id = id;
            this.template_id = template_id;
            this.question_one_id = question_one_id;
            this.question_one = question_one;
            this.question_two_id = question_two_id;
            this.question_two = question_two;
        }

        public int id { get; set; }

        public int template_id { get; set; }

        public int question_one_id { get; set; }

        public string question_one { get; set; }

        public int question_two_id { get; set; }

        public string question_two { get; set; }
    }
}

