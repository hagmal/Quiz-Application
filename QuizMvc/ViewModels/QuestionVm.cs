using System.Collections.Generic;

namespace QuizMvc.ViewModels
{
    // Ett spørsmål i en quiz som vises for brukeren
    // A question in a quiz that is shown to the user
    public class QuestionVm
    {
        public int Id { get; set; }
        public string Text { get; set; } = "";
        public int Points { get; set; } = 1;
        
        // Mulige svar
        // Possible answers
        public List<OptionVm> Options { get; set; } = new();
    }
}