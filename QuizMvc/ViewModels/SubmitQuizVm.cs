using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace QuizMvc.ViewModels
{
    // Pakken som POST-es fra skjemaet når brukeren sender inn svarene sine
    // The package that is POSTed from the form when the user submits their answers
    public class SubmitQuizVm
    {
        [Required] public int QuizId { get; set; }

        // Vises i skjemaet - vi lagrer navnet på "scoreboardet"
        // Shown in the form - we store the name on the "scoreboard"
        [Required, MinLength(2), MaxLength(20)] public string DisplayName { get; set; } = "";

        // Valgte svar fra skjemaet: QuestionId -> OptionId
        // (HTML-navn "Answers[<QuestionId>]" binder automatisk til denne dictionary'en)
        // Selected answers from the form: QuestionId -> OptionId
        // (HTML name "Answers[<QuestionId>]" automatically binds to this dictionary)
        [Required] public Dictionary<int, int> Answers { get; set; } = new();
    }
}