using System.Collections.Generic;
using System.Linq;

namespace MedicalSystems.Data
{
    public class PrescriptionRepository : IPrescriptionRepository
    {
        private readonly AppDbContext _db;

        public PrescriptionRepository(AppDbContext db)
        {
            _db = db;
        }

        public List<Prescription> GetPrescriptions()
        {
            var prescriptions = _db.Prescriptions.ToList();
            return prescriptions;
        }

        public bool CreatePrescription(Prescription prescription)
        {
            _db.Prescriptions.Add(prescription);
            _db.SaveChanges();
            return true;
        }

        public Prescription GetPrescriptionById(int id)
        {
            return _db.Prescriptions.FirstOrDefault(s => s.PrescriptionId == id);
        }

        public bool UpdatePrescription(Prescription prescription)
        {
            _db.Prescriptions.Update(prescription);
            _db.SaveChanges();
            return true;
        }

        public bool DeletePrescription(Prescription prescription)
        {
            _db.Remove(prescription);
            _db.SaveChanges();
            return true;
        }
    }
}
