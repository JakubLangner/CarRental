using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRental.Models
{
    public class Archives
    {
        public int ArchiveId { get; set; }
        public virtual int RentId { get; set; }
        public virtual Rent Rent { get; set; }
        public string Status { get; set; }
    }
}
