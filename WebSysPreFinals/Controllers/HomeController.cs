using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebSysPreFinals.Models;

namespace WebSysPreFinals.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            StudentPageModel resp = new StudentPageModel();
            using (var db = new StudInfoSysContext())
            {
                resp.students = db.Students.ToList();
            }
            return View(resp);
        }
        public IActionResult Student()
        {
            return View();
        }
        public IActionResult Teacher()
        {
            return View();
        }
        public IActionResult Course()
        {
            return View();
        }
        public IActionResult Room()
        {
            return View();
        }
        public IActionResult Section()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
