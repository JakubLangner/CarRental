using CarRental.Models.Database;
using CarRental.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRental.Models.Repository
{
    public class ArchivesRepository : IArchivesRepository
    {
        private readonly DatabaseContext _databaseContext;

        public ArchivesRepository(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public void AddArchive(Archives archives)
        {
            _databaseContext.Archives.Add(archives);
            _databaseContext.SaveChanges();
        }

        public List<Archives> GetAll()
        {
            return _databaseContext.Archives.ToList();
        }

        public Archives GetArchives(int id)
        {
            return _databaseContext.Archives.FirstOrDefault(archives => archives.ArchiveId == id);
        }

        public void UpdateArchive(Archives archives)
        {
            _databaseContext.Archives.Update(archives);
            _databaseContext.SaveChanges();
        }
    }
}
