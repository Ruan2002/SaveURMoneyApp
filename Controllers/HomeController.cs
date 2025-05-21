using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SaveUrMoneyApp.Models;

namespace SaveUrMoneyApp.Controllers
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
            return View();
        }

        public IActionResult Riscos() 
        {
            return View();
        }

        public IActionResult Solucoes()
        {
            return View();
        }

        public IActionResult Ajuda()
        {
            return View();
        }
    }
}
