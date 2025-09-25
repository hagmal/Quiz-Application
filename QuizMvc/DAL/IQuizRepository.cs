using System.Threading.Tasks;
using QuizMvc.ViewModels;

namespace QuizMvc.DAL
{
    public interface IQuizRepository
    {
        //Retrieves a quiz based on quizId and returns a Viewmodel(TakeQuizVm)
        //Henter en quiz basert på quizId, returnerer Viewmodel(TakeQuizVm) 
        Task<TakeQuizVm?> GetQuizForTaking(int quizId);
        //Calculates the score (int) for a quiz based on the submitted answers(SubmitQuizVm)
        //Beregner poengsummen(int) for en quiz basert på innsendt besvarelse(SubmitQuizVm)
        Task<int> Score(SubmitQuizVm submission);
    }
}