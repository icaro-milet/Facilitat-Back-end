using System.Text.Json.Serialization;

namespace Facilitat.CRUD.Application.Dtos
{
    public class QuestionDto
	{

        public QuestionDto() { }

        public QuestionDto(int id, int templateId, int questionOneId, string questionOne, int questionTwoId, string questionTwo)
        {
            Id = id;
            TemplateId = templateId;
            QuestionOneId = questionOneId;
            QuestionOne = questionOne;
            QuestionTwoId = questionTwoId;
            QuestionTwo = questionTwo;
        }

        [JsonIgnore]
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonIgnore]
        [JsonPropertyName("template_id")]
        public int TemplateId { get; set; }

        [JsonIgnore]
        [JsonPropertyName("question_one_id")]
        public int QuestionOneId { get; set; }

        [JsonPropertyName("question_one")]
        public string QuestionOne { get; set; }

        [JsonIgnore]
        [JsonPropertyName("question_two_id")]
        public int QuestionTwoId { get; set; }

        [JsonPropertyName("question_two")]
        public string QuestionTwo { get; set; }

    }
}

