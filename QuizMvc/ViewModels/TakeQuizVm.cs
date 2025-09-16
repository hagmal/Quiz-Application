using System.Collections.Generic;

namespace QuizMvc.ViewModels
{
    // Hele quizen slik "Ta quiz"-siden trenger den
    // The entire quiz as needed by the "Take quiz"-page
    public class TakeQuizVm
    {
        public int QuizId { get; set; }
        public string Title { get; set; } = "";
        public List<QuestionVm> Questions { get; set; } = new();
    }
}