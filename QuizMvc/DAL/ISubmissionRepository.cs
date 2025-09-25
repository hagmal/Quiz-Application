using System.Collections.Generic;
using System.Threading.Tasks;
using QuizMvc.ViewModels;

namespace QuizMvc.DAL
{
    public interface ISubmissionRepository
    {
        // Saves results and retrieves leaderboard
        //Lagrer resultater og henter leaderboard
        Task<int> Add(int quizId, string displayName, int score);
        Task<IReadOnlyList<LeaderboardEntryVm>> GetTop(int quizId, int topN = 10);
    }
}