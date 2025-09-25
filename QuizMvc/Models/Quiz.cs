namespace QuizMvc.Models
{
    public class Quiz
    {
        public int Id { get; set; }  // Unique identifier

        public string Title { get; set; } = string.Empty;  // Quiz title

        public string? Description { get; set; }  // Optional description
    }
}
