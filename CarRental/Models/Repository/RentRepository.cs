using CarRental.Models.Database;
using CarRental.Models.Interfaces;
using CarRental.ViewModels.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRental.Models.Repository
{
    public class RentRepository : IRentReposiotry
    {
        private readonly DatabaseContext _databasecontext;

        public RentRepository(DatabaseContext databasecontext)
        {
            _databasecontext = databasecontext;
        }

        public void AddRent(Rent rent)
        {
            _databasecontext.Rents.Add(rent);
            _databasecontext.SaveChanges();
        }

        public void ArchiveRent(Rent rent, Archives archives)
        {
            _databasecontext.Archives.Add(archives);
            _databasecontext.Rents.Remove(rent);
            _databasecontext.SaveChanges();
        }

        public void DeleteRent(Rent rent)
        {
            _databasecontext.Rents.Remove(rent);
            _databasecontext.SaveChanges();
        }

        public List<Rent> GetAll()
        {
            return _databasecontext.Rents.ToList();
        }

        public  List<Rent>GetMyRents(string userId)
        {
            return _databasecontext.Rents.Where(x => x.UserId == userId).ToList();
        }

        public Rent GetRent(int id)
        {
            return _databasecontext.Rents.FirstOrDefault(rent => rent.RentId == id);
            
        }

        public Rent GetRentByStatus(string status)
        {
            return _databasecontext.Rents.FirstOrDefault(rent => rent.RentStatus == status);
        }

        public void UpdateRent(Rent rent)
        {
            _databasecontext.Rents.Update(rent);
            _databasecontext.SaveChanges();
            
        }
    }
}
