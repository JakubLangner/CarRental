using CarRental.Models.Database;
using CarRental.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRental.Models.Repository
{
    public class EmployeeRepository 
    {
        private readonly DatabaseContext _databaseContext;

        public EmployeeRepository(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        //public List<AppUser> GetAll()
        //{
            

        //}
    }
}
