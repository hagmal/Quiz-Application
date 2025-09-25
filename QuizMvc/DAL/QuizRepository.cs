using QuizMvc.Models;
using QuizMvc.ViewModels;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizMvc.DAL
{
    public class QuizRepository : IQuizRepository
    {
        private readonly QuizDbContext _context;

        public QuizRepository(QuizDbContext context)
        {
            _context = context;
        }

        // Hent en quiz for å ta den
        public async Task<TakeQuizVm?> GetQuizForTaking(int quizId)
        {
            var quiz = await _context.Quizzes
                .Include(q => q.Questions)
                .FirstOrDefaultAsync(q => q.QuizId == quizId);

            if (quiz == null) return null;

            var vm = new TakeQuizVm
            {
                QuizId = quiz.QuizId,
                Title = quiz.Title,
                Questions = quiz.Questions.Select(q => new QuestionVm
                {
                    Id = q.QuestionId,
                    Text = q.Text,
                    Point = q.Points,
                    Options = new List<OptionVm>() // fyll ut hvis du har options
                }).ToList()
            };
            return vm;
        }

        // Score en innsending
        public Task<int> Score(SubmitQuizVm submission)
        {
            // Dummy-implementasjon: returner 0 poeng foreløpig
            return Task.FromResult(0);
        }
    }
}