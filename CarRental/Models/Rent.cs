using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRental.Models
{
    public class Rent
    {
        public int RentId { get; set; }
        public virtual int CarId { get; set; }
        public virtual Car Car { get; set; }
        public DateTime RentStart { get; set; }
        public DateTime RentEnd { get; set; }
        public string RentAddress { get; set; }
        public string Description { get; set; }
        public virtual int AdditionalEquipmentId { get; set; }
        public virtual AdditionalEquipment AdditionalEquipment { get; set; }
        public decimal Price { get; set; }
        public bool IsInvoice { get; set; }
        public string Note { get; set; }
        public string RentStatus { get; set; }
        public  virtual int UserId { get; set; }
        public  virtual AppUser User { get; set; }
    }
}
