using Microsoft.AspNetCore.Mvc;

namespace STSolution.Web.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Current = "About";
            
            return View();
        }
    }
}