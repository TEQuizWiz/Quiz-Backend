using NuGet.Packaging.Signing;

namespace Quiz.Entities
{
    public class Question
    {
        public string id { get; set; }
        public string QuestionText { get; set; }
        public Dictionary<string, bool> answers { get; set; }
        public int Timer { get; set; }
        public Timestamp FinalQuestionTime { get; set; }
        public MediaFile mediaFile { get; set; }
    }
}