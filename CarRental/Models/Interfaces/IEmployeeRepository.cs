using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRental.Models.Interfaces
{
    interface IEmployeeRepository
    {
        List<AppUser> GetAll();
    }
}
