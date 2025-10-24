using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TranDucThinh_231230917_de01.Models;

namespace TranDucThinh_231230917_de01.Controllers
{
    public class TranDucThinhHomeController : Controller
    {
        private readonly ILogger<TranDucThinhHomeController> _logger;

        public TranDucThinhHomeController(ILogger<TranDucThinhHomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult TranDucThinhContact()
        {
            return View();
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
