using System;
using System.Collections.Generic;
using System.Linq;

namespace BlazorCRUD.Data
{
    public class MedicRepository : IMedicRepository
    {
        private readonly AppDbContext _db;

        public MedicRepository(AppDbContext db)
        {
            _db = db;
        }

        public List<Medic> GetMedics()
        {
            var medicList = _db.Medics.ToList();
            return medicList;
        }

        public bool CreateMedic(Medic objMedic)
        {
            _db.Medics.Add(objMedic);
            _db.SaveChanges();
            return true;
        }

        public Medic GetMedicById(int id)
        {
            return _db.Medics.FirstOrDefault(s => s.MedicId == id);
        }

        public bool UpdateMedic(Medic objMedic)
        {
            _db.Medics.Update(objMedic);
            _db.SaveChanges();
            return true;
        }

        public bool DeleteMedic(Medic objMedic)
        {
            _db.Remove(objMedic);
            _db.SaveChanges();
            return true;
        }
    }
}
