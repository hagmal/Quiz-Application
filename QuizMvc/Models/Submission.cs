using System;

namespace QuizMvc.Models
{
    public class Submission
    {
        public int Id { get; set; }
        public int QuizId { get; set; }
        public string DisplayName { get; set; } = "";
        public int Score { get; set; }
        public DateTime SubmittedAt { get; set; }
    }
}