using System;

namespace QuizMvc.ViewModels
{
    // Slik én rad på ledertavla ser ut
    // What one row on the leaderboard looks like
    public class
    {
        public string DisplayName { get; set; } = ""; // Brukernavn/alias
        public int Score { get; set; } // poengsum
        
        public DateTime SubmittedAt { get; set; } // Tidspunkt for innsending
    }
}