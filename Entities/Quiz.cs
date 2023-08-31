namespace Quiz.Entities
{
    public class Quiz
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Owner { get; set; }
        public bool isPrivate { get; set; }
        public List<Question> Questions { get; set; }
    }
}
