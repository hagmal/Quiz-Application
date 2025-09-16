using System.Collections.Generic;

namespace QuizMvc.ViewModels
{
    // Ett spørsmål i en quiz som vises for brukeren
    // A question in a quiz that is shown to the user
    public class QuestionVm
    {
        public int Id { get; set; } // Unik ID for spørsmålet
        public string Text { get; set; } = ""; //Spørsmåls-tekst
        public int Points { get; set; } = 1; // Poeng for riktig svar
        public List<OptionVm> Options { get; set; } = new(); // Mulige svar
    }
}