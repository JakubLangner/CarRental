using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CarRental.Models;
using CarRental.Models.Interfaces;
using CarRental.ViewModels;

namespace CarRental.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICarRepository _carRepository;
        public HomeController(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

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
        [HttpGet]
        public IActionResult Cars()
        {
            var _cars = _carRepository.GetAll().OrderBy(s => s.CarId);

            var homeVM = new HomeVM()
            {
                Title = "Przegląd Samochodów",
                cars = _cars.ToList()
            };

            return View(homeVM);
        }
    }
}
