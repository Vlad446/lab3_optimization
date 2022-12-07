using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using LR3_Modelirovanie.Models;

namespace LR3_Modelirovanie.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [HttpGet]      

        public IActionResult Index()
        {
            DataViewModel dateViewModel = new DataViewModel
            {
                A1_Square = 52,
                A1_1 = 2,
                A1_2 = 1,
                A1_3 = 1,
                A1_4 = 0,
                A1_5 = 0,
                A1_AmountOn1 = 4,

                A2_Square = 61,
                A2_1 = 0,
                A2_2 = 1,
                A2_3 = 0,
                A2_4 = 2,
                A2_5 = 0,
                A2_AmountOn1 = 3,

                A3_Square = 70,
                A3_1 = 0,
                A3_2 = 0,
                A3_3 = 1,
                A3_4 = 0,
                A3_5 = 1,
                A3_AmountOn1 = 2,
                             

                F = 123,
                R = 50,
            };
            return View(dateViewModel);
        }
        [HttpGet]
        public IActionResult Report(DataViewModel dateViewModel)
        {
            var resultViewModel = new ResultViewModel(dateViewModel);

            return View(resultViewModel);
        }
        [HttpGet]
        public IActionResult Result(DataViewModel dateViewModel)
        {
            var resultViewModel = new ResultViewModel(dateViewModel);

            return View(resultViewModel);
        }
        [HttpGet]
        public IActionResult FalseSolver()
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
