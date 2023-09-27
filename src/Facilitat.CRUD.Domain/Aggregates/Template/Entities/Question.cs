using System.Text.Json.Serialization;

namespace Facilitat.CRUD.Domain.Aggregates.Template.Entities
{
    public class Question
	{
        public Question(
            int id,
            int templateId,
            int questionOneId,
            string questionOne,
            int questionTwoId,
            string questionTwo)
        {
            Id = id;
            TemplateId = templateId;
            QuestionOneId = questionOneId;
            QuestionOne = questionOne;
            QuestionTwoId = questionTwoId;
            QuestionTwo = questionTwo;
        }

        public Question() { }

        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("template_id")]
        public int TemplateId { get; set; }

        [JsonPropertyName("question_one_id")]
        public int QuestionOneId { get; set; }

        [JsonPropertyName("question_one")]
        public string QuestionOne { get; set; }

        [JsonPropertyName("question_two_id")]
        public int QuestionTwoId { get; set; }

        [JsonPropertyName("question_two")]
        public string QuestionTwo { get; set; }
    }
}

