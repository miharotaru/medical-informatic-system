using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCRUD.Data
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
