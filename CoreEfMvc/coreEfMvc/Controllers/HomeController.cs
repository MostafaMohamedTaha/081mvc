using coreEfMvc.data;
using coreEfMvc.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace coreEfMvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ILogger<CoreEfMvcContext> _context;


        public HomeController(ILogger<HomeController> logger, ILogger<CoreEfMvcContext> context)
        {
            _context = context;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
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