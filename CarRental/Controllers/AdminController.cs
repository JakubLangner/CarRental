using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using CarRental.Models;
using CarRental.Models.Database;
using CarRental.Models.Interfaces;
using CarRental.Models.Repository;
using CarRental.ViewModels.Admin;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace CarRental.Controllers
{
    public class AdminController : Controller
    {
        private readonly ICarRepository _carRepository;
        private readonly IHostingEnvironment _env;
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly IConfiguration _configuration;
        private readonly IAdditionalEquipmentRepository _additionalEquipmentRepository;
        public AdminController(ICarRepository carRepository, IHostingEnvironment env, UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, IConfiguration configuration, IAdditionalEquipmentRepository additionalEquipmentRepository)
        {
            _carRepository = carRepository;
            _env = env;
            _userManager = userManager;
            _signInManager = signInManager;
            _configuration = configuration;
            _additionalEquipmentRepository = additionalEquipmentRepository;
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

        public IActionResult DetailsCar(int id)
        {
            var car = _carRepository.GetCar(id);

            if (car == null)
                return NotFound();

            return View(car);
        }

        [HttpGet]
        public IActionResult CreateCar(string FileName)
        {
            if (!string.IsNullOrEmpty(FileName))
                ViewBag.ImgPath = "/images/" + FileName;

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateCar(Car car)
        {
            if (ModelState.IsValid)
            {
                _carRepository.AddCar(car);
                return RedirectToAction(nameof(Cars));
            }
            return View(car);
        }

        [HttpGet]
        public IActionResult EditCar(int Id, string FileName)
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
        public IActionResult EditCar(Car car)
        {
            if (ModelState.IsValid)
            {
                _carRepository.UpdateCar(car);
                return RedirectToAction(nameof(Cars));
            }
            return View(car);
        }

        public IActionResult DeleteCar(int Id)
        {
            var car = _carRepository.GetCar(Id);
            if (car == null)
                return NotFound();
            return View(car);
        }

        [HttpPost, ActionName("DeleteCar")]
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
                return RedirectToAction(nameof(CreateCar), new { FileName = (string)form.Files[0].FileName });

            return RedirectToAction(nameof(EditCar), new { FileName = Convert.ToString(form.Files[0].FileName), id = Convert.ToString(form["CarId"]) });


        }

        [HttpGet]
        public IActionResult Equipments()
        {
            return View(_additionalEquipmentRepository.GetAll());
        }
        [HttpGet]
        public IActionResult CreateEquipment()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateEquipment(AdditionalEquipment equipment)
        {
            if (ModelState.IsValid)
            {
                _additionalEquipmentRepository.AddEquipment(equipment);
                return RedirectToAction(nameof(Equipments));
            }
            return View(equipment);
        }

        [HttpGet]
        public IActionResult EditEquipment(int Id)
        {
            var eq = _additionalEquipmentRepository.GetEquipment(Id);
            if (eq == null)
                return NotFound();


            return View(eq);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditEquipment(AdditionalEquipment equipment)
        {
            if (ModelState.IsValid)
            {
                _additionalEquipmentRepository.UpdateEquipment(equipment);
                return RedirectToAction(nameof(Equipments));
            }
            return View(equipment);
        }

        public IActionResult DeleteEquipment(int Id)
        {
            var eq = _additionalEquipmentRepository.GetEquipment(Id);
            if (eq == null)
                return NotFound();
            return View(eq);
        }

        [HttpPost, ActionName("DeleteEquipment")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var eq = _additionalEquipmentRepository.GetEquipment(id);
            _additionalEquipmentRepository.DeleteEquipment(eq);

            return RedirectToAction(nameof(Equipments));
        }

        public DatabaseContext initContext()
        {
            DbContextOptionsBuilder<DatabaseContext> options = new DbContextOptionsBuilder<DatabaseContext>();
            options.UseSqlServer(_configuration.GetConnectionString("DefaultConnection"));
            var context = new DatabaseContext(options.Options);

            return context;
        }

        public IActionResult Users()
        {
            if (!User.IsInRole("Admin"))
                return RedirectToAction("Index", "Home");

            DatabaseContext context = this.initContext();
            var userRoles = new List<AdminUsersView>();
            var userStore = new UserStore<AppUser>(context);


            //Get all the usernames
            foreach (var user in userStore.Users)
            {
                var model = new AdminUsersView
                {
                    UserName = user.UserName,
                    Role = new List<string>()
                    //Role = _userManager.GetRolesAsync(user).ToString()
                };


                var roles = _userManager.GetRolesAsync(user).Result;
                foreach (var role in roles)
                {
                    model.Role.Add(role);
                }
                userRoles.Add(model);
            }

            return View(userRoles);
        }
    }
}