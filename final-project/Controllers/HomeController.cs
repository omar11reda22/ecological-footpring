using final_project.Models;
using final_project.myContext;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
namespace final_project.Controllers
{
    public class HomeController : Controller
    {
        ITIContext context = new ITIContext();
        public IActionResult Index()
        {

            return View();
        }
        public IActionResult Home()
        {

            return View();
        }
        public IActionResult savingdata(result result)
        {
            question questionquestion = new question();
            var data = context.questions.Where(c => c.Question_ID == 1).Select(c => c.factor);
            var item = result.value;
         
                result.value = item * data.First();
            context.results.Add(result);
            context.SaveChanges();
           


            return RedirectToAction("Waste");
        }

        public IActionResult Waste()
        {

            return View();
        }
        public IActionResult savewaste(result result)
        {
            question question = new question();
            var data = context.questions.Where(c => c.Question_ID == 19).Select(c => c.factor);
            var item = result.value;


            return RedirectToAction("Food");
        }
        public IActionResult Food()
        {

            return View();
        }
        public IActionResult saveFood()
        {
            return RedirectToAction("transportation");  
        }
        public IActionResult transportation()
        {

            return View();
        }
        public IActionResult savetransportation()
        {
            return RedirectToAction("");
        }

    }
}
