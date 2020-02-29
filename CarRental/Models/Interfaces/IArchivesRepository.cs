using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRental.Models.Interfaces
{
    public interface IArchivesRepository
    {
        void AddArchive(Archives archives);
        List<Archives> GetAll();
        Archives GetArchives(int id);
        void UpdateArchive(Archives archives);
    }
}
