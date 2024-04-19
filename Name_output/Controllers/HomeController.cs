using Microsoft.AspNetCore.Mvc;
using Name_output.Models;
using System.Diagnostics;

namespace Name_output.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ShowName(string name)
        {
            ViewBag.Name = name;
            return View("ShowName");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}