using CarRental.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRental.Models.Repository
{
    public class RentRepository : IRentReposiotry
    {
        public void AddRent(Rent rent)
        {
            throw new NotImplementedException();
        }

        public void ArchiveRent(Rent rent, Archives archives)
        {
            throw new NotImplementedException();
        }

        public void DeleteRent(Rent rent)
        {
            throw new NotImplementedException();
        }

        public List<Rent> GetAll()
        {
            throw new NotImplementedException();
        }

        public Rent GetRent(int id)
        {
            throw new NotImplementedException();
        }

        public Rent GetRentByStatus(string status)
        {
            throw new NotImplementedException();
        }

        public void UpdateRent(Rent rent)
        {
            throw new NotImplementedException();
        }
    }
}
