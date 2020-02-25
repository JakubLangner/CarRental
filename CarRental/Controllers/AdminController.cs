using CarRental.Models;
using CarRental.Models.Database;
using CarRental.Models.Interfaces;
using CarRental.ViewModels.Admin;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace CarRental.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private readonly ICarRepository _carRepository;
        private readonly IHostingEnvironment _env;
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly IConfiguration _configuration;
        private readonly IAdditionalEquipmentRepository _additionalEquipmentRepository;
        private readonly IServiceProvider _provider;
        public AdminController(ICarRepository carRepository, IHostingEnvironment env, UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, IConfiguration configuration, IAdditionalEquipmentRepository additionalEquipmentRepository, IServiceProvider provider)
        {
            _carRepository = carRepository;
            _env = env;
            _userManager = userManager;
            _signInManager = signInManager;
            _configuration = configuration;
            _additionalEquipmentRepository = additionalEquipmentRepository;
            _provider = provider;
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

        [HttpGet]
        public IActionResult Users()
        {
            DatabaseContext context = this.initContext();
            var userRoles = new List<AdminUsersView>();
            var userStore = new UserStore<AppUser>(context);


            //Get all the usernames
            foreach (var user in userStore.Users)
            {
                var model = new AdminUsersView
                {
                    UserName = user.UserName,
                    PhoneNumber = user.PhoneNumber,
                    Email = user.Email,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
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

        public IActionResult CreateUser()
        {
            var userEdit = new AdminUsersView();

            userEdit.Roles = new List<SelectListItem>()
            {
                new SelectListItem {Text = "Administrator", Value = "Admin"},
                new SelectListItem {Text = "Pracownik", Value = "Employee"}
            };

            return PartialView("CreateUser", userEdit);
        }
        [HttpPost]
        public async Task<IActionResult> CreateUser(AdminUsersView model)
        {
            if (ModelState.IsValid)
            {

                AppUser newUser = _userManager.FindByNameAsync(model.UserName).Result;
                if (newUser == null)
                {
                    newUser = new AppUser();
                    newUser.UserName = model.UserName;
                    newUser.PhoneNumber = model.PhoneNumber;
                    newUser.Email = model.Email;
                    newUser.FirstName = model.FirstName;
                    newUser.LastName = model.LastName;

                    var resultCreate = await _userManager.CreateAsync(newUser, model.Password);
                    if (resultCreate.Succeeded)
                    {
                        var roleManager = _provider.GetRequiredService<RoleManager<IdentityRole>>();
                        if (model.Role != null)
                        {
                            foreach (string role in model.Role)
                            {

                                var roleCheck = roleManager.RoleExistsAsync(role).Result;
                                if (roleCheck)
                                {
                                    var isInRole = await _userManager.IsInRoleAsync(newUser, role);
                                    if (!isInRole)
                                    {
                                        await _userManager.AddToRoleAsync(newUser, role);
                                    }
                                }
                            }
                        }
                        return RedirectToAction("Users", "Admin");
                    }
                    else
                    {
                        foreach (var error in resultCreate.Errors)
                        {
                            ModelState.AddModelError("", error.Description);
                        }

                    }
                }

            }

            model.Roles = new List<SelectListItem>()
            {
                new SelectListItem {Text = "Administrator", Value = "Admin"},
                new SelectListItem {Text = "Pracownik", Value = "Employee"}
            };

            return View("Users", model);
        }

        [HttpGet]
        public async Task<IActionResult> EditUser(string username)
        {
            var editUser = await _userManager.FindByNameAsync(username);
            var User = new AdminUsersView();
            User.PhoneNumber = editUser.PhoneNumber;
            User.Email = editUser.Email;
            User.FirstName = editUser.FirstName;
            User.LastName = editUser.LastName;

            User.Roles = new List<SelectListItem>()
            {
                new SelectListItem {Text = "Administrator", Value = "Admin",Selected = _userManager.IsInRoleAsync(editUser, "Admin").Result},
                new SelectListItem {Text = "Użytkownik", Value = "User",Selected = _userManager.IsInRoleAsync(editUser, "User").Result},
                new SelectListItem {Text = "Pracownik", Value = "Employee",Selected = _userManager.IsInRoleAsync(editUser, "Employee").Result}
            };

            return PartialView("EditUser", User);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditUser(AdminUsersView model)
        {
            var roleManager = _provider.GetRequiredService<RoleManager<IdentityRole>>();

            AppUser editUser = _userManager.FindByNameAsync(model.UserName).Result;
            editUser.Email = model.Email;
            editUser.PhoneNumber = model.PhoneNumber;
            editUser.FirstName = model.FirstName;
            editUser.LastName = model.LastName;
            if (model.Role != null)
            {
                IList<string> userRoles = _userManager.GetRolesAsync(editUser).Result;
                foreach (string roleName in userRoles)
                {
                    if (!model.Role.Contains(roleName))
                    {
                        await _userManager.RemoveFromRoleAsync(editUser, roleName);
                    }
                }
                foreach (string role in model.Role)
                {

                    var roleCheck = roleManager.RoleExistsAsync(role).Result;
                    if (roleCheck)
                    {
                        var isInRole = await _userManager.IsInRoleAsync(editUser, role);
                        if (!isInRole)
                        {
                            await _userManager.AddToRoleAsync(editUser, role);
                        }
                    }
                }
            }
            var result = _userManager.UpdateAsync(editUser).Result;

            return RedirectToAction("Users", "Admin");
        }


        public async Task<IActionResult> DeleteUser(AdminUsersView model)
        {
            AppUser editUser = _userManager.FindByNameAsync(model.UserName).Result;
            editUser.Email = model.Email;
            editUser.PhoneNumber = model.PhoneNumber;
            editUser.FirstName = model.FirstName;
            editUser.LastName = model.LastName;

            await _userManager.DeleteAsync(editUser);

            return RedirectToAction("Users", "Admin");
        }

    }
}