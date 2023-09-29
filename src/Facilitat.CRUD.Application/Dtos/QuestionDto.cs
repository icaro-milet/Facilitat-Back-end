using System.Text.Json.Serialization;

namespace Facilitat.CRUD.Application.Dtos
{
    public class QuestionDto
	{

        public QuestionDto() { }

        public QuestionDto(
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

        [JsonIgnore]
        public int id { get; set; }

        [JsonIgnore]
        public int template_id { get; set; }

        [JsonIgnore]
        public int question_one_id { get; set; }

        public string question_one { get; set; }

        [JsonIgnore]
        public int question_two_id { get; set; }

        public string question_two { get; set; }

    }
}

