using Microsoft.AspNetCore.Mvc;
using QuizMvc.DAL;
using QuizMvc.ViewModels;
using System.Threading.Tasks;

namespace QuizMvc.Controllers
{
    public class TakeController : Controller
    {
        private readonly IQuizRepository _quizRepo; // Interfacet for å hente quiz
        private readonly ISubmissionRepository _subRepo; // Interfacet for å lagre resultater

        //Konstruktør som "får inn" repositoriesene 
        public TakeController(IQuizRepository quizRepo, ISubmissionRepository subRepo)
        {
            _quizRepo = quizRepo;
            _subRepo = subRepo;
        }

        // GET 
        // Viser quizen 
        public async Task<IActionResult> Index(int quizId = 1)
        {
            var vm = await _quizRepo.GetQuizForTaking(quizId); //Henter quiz
            if (vm == null) return NotFound(); // Hvis den ikke finnes, vis 404
            return View(vm); // Sender quiz videre til view (HTML-side)
        }

        // POST
        // Tar i mot svarene fra brukeren, scorer og lagrer resultatet
        public async Task<IActionResult> Submit(SubmitQuizVm model)
        {
            // Sjekker om innsendingen er gyldig, hvis ikke returneres feil
            if (!ModelState.IsValid) return BadRequest("Invalid submission");

            var score = await _quizRepo.Score(model); // Regner ut poeng
            var submissionId = await _subRepo.Add(model.QuizId, model.DisplayName, score); //Lagrer resultatet og får tilbake en id

            // TempData brukes for å sende data videre til neste request (Results)
            TempData["DisplayName"] = model.DisplayName;
            TempData["Score"] = score;
            TempData["QuizId"] = model.QuizId;

            return RedirectToAction("Results", new { id = submissionId }); //Sender bruker videre til resultat-siden
        }

        // GET
        //Viser resultatsiden
        public IActionResult Results(int id)
        {
            //Henter data fra TempData og sender til view
            ViewBag.DisplayName = TempData["DisplayName"];
            ViewBag.Score = TempData["Score"];
            ViewBag.QuizId = TempData["QuizId"];
            return View();
        }
    }
}
