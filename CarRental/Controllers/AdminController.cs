using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using CarRental.Models;
using CarRental.Models.Interfaces;
using CarRental.Models.Repository;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarRental.Controllers
{
    public class AdminController : Controller
    {
        private readonly ICarRepository _carRepository;
        private readonly IHostingEnvironment _env;

        public AdminController(ICarRepository carRepository, IHostingEnvironment env)
        {
            _carRepository = carRepository;
            _env = env;
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

        public IActionResult Details(int id)
        {
            var car = _carRepository.GetCar(id);

            if (car == null)
                return NotFound();

            return View(car);
        }

        [HttpGet]
        public IActionResult Create(string FileName)
        {
            if (!string.IsNullOrEmpty(FileName))
                ViewBag.ImgPath = "/images/" + FileName;


            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Car car)
        {
            if (ModelState.IsValid)
            {
                _carRepository.AddCar(car);
                return RedirectToAction(nameof(Cars));
            }
            return View(car);
        }

        [HttpGet]
        public IActionResult Edit(int Id, string FileName)
        {
            var car = _carRepository.GetCar(Id);
            if (car == null)
                return NotFound();
            if (!string.IsNullOrEmpty(FileName))
                ViewBag.ImgPath = "/images/" + FileName;
            else
                ViewBag.ImgPath = car.ImageUrl;

            return View(car);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Car car)
        {
            if (ModelState.IsValid)
            {
                _carRepository.UpdateCar(car);
                return RedirectToAction(nameof(Cars));
            }
            return View(car);
        }

        public IActionResult Delete(int Id)
        {
            var car = _carRepository.GetCar(Id);
            if (car == null)
                return NotFound();
            return View(car);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id, string ZdjecieUrl)
        {
            var car = _carRepository.GetCar(id);
            _carRepository.DeleteCaR(car);

            //delete file
            if (ZdjecieUrl != null)
            {
                var webRoot = _env.WebRootPath;
                var filePath = Path.Combine(webRoot.ToString() + ZdjecieUrl);
                System.IO.File.Delete(filePath);
            }
            return RedirectToAction(nameof(Cars));
        }

        [HttpPost("UploadFile")]
        public async Task<IActionResult> UploadFile(IFormCollection form)
        {
            var webRoot = _env.WebRootPath;
            var filePath = Path.Combine(webRoot.ToString() + "\\images\\" + form.Files[0].FileName);

            if (form.Files[0].FileName.Length > 0)
            {
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await form.Files[0].CopyToAsync(stream);
                }
            }

            if ((string)form["CarId"] == string.Empty || (string)form["CarId"] == "0")
                return RedirectToAction(nameof(Create), new { FileName = (string)form.Files[0].FileName });

            return RedirectToAction(nameof(Edit), new { FileName = Convert.ToString(form.Files[0].FileName), id = Convert.ToString(form["CarId"]) });

            
        }

    }
}