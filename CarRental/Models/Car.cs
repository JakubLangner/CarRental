using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRental.Models
{
    public class Car
    {
        public int CarId { get; set; }
        public string Plates { get; set; }
        public string Mark { get; set; }
        public string Model { get; set; }
        public EngineType Engine { get; set; }
        public int YearOfProduction { get; set; }
        public string VehicleMileage { get; set; }
        public string EnginePower { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string ThumbnaulUrl { get; set; }
    }

    public enum EngineType
    {
        Petrol = 0,
        Diesel = 1
    }

}
