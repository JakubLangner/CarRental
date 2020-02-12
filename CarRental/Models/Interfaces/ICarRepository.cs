using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRental.Models.Interfaces
{
    public interface ICarRepository
    {
        List<Car> GetAll();
        Car GetCar(int id);
        Car GetCarByModel(string model);
        void AddCar(Car car);
        void UpdateCar(Car car);
        void DeleteCaR(Car car);
    }
}
