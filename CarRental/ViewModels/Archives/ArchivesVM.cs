using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRental.ViewModels.Archives
{
    public class ArchivesVM
    {
        public int ArchiveId { get; set; }
        public int RentId { get; set; }
        public int CarId { get; set; }
        public string RentAddress { get; set; }
        public string Description { get; set; }
        public virtual int? AdditionalEquipmentId { get; set; }
        public decimal Price { get; set; }
        public string IsInvoice { get; set; }
        public string Note { get; set; }
        public string RentStatus { get; set; }
        public  string UserId { get; set; }
        public DateTime RentStart { get; set; }
        public DateTime RentEnd { get; set; }
    }
}
