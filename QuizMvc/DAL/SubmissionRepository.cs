using QuizMvc.Models;
using QuizMvc.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizMvc.DAL
{
    public class SubmissionRepository : ISubmissionRepository
    {
        private readonly QuizDbContext _context;

        public SubmissionRepository(QuizDbContext context)
        {
            _context = context;
        }

        public async Task<int> Add(int quizId, string displayName, int score)
        {
            var submission = new Submission
            {
                QuizId = quizId,
                DisplayName = displayName,
                Score = score,
                SubmittedAt = DateTime.Now
            };

            _context.Submissions.Add(submission);
            await _context.SaveChangesAsync();
            return submission.Id;
        }

        public async Task<IReadOnlyList<LeaderboardEntryVm>> GetTop(int quizId, int topN = 10)
        {
            return await _context.Submissions
                .Where(s => s.QuizId == quizId)
                .OrderByDescending(s => s.Score)
                .ThenBy(s => s.SubmittedAt)
                .Take(topN)
                .Select(s => new LeaderboardEntryVm
                {
                    DisplayName = s.DisplayName,
                    Score = s.Score,
                    SubmittedAt = s.SubmittedAt
                })
                .ToListAsync();
        }
    }
}