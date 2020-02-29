using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CarRental.Models;
using CarRental.Models.Interfaces;
using CarRental.ViewModels;
using Microsoft.AspNetCore.Identity;
using CarRental.ViewModels.Home;

namespace CarRental.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICarRepository _carRepository;
        private readonly UserManager<AppUser> _userManager;
        private readonly IServiceProvider _provider;
        public HomeController(ICarRepository carRepository, UserManager<AppUser> userManager, IServiceProvider provider)
        {
            _carRepository = carRepository;
            _userManager = userManager;
            _provider = provider;
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
        [HttpGet]
        public async Task<IActionResult> Account(string username)
        {
            var OldUser = await _userManager.FindByNameAsync(username);
            var User = new UserVM();
            User.PhoneNumber = OldUser.PhoneNumber;
            User.Email = OldUser.Email;
            User.FirstName = OldUser.FirstName;
            User.LastName = OldUser.LastName;

            

            return PartialView("Account", User);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Account(UserVM model)
        {
            

            AppUser editUser = _userManager.FindByNameAsync(model.UserName).Result;
            editUser.Email = model.Email;
            editUser.PhoneNumber = model.PhoneNumber;
            editUser.FirstName = model.FirstName;
            editUser.LastName = model.LastName;
                var result = _userManager.UpdateAsync(editUser).Result;
                return RedirectToAction(nameof(Index));
           
        }
    }
}
