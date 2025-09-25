using System;
namespace QuizMvc.Models
{
    public class Quiz
    {
        public int QuizId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    

        public List<Question> Questions { get; set; } = new();
    


        public int Id { get; set; }  // Unique identifier

        public string Title { get; set; } = string.Empty;  // Quiz title

        public string? Description { get; set; }  // Optional description
    }
}
