using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
