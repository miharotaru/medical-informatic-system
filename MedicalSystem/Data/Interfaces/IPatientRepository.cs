using System.Collections.Generic;

namespace MedicalSystems.Data
{
    public interface IPatientRepository
    {
        public List<Patient> GetPatients();
        public bool CreatePatient(Patient patient);

        public Patient GetPatientById(int id);

        public bool UpdatePatient(Patient patient);

        public bool DeletePatient(Patient patient);
    }
}
