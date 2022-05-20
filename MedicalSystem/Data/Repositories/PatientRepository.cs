using System;
using System.Collections.Generic;
using System.Linq;

namespace MedicalSystems.Data
{
    public class PatientRepository : IPatientRepository
    {
        private readonly AppDbContext _db;

        public PatientRepository(AppDbContext db)
        {
            _db = db;
        }

        public List<Patient> GetPatients()
        {
            var patients = _db.Patients.ToList();
            return patients;
        }

        public bool CreatePatient(Patient patient)
        {
            _db.Patients.Add(patient);
            _db.SaveChanges();
            return true;
        }

        public Patient GetPatientById(int id)
        {
            return _db.Patients.FirstOrDefault(s => s.PatientId == id);
        }

        public bool UpdatePatient(Patient patient)
        {
            _db.Patients.Update(patient);
            _db.SaveChanges();
            return true;
        }

        public bool DeletePatient(Patient patient)
        {
            _db.Remove(patient);
            _db.SaveChanges();
            return true;
        }
    }
}
