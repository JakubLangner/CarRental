using CarRental.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CarRental.ViewModels.Admin
{
    public class AdminUsersView
    {
        [Required]
        [Display(Name = "Nazwa użytkownika")]
        public string UserName { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Hasło")]
        public string Password { get; set; }
        [NotMapped]
        public List<string> Role { get; set; }
        [NotMapped]
        public IEnumerable<SelectListItem> Roles { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public AdminUsersView()
        {

        }

        public AdminUsersView(AppUser row)
        {
            
        }

    }
}
