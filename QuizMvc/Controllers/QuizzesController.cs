using Microsoft.AspNetCore.Mvc;
using QuizMvc.Models;

namespace QuizMvc.Controllers
{
    public class QuizzesController : Controller
    {
        private readonly QuizDbContext _context;

        // Constructor injection: DbContext blir "automatisk" sendt inn
        public QuizzesController(QuizDbContext context)
        {
            _context = context;
        }

        // GET: /Quizzes/
        public IActionResult Index()
        {
            var quizzes = _context.Quizzes.ToList(); // henter alle quizer fra databasen
            return View(quizzes);
        }
    }
}

