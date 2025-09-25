using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace QuizMvc.ViewModels
{
    // Pakken som POST-es fra skjemaet når brukeren sender inn svarene sine
    // The package that is POSTed from the form when the user submits their answers
    public class SubmitQuizVm
    {
        // Hvilken quiz brukeren tok
        [Required] public int QuizId { get; set; }

        // Vises i skjemaet - vi lagrer navnet på "leaderboardet"
        [Required, MinLength(2), MaxLength(20)] public string DisplayName { get; set; } = "";

        // Valgte svar fra skjemaet: QuestionId -> OptionId
        // HTML-navn "Answers[<QuestionId>]" binder automatisk hit
        [Required] public Dictionary<int, int> Answers { get; set; } = new();
    }
}