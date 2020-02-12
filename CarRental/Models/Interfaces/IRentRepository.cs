using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRental.Models.Interfaces
{
    public interface IRentReposiotry
    {
        List<Rent> GetAll();
        void AddRent(Rent rent);
        void UpdateRent(Rent rent);
        void DeleteRent(Rent rent);
        void ArchiveRent(Rent rent, Archives archives);
        Rent GetRent(int id);
        Rent GetRentByStatus(string status);
    }
}
