using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRental.Models.Interfaces
{
    interface IAdditionalEquipment
    {
        void AddEquipment(AdditionalEquipment additionalEquipment);
        void UpdateEquipment(AdditionalEquipment additionalEquipment);
        void DeleteEquipment(AdditionalEquipment additionalEquipment);
    }
}
