using Microsoft.AspNetCore.Mvc;

namespace STSolution.Web.Controllers
{
    public class SolutionController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Current = "Solution";
            
            return View();
        }
    }
}