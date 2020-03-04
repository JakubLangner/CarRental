using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRental.Models
{
    public class AdditionalEquipment
    {
        public int AdditionalEquipmentId { get; set; }
        public string Type { get; set; }
        public bool IsSelected { get; set; }
    }
}
