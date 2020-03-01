using CarRental.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRental.ViewModels
{
    public class AddArchiveVM
    {
        public int ArchiveId { get; set; }
        public int Rents { get; set; }
        public string Status { get; set; }
    }
}
