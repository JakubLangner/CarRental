using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRental.Models;
using CarRental.Models.Database;
using CarRental.Models.Interfaces;
using CarRental.ViewModels.Order;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace CarRental.Controllers
{
    [Authorize(Roles = "User")]
    public class UserController : Controller
    {
        private readonly IConfiguration _configuration;
        private readonly UserManager<AppUser> _userManager;
        private readonly IRentReposiotry _rentRepository;
        public UserController(IConfiguration configuration, UserManager<AppUser> userManager, IRentReposiotry rentRepository)
        {
            _configuration = configuration;
            _userManager = userManager;
            _rentRepository = rentRepository;
        }

        public DatabaseContext DatabaseInitialization()
        {
            DbContextOptionsBuilder<DatabaseContext> options = new DbContextOptionsBuilder<DatabaseContext>();
            options.UseSqlServer(_configuration.GetConnectionString("DefaultConnection"));
            var context = new DatabaseContext(options.Options);

            return context;
        }

        [HttpGet]
        public async Task<IActionResult> Order(string username)
        {
            var User = await _userManager.FindByNameAsync(username);

            DatabaseContext context = this.DatabaseInitialization();

            List<SelectListItem> listSelectListItemCars = new List<SelectListItem>();
            
            foreach (Car car in context.Cars)
            {
                SelectListItem selectListItemC = new SelectListItem()
                {
                    Text = car.Mark + " " + car.Model,
                    Value = car.CarId.ToString(),
                    Selected = car.IsSelected
                };
                listSelectListItemCars.Add(selectListItemC);
            }
            List<SelectListItem> listSelectListItemEquipment = new List<SelectListItem>();
            foreach (AdditionalEquipment item in context.AdditionalEquipments)
            {
                SelectListItem selectListItemE = new SelectListItem()
                {
                    Text = item.Type,
                    Value = item.AdditionalEquipmentId.ToString(),
                    Selected = item.IsSelected
                };
                listSelectListItemEquipment.Add(selectListItemE);
            }


            RentVM model = new RentVM();
            model.Cars = listSelectListItemCars;
            model.Equipments = listSelectListItemEquipment;
            model.RentStart = DateTime.Now;
            model.RentEnd = DateTime.Now.AddDays(1);
            model.Price = 100 * model.RentEnd.Day;
            model.UserName = User.UserName;
            return View("Order", model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Order(RentVM model)
        {
           var USER = await _userManager.FindByNameAsync(model.UserName);
            Rent rent = new Rent();
            rent.UserId = USER.Id;
            rent.Note = model.Note;
            rent.IsInvoice = model.IsInvoice;
            rent.Price = (model.RentEnd.DayOfYear-model.RentStart.DayOfYear) * 100;
            rent.Description = model.Description;
            rent.RentAddress = model.RentAddress;
            rent.RentStart = DateTime.Today;
            rent.RentEnd = model.RentEnd;
            if (model.SelectedCar == null)
            {
                ModelState.AddModelError("", "Auto musi być wybrane");
                return RedirectToAction("Error", "Home");
            }
            rent.CarId = int.Parse(model.SelectedCar.Last());
            rent.RentStatus = "Oczekujące";
            if (model.SelectedEquipment == null)
            {
                //rent.AdditionalEquipmentId = 1;
            }
            else
            {
                rent.AdditionalEquipmentId = model.SelectedEquipment.Last();
            }
            
            _rentRepository.AddRent(rent);
            return RedirectToAction("Index", "Home"); 
        }

        [HttpGet]
        public async Task<IActionResult> MyOrders(string username)
        {
            var User = await _userManager.FindByNameAsync(username);
            var Rents = _rentRepository.GetMyRents(User.Id);
            return View(Rents);
        }
    }
}