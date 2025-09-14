using Microsoft.AspNetCore.Mvc;

namespace QuizMvc.Controllers;

    public class LeaderboardController : Controller
    {
        // GET: LeaderboardController
        public ActionResult Index()
        {
            return View();
        }

    }

