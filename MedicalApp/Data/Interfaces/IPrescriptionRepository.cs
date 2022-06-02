using System.Collections.Generic;

namespace MedicalSystems.Data
{
    public interface IPrescriptionRepository
    {
        public List<Prescription> GetPrescriptions();
        public bool CreatePrescription(Prescription prescription);

        public Prescription GetPrescriptionById(int id);

        public bool UpdatePrescription(Prescription prescription);

        public bool DeletePrescription(Prescription prescription);
    }
}
