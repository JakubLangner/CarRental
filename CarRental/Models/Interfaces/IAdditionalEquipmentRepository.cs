using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRental.Models.Interfaces
{
    public interface IAdditionalEquipmentRepository
    {
        List<AdditionalEquipment> GetAll();
        AdditionalEquipment GetEquipment(int id);
        void AddEquipment(AdditionalEquipment additionalEquipment);
        void UpdateEquipment(AdditionalEquipment additionalEquipment);
        void DeleteEquipment(AdditionalEquipment additionalEquipment);
    }
}
