using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRental.Models;
using CarRental.Models.Interfaces;
using CarRental.Models.Repository;
using Microsoft.AspNetCore.Mvc;

namespace CarRental.Controllers
{
    public class AdminController : Controller
    {
        private readonly ICarRepository _carRepository;

        public AdminController(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        [HttpGet]
        public IActionResult Dashboard()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Cars()
        {
            return View(_carRepository.GetAll());
        }

        [HttpGet]
        public IActionResult Create(string FileName)
        {
            if (!string.IsNullOrEmpty(FileName))
                ViewBag.ImgPath = "/Images/" + FileName;
            return View();
        }
        [HttpPost]
        public IActionResult Create(Car car)
        {
            if (ModelState.IsValid)
            {
                _carRepository.AddCar(car);
                return RedirectToAction(nameof(Cars));
            }
            return View(car);
        }
    }
}