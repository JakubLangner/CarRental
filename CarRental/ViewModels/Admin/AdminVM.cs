using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRental.ViewModels.Admin
{
    public class AdminVM
    {
        public int CarId { get; set; }
        public string Plates { get; set; }
        public string Mark { get; set; }
        public string Model { get; set; }
        public string Engine { get; set; }
        public int YearOfProduction { get; set; }
        public string VehicleMileage { get; set; }
        public string EnginePower { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string ThumbnaulUrl { get; set; }
        public string CarStatus { get; set; }
    }
}
