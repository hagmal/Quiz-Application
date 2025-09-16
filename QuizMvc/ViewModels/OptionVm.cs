namespace QuizMvc.ViewModels
{
    // Reperesenterer ett svaralternativ i et spørsmål
    // Represents one answer option in a question
    public class OptionVm
    {
        public int Id { get; set; }
        public string Text { get; set; } = "";
        // Bruker kun til scoring på server (vises ikke i UI)
        // Used only for scoring on the server (do not display in the UI)
        public bool IsCorrect { get; set; } 
    }
}