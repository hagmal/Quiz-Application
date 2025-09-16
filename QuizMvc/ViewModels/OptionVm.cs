namespace QuizMvc.ViewModels
{
    // Reperesenterer ett svaralternativ i et spørsmål
    // Represents one answer option in a question
    public class OptionVm
    {
        public int Id { get; set; } // Unik ID for svaralternativet
        public string Text { get; set; } = ""; // Teksten brukeren ser
        public bool IsCorrect { get; set; } // Bruker kun til scoring på server (vises ikke i UI)
    }
}