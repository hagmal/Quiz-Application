using Microsoft.EntityFrameworkCore;

namespace QuizMvc.Models
{
    public class QuizDbContext : DbContext
    {
        public QuizDbContext(DbContextOptions<QuizDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Quiz> Quizzes { get; set; }
        public DbSet<Question> Questions { get; set; }        
        public DbSet<Submission> Submissions { get; set; }

    }
}