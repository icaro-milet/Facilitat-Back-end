namespace Facilitat.CRUD.Domain.Aggregates.Template.Entities
{
    public class Template
    {
        public Template(
            int id,
            string name,
            Question question)
        {
            Id = id;
            Name = name;
            Question = question;
        }

        public Template() { }

        public int Id { get; set; }

        public string Name { get; set; }

        public int question_id { get; set; }

        public Question Question { get; set; }
    }
}

