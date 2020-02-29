using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRental.Models;
using CarRental.Models.Interfaces;
using CarRental.ViewModels;
using CarRental.ViewModels.Archives;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CarRental.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ICarRepository _carRepository;
        private readonly IRentReposiotry _rentReposiotry;
        private readonly IArchivesRepository _archivesRepository;
        private readonly IAdditionalEquipmentRepository _additionalEquipmentRepository;
        private readonly UserManager<AppUser> _userManager;
        public EmployeeController(ICarRepository carRepository, IRentReposiotry rentReposiotry, IArchivesRepository archivesRepository, IAdditionalEquipmentRepository additionalEquipmentRepository, UserManager<AppUser> userManager)
        {
            _carRepository = carRepository;
            _rentReposiotry = rentReposiotry;
            _archivesRepository = archivesRepository;
            _additionalEquipmentRepository = additionalEquipmentRepository;
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Dashboard()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Archives()
        {
            return View(_archivesRepository.GetAll());
        }

        [HttpGet]
        public IActionResult ArchivesDetails(int id)
        {
            ArchivesVM model = new ArchivesVM();
            
            var rent = _rentReposiotry.GetRent(id);

            model.RentId = rent.RentId;
            model.CarId = rent.CarId;
            model.RentAddress = rent.RentAddress;
            model.Description = rent.Description;
            model.AdditionalEquipmentId = rent.AdditionalEquipmentId;
            model.Price = rent.Price;
            if (rent.IsInvoice != false)
            {
                model.IsInvoice = "Tak";
;           }
            else
            {
                model.IsInvoice = "Nie";
            }
            model.Note = rent.Note;
            model.RentStatus = rent.RentStatus;
            model.UserId = rent.UserId;
            model.RentStart = rent.RentStart;
            model.RentEnd = rent.RentEnd;

            return View(model);
        }

        [HttpGet]
        public IActionResult FreeCars()
        {
            var cars = _carRepository.GetAll().Where(x => x.CarStatus == "Wolny").ToList();
            return View(cars);
        }

        [HttpGet]
        public IActionResult Rents()
        {

            return View(_rentReposiotry.GetAll());
        }

        [HttpGet]
        public IActionResult Execute(int id)
        {
            var rent = _rentReposiotry.GetRent(id);
            if (rent == null)
                return NotFound();
            
            return View(rent);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Execute(Rent rent)
        {
            if (ModelState.IsValid)
            {
                _rentReposiotry.UpdateRent(rent);
                return RedirectToAction(nameof(Rents));
            }
            return View(rent);
        }

    }
}