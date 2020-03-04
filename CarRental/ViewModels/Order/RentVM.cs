using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarRental.ViewModels.Order
{
    public class RentVM
    {
        public IEnumerable<SelectListItem> Cars { get; set; }
        public IEnumerable<string> SelectedCar { get; set; }

        public IEnumerable<SelectListItem> Equipments { get; set; }
        public IEnumerable<string> SelectedEquipment { get; set; }

        public int RentId { get; set; }
        [Required]
        public  int CarId { get; set; }
        public DateTime RentStart { get; set; }
        public DateTime RentEnd { get; set; }
        public string RentAddress { get; set; }
        public string Description { get; set; }
        public int AdditionalEquipmentId { get; set; }
        public decimal Price { get; set; }
        public bool IsInvoice { get; set; }
        public string Note { get; set; }
        [Required]
        [Display(Name = "Nazwa użytkownika")]
        public string UserName { get; set; }
    }
}
