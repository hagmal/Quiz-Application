using System;

namespace QuizMvc.ViewModels
{
    // Slik én rad på ledertavla ser ut
    // What one row on the leaderboard looks like
    public class
    {
        public string DisplayName { get; set; } = "";
        public int Score { get; set; }
        // Når resultatet ble postet
        // When the result was posted
        public DateTime SubmittedAt { get; set; }
    }
}