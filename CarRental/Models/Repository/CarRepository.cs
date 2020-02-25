using CarRental.Models.Database;
using CarRental.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRental.Models.Repository
{
    public class CarRepository : ICarRepository
    {
        private readonly DatabaseContext _databasecontext;

        public CarRepository(DatabaseContext databasecontext)
        {
            _databasecontext = databasecontext;
        }


        public void AddCar(Car car)
        {
            _databasecontext.Cars.Add(car);
            car.CarStatus = "Wolny";
            _databasecontext.SaveChanges();
        }

        public void DeleteCaR(Car car)
        {
            _databasecontext.Cars.Remove(car);
            _databasecontext.SaveChanges();
        }

        public List<Car> GetAll()
        {
            return _databasecontext.Cars.ToList();
        }

        public Car GetCar(int id)
        {
            return _databasecontext.Cars.FirstOrDefault(car => car.CarId == id);
        }

        public Car GetCarByModel(string model)
        {
            return _databasecontext.Cars.FirstOrDefault(car => car.Model == model);
        }

        public void UpdateCar(Car car)
        {
            _databasecontext.Cars.Update(car);
            _databasecontext.SaveChanges();
        }
    }
}
