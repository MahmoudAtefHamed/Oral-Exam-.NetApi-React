namespace QuestionsApi.Models
{
    public class Question
    {
        public string? Id { get; set; }
        public string? QuestionText { get; set; }
        public List<string>? Options { get; set; }
        public string? Correct { get; set; }
    }
}
