using CarRental.Models.Database;
using CarRental.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRental.Models.Repository
{
    public class AdditionalEquipmentRepository : IAdditionalEquipmentRepository
    {
        private readonly DatabaseContext _databasecontext;

        public AdditionalEquipmentRepository(DatabaseContext databasecontext)
        {
            _databasecontext = databasecontext;
        }

        public void AddEquipment(AdditionalEquipment additionalEquipment)
        {
            _databasecontext.AdditionalEquipments.Add(additionalEquipment);
            _databasecontext.SaveChanges();

        }

        public void DeleteEquipment(AdditionalEquipment additionalEquipment)
        {
            _databasecontext.AdditionalEquipments.Remove(additionalEquipment);
            _databasecontext.SaveChanges();
        }

        public void UpdateEquipment(AdditionalEquipment additionalEquipment)
        {
            _databasecontext.AdditionalEquipments.Update(additionalEquipment);
            _databasecontext.SaveChanges();
        }
        public List<AdditionalEquipment> GetAll()
        {
            return _databasecontext.AdditionalEquipments.ToList();
        }

        public AdditionalEquipment GetEquipment(int id)
        {
            return _databasecontext.AdditionalEquipments.FirstOrDefault(x => x.AdditionalEquipmentId == id);
        }
    }
}
