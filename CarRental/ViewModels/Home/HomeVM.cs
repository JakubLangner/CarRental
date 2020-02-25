using CarRental.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRental.ViewModels
{
    public class HomeVM
    {
        public string Title { get; set; }
        public List<Car> cars { get; set; }
    }
}
