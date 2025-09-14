namespace QuizMvc.Models
{
    public class Question
    {
        public int QuestionId { get; set; }
        public string Text { get; set; } = string.Empty;
        public int Points { get; set; }

        public int QuizId { get; set; }

        // Nullable for å slippe EF warnings
        public Quiz? Quiz { get; set; }
    }
}
